using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class LogicaNegocioClientes : ILogicaNegocioClientes
    {
        public static EntidadesRestaurante entidad;
        private readonly IAccesoDatosClientes _entidad = new AccesoDatosClientes(entidad);

        public bool agregarCliente(TREST_CLIENTES cliente)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.agregarCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool eliminarCliente(TREST_CLIENTES cliente)
        {
            bool respuesta = false;
            try
            {
                respuesta = _entidad.eliminarCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return respuesta;
        }

        public bool modificarCliente(TREST_CLIENTES cliente)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.modificarCliente(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public List<TREST_CLIENTES> obtenerClientes()
        {
            List<TREST_CLIENTES> listaClientes = new List<TREST_CLIENTES>();

            try
            {
                listaClientes = _entidad.obtenerClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaClientes;
        }

        public TREST_CLIENTES obtenerClientesID(int Id)
        {
            TREST_CLIENTES cliente = new TREST_CLIENTES();
            try
            {
                cliente = _entidad.obtenerClientesID(Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return cliente;
        }
    }
}
