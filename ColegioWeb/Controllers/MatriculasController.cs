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
        public ActionResult Index(int? estudiante, int? estadomatricula)
        {

            matriculas = new List<Matricula>();
            try
            {
                matriculas = hlp.Listarmatriculas(estudiante, estadomatricula);
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
        public ActionResult Create(int estudiante)
        {
            try
            {
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
                Curso curso = cursos.Find(x => x.Id == int.Parse(collection["curso"]));
                DateTime Fechainicio = DateTime.Parse(collection["fechainicio"]);
                DateTime fechaFin = ColegioWeb.Utilities.GetFinalDate(Fechainicio, curso);
                Matricula matricula = new Matricula
                {
                    Curso = int.Parse(collection["curso"]),
                    Jornada = int.Parse(collection["jornada"]),
                    Estudiante = int.Parse(collection["estudiante"]),
                    Valor = decimal.Parse(collection["valor"]),
                    Fechainicio = Fechainicio  ,
                    Descripcion = collection["descripciom"],
                    EstadoMatricula = int.Parse(collection["estadomatricula"])
                };
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se ha insertado con exito";
                hlp.insertarMatricula(matricula);
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
