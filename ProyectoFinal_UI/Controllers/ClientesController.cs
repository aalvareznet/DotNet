using ProyectoFinal_UI.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProyectoFinal_UI.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult obtenerClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            Clientes cliente;

            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    var lista = servicio.obtenerClientes();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            cliente = new Clientes();
                            cliente.TN_IdCliente = item.TN_IdCliente;
                            cliente.TC_Nombre = item.TC_Nombre;
                            cliente.TC_Ap1 = item.TC_Ap1;
                            cliente.TC_Ap2 = item.TC_Ap2;
                            cliente.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            cliente.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            listaClientes.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View(listaClientes);
        }

        public ActionResult agregarCliente()
        {
            Clientes cliente = new Clientes();
            return View(cliente);
        }

        public ActionResult modificarCliente(int idCliente)
        {
            Clientes cliente = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    var clienteDTO = servicio.obtenerClientesID(idCliente);
                    cliente.TN_IdCliente = clienteDTO.TN_IdCliente;
                    cliente.TC_Nombre = clienteDTO.TC_Nombre;
                    cliente.TC_Ap1 = clienteDTO.TC_Ap1;
                    cliente.TC_Ap2 = clienteDTO.TC_Ap2;
                    cliente.Tc_NumTelefonico = clienteDTO.Tc_NumTelefonico;
                    cliente.TC_CorreoElectronico = clienteDTO.TC_CorreoElectronico;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(cliente);
        }

        public ActionResult eliminarCliente(int idCliente)
        {
            Clientes cliente = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    var clienteDTO = servicio.obtenerClientesID(idCliente);
                    cliente.TN_IdCliente = clienteDTO.TN_IdCliente;
                    cliente.TC_Nombre = clienteDTO.TC_Nombre;
                    cliente.TC_Ap1 = clienteDTO.TC_Ap1;
                    cliente.TC_Ap2 = clienteDTO.TC_Ap2;
                    cliente.Tc_NumTelefonico = clienteDTO.Tc_NumTelefonico;
                    cliente.TC_CorreoElectronico = clienteDTO.TC_CorreoElectronico;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(cliente);
        }

        public ActionResult detalleCliente(int id)
        {
            Clientes cliente = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    var clienteDTO = servicio.obtenerClientesID(id);
                    cliente.TN_IdCliente = clienteDTO.TN_IdCliente;
                    cliente.TC_Nombre = clienteDTO.TC_Nombre;
                    cliente.TC_Ap1 = clienteDTO.TC_Ap1;
                    cliente.TC_Ap2 = clienteDTO.TC_Ap2;
                    cliente.Tc_NumTelefonico = clienteDTO.Tc_NumTelefonico;
                    cliente.TC_CorreoElectronico = clienteDTO.TC_CorreoElectronico;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(cliente);
        }

        public ActionResult insertarCliente(Clientes cliente)
        {
            List<Clientes> listaClientes = new List<Clientes>();
            Clientes clienteDto;
            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    srvClientes.TREST_CLIENTES servicioCliente = new srvClientes.TREST_CLIENTES();
                    servicioCliente.TN_IdCliente = cliente.TN_IdCliente;
                    servicioCliente.TC_Nombre = cliente.TC_Nombre;
                    servicioCliente.TC_Ap1 = cliente.TC_Ap1;
                    servicioCliente.TC_Ap2 = cliente.TC_Ap2;
                    servicioCliente.Tc_NumTelefonico = cliente.Tc_NumTelefonico;
                    servicioCliente.TC_CorreoElectronico = cliente.TC_CorreoElectronico;
                    servicio.agregarCliente(servicioCliente);

                    var lista = servicio.obtenerClientes();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            clienteDto = new Clientes();
                            clienteDto.TN_IdCliente = item.TN_IdCliente;
                            clienteDto.TC_Nombre = item.TC_Nombre;
                            clienteDto.TC_Ap1 = item.TC_Ap1;
                            clienteDto.TC_Ap2 = item.TC_Ap2;
                            clienteDto.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            clienteDto.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            listaClientes.Add(clienteDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("obtenerClientes", listaClientes);
        }

        public ActionResult actualizarCliente(Clientes cliente)
        {
            List<Clientes> listaClientes = new List<Clientes>();
            Clientes clienteDto;

            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    srvClientes.TREST_CLIENTES servicioCliente = new srvClientes.TREST_CLIENTES();
                    servicioCliente.TN_IdCliente = cliente.TN_IdCliente;
                    servicioCliente.TC_Nombre = cliente.TC_Nombre;
                    servicioCliente.TC_Ap1 = cliente.TC_Ap1;
                    servicioCliente.TC_Ap2 = cliente.TC_Ap2;
                    servicioCliente.Tc_NumTelefonico = cliente.Tc_NumTelefonico;
                    servicioCliente.TC_CorreoElectronico = cliente.TC_CorreoElectronico;
                    servicio.modificarCliente(servicioCliente);

                    var lista = servicio.obtenerClientes();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            clienteDto = new Clientes();
                            clienteDto.TN_IdCliente = item.TN_IdCliente;
                            clienteDto.TC_Nombre = item.TC_Nombre;
                            clienteDto.TC_Ap1 = item.TC_Ap1;
                            clienteDto.TC_Ap2 = item.TC_Ap2;
                            clienteDto.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            clienteDto.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            listaClientes.Add(clienteDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("obtenerClientes", listaClientes);
        }

        public ActionResult borrarCliente(Clientes cliente)
        {
            List<Clientes> listaClientes = new List<Clientes>();
            Clientes clienteDto;
            try
            {
                using (srvClientes.IsrvClientesClient servicio = new srvClientes.IsrvClientesClient())
                {
                    srvClientes.TREST_CLIENTES servicioCliente = new srvClientes.TREST_CLIENTES();
                    servicioCliente.TN_IdCliente = cliente.TN_IdCliente;
                    servicioCliente.TC_Nombre = cliente.TC_Nombre;
                    servicioCliente.TC_Ap1 = cliente.TC_Ap1;
                    servicioCliente.TC_Ap2 = cliente.TC_Ap2;
                    servicioCliente.Tc_NumTelefonico = cliente.Tc_NumTelefonico;
                    servicioCliente.TC_CorreoElectronico = cliente.TC_CorreoElectronico;
                    servicio.eliminarCliente(servicioCliente);

                    var lista = servicio.obtenerClientes();
                    if (lista != null)
                    {
                        foreach (var item in lista)
                        {
                            clienteDto = new Clientes();
                            clienteDto.TN_IdCliente = item.TN_IdCliente;
                            clienteDto.TC_Nombre = item.TC_Nombre;
                            clienteDto.TC_Ap1 = item.TC_Ap1;
                            clienteDto.TC_Ap2 = item.TC_Ap2;
                            clienteDto.Tc_NumTelefonico = item.Tc_NumTelefonico;
                            clienteDto.TC_CorreoElectronico = item.TC_CorreoElectronico;
                            listaClientes.Add(clienteDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("obtenerClientes", listaClientes);
        }

        public ActionResult accionesEjecicion(string accionEjecutar, Clientes clientes)
        {
            try
            {
                switch (accionEjecutar)
                {
                    case "Agregar":
                        return insertarCliente(clientes);

                    case "Modificar":
                        return actualizarCliente(clientes);

                    case "Borrar":
                        return borrarCliente(clientes);

                    default:
                        return RedirectToAction("obtenerClientes");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}