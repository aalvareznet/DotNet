﻿using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementaciones
{
    public class ClienteAD:IClienteAD
    {
        private RestEntidad _gConeccionRest;

        public ClienteAD(RestEntidad lConeccionRest)
        {
            _gConeccionRest = lConeccionRest;
        }

        public List<TREST_CLIENTES> obtenerClientes_Rest() 
        {
            List<TREST_CLIENTES> lRespuesta = new List<TREST_CLIENTES>();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_CLIENTES.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = true;
            }
            return lRespuesta;
        }
        public TREST_CLIENTES obtenerCliente_RestID(int pIdCliente) 
        {
            TREST_CLIENTES lRespuesta = new TREST_CLIENTES();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_CLIENTES.ToList().Find(x => x.TN_IdCliente == pIdCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = true;
            }
            return lRespuesta;
        }
        public bool agregarCliente_Rest(TREST_CLIENTES pCliente) 
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_CLIENTES.Find(pCliente.TN_IdCliente);
                if (lRegistroEncontrado == null)
                {
                    _gConeccionRest.TREST_CLIENTES.Add(pCliente);
                    _gConeccionRest.SaveChanges();
                    lRespuesta = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = true;
            }
            return lRespuesta;
        }
        public bool modificarCliente_Rest(TREST_CLIENTES pCliente) 
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_CLIENTES.Find(pCliente.TN_IdCliente);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pCliente);
                    _gConeccionRest.Entry(lRegistroEncontrado).State = EntityState.Modified;
                    _gConeccionRest.SaveChanges();
                    lRespuesta = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = true;
            }
            return lRespuesta;
        }

        public bool eliminarCliente_Rest(TREST_CLIENTES pCliente)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_CLIENTES.Find(pCliente.TN_IdCliente);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pCliente);
                    _gConeccionRest.Entry(lRegistroEncontrado).State = EntityState.Deleted;
                    _gConeccionRest.SaveChanges();
                    lRespuesta = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = true;
            }
            return lRespuesta;
        }
    }
}
