using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class AccesoDatosClientes : IAccesoDatosClientes
    {
        private EntidadesRestaurante _entidad;

        public AccesoDatosClientes(EntidadesRestaurante entidad) 
        {
            _entidad = entidad;
        }

        public bool agregarCliente(TREST_CLIENTES cliente)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var clienteEncontrado = _entidad.TREST_CLIENTES.Find(cliente.TN_IdCliente);
                if (clienteEncontrado == null) 
                {
                    _entidad.TREST_CLIENTES.Add(cliente);
                    _entidad.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return resultado;
        }

        public bool eliminarCliente(TREST_CLIENTES cliente)
        {
            bool respuesta = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var clienteEncontrado = _entidad.TREST_CLIENTES.Find(cliente.TN_IdCliente);
                if (clienteEncontrado != null) 
                {
                    _entidad.Entry(clienteEncontrado).CurrentValues.SetValues(cliente);
                    _entidad.Entry(clienteEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    _entidad.SaveChanges();
                    respuesta = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return respuesta;
        }

        public bool modificarCliente(TREST_CLIENTES cliente)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var clienteEncontrado = _entidad.TREST_CLIENTES.Find(cliente.TN_IdCliente);
                if (clienteEncontrado != null)
                {
                    _entidad.Entry(clienteEncontrado).CurrentValues.SetValues(cliente);
                    _entidad.Entry(clienteEncontrado).State = System.Data.Entity.EntityState.Modified;
                    _entidad.SaveChanges();
                    resultado = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return resultado;
        }

        public List<TREST_CLIENTES> obtenerClientes()
        {
            List<TREST_CLIENTES> listaClientes = new List<TREST_CLIENTES>();

            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                listaClientes = _entidad.TREST_CLIENTES.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                _entidad.Configuration.ProxyCreationEnabled=true;
            }
            return listaClientes;
        }

        public TREST_CLIENTES obtenerClientesID(int Id)
        {
            TREST_CLIENTES cliente = new TREST_CLIENTES();
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                cliente = _entidad.TREST_CLIENTES.ToList().Find(x => x.TN_IdCliente == Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return cliente;
        }
    }
}
