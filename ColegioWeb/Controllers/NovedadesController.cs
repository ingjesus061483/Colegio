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
    public class NovedadesController : Controller
    {
        DataTable table;
        SelectList tiponovedad;
        SelectList estadoMatricula;
        List<Novedad> novedades;
        DatosHelper helper;
        public NovedadesController()
        {
            helper = new DatosHelper();
        }
        // GET: Novedades
        public ActionResult Index()
        {

            return View();
        }

        // GET: Novedades/Details/5
        

        // GET: Novedades/Create
        public ActionResult Create(int matricula)
        {
            try
            {
                ViewBag.matricula = matricula;
                List<Matricula> matriculas = helper.Listarmatriculas(null, null);
                Matricula mat = matriculas.Find(x => x.Id == matricula && x.EstadoMatricula >= 3);
                if( mat !=null)
                {
                    TempData["tipo"] = 3;
                    TempData["message"] ="el proceso de matricula ha finalizado";
                    return RedirectToAction("index");
                }
                table = helper.ListarestadoMatricula();
                estadoMatricula = ColegioWeb.Utilities.GetSelectList(table);
                ViewBag.estadoMatricula = estadoMatricula;
                table = helper.listarTipoNovedades();
                tiponovedad = ColegioWeb.Utilities.GetSelectList(table);
                ViewBag.TipoNovedad = tiponovedad;
                return View();
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("index");
            }
        }

        // POST: Novedades/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                int EstadoMatricula = int.Parse(collection["estadomatricula"]);
                Novedad novedad = new Novedad
                {
                    Matricula = int.Parse(collection["matricula"]),
                    TipoNovedad = int.Parse(collection["tiponovedad"]),
                    Descripcion = collection["descripcion"],
                    fecha = DateTime.Parse(collection["fecha"])
                };
                helper.InsertarNovedad(EstadoMatricula, novedad);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se ha insertado con exito";
                return RedirectToAction("Index");
            }
            catch(Exception ex )
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex;
                return RedirectToAction("Index");                
            }
        }

        

        // GET: Novedades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Novedades/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
