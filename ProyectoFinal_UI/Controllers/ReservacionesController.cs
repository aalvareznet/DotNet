using ProyectoFinal_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal_UI.Controllers
{
    public class ReservacionesController : Controller
    {
        // GET: Reservaciones
        public ActionResult obtenerReservaciones()
        {
            List<Reservaciones> listaReservaciones = new List<Reservaciones>();
            Reservaciones reservacion;

            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient()) 
                {
                    var lista = servicio.obtenerReservacion();
                    if (lista != null) 
                    {
                        foreach (var item in lista) 
                        {
                            reservacion = new Reservaciones();
                            reservacion.TN_NumReservacion = item.TN_NumReservacion;
                            reservacion.TF_FecReserva = item.TF_FecReserva;
                            reservacion.TN_IdMesa = item.TN_IdMesa;
                            reservacion.TN_IdCliente = item.TN_IdCliente;
                            reservacion.TN_IdMenu = item.TN_IdMenu;
                            reservacion.TN_Cantidad = item.TN_Cantidad;
                            listaReservaciones.Add(reservacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return View(listaReservaciones);
        }

        public ActionResult agregarReservacion() 
        {
            Reservaciones reservacion = new Reservaciones();
            return View(reservacion);
        }

        public ActionResult modificarReservacion(int idReservacion) 
        {
            Reservaciones reservacion = new Reservaciones();
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient()) 
                {
                    var reservacionDTO = servicio.obtenerReservacionID(idReservacion);
                    reservacion.TN_NumReservacion = reservacionDTO.TN_NumReservacion;
                    reservacion.TF_FecReserva = reservacionDTO.TF_FecReserva;
                    reservacion.TN_IdMesa = reservacionDTO.TN_IdMesa;
                    reservacion.TN_IdCliente = reservacionDTO.TN_IdCliente;
                    reservacion.TN_IdMenu = reservacionDTO.TN_IdMenu;
                    reservacion.TN_Cantidad = reservacionDTO.TN_Cantidad;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(reservacion);
        }
        public ActionResult eliminarReservacion(int idReservacion)
        {
            Reservaciones reservacion = new Reservaciones();
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient())
                {
                    var reservacionDTO = servicio.obtenerReservacionID(idReservacion);
                    reservacion.TN_NumReservacion = reservacionDTO.TN_NumReservacion;
                    reservacion.TF_FecReserva = reservacionDTO.TF_FecReserva;
                    reservacion.TN_IdMesa = reservacionDTO.TN_IdMesa;
                    reservacion.TN_IdCliente = reservacionDTO.TN_IdCliente;
                    reservacion.TN_IdMenu = reservacionDTO.TN_IdMenu;
                    reservacion.TN_Cantidad = reservacionDTO.TN_Cantidad;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(reservacion);
        }
        public ActionResult detalleReservacion(int idReservacion)
        {
            Reservaciones reservacion = new Reservaciones();
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient())
                {
                    var reservacionDTO = servicio.obtenerReservacionID(idReservacion);
                    reservacion.TN_NumReservacion = reservacionDTO.TN_NumReservacion;
                    reservacion.TF_FecReserva = reservacionDTO.TF_FecReserva;
                    reservacion.TN_IdMesa = reservacionDTO.TN_IdMesa;
                    reservacion.TN_IdCliente = reservacionDTO.TN_IdCliente;
                    reservacion.TN_IdMenu = reservacionDTO.TN_IdMenu;
                    reservacion.TN_Cantidad = reservacionDTO.TN_Cantidad;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(reservacion);
        }

        public ActionResult insertarReservacion(Reservaciones reservacion) 
        {
            List<Reservaciones> listaReservaciones = new List<Reservaciones>();
            Reservaciones reservacionDto;
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient()) 
                {
                    srvReservaciones.TREST_RESERVACION servicioReservacion = new srvReservaciones.TREST_RESERVACION();
                    servicioReservacion.TF_FecReserva = reservacion.TF_FecReserva;
                    servicioReservacion.TN_IdMesa = reservacion.TN_IdMesa;  
                    servicioReservacion.TN_IdCliente = reservacion.TN_IdCliente;
                    servicioReservacion.TN_IdMenu = reservacion.TN_IdMenu;
                    servicioReservacion.TN_Cantidad = reservacion.TN_Cantidad;
                    servicio.agregarReservacion(servicioReservacion);

                    var lista = servicio.obtenerReservacion();
                    if (lista != null) 
                    {
                        foreach (var item in lista)
                        {
                            reservacionDto = new Reservaciones();
                            reservacionDto.TN_NumReservacion = item.TN_NumReservacion;
                            reservacionDto.TF_FecReserva = item.TF_FecReserva;
                            reservacionDto.TN_IdMesa = item.TN_IdMesa;
                            reservacionDto.TN_IdCliente = item.TN_IdCliente;
                            reservacionDto.TN_IdMenu = item.TN_IdMenu;
                            reservacionDto.TN_Cantidad = item.TN_Cantidad;
                            listaReservaciones.Add(reservacionDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservaciones", listaReservaciones);
        }
        public ActionResult actualizarReservacion (Reservaciones reservacion)
        {
            List<Reservaciones> listaReservaciones = new List<Reservaciones>();
            Reservaciones reservacionDto;
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient())
                {
                    srvReservaciones.TREST_RESERVACION servicioReservacion = new srvReservaciones.TREST_RESERVACION();
                    servicioReservacion.TN_NumReservacion = reservacion.TN_NumReservacion;
                    servicioReservacion.TF_FecReserva = reservacion.TF_FecReserva;
                    servicioReservacion.TN_IdMesa = reservacion.TN_IdMesa;
                    servicioReservacion.TN_IdCliente = reservacion.TN_IdCliente;
                    servicioReservacion.TN_IdMenu = reservacion.TN_IdMenu;
                    servicioReservacion.TN_Cantidad = reservacion.TN_Cantidad;
                    servicio.modificarReservacion(servicioReservacion);

                    var lista = servicio.obtenerReservacion();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            reservacionDto = new Reservaciones();
                            reservacionDto.TN_NumReservacion = item.TN_NumReservacion;
                            reservacionDto.TF_FecReserva = item.TF_FecReserva;
                            reservacionDto.TN_IdMesa = item.TN_IdMesa;
                            reservacionDto.TN_IdCliente = item.TN_IdCliente;
                            reservacionDto.TN_IdMenu = item.TN_IdMenu;
                            reservacionDto.TN_Cantidad = item.TN_Cantidad;
                            listaReservaciones.Add(reservacionDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservaciones", listaReservaciones);
        }
        public ActionResult borrarCliente (Reservaciones reservacion)
        {
            List<Reservaciones> listaReservaciones = new List<Reservaciones>();
            Reservaciones reservacionDto;
            try
            {
                using (srvReservaciones.IsrvReservacionesClient servicio = new srvReservaciones.IsrvReservacionesClient())
                {
                    srvReservaciones.TREST_RESERVACION servicioReservacion = new srvReservaciones.TREST_RESERVACION();
                    servicioReservacion.TN_NumReservacion = reservacion.TN_NumReservacion;
                    servicioReservacion.TF_FecReserva = reservacion.TF_FecReserva;
                    servicioReservacion.TN_IdMesa = reservacion.TN_IdMesa;
                    servicioReservacion.TN_IdCliente = reservacion.TN_IdCliente;
                    servicioReservacion.TN_IdMenu = reservacion.TN_IdMenu;
                    servicioReservacion.TN_Cantidad = reservacion.TN_Cantidad;
                    servicio.eliminarReservacion(servicioReservacion);

                    var lista = servicio.obtenerReservacion();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            reservacionDto = new Reservaciones();
                            reservacionDto.TN_NumReservacion = item.TN_NumReservacion;
                            reservacionDto.TF_FecReserva = item.TF_FecReserva;
                            reservacionDto.TN_IdMesa = item.TN_IdMesa;
                            reservacionDto.TN_IdCliente = item.TN_IdCliente;
                            reservacionDto.TN_IdMenu = item.TN_IdMenu;
                            reservacionDto.TN_Cantidad = item.TN_Cantidad;
                            listaReservaciones.Add(reservacionDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerReservaciones", listaReservaciones);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, Reservaciones reservacion) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Insertar":
                        return insertarReservacion(reservacion);
                    case "Actualizar":
                        return actualizarReservacion(reservacion);
                    case "Eliminar":
                        return borrarCliente(reservacion);
                    default:
                        return RedirectToAction("obtenerReservaciones");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}   