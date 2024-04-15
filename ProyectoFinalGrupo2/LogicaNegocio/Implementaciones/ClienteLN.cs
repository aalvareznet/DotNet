using AccesoDatos;
using AccesoDatos.Implementaciones;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementaciones
{
    public class ClienteLN : IClienteLN
    {
        public static RestEntidad lConeccionRest = new RestEntidad();
        private readonly IClienteAD _gClienteAD = new ClienteAD(lConeccionRest);

        public List<TREST_CLIENTES> obtenerClientes_Rest()
        {
            List<TREST_CLIENTES> lRespuesta = new List<TREST_CLIENTES>();
            try
            {
                lRespuesta = _gClienteAD.obtenerClientes_Rest();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public TREST_CLIENTES obtenerCliente_RestID(int pIdCliente)
        {
            TREST_CLIENTES lRespuesta = new TREST_CLIENTES();
            try
            {

                lRespuesta = _gClienteAD.obtenerCliente_RestID(pIdCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool agregarCliente_Rest(TREST_CLIENTES pCliente)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gClienteAD.agregarCliente_Rest(pCliente);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }
        public bool modificarCliente_Rest(TREST_CLIENTES pCliente)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gClienteAD.modificarCliente_Rest(pCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }

        public bool eliminarCliente_Rest(TREST_CLIENTES pCliente)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gClienteAD.eliminarCliente_Rest(pCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
    }
}
