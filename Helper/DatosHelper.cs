using Datos;
using Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class DatosHelper
    {
        DataAccess Datos;
        DataTable table;

        public DatosHelper()
        {
            Datos = new DataAccess();
        }
        public List <EstadoCivil>listarEstadoCivilList()
        {
            try
            {
                table = listarEstadoCivil();
                List<EstadoCivil> estadoCivils = new List<EstadoCivil>();
                foreach (DataRow row in table.Rows)
                {
                    EstadoCivil estadoCivil = new EstadoCivil
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    estadoCivils.Add(estadoCivil);
                }
                return estadoCivils;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List <UnidadTiempo >GetUnidadTiempos(            )
        {
            try
            {
                table = listarUnidadtiempo();
                List<UnidadTiempo> unidadTiempos = new List<UnidadTiempo>();
                foreach (DataRow row in table.Rows)
                {
                    UnidadTiempo unidadTiempo = new UnidadTiempo
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()

                    };
                    unidadTiempos.Add(unidadTiempo);
                }
                return unidadTiempos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List <Jornada> GetJornadas()
        {
            try
            {
                table = ListarJornadas();
                List<Jornada> jornadas = new List<Jornada>();
                foreach (DataRow row in table.Rows)
                {
                    Jornada jornada = new Jornada
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    jornadas.Add(jornada);
                }
                return jornadas;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public List<EstadoMatricula> GetEstadoMatriculas()
        {
            try
            {
                table = ListarestadoMatricula();
                List<EstadoMatricula> estadoMatriculas = new List<EstadoMatricula>();
                foreach (DataRow row in table.Rows)
                {
                    EstadoMatricula estadoMatricula = new EstadoMatricula
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    estadoMatriculas.Add(estadoMatricula);
                }
                return estadoMatriculas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List <Matricula> Listarmatriculas(int?estudiante,int? estadomatricula)
        {
            try
            {
                List<EstadoMatricula> estadoMatriculas = GetEstadoMatriculas();
                List < Jornada >jornadas = GetJornadas();
                List<Usuario> usuarios = ListarUsuarios();
                List<Curso> cursos = ListarCursoslist();
                table = Datos.Listarmatriculas();
                List<Matricula> matriculas = new List<Matricula>();
                foreach (DataRow row in table .Rows )
                {
                    Matricula matricula = new Matricula 
                    {
                        Id=int.Parse ( row["id"].ToString ()),                        
                        Curso =int.Parse( row ["curso"].ToString()),
                        Cursos=cursos ,
                        EstadoMatriculas=estadoMatriculas ,
                        jornadas=jornadas,
                        Usuarios=usuarios ,
                        Estudiante =int.Parse (row ["estudiante" ].ToString()),
                        Jornada=int .Parse(row["jornada"].ToString ()),
                        Fechainicio=DateTime .Parse(row ["Fechainicio"].ToString ()),
                        Valor=decimal .Parse(row ["valor"].ToString ()),
                        EstadoMatricula =int .Parse (row ["EstadoMatricula"].ToString ()),
                        Descripcion =row ["Descripcion"].ToString ()
                    };
                    matriculas.Add(matricula);
                }
                if (estudiante != null || estadomatricula != null)
                    matriculas = matriculas.FindAll(x => x.Estudiante == estudiante|| x.EstadoMatricula ==estadomatricula  );
                return matriculas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void actualizarTipoNovedad(TipoNovedad tipoNovedad)
        {
            try
            {
                Datos.actualizarTipoNovedad(tipoNovedad.Id, tipoNovedad.Nombre, tipoNovedad.Descripcion);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public void InsertarTipoNovedad(TipoNovedad tipoNovedad)
        {
            try
            {
                Datos.InsertarTipoNovedad(tipoNovedad.Nombre, tipoNovedad.Descripcion);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List <TipoNovedad > listarTipoNovedadList()
        {
            try
            {
                table =listarTipoNovedades();
                List<TipoNovedad> tipoNovedades = new List<TipoNovedad>();
                foreach(DataRow row in table .Rows )
                {
                    TipoNovedad tipoNovedad = new TipoNovedad
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        Descripcion = row["descriocion"].ToString()
                    };
                    tipoNovedades.Add(tipoNovedad);
                }
                return tipoNovedades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarNovedad(int estadomatricula, Novedad novedad )
        {
            Datos.InsertarNovedad(novedad.Matricula, estadomatricula, novedad.TipoNovedad, novedad.Fecha, novedad.Descripcion);
        }
        public void insertarMatricula(Matricula matricula)
        {
            try
            {
                Datos.insertarMatricula(matricula.Codigo, matricula.Curso, matricula.Jornada, matricula.Estudiante,
                    matricula.Valor, matricula.Fechainicio, matricula.Fechafin, matricula.Descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarUsuarios(Usuario usuario )
        {
            try
            {
                Datos.InsertarUsuario(usuario.IDENTIFICACION, usuario.NOMBRE, usuario.APELLIDO,usuario .EstadoCivil ,
                    usuario.FechaNacimiento,usuario.DIRECCION, usuario.TELEFONO, usuario.Sexo, usuario.EMAIL,
                    usuario.USUARIO, usuario.Pwd,usuario .Perfil );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void actualizarUsuario(Usuario usuario)
        {
            try
            {
                Datos.actualizarUsuario(usuario.ID, usuario.IDENTIFICACION, usuario.NOMBRE, usuario.APELLIDO,
                    usuario .EstadoCivil , usuario .FechaNacimiento , usuario.DIRECCION, usuario.TELEFONO, 
                    usuario .Sexo , usuario.EMAIL, usuario.USUARIO,  usuario.Pwd,usuario .Perfil );
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }
        public DataTable listarUnidadtiempo()
        {
            try
            {
                return Datos.SeleccionTabla("unidadtiempo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listaarPerfiles()
        {
            try
            {
                return Datos.SeleccionTabla("Perfiles");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listarEstadoCivil()
        {
            try
            {
                return Datos.SeleccionTabla("estadocivil");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<Categoria > GetCategorias ()
        {
            try
            {
                table = listarCategorias();
                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in table.Rows)
                {
                    Categoria categoria = new Categoria
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    categorias.Add(categoria);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List <Curso >ListarCursoslist ()
        {
            try
            {
                List<Categoria> categorias = GetCategorias();
                List<UnidadTiempo> unidadTiempos = GetUnidadTiempos();
                table = this.ListarCursos();
                List<Curso> cursos = new List<Curso>();
                foreach (DataRow row in table.Rows)
                {
                    
                    Curso curso = new Curso
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["Nombre"].ToString(),
                        Descripcion = row["Descripcion"].ToString(),
                        Valor = decimal.Parse(row["valor"].ToString()),
                        Duracion = int.Parse(row["duracion"].ToString()),
                        UnidadTiempo = int.Parse(row["unidadtiempo"].ToString()) ,
                        UnidadTiempos =unidadTiempos ,
                        Categoria =int .Parse (row["categoria"].ToString ()),
                        Categorias=categorias                        
                    };
                    cursos.Add(curso);
                }
                return cursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void  actualizarCurso(Curso curso)
        {
            try
            {
                Datos.actualizarCurso(curso.Id, curso.Nombre, curso.Descripcion, curso.Categoria,
                    curso .Valor ,curso .Duracion ,curso .UnidadTiempo );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void insetartarCurso(Curso curso )
        {
            try
            {
                Datos.insetartarCurso(curso.Nombre, curso.Descripcion, curso.Categoria,
                    curso.Valor, curso.Duracion, curso.UnidadTiempo);
            }
            catch(Exception ex)
            { 
                throw ex; 
            }
        }
        public DataTable  listarCategorias ()
        {
            try
            {
                return Datos.SeleccionTabla("categorias");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarJornadas()
        {
            try
            {
                return Datos.SeleccionTabla("jornadas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarestadoMatricula()
        {
            try
            {
               return  Datos.SeleccionTabla("estadomatricula");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listarTipoNovedades()
        {
            try
            {
                return Datos.SeleccionTabla("TipoNovedades");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarCursos()
        {
            try
            {
                return Datos.listarCursos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable listarSexo()
        {
            try
            {
                return Datos.SeleccionTabla("sexo");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List <Sexo >GetSexos()
        {
            try
            {
                table = listarSexo();
                List<Sexo> sexos = new List<Sexo>();
                foreach (DataRow row in table.Rows)
                {
                    Sexo sexo = new Sexo
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    sexos.Add(sexo);
                }
                return sexos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Perfil >GetPerfils()
        {
            try
            {
                table = listaarPerfiles();
                List<Perfil> perfils = new List<Perfil>();
                foreach (DataRow row in table .Rows )
                {
                    Perfil perfil = new Perfil
                    {
                        Id = int.Parse(row["id"].ToString()),
                        Nombre = row["nombre"].ToString()
                    };
                    perfils.Add(perfil);
                }
                return perfils;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
     
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                List<EstadoCivil> estadoCivils = listarEstadoCivilList();
                List<Sexo> sexos = GetSexos();
                List<Perfil> perfils = GetPerfils();
                table = Datos.ListarUsuarios();            
                List<Usuario> usuarios = new List<Usuario>();
                foreach(DataRow row in table .Rows )
                {                    
                    Usuario usuario = new Usuario
                    {
                        ID =int.Parse (row ["id"].ToString()),                       
                        IDENTIFICACION = row["identificacion"].ToString(),                        
                        NOMBRE = row["nombre"].ToString(),
                        APELLIDO = row["apellido"].ToString(),
                        EstadoCivil =int .Parse (row["estadoCivil"].ToString ()) ,
                        EstadoCivils=estadoCivils ,
                        FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString()),
                        DIRECCION = row["direccion"].ToString(),
                        TELEFONO = row["telefono"].ToString(),
                        Sexo=int .Parse (row ["sexo"].ToString ()) ,
                        Sexos=sexos ,
                        EMAIL = row["email"].ToString(),
                        USUARIO = row["usuario"].ToString(),
                        Pwd = row["pwd"].ToString(),
                        Perfil =int .Parse(row["perfil"].ToString ()),
                        Perfiles=perfils 
                      
                    };
                    usuarios.Add(usuario);
                }
                return usuarios;
            
            }
            catch (Exception ex)
            {
                throw ex;
                    
            }
        }
      public   List <Novedad >GetNovedades( int?matricula)
        {
            try
            {
                List<TipoNovedad> tipoNovedads = listarTipoNovedadList();
                table = Datos.listarNovedad();
                List<Novedad> novedads = new List<Novedad>();
                foreach (DataRow row in table.Rows)
                {
                    Novedad novedad = new Novedad
                    {
                        Id = int.Parse(row["id"].ToString()),
                        TipoNovedad = int.Parse(row["tiponovedad"].ToString()),
                        Matricula = int.Parse(row["matricula"].ToString()),
                        Fecha = DateTime.Parse(row["fecha"].ToString()),
                        TipoNovedads = tipoNovedads,
                        Descripcion = row["descripcion"].ToString()

                    };
                    novedads.Add(novedad);
                }
                if (matricula !=null)
                {
                    novedads = novedads.FindAll(x => x.Matricula == matricula);
                }
                return novedads;
            }
            catch (Exception ex )
            {
                throw ex;
            
            }
        }
    }
}
