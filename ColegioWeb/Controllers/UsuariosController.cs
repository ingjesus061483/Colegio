using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio.Controllers
{
    public class UsuariosController : Controller
    {
        List<Usuario> usuarios;
        DatosHelper helper;
        DataTable table;
        SelectList sexo;
        SelectList perfles;
        SelectList estadoCivil;
        public UsuariosController()
        {
            helper = new DatosHelper();          

        }
        // GET: Usuarios
        public ActionResult Index(int ?perfil)
        {
            usuarios = new List<Usuario>();
            try
            {
                table = helper.listaarPerfiles();
                perfles = ColegioWeb.Utilities.GetSelectList(table);
                ViewBag.perfiles = perfles;
                usuarios = helper.ListarUsuarios();
                if (perfil != null)
                {
                    usuarios = usuarios.FindAll(x => x.Perfil == perfil);
                }
                return View(usuarios );
            }
            catch (Exception ex )
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return View(usuarios);
            }
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            Usuario usuario=new Usuario ();
            try
            {
                usuarios = helper.ListarUsuarios();
                 usuario = usuarios.Find(x => x.ID == id);
                return View(usuario );
            }
            catch (Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return View(usuario);
            }
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
         
            try
            {
                Usuario usuario = new Usuario();
                cargarCombo();
                return View(usuario);
            }
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
            
        }
        void cargarCombo()
        {

            table = helper.listaarPerfiles();
            perfles = ColegioWeb.Utilities.GetSelectList(table);

            table = helper.listarEstadoCivil();
            estadoCivil = ColegioWeb.Utilities.GetSelectList(table);

            table = helper.listarSexo();
            sexo = ColegioWeb.Utilities.GetSelectList(table);

            ViewBag.Perfiles = perfles;
            ViewBag.Estadocivil = estadoCivil;
            ViewBag.Sexo = sexo;
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {               
                Usuario usuario = new Usuario
                {
                    IDENTIFICACION = collection["identificacion"],
                    FechaNacimiento =DateTime.Parse (  collection ["FechaNacimiento"]),
                    NOMBRE = collection["nombre"],
                    APELLIDO = collection["apellido"],
                    EstadoCivil =int.Parse ( collection ["EstadoCivil"]),
                    DIRECCION = collection["direccion"],
                    TELEFONO = collection["telefono"],
                    Sexo =int.Parse (collection ["sexo"]),
                    EMAIL = collection["email"],
                    USUARIO = collection["usuario"],
                    Pwd = collection["pwd"],
                    Perfil =int.Parse ( collection ["perfil"])

                };
                // TODO: Add insert logic here
                helper.InsertarUsuarios(usuario);
                TempData["tipo"] = 2;
                TempData["message"] = "El registro se ha insertado correctamente";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {            
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                cargarCombo();
                usuarios = helper.ListarUsuarios();
                Usuario usuario = usuarios.Find(x => x.ID == id);              
                return View(usuario);
            } 
            catch(Exception ex)
            {
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {               
                Usuario usuario = new Usuario
                {
                    ID =id,
                    IDENTIFICACION = collection["identificacion"],
                    FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"]),
                    NOMBRE = collection["nombre"],
                    APELLIDO = collection["apellido"],
                    EstadoCivil = int.Parse(collection["EstadoCivil"]),
                    DIRECCION = collection["direccion"],
                    TELEFONO = collection["telefono"],
                    Sexo = int.Parse(collection["sexo"]),
                    EMAIL = collection["email"],
                    USUARIO = collection["usuario"],
                    Pwd = collection["pwd"],
                    Perfil = int.Parse(collection["perfil"])
                };
                helper.actualizarUsuario(usuario);
                TempData["tipo"] = 1;
                TempData["message"] = "El registro se actualizo correctamente";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {             
                TempData["tipo"] = 2;
                TempData["message"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
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
