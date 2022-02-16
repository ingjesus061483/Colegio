using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioWeb.Controllers
{
    public class HomeController : Controller
    {
        List<Curso> cursos;
        DatosHelper helper;
        SelectList categorias;
        public HomeController()
        {
            helper = new DatosHelper();

        }
        public ActionResult Index(int? categoria)
        {
            cursos = new List<Curso>();
            try
            {
                cursos = helper.ListarCursoslist();
                ViewBag.Cursos = cursos.FindAll(x=>x.Categoria ==categoria );
                return View();
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}