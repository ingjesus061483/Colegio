using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Factory;
using Helper;
namespace ColegioWeb.Controllers
{
    public class CursosController : Controller
    {
        DataTable table;
        DatosHelper hlp;
        SelectList categorias;
        SelectList unidadtiempo;
        List<Curso> cursos;
       void  cargarcombo()
        {
            table = hlp.listarUnidadtiempo();
            unidadtiempo = ColegioWeb.Utilities.GetSelectList(table);
            table = hlp.listarCategorias();
            categorias = ColegioWeb.Utilities.GetSelectList(table);
            ViewBag.Categorias = categorias;
            ViewBag.UnidadTiempo = unidadtiempo;

        }
        public CursosController()
        {
            hlp = new DatosHelper();
        }
        // GET: Cursos
        public ActionResult Index(int? categoria )
        {
            cursos = new List<Curso>();
            try
            {
                table = hlp.listarCategorias();
                categorias = ColegioWeb.Utilities.GetSelectList(table);
                ViewBag.Categorias = categorias;
                cursos = hlp.ListarCursoslist();
                if (categoria !=null)
                {
                    cursos= cursos.FindAll(x => x.Categoria == categoria);
                }
                return View(cursos);

            }
            catch (Exception ex )
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return View(cursos);
            }
            
                    
        }

        // GET: Cursos/Details/5
        public ActionResult Details(int? id)
        {
            try
            {
                cursos = hlp.ListarCursoslist();
                Curso curso = cursos.Find(x => x.Id == id);
                return View(curso);
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");

            }
  
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            try
            {
                cargarcombo();
                return View();
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;

                return RedirectToAction("Index");

            }

        }

        // POST: Cursos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Curso curso = new Curso
                {
                    Nombre = collection["nombre"],
                    Descripcion = collection["descripcion"],
                    UnidadTiempo =int.Parse ( collection ["unidadtiempo"]),
                    Valor =decimal .Parse (collection ["valor"]),
                    Duracion=int .Parse (collection ["duracion"]),
                    Categoria = int.Parse(collection["categoria"])
                };
                hlp.insetartarCurso(curso);
                TempData["tipo"] = 1;
                TempData["message"] ="El registro se ha insetado correctamente";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;

                return RedirectToAction("Index");
            }
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                cargarcombo();
                cursos = hlp.ListarCursoslist();
                Curso curso = cursos.Find(x => x.Id == id);
                return View(curso );
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");


            }

        }

        // POST: Cursos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Curso curso = new Curso {
                    Id=id,
                    Nombre = collection["nombre"],
                    Descripcion = collection["descripcion"],
                    UnidadTiempo = int.Parse(collection["unidadtiempo"]),
                    Valor = decimal.Parse(collection["valor"]),
                    Duracion = int.Parse(collection["duracion"]),
                    Categoria = int.Parse(collection["categoria"])
                };
                // TODO: Add update logic here
                hlp.actualizarCurso( curso);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se ha actulizado correctamente";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cursos/Delete/5
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
