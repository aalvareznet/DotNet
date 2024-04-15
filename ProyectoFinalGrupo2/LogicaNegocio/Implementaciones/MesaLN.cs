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
    public class MesaLN:IMesaLN
    {
        public static RestEntidad lConeccionRest = new RestEntidad();
        private readonly IMesaAD _gMesaAD = new MesaAD(lConeccionRest);

        public List<TREST_MESAS> obtenerMesas_Rest()
        {
            List<TREST_MESAS> lRespuesta = new List<TREST_MESAS>();
            try
            {
                lRespuesta = _gMesaAD.obtenerMesas_Rest();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public TREST_MESAS obtenerMesa_RestID(int pIdMesa)
        {
            TREST_MESAS lRespuesta = new TREST_MESAS();
            try
            {

                lRespuesta = _gMesaAD.obtenerMesa_RestID(pIdMesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool agregarMesa_Rest(TREST_MESAS pMesa)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMesaAD.agregarMesa_Rest(pMesa);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }
        public bool modificarMesa_Rest(TREST_MESAS pMesa)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMesaAD.modificarMesa_Rest(pMesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool eliminarMesa_Rest(TREST_MESAS pMesa)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMesaAD.eliminarMesa_Rest(pMesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
    }
}
