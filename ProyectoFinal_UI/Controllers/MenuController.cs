using ProyectoFinal_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal_UI.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult obtenerMenu()
        {
            List<Menu> listaMenu = new List<Menu>();
            Menu menu;
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient()) 
                {
                    var lista = servicio.obtenerMenu();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            menu = new Menu();
                            menu.TN_IdMenu = item.TN_IdMenu;
                            menu.TC_DscMenu = item.TC_DscMenu;
                            menu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            menu.TD_Precio = item.TD_Precio;
                            listaMenu.Add(menu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return View(listaMenu);
        }

        public ActionResult agregarMenu() 
        {
            Menu menu = new Menu();
            return View(menu);
        }

        public ActionResult modificarMenu(int idMenu) 
        {
            Menu menu = new Menu();
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient())
                {
                    var item = servicio.obtenerItemMenu(idMenu);
                    menu.TN_IdMenu = item.TN_IdMenu;
                    menu.TC_DscMenu = item.TC_DscMenu;
                    menu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                    menu.TD_Precio = item.TD_Precio;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(menu);
        }

        public ActionResult eliminarMenu(int idMenu) 
        {
            Menu menu = new Menu();
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient())
                {
                    var item = servicio.obtenerItemMenu(idMenu);
                    menu.TN_IdMenu = item.TN_IdMenu;
                    menu.TC_DscMenu = item.TC_DscMenu;
                    menu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                    menu.TD_Precio = item.TD_Precio;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(menu);
        }
        public ActionResult detalleMenu(int id) 
        {
            Menu menu = new Menu();
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient())
                {
                    var item = servicio.obtenerItemMenu(id);
                    menu.TN_IdMenu = item.TN_IdMenu;
                    menu.TC_DscMenu = item.TC_DscMenu;
                    menu.TN_IdTipoMenu = item.TN_IdTipoMenu;
                    menu.TD_Precio = item.TD_Precio;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(menu);
        }

        public ActionResult insertarMenu(Menu menu) 
        {
            List<Menu> listaMenu = new List<Menu>();
            Menu menuDto;
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient()) 
                {
                    srvMenu.TREST_MENU servicioMenu = new srvMenu.TREST_MENU();
                    servicioMenu.TN_IdMenu = menu.TN_IdMenu;
                    servicioMenu.TC_DscMenu = menu.TC_DscMenu;
                    servicioMenu.TN_IdTipoMenu = menu.TN_IdTipoMenu;
                    servicioMenu.TD_Precio = menu.TD_Precio;
                    servicio.agregarItemMenu(servicioMenu);

                    var lista = servicio.obtenerMenu();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            menuDto = new Menu();
                            menuDto.TN_IdMenu = item.TN_IdMenu;
                            menuDto.TC_DscMenu = item.TC_DscMenu;
                            menuDto.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            menuDto.TD_Precio = item.TD_Precio;
                            listaMenu.Add(menuDto);
                        }
                    }   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", listaMenu);
        }

        public ActionResult actualizarMenu(Menu menu) 
        {
            List<Menu> listaMenu = new List<Menu>();
            Menu menuDto;
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient())
                {
                    srvMenu.TREST_MENU servicioMenu = new srvMenu.TREST_MENU();
                    servicioMenu.TN_IdMenu = menu.TN_IdMenu;
                    servicioMenu.TC_DscMenu = menu.TC_DscMenu;
                    servicioMenu.TN_IdTipoMenu = menu.TN_IdTipoMenu;
                    servicioMenu.TD_Precio = menu.TD_Precio;
                    servicio.modificarItemMenu(servicioMenu);

                    var lista = servicio.obtenerMenu();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            menuDto = new Menu();
                            menuDto.TN_IdMenu = item.TN_IdMenu;
                            menuDto.TC_DscMenu = item.TC_DscMenu;
                            menuDto.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            menuDto.TD_Precio = item.TD_Precio;
                            listaMenu.Add(menuDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", listaMenu);
        }

        public ActionResult borrarMenu(Menu menu) 
        {
            List<Menu> listaMenu = new List<Menu>();
            Menu menuDto;
            try
            {
                using (srvMenu.IsrvMenuClient servicio = new srvMenu.IsrvMenuClient())
                {
                    srvMenu.TREST_MENU servicioMenu = new srvMenu.TREST_MENU();
                    servicioMenu.TN_IdMenu = menu.TN_IdMenu;
                    servicioMenu.TC_DscMenu = menu.TC_DscMenu;
                    servicioMenu.TN_IdTipoMenu = menu.TN_IdTipoMenu;
                    servicioMenu.TD_Precio = menu.TD_Precio;
                    servicio.elimiarItemMenu(servicioMenu);

                    var lista = servicio.obtenerMenu();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            menuDto = new Menu();
                            menuDto.TN_IdMenu = item.TN_IdMenu;
                            menuDto.TC_DscMenu = item.TC_DscMenu;
                            menuDto.TN_IdTipoMenu = item.TN_IdTipoMenu;
                            menuDto.TD_Precio = item.TD_Precio;
                            listaMenu.Add(menuDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMenu", listaMenu);
        }

        public ActionResult accionesEjecucion(string accionEjecutar, Menu menu) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Insertar":
                        return insertarMenu(menu);
                    case "Actualizar":
                        return actualizarMenu(menu);
                    case "Borrar":
                        return borrarMenu(menu);
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