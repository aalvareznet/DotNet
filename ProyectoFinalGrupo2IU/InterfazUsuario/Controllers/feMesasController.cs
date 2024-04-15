using InterfazUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfazUsuario.Controllers
{
    public class feMesasController : Controller
    {
        public ActionResult obtenerMesa() 
        {
            List<ModeloMesas> lRespuesta = new List<ModeloMesas>();
            ModeloMesas lMesa;
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient()) 
                {
                    var listaMesas = lServicio.obtenerMesas_Rest();
                    if (listaMesas != null)
                    {
                        foreach (var item in listaMesas)
                        {
                            lMesa = new ModeloMesas();
                            lMesa.TN_IdMesa = item.TN_IdMesa;
                            lMesa.TC_DscMesa = item.TC_DscMesa;
                            lRespuesta.Add(lMesa);
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
        public ActionResult agregarMesa() 
        {
            ModeloMesas lMesa = new ModeloMesas();
            return View(lMesa);
        }
        public ActionResult modificarMesa(int pId) 
        {
            ModeloMesas lRespuesta = new ModeloMesas();
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient()) 
                {
                    var lMesa = lServicio.obtenerMesa_RestID(pId);
                    lRespuesta.TN_IdMesa = lMesa.TN_IdMesa;
                    lRespuesta.TC_DscMesa = lMesa.TC_DscMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult eliminarMesa(int pId)
        {
            ModeloMesas lRespuesta = new ModeloMesas();
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient())
                {
                    var lMesa = lServicio.obtenerMesa_RestID(pId);
                    lRespuesta.TN_IdMesa = lMesa.TN_IdMesa;
                    lRespuesta.TC_DscMesa = lMesa.TC_DscMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult detallesMesa(int pId)
        {
            ModeloMesas lRespuesta = new ModeloMesas();
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient())
                {
                    var lMesa = lServicio.obtenerMesa_RestID(pId);
                    lRespuesta.TN_IdMesa = lMesa.TN_IdMesa;
                    lRespuesta.TC_DscMesa = lMesa.TC_DscMesa;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }

        //CRUD

        public ActionResult insertarMesa(ModeloMesas pMesas) 
        {
            List<ModeloMesas> lRespuesta = new List<ModeloMesas>();
            ModeloMesas lMesa;
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient()) 
                {
                    ReferenciaSrvMesa.TREST_MESAS lObjetoMesas = new ReferenciaSrvMesa.TREST_MESAS();
                    lObjetoMesas.TN_IdMesa = pMesas.TN_IdMesa;
                    lObjetoMesas.TC_DscMesa = pMesas.TC_DscMesa;
                    lServicio.agregarMesa_Rest(lObjetoMesas);

                    var listMesas = lServicio.obtenerMesas_Rest();
                    if (listMesas != null)
                    {
                        foreach (var item in listMesas)
                        {
                            lMesa = new ModeloMesas();
                            lMesa.TN_IdMesa = item.TN_IdMesa;
                            lMesa.TC_DscMesa = item.TC_DscMesa;
                            lRespuesta.Add(lMesa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesa", lRespuesta);
        }
        public ActionResult actualizarMesa(ModeloMesas pMesas)
        {
            List<ModeloMesas> lRespuesta = new List<ModeloMesas>();
            ModeloMesas lMesa;
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient())
                {
                    ReferenciaSrvMesa.TREST_MESAS lObjetoMesas = new ReferenciaSrvMesa.TREST_MESAS();
                    lObjetoMesas.TN_IdMesa = pMesas.TN_IdMesa;
                    lObjetoMesas.TC_DscMesa = pMesas.TC_DscMesa;
                    lServicio.modificarMesa_Rest(lObjetoMesas);

                    var listMesas = lServicio.obtenerMesas_Rest();
                    if (listMesas != null)
                    {
                        foreach (var item in listMesas)
                        {
                            lMesa = new ModeloMesas();
                            lMesa.TN_IdMesa = item.TN_IdMesa;
                            lMesa.TC_DscMesa = item.TC_DscMesa;
                            lRespuesta.Add(lMesa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesa", lRespuesta);
        }
        public ActionResult borrarMesa(ModeloMesas pMesas)
        {
            List<ModeloMesas> lRespuesta = new List<ModeloMesas>();
            ModeloMesas lMesa;
            try
            {
                using (ReferenciaSrvMesa.IsrvMesaClient lServicio = new ReferenciaSrvMesa.IsrvMesaClient())
                {
                    ReferenciaSrvMesa.TREST_MESAS lObjetoMesas = new ReferenciaSrvMesa.TREST_MESAS();
                    lObjetoMesas.TN_IdMesa = pMesas.TN_IdMesa;
                    lObjetoMesas.TC_DscMesa = pMesas.TC_DscMesa;
                    lServicio.eliminarMesa_Rest(lObjetoMesas);

                    var listMesas = lServicio.obtenerMesas_Rest();
                    if (listMesas != null)
                    {
                        foreach (var item in listMesas)
                        {
                            lMesa = new ModeloMesas();
                            lMesa.TN_IdMesa = item.TN_IdMesa;
                            lMesa.TC_DscMesa = item.TC_DscMesa;
                            lRespuesta.Add(lMesa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerMesa", lRespuesta);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, ModeloMesas pMesa) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Agregar":
                        return insertarMesa(pMesa);
                    case "Modificar":
                        return actualizarMesa(pMesa);
                    case "Borrar":
                        return borrarMesa(pMesa);
                    default:
                        return RedirectToAction("obtenerMesa");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}