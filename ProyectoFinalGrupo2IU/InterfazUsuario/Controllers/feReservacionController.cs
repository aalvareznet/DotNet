using InterfazUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfazUsuario.Controllers
{
    public class feReservacionController : Controller
    {
        // Funciones para las vistas
        public ActionResult obtenerReservacion() 
        {
            List<ModeloReservacion> lRespuesta = new List<ModeloReservacion>();
            ModeloReservacion lReservacion;

            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient()) 
                {
                    var listaReservacion = lServicio.obtenerReservaciones_Rest();
                    if (listaReservacion != null)
                    {
                        foreach (var item in listaReservacion)
                        {
                            lReservacion = new ModeloReservacion();
                            lReservacion.TN_NumReservacion = item.TN_NumReservacion;
                            lReservacion.TN_IdCliente = item.TN_IdCliente;
                            lReservacion.TN_IdMesa = item.TN_IdMesa;
                            lReservacion.TN_IdMenu = item.TN_IdMenu;
                            lReservacion.TN_Cantidad = item.TN_Cantidad;
                            lReservacion.TF_FecReserva = item.TF_FecReserva;
                            lRespuesta.Add(lReservacion);
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
        public ActionResult agregarReservacion()
        {
            ModeloReservacion lRespuesta = new ModeloReservacion();
            return View(lRespuesta);
        }

        public ActionResult modificarReservacion(int pId) 
        {
            ModeloReservacion lRespuesta = new ModeloReservacion();
            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient())
                {
                    var lReservacion = lServicio.obtenerReservacion_RestID(pId);
                    lRespuesta.TN_NumReservacion = lReservacion.TN_NumReservacion;
                    lRespuesta.TN_IdCliente = lReservacion.TN_IdCliente;
                    lRespuesta.TN_IdMesa = lReservacion.TN_IdMesa;
                    lRespuesta.TN_IdMenu = lReservacion.TN_IdMenu;
                    lRespuesta.TN_Cantidad = lReservacion.TN_Cantidad;
                    lRespuesta.TF_FecReserva = lReservacion.TF_FecReserva;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }

        public ActionResult eliminarReservacion(int pId)
        {
            ModeloReservacion lRespuesta = new ModeloReservacion();
            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient())
                {
                    var lReservacion = lServicio.obtenerReservacion_RestID(pId);
                    lRespuesta.TN_NumReservacion = lReservacion.TN_NumReservacion;
                    lRespuesta.TN_IdCliente = lReservacion.TN_IdCliente;
                    lRespuesta.TN_IdMesa = lReservacion.TN_IdMesa;
                    lRespuesta.TN_IdMenu = lReservacion.TN_IdMenu;
                    lRespuesta.TN_Cantidad = lReservacion.TN_Cantidad;
                    lRespuesta.TF_FecReserva = lReservacion.TF_FecReserva;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult detalleReservacion(int pId)
        {
            ModeloReservacion lRespuesta = new ModeloReservacion();
            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient())
                {
                    var lReservacion = lServicio.obtenerReservacion_RestID(pId);
                    lRespuesta.TN_NumReservacion = lReservacion.TN_NumReservacion;
                    lRespuesta.TN_IdCliente = lReservacion.TN_IdCliente;
                    lRespuesta.TN_IdMesa = lReservacion.TN_IdMesa;
                    lRespuesta.TN_IdMenu = lReservacion.TN_IdMenu;
                    lRespuesta.TN_Cantidad = lReservacion.TN_Cantidad;
                    lRespuesta.TF_FecReserva = lReservacion.TF_FecReserva;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }

        //CRUD

        public ActionResult insertarReservacion(ModeloReservacion pReservacion) 
        {
            List<ModeloReservacion> lRespuesta = new List<ModeloReservacion>();
            ModeloReservacion lReservacion;

            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient()) 
                {
                    ReferenciaSrvReservacion.TREST_RESERVACION lObjetoReservacion = new ReferenciaSrvReservacion.TREST_RESERVACION();
                    lObjetoReservacion.TN_NumReservacion = pReservacion.TN_NumReservacion;
                    lObjetoReservacion.TN_IdCliente = pReservacion.TN_IdCliente;
                    lObjetoReservacion.TN_IdMesa = pReservacion.TN_IdMesa;
                    lObjetoReservacion.TN_IdMenu = pReservacion.TN_IdMenu;
                    lObjetoReservacion.TN_Cantidad = pReservacion.TN_Cantidad;
                    lObjetoReservacion.TF_FecReserva = pReservacion.TF_FecReserva;
                    lServicio.agregarReservacion_Rest(lObjetoReservacion);

                    var listaReservaciones = lServicio.obtenerReservaciones_Rest();
                    if (listaReservaciones != null)
                    {
                        foreach (var item in listaReservaciones)
                        {
                            lReservacion = new ModeloReservacion();
                            lReservacion.TN_NumReservacion = item.TN_NumReservacion;
                            lReservacion.TN_IdCliente = item.TN_IdCliente;
                            lReservacion.TN_IdMesa = item.TN_IdMesa;
                            lReservacion.TN_IdMenu = item.TN_IdMenu;
                            lReservacion.TN_Cantidad = item.TN_Cantidad;
                            lReservacion.TF_FecReserva = item.TF_FecReserva;
                            lRespuesta.Add(lReservacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservacion", lRespuesta);
        }

        public ActionResult actualizarReservacion(ModeloReservacion pReservacion)
        {
            List<ModeloReservacion> lRespuesta = new List<ModeloReservacion>();
            ModeloReservacion lReservacion;

            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient())
                {
                    ReferenciaSrvReservacion.TREST_RESERVACION lObjetoReservacion = new ReferenciaSrvReservacion.TREST_RESERVACION();
                    lObjetoReservacion.TN_NumReservacion = pReservacion.TN_NumReservacion;
                    lObjetoReservacion.TN_IdCliente = pReservacion.TN_IdCliente;
                    lObjetoReservacion.TN_IdMesa = pReservacion.TN_IdMesa;
                    lObjetoReservacion.TN_IdMenu = pReservacion.TN_IdMenu;
                    lObjetoReservacion.TN_Cantidad = pReservacion.TN_Cantidad;
                    lObjetoReservacion.TF_FecReserva = pReservacion.TF_FecReserva;
                    lServicio.modificarReservacion_Rest(lObjetoReservacion);

                    var listaReservaciones = lServicio.obtenerReservaciones_Rest();
                    if (listaReservaciones != null)
                    {
                        foreach (var item in listaReservaciones)
                        {
                            lReservacion = new ModeloReservacion();
                            lReservacion.TN_NumReservacion = item.TN_NumReservacion;
                            lReservacion.TN_IdCliente = item.TN_IdCliente;
                            lReservacion.TN_IdMesa = item.TN_IdMesa;
                            lReservacion.TN_IdMenu = item.TN_IdMenu;
                            lReservacion.TN_Cantidad = item.TN_Cantidad;
                            lReservacion.TF_FecReserva = item.TF_FecReserva;
                            lRespuesta.Add(lReservacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservacion", lRespuesta);
        }
        public ActionResult borrarReservacion(ModeloReservacion pReservacion)
        {
            List<ModeloReservacion> lRespuesta = new List<ModeloReservacion>();
            ModeloReservacion lReservacion;

            try
            {
                using (ReferenciaSrvReservacion.IsrvReservacionClient lServicio = new ReferenciaSrvReservacion.IsrvReservacionClient())
                {
                    ReferenciaSrvReservacion.TREST_RESERVACION lObjetoReservacion = new ReferenciaSrvReservacion.TREST_RESERVACION();
                    lObjetoReservacion.TN_NumReservacion = pReservacion.TN_NumReservacion;
                    lObjetoReservacion.TN_IdCliente = pReservacion.TN_IdCliente;
                    lObjetoReservacion.TN_IdMesa = pReservacion.TN_IdMesa;
                    lObjetoReservacion.TN_IdMenu = pReservacion.TN_IdMenu;
                    lObjetoReservacion.TN_Cantidad = pReservacion.TN_Cantidad;
                    lObjetoReservacion.TF_FecReserva = pReservacion.TF_FecReserva;
                    lServicio.eliminarReservacion_Rest(lObjetoReservacion);

                    var listaReservaciones = lServicio.obtenerReservaciones_Rest();
                    if (listaReservaciones != null)
                    {
                        foreach (var item in listaReservaciones)
                        {
                            lReservacion = new ModeloReservacion();
                            lReservacion.TN_NumReservacion = item.TN_NumReservacion;
                            lReservacion.TN_IdCliente = item.TN_IdCliente;
                            lReservacion.TN_IdMesa = item.TN_IdMesa;
                            lReservacion.TN_IdMenu = item.TN_IdMenu;
                            lReservacion.TN_Cantidad = item.TN_Cantidad;
                            lReservacion.TF_FecReserva = item.TF_FecReserva;
                            lRespuesta.Add(lReservacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservacion", lRespuesta);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, ModeloReservacion pReservacion) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Agregar":
                        return insertarReservacion(pReservacion);
                    case "Modificar":
                        return actualizarReservacion(pReservacion);
                    case "Borrar":
                        return borrarReservacion(pReservacion);
                    default:
                        return RedirectToAction("obtenerReservacion");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}