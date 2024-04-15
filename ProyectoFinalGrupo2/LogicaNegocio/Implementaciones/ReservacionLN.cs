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
    public class ReservacionLN:IReservacionLN
    {
        public static RestEntidad lConeccionRest = new RestEntidad();
        private readonly IReservacionAD _gReservacionAD = new ReservacionAD(lConeccionRest);

        public List<TREST_RESERVACION> obtenerReservaciones_Rest()
        {
            List<TREST_RESERVACION> lRespuesta = new List<TREST_RESERVACION>();
            try
            {
                lRespuesta = _gReservacionAD.obtenerReservaciones_Rest();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public TREST_RESERVACION obtenerReservacion_RestID(int pIdReservacion)
        {
            TREST_RESERVACION lRespuesta = new TREST_RESERVACION();
            try
            {

                lRespuesta = _gReservacionAD.obtenerReservacion_RestID(pIdReservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool agregarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gReservacionAD.agregarReservacion_Rest(pReservacion);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }
        public bool modificarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gReservacionAD.modificarReservacion_Rest(pReservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool eliminarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gReservacionAD.eliminarReservacion_Rest(pReservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }   
    }
}
