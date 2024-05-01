using ProyectoFinal_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal_UI.Controllers
{
    public class MesasController : Controller
    {
        // GET: Mesas
        public ActionResult obtenerMesas()
        {
            List<Mesas> listaMesas = new List<Mesas>();
            Mesas mesa;

            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    var lista = servicio.obtenerMesas();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            mesa = new Mesas();
                            mesa.TN_IdMesa = item.TN_IdMesa;
                            mesa.TC_DscMesa = item.TC_DscMesa;

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(listaMesas);
        }
        public ActionResult agregarMesa()
        {
            Mesas mesa = new Mesas();
            return View(mesa);
        }

        public ActionResult modificarMesa(int idMesa)
        {
            Mesas mesa = new Mesas();
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    var item = servicio.obtenerMesaID(idMesa);
                    mesa.TC_DscMesa = item.TC_DscMesa;
                    mesa.TN_IdMesa = item.TN_IdMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(mesa);
        }
        public ActionResult eliminarMesa(int idMesa)
        {
            Mesas mesa = new Mesas();
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    var item = servicio.obtenerMesaID(idMesa);
                    mesa.TC_DscMesa = item.TC_DscMesa;
                    mesa.TN_IdMesa = item.TN_IdMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(mesa);
        }

        public ActionResult detalleMesa(int idMesa)
        {
            Mesas mesa = new Mesas();
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    var item = servicio.obtenerMesaID(idMesa);
                    mesa.TC_DscMesa = item.TC_DscMesa;
                    mesa.TN_IdMesa = item.TN_IdMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(mesa);
        }

        public ActionResult insertarMesa(Mesas mesa)
        {
            List<Mesas> listaMesas = new List<Mesas>();
            Mesas mesaDto;
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    srvMesas.TREST_MESAS servicioMesas = new srvMesas.TREST_MESAS();
                    servicioMesas.TC_DscMesa = mesa.TC_DscMesa;
                    servicioMesas.TN_IdMesa = mesa.TN_IdMesa;
                    servicio.agregarMesa(servicioMesas);

                    var lista = servicio.obtenerMesas();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            mesaDto = new Mesas();
                            mesaDto.TN_IdMesa = item.TN_IdMesa;
                            mesaDto.TC_DscMesa = item.TC_DscMesa;
                            listaMesas.Add(mesaDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesas", listaMesas);

        }

        public ActionResult actualizarMesa(Mesas mesa)
        {
            List<Mesas> listaMesas = new List<Mesas>();
            Mesas mesaDto;
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    srvMesas.TREST_MESAS servicioMesas = new srvMesas.TREST_MESAS();
                    servicioMesas.TC_DscMesa = mesa.TC_DscMesa;
                    servicioMesas.TN_IdMesa = mesa.TN_IdMesa;
                    servicio.modificarMesa(servicioMesas);

                    var lista = servicio.obtenerMesas();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            mesaDto = new Mesas();
                            mesaDto.TN_IdMesa = item.TN_IdMesa;
                            mesaDto.TC_DscMesa = item.TC_DscMesa;
                            listaMesas.Add(mesaDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesas", listaMesas);
        }

        public ActionResult borrarMesa(Mesas mesa)
        {
            List<Mesas> listaMesas = new List<Mesas>();
            Mesas mesaDto;
            try
            {
                using (srvMesas.IsrvMesasClient servicio = new srvMesas.IsrvMesasClient())
                {
                    srvMesas.TREST_MESAS servicioMesas = new srvMesas.TREST_MESAS();
                    servicioMesas.TC_DscMesa = mesa.TC_DscMesa;
                    servicioMesas.TN_IdMesa = mesa.TN_IdMesa;
                    servicio.eliminarMesa(servicioMesas);

                    var lista = servicio.obtenerMesas();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            mesaDto = new Mesas();
                            mesaDto.TN_IdMesa = item.TN_IdMesa;
                            mesaDto.TC_DscMesa = item.TC_DscMesa;
                            listaMesas.Add(mesaDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesas", listaMesas);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, Mesas mesa)
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Insertar":
                        return insertarMesa(mesa);
                    case "Actualizar":
                        return actualizarMesa(mesa);
                    case "Borrar":
                        return borrarMesa(mesa);
                    default:
                        return RedirectToAction("obtenerMesas");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}