using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioWeb.Controllers
{
    public class MatriculasController : Controller
    {
        SelectList estadoMatricula;
        DatosHelper hlp;
        SelectList cursos;
        SelectList jornadas;
        DataTable table;
        List<Matricula> matriculas;
        public  MatriculasController()
        {
            hlp = new DatosHelper();
        }
        // GET: Matriculas
        public ActionResult Index(string  identificacion, int? estadomatricula)
        {            
            matriculas = new List<Matricula>();
            try
            {
                table = hlp.ListarestadoMatricula();
                estadoMatricula = Utilities.GetSelectList(table);
                ViewBag.estadoMatricula = estadoMatricula;
                List<Usuario> usuarios = hlp.ListarUsuarios();
                Usuario usuario = usuarios.Find(x => x.IDENTIFICACION == identificacion && x.Rol.Nombre == "Estudiante");
                ViewBag.estudiante = null;
                int? id = null;
                if (usuario !=null)
                {
                   ViewBag.estudiante = usuario;
                    id = usuario.ID;
                }
                matriculas = hlp.Listarmatriculas(id , estadomatricula);
                return View(matriculas);
            }
            catch (Exception ex )
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return View (matriculas );
            }
        }

        // GET: Matriculas/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                matriculas = hlp.Listarmatriculas(null, null);
               Matricula matricula= matriculas.Find(x => x.Id == id);
                return View(matricula);
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("index");
            }
        }

        // GET: Matriculas/Create
        public ActionResult Create(int? estudiante)
        {
            try
            {
                List<Usuario> usuarios = hlp.ListarUsuarios();
                Usuario usuario = usuarios.Find(x => x.ID == estudiante);
                if (usuario == null)
                {
                    TempData["tipo"] = 2;
                    TempData["message"] = "No hay usuario disponible";
                    return RedirectToAction("Index");

                }
                table = hlp.ListarCursos();
                cursos = ColegioWeb.Utilities.GetSelectList(table);
                table = hlp.ListarJornadas();
                jornadas = ColegioWeb.Utilities.GetSelectList(table);
                ViewBag.cursos = cursos;
                ViewBag.jornadas = jornadas;
                ViewBag.estudiante = estudiante;
                return View();
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
           
        }

        // POST: Matriculas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                List<Curso> cursos = hlp.ListarCursoslist();
                List<Jornada> jornadas = hlp.GetJornadas();
                List<Usuario> usuarios = hlp.ListarUsuarios();
                List<EstadoMatricula> estadoMatriculas = hlp.GetEstadoMatriculas();
                Matricula matricula = new Matricula
                {
                    Curso = int.Parse(collection["curso"]),
                    Cursos=cursos,
                    Jornada = int.Parse(collection["jornada"]),
                    jornadas=jornadas,
                    Estudiante = int.Parse(collection["estudiante"]),
                    Usuarios=usuarios ,
                    Valor = decimal.Parse(collection["valor"]),
                    Fechainicio = DateTime.Parse(collection["fechainicio"])  ,
                    Descripcion = collection["descripciom"]
                };
                hlp.insertarMatricula(matricula);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se ha insertado con exito";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
