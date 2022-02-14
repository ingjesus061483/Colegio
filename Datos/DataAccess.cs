using System;
using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace Datos
{
    public class DataAccess
    {
        DataTable table; OracleConnection conexion; OracleCommand comand; OracleDataAdapter adapter; DataSet bd;
        string NombreCadena = "pruebaOracle";
        string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[NombreCadena].ConnectionString;
            }
        }
        public DataAccess()
        {
            conexion = new OracleConnection { ConnectionString = CadenaConexion };
        }

        /// <summary>
        /// Abre una conexion
        /// </summary>
        void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Cierra una conexion
        /// </summary>
        void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///Inicia una consulta a la base de datos 
        /// </summary>
        /// <param name="con"></param>
        /// <param name="comandtype"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        OracleCommand InicializarComando(OracleConnection con, CommandType comandtype, string query)
        {
            OracleCommand com;
            com = new OracleCommand
            {
                Connection = con,
                CommandType = comandtype,
                CommandText = query
            };
            return com;
        }
        DataSet LlenarDataset(OracleCommand comando, string  nombrecursor)
        {
            try
            {
                OracleRefCursor cursor = (OracleRefCursor)comando.Parameters[nombrecursor ].Value;
                DataSet bdatos = new DataSet();
                adapter = new OracleDataAdapter();             
                adapter.Fill(bdatos,cursor );
                return bdatos;
            }
            catch(Exception ex )
            {
                throw ex;
            }


        }


        /// <summary>
        /// llena los ddatos en una dataset
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>

        DataSet LlenarDataset(OracleCommand comando)
        {
            try
            {
                DataSet bdatos = new DataSet();
                adapter = new OracleDataAdapter
                {
                    SelectCommand = comando
                };
                adapter.Fill(bdatos);
                return bdatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SeleccionTabla(string tabla)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.Text, "select id,nombre from " + tabla);
                bd = LlenarDataset(comand);
                table = bd.Tables[0];
                bd = null;
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public DataTable  Listarmatriculas()
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "Listarmatriculas");
                comand.Parameters.Add("matriculas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comand.ExecuteNonQuery();
                bd = LlenarDataset(comand, "matriculas");
                return bd.Tables [0];
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarNovedad(int matricula ,int estadomatricula,int tiponovedad ,DateTime fecha ,
            string  descripcion)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "insertarnovedad");
                comand.Parameters.Add("P_matricula", OracleDbType.Int32).Value = matricula;
                comand.Parameters.Add("P_estadomatricula", OracleDbType.Int32).Value = estadomatricula;
                comand.Parameters.Add("P_tiponovedad", OracleDbType.Int32).Value = tiponovedad;
                comand.Parameters.Add("P_fecha", OracleDbType.Date).Value = fecha;
                comand.Parameters.Add("P_descripcion", OracleDbType.Varchar2).Value = descripcion;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void actualizarTipoNovedad(int id, string nombre, string descripcion)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "actualizarTipoNovedad");
                comand.Parameters.Add("P_id", OracleDbType.Varchar2).Value =id;
                comand.Parameters.Add("P_nombre", OracleDbType.Varchar2).Value = nombre;
                comand.Parameters.Add("P_descripcion", OracleDbType.Varchar2).Value = descripcion;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public void InsertarTipoNovedad(string nombre ,string descripcion)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "InsertarTipoNovedad");
                comand.Parameters.Add("P_nombre", OracleDbType.Varchar2).Value = nombre;
                comand.Parameters.Add("P_descripcion", OracleDbType.Varchar2).Value = descripcion;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public DataTable  listarTipoNovedad()
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "listarTipoNovedad");
                comand.Parameters.Add("TipoNovedad", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comand.ExecuteNonQuery();
                bd = LlenarDataset(comand, "tiponovedad");
                return bd.Tables[0];                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void insertarMatricula(   string   Codigo ,  int Curso , int Jornada , int Estudiante , decimal Valor ,
                                        DateTime Fechainicio , DateTime Fechafin, string Descripcion)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "insertarMatricula");
                comand.Parameters.Add("P_codigo", OracleDbType.Varchar2).Value = Codigo;
                comand.Parameters.Add("P_curso", OracleDbType.Int32).Value = Curso;
                comand.Parameters.Add("P_jornada", OracleDbType.Int32).Value = Jornada;
                comand.Parameters.Add("P_estudiante", OracleDbType.Int32).Value = Estudiante;
                comand.Parameters.Add("P_valor", OracleDbType.Decimal).Value = Valor;
                comand.Parameters.Add("P_fechainicio", OracleDbType.Date).Value = Fechainicio;
                comand.Parameters.Add("P_fechafin", OracleDbType.Date).Value = Fechafin;
                comand.Parameters.Add("P_descripcion", OracleDbType.Varchar2).Value = Descripcion;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public DataTable listarCursos()
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "listarCursos");
                comand.Parameters.Add("CURSOS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comand.ExecuteNonQuery();
                bd= LlenarDataset(comand, "cursos");
                table = bd.Tables[0];
                return table;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public void actualizarCurso(int id, string nombre, string descripcion, int categoria, decimal  valor,
                                    int duracion, int  unidadtiempo)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "actualizarCurso");
                comand.Parameters.Add("P_id", OracleDbType.Int32).Value = id;
                comand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = nombre;
                comand.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2).Value = descripcion;
                comand.Parameters.Add("P_CATEGORIA", OracleDbType.Int32).Value = categoria; 
                comand.Parameters.Add("P_valor", OracleDbType.Int32).Value = valor;
                comand.Parameters.Add("P_duracion", OracleDbType.Int32).Value = duracion ;
                comand.Parameters.Add("P_unidadtiempo", OracleDbType.Int32).Value = unidadtiempo ;

                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void insetartarCurso(string nombre, string descripcion, int categoria, decimal valor,
                                    int duracion, int unidadtiempo)
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "insertarCurso");
                comand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = nombre;
                comand.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2).Value = descripcion;
                comand.Parameters.Add("P_CATEGORIA", OracleDbType.Int32).Value = categoria;
                comand.Parameters.Add("P_valor", OracleDbType.Int32).Value = valor;
                comand.Parameters.Add("P_duracion", OracleDbType.Int32).Value = duracion;
                comand.Parameters.Add("P_unidadtiempo", OracleDbType.Int32).Value = unidadtiempo;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public DataTable   ListarUsuarios()
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "LISTARUSUARIOS");
                comand.Parameters.Add("CURSOR_USUARIOS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comand.ExecuteNonQuery();
                bd = LlenarDataset(comand , "CURSOR_USUARIOS");
                table = bd.Tables[0];
                return table;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public void InsertarUsuario(string IDENTIFICACION, string NOMBRE,  string APELLIDO, int EstadoCivil, DateTime fechaNacimiento, string DIRECCION, 
                                    string TELEFONO,int  sexo, string EMAIL, string USUARIO, string pwd,int perfil)     
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "InsertarUsuario");
                comand.Parameters.Add("P_IDENTIFICACION", OracleDbType.Varchar2).Value = IDENTIFICACION;
                comand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = NOMBRE;
                comand.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = APELLIDO;
                comand.Parameters.Add("P_EstadoCivil", OracleDbType.Int32).Value = EstadoCivil;
                comand.Parameters.Add("P_FECHANACIMIENTO", OracleDbType.Date).Value = fechaNacimiento;
                comand.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = DIRECCION;
                comand.Parameters.Add("P_TELEFONO", OracleDbType.Varchar2).Value = TELEFONO;
                comand.Parameters.Add("P_SEXO", OracleDbType.Int32).Value = sexo;
                comand.Parameters.Add("P_EMAIL", OracleDbType.Varchar2).Value = EMAIL;
                comand.Parameters.Add("P_USUARIO", OracleDbType.Varchar2).Value = USUARIO;
                comand.Parameters.Add("P_pwd", OracleDbType.Varchar2).Value = pwd;
                comand.Parameters.Add("P_Perfil", OracleDbType.Int32).Value = perfil;
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }

        }
        public void actualizarUsuario(int id, string IDENTIFICACION, string NOMBRE, string APELLIDO,int estadocivil, DateTime fechaNacimiento, string DIRECCION,
                                    string TELEFONO, int sexo, string EMAIL, string USUARIO, string pwd,int perfil )
        {
            try
            {
                AbrirConexion();
                comand = InicializarComando(conexion, CommandType.StoredProcedure, "actualizarUsuario");
                comand.Parameters.Add("P_ID", OracleDbType.Varchar2).Value = id;
                comand.Parameters.Add("P_IDENTIFICACION", OracleDbType.Varchar2).Value = IDENTIFICACION;
                comand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = NOMBRE;
                comand.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = APELLIDO;
                comand.Parameters.Add("P_estadocivil", OracleDbType.Int32).Value = estadocivil;
                comand.Parameters.Add("P_FECHANACIMIENTO", OracleDbType.Date).Value = fechaNacimiento;
                comand.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = DIRECCION;
                comand.Parameters.Add("P_TELEFONO", OracleDbType.Varchar2).Value = TELEFONO;
                comand.Parameters.Add("P_SEXO", OracleDbType.Int32).Value = sexo;
                comand.Parameters.Add("P_EMAIL", OracleDbType.Varchar2).Value = EMAIL;
                comand.Parameters.Add("P_USUARIO", OracleDbType.Varchar2).Value = USUARIO;
                comand.Parameters.Add("P_pwd", OracleDbType.Varchar2).Value = pwd;
                comand .Parameters .Add ("P_perfil",OracleDbType.Int32 ).Value =perfil ;

                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
