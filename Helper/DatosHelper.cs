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
        public List <Curso >ListarCursoslist ()
        {
            try
            {
                table = this.ListarCursos();
                List<Curso> cursos = new List<Curso>();
                foreach (DataRow row in table.Rows)
                {
                    int.TryParse(row["id"].ToString(), out int id);
                    int.TryParse(row["categoria"].ToString(), out int categoria);
                    decimal.TryParse(row["valor"].ToString (), out decimal valor);
                    int.TryParse(row["duracion"].ToString(), out int duracion);
                    int.TryParse(row["unidadtiempo"].ToString(), out int unidadtiempo);
                    Curso curso = new Curso
                    {
                        Id = id,
                        Nombre = row["Nombre"].ToString(),
                        Descripcion = row["Descripcion"].ToString(),
                        Valor = valor,
                        Duracion = duracion,
                        UnidadTiempo =unidadtiempo ,
                        Categoria = categoria 
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
     
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                table = Datos.ListarUsuarios();
                List<Usuario> usuarios = new List<Usuario>();
                foreach(DataRow row in table .Rows )
                {
                    
                    int.TryParse(row["id"].ToString(),out int id);                   
                    int.TryParse(row ["estadocivil"].ToString (),out int  estadoCivil );                 
                    int.TryParse(row["sexo"].ToString(), out int  sexo);                  
                    int.TryParse(row["perfil"].ToString(), out int  perfil);
                    Usuario usuario = new Usuario
                    {
                        ID =id,                       
                        IDENTIFICACION = row["identificacion"].ToString(),                        
                        NOMBRE = row["nombre"].ToString(),
                        APELLIDO = row["apellido"].ToString(),
                        EstadoCivil =estadoCivil ,
                        FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString()),
                        DIRECCION = row["direccion"].ToString(),
                        TELEFONO = row["telefono"].ToString(),
                        Sexo=sexo ,
                        EMAIL = row["email"].ToString(),
                        USUARIO = row["usuario"].ToString(),
                        Pwd = row["pwd"].ToString(),
                        Perfil =perfil 
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
    }
}
