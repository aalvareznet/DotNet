using InterfazUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfazUsuario.Controllers
{
    public class feMenuController : Controller
    {
        public ActionResult obtenerMenu() 
        {
            List<ModeloMenu> lRespuesta = new List<ModeloMenu>();
            ModeloMenu lMenu;

            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient()) 
                {
                    var listaMenu = lServicio.obtenerMenu_Rest();   
                    if (listaMenu != null)
                    {
                        foreach (var item in listaMenu)
                        {
                            lMenu = new ModeloMenu();
                            lMenu.TN_IdMenu = item.TN_IdMenu;
                            lMenu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            lMenu.TC_DscMenu = item.TC_DscMenu;
                            lMenu.TD_Precio = item.TD_Precio;
                            lRespuesta.Add(lMenu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult agregarMenu() 
        {
            ModeloMenu lRespuesta = new ModeloMenu();
            return View(lRespuesta);
        }
        public ActionResult modificarMenu(int pId)
        {
            ModeloMenu lRespuesta = new ModeloMenu();
            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient())
                {
                    var lMenu = lServicio.obtenerMenu_RestID(pId);
                    lRespuesta.TN_IdMenu = lMenu.TN_IdMenu;
                    lRespuesta.TN_IdTipoMenu = lMenu.TN_IdTipoMenu;
                    lRespuesta.TC_DscMenu = lMenu.TC_DscMenu;
                    lRespuesta.TD_Precio = lMenu.TD_Precio;

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }

        public ActionResult eliminarMenu(int pId)
        {
            ModeloMenu lRespuesta = new ModeloMenu();
            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient())
                {
                    var lMenu = lServicio.obtenerMenu_RestID(pId);
                    lRespuesta.TN_IdMenu = lMenu.TN_IdMenu;
                    lRespuesta.TN_IdTipoMenu = lMenu.TN_IdTipoMenu;
                    lRespuesta.TC_DscMenu = lMenu.TC_DscMenu;
                    lRespuesta.TD_Precio = lMenu.TD_Precio;

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult detalleMenu(int pId)
        {
            ModeloMenu lRespuesta = new ModeloMenu();
            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient())
                {
                    var lMenu = lServicio.obtenerMenu_RestID(pId);
                    lRespuesta.TN_IdMenu = lMenu.TN_IdMenu;
                    lRespuesta.TN_IdTipoMenu = lMenu.TN_IdTipoMenu;
                    lRespuesta.TC_DscMenu = lMenu.TC_DscMenu;
                    lRespuesta.TD_Precio = lMenu.TD_Precio;

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }

        public ActionResult insertarMenu(ModeloMenu pMenu) 
        {
            List<ModeloMenu> lRespuesta = new List<ModeloMenu>();
            ModeloMenu lMenu;

            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient()) 
                {
                    ReferenciaSrvMenu.TREST_MENU lObjetoMenu = new ReferenciaSrvMenu.TREST_MENU();
                    lObjetoMenu.TN_IdMenu = pMenu.TN_IdMenu;
                    lObjetoMenu.TN_IdTipoMenu = pMenu.TN_IdTipoMenu;
                    lObjetoMenu.TC_DscMenu = pMenu.TC_DscMenu;
                    lObjetoMenu.TD_Precio = pMenu.TD_Precio;
                    lServicio.agregarMenu_Rest(lObjetoMenu);

                    var listaMenu = lServicio.obtenerMenu_Rest();
                    if (listaMenu != null)
                    {
                        foreach (var item in listaMenu)
                        {
                            lMenu = new ModeloMenu();
                            lMenu.TN_IdMenu = item.TN_IdMenu;
                            lMenu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            lMenu.TC_DscMenu = item.TC_DscMenu;
                            lMenu.TD_Precio = item.TD_Precio;
                            lRespuesta.Add(lMenu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", lRespuesta);
        }
        public ActionResult actualizarMenu(ModeloMenu pMenu)
        {
            List<ModeloMenu> lRespuesta = new List<ModeloMenu>();
            ModeloMenu lMenu;

            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient())
                {
                    ReferenciaSrvMenu.TREST_MENU lObjetoMenu = new ReferenciaSrvMenu.TREST_MENU();
                    lObjetoMenu.TN_IdMenu = pMenu.TN_IdMenu;
                    lObjetoMenu.TN_IdTipoMenu = pMenu.TN_IdTipoMenu;
                    lObjetoMenu.TC_DscMenu = pMenu.TC_DscMenu;
                    lObjetoMenu.TD_Precio = pMenu.TD_Precio;
                    lServicio.modificarMenu_Rest(lObjetoMenu);

                    var listaMenu = lServicio.obtenerMenu_Rest();
                    if (listaMenu != null)
                    {
                        foreach (var item in listaMenu)
                        {
                            lMenu = new ModeloMenu();
                            lMenu.TN_IdMenu = item.TN_IdMenu;
                            lMenu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            lMenu.TC_DscMenu = item.TC_DscMenu;
                            lMenu.TD_Precio = item.TD_Precio;
                            lRespuesta.Add(lMenu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", lRespuesta);
        }
        public ActionResult borrarMenu(ModeloMenu pMenu)
        {
            List<ModeloMenu> lRespuesta = new List<ModeloMenu>();
            ModeloMenu lMenu;

            try
            {
                using (ReferenciaSrvMenu.IsrvMenuClient lServicio = new ReferenciaSrvMenu.IsrvMenuClient())
                {
                    ReferenciaSrvMenu.TREST_MENU lObjetoMenu = new ReferenciaSrvMenu.TREST_MENU();
                    lObjetoMenu.TN_IdMenu = pMenu.TN_IdMenu;
                    lObjetoMenu.TN_IdTipoMenu = pMenu.TN_IdTipoMenu;
                    lObjetoMenu.TC_DscMenu = pMenu.TC_DscMenu;
                    lObjetoMenu.TD_Precio = pMenu.TD_Precio;
                    lServicio.eliminarMenu_Rest(lObjetoMenu);

                    var listaMenu = lServicio.obtenerMenu_Rest();
                    if (listaMenu != null)
                    {
                        foreach (var item in listaMenu)
                        {
                            lMenu = new ModeloMenu();
                            lMenu.TN_IdMenu = item.TN_IdMenu;
                            lMenu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            lMenu.TC_DscMenu = item.TC_DscMenu;
                            lMenu.TD_Precio = item.TD_Precio;
                            lRespuesta.Add(lMenu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", lRespuesta);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, ModeloMenu pModelo) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Agregar":
                        return insertarMenu(pModelo);
                    case "Modificar":
                        return actualizarMenu(pModelo);
                    case "Borrar":
                        return borrarMenu(pModelo);
                    default:
                        return RedirectToAction("obtenerMenu");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}