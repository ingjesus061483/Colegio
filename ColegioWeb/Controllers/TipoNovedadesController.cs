using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColegioWeb.Controllers
{
    public class TipoNovedadesController : Controller
    {
        List<TipoNovedad> tipoNovedades;
        DatosHelper helper;
        public   TipoNovedadesController()
        {
            helper = new DatosHelper();
        }
        // GET: TipoNovedades
        public ActionResult Index()
        {
            tipoNovedades = helper.listarTipoNovedadList();
            return View(tipoNovedades );
        }
        // GET: TipoNovedades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoNovedades/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                TipoNovedad tipoNovedad = new TipoNovedad
                {
                    Nombre = collection["nombre"],
                    Descripcion = collection["descripcion"]
                };
                // TODO: Add insert logic here
                helper.InsertarTipoNovedad(tipoNovedad);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se ha insertado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message ;
                return RedirectToAction("Index");
            }
        }

        // GET: TipoNovedades/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                tipoNovedades = helper.listarTipoNovedadList();
                TipoNovedad tipoNovedad = tipoNovedades.Find(x => x.Id == id);
                return View( tipoNovedad );
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");

            }
        }

        // POST: TipoNovedades/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                TipoNovedad tipoNovedad = new TipoNovedad
                {
                    Id = id,
                    Nombre = collection["nombre"],
                    Descripcion = collection["descripcion"]
                };
                
                helper.actualizarTipoNovedad(tipoNovedad);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro seha actualizado con exito";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] =ex.Message ;
                return RedirectToAction("Index");
            }
        }

        // GET: TipoNovedades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoNovedades/Delete/5
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
