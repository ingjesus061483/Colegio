using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioWeb.Controllers
{
    public class MatriculasController : Controller
    {
        DatosHelper hlp;
        List<Matricula> matriculas;
        public  MatriculasController()
        {
            hlp = new DatosHelper();
        }
        // GET: Matriculas
        public ActionResult Index()
        {

            matriculas = new List<Matricula>();
            return View(matriculas);
        }

        // GET: Matriculas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matriculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matriculas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Matricula matricula = new Matricula
                {
                    Codigo = collection["codigo"],
                    Curso = int.Parse(collection["curso"]),
                    Jornada = int.Parse(collection["jornada"]),
                    Estudiante = int.Parse(collection["estudiante"]),
                    Valor = decimal.Parse(collection["valor"]),
                    Fechafin = DateTime.Parse(collection["fechafin"]),
                    Fechainicio = DateTime.Parse(collection["fechainicio"]),
                    Descripcion = collection["descripciom"],
                    EstadoMatricula = int.Parse(collection["estadomatricula"])
                };
                hlp.insertarMatricula(matricula);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
