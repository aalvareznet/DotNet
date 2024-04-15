using InterfazUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfazUsuario.Controllers
{
    public class feClienteController : Controller
    {
        //Funciones para las vistas

        public ActionResult obtenerCliente() 
        {
            List<ModeloCliente> lRespuesta = new List<ModeloCliente>();
            ModeloCliente lCliente = new ModeloCliente();

            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient()) 
                {
                    var listaCliete = lServicio.obtenerClientes_Rest();
                    if (listaCliete != null)
                    {
                        foreach (var item in listaCliete)
                        {
                            lCliente = new ModeloCliente();
                            lCliente.TN_IdCliente = item.TN_IdCliente;
                            lCliente.TC_Nombre = item.TC_Nombre;
                            lCliente.TC_Ap1 = item.TC_Ap1;
                            lCliente.TC_Ap2 = item.TC_Ap2;
                            lCliente.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            lCliente.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            lRespuesta.Add(lCliente);
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
        public ActionResult agregarCliente() 
        {
            ModeloCliente lCliente = new ModeloCliente();
            return View(lCliente);
        }
        public ActionResult modificarCliente(int pId) 
        {
            ModeloCliente lRespuesta = new ModeloCliente();
            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient()) 
                {
                    var lCliente = lServicio.obtenerCliente_RestID(pId);
                    lRespuesta.TN_IdCliente = lCliente.TN_IdCliente;
                    lRespuesta.TC_Nombre = lCliente.TC_Nombre;
                    lRespuesta.TC_Ap1 = lCliente.TC_Ap1;
                    lRespuesta.TC_Ap2 = lCliente.TC_Ap2;
                    lRespuesta.TC_CorreoElectronico = lCliente.TC_CorreoElectronico;
                    lRespuesta.Tc_NumTelefonico = lCliente.Tc_NumTelefonico;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult eliminarCliente(int pId)
        {
            ModeloCliente lRespuesta = new ModeloCliente();
            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient())
                {
                    var lCliente = lServicio.obtenerCliente_RestID(pId);
                    lRespuesta.TN_IdCliente = lCliente.TN_IdCliente;
                    lRespuesta.TC_Nombre = lCliente.TC_Nombre;
                    lRespuesta.TC_Ap1 = lCliente.TC_Ap1;
                    lRespuesta.TC_Ap2 = lCliente.TC_Ap2;
                    lRespuesta.TC_CorreoElectronico = lCliente.TC_CorreoElectronico;
                    lRespuesta.Tc_NumTelefonico = lCliente.Tc_NumTelefonico;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        public ActionResult detalleCliente(int pId)
        {
            ModeloCliente lRespuesta = new ModeloCliente();
            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient())
                {
                    var lCliente = lServicio.obtenerCliente_RestID(pId);
                    lRespuesta.TN_IdCliente = lCliente.TN_IdCliente;
                    lRespuesta.TC_Nombre = lCliente.TC_Nombre;
                    lRespuesta.TC_Ap1 = lCliente.TC_Ap1;
                    lRespuesta.TC_Ap2 = lCliente.TC_Ap2;
                    lRespuesta.TC_CorreoElectronico = lCliente.TC_CorreoElectronico;
                    lRespuesta.Tc_NumTelefonico = lCliente.Tc_NumTelefonico;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(lRespuesta);
        }
        //CRUD
        public ActionResult insertarCliente(ModeloCliente pCliente) 
        {
            List<ModeloCliente> lRespuesta = new List<ModeloCliente>();
            ModeloCliente lCliente;

            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient()) 
                {
                    ReferenciaSrvCliente.TREST_CLIENTES lObjetoCliente = new ReferenciaSrvCliente.TREST_CLIENTES();
                    lObjetoCliente.TC_Nombre = pCliente.TC_Nombre;
                    lObjetoCliente.TC_Ap1 = pCliente.TC_Ap1;
                    lObjetoCliente.TC_Ap2 = pCliente.TC_Ap2;
                    lObjetoCliente.TC_CorreoElectronico = pCliente.TC_CorreoElectronico;
                    lObjetoCliente.Tc_NumTelefonico = pCliente.Tc_NumTelefonico;
                    lServicio.agregarCliente_Rest(lObjetoCliente);

                    var listaCliente = lServicio.obtenerClientes_Rest();
                    if (listaCliente != null)
                    {
                        foreach (var item in listaCliente)
                        {
                            lCliente = new ModeloCliente();
                            lCliente.TN_IdCliente = item.TN_IdCliente;
                            lCliente.TC_Nombre = item.TC_Nombre;
                            lCliente.TC_Ap1 = item.TC_Ap1;
                            lCliente.TC_Ap2 = item.TC_Ap2;
                            lCliente.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            lCliente.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            lRespuesta.Add(lCliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerCliente", lRespuesta);
        }
        public ActionResult actualizarCliente(ModeloCliente pCliente)
        {
            List<ModeloCliente> lRespuesta = new List<ModeloCliente>();
            ModeloCliente lCliente;

            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient())
                {
                    ReferenciaSrvCliente.TREST_CLIENTES lObjetoCliente = new ReferenciaSrvCliente.TREST_CLIENTES();
                    lObjetoCliente.TN_IdCliente = pCliente.TN_IdCliente;
                    lObjetoCliente.TC_Nombre = pCliente.TC_Nombre;
                    lObjetoCliente.TC_Ap1 = pCliente.TC_Ap1;
                    lObjetoCliente.TC_Ap2 = pCliente.TC_Ap2;
                    lObjetoCliente.TC_CorreoElectronico = pCliente.TC_CorreoElectronico;
                    lObjetoCliente.Tc_NumTelefonico = pCliente.Tc_NumTelefonico;
                    lServicio.modificarCliente_Rest(lObjetoCliente);

                    var listaCliente = lServicio.obtenerClientes_Rest();
                    if (listaCliente != null)
                    {
                        foreach (var item in listaCliente)
                        {
                            lCliente = new ModeloCliente();
                            lCliente.TN_IdCliente = item.TN_IdCliente;
                            lCliente.TC_Nombre = item.TC_Nombre;
                            lCliente.TC_Ap1 = item.TC_Ap1;
                            lCliente.TC_Ap2 = item.TC_Ap2;
                            lCliente.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            lCliente.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            lRespuesta.Add(lCliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerCliente", lRespuesta);
        }
        public ActionResult borrarCliente(ModeloCliente pCliente)
        {
            List<ModeloCliente> lRespuesta = new List<ModeloCliente>();
            ModeloCliente lCliente;

            try
            {
                using (ReferenciaSrvCliente.IsrvClienteClient lServicio = new ReferenciaSrvCliente.IsrvClienteClient())
                {
                    ReferenciaSrvCliente.TREST_CLIENTES lObjetoCliente = new ReferenciaSrvCliente.TREST_CLIENTES();
                    lObjetoCliente.TN_IdCliente = pCliente.TN_IdCliente;
                    lObjetoCliente.TC_Nombre = pCliente.TC_Nombre;
                    lObjetoCliente.TC_Ap1 = pCliente.TC_Ap1;
                    lObjetoCliente.TC_Ap2 = pCliente.TC_Ap2;
                    lObjetoCliente.TC_CorreoElectronico = pCliente.TC_CorreoElectronico;
                    lObjetoCliente.Tc_NumTelefonico = pCliente.Tc_NumTelefonico;
                    lServicio.eliminarCliente_Rest(lObjetoCliente);

                    var listaCliente = lServicio.obtenerClientes_Rest();
                    if (listaCliente != null)
                    {
                        foreach (var item in listaCliente)
                        {
                            lCliente = new ModeloCliente();
                            lCliente.TN_IdCliente = item.TN_IdCliente;
                            lCliente.TC_Nombre = item.TC_Nombre;
                            lCliente.TC_Ap1 = item.TC_Ap1;
                            lCliente.TC_Ap2 = item.TC_Ap2;
                            lCliente.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            lCliente.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            lRespuesta.Add(lCliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("obtenerCliente", lRespuesta);
        }
        public ActionResult accionesEjecucion(string accionEjecutar, ModeloCliente pCliente) 
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Agregar":
                        return insertarCliente(pCliente);
                    case "Modificar":
                        return actualizarCliente(pCliente);
                    case "Borrar":
                        return borrarCliente(pCliente);
                    default:
                        return RedirectToAction("obtenerCliente");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}