using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementaciones
{
    public class ReservacionAD:IReservacionAD
    {
        private RestEntidad _gConeccionRest;
        public ReservacionAD(RestEntidad lConeccionRest)
        {
            _gConeccionRest = lConeccionRest; 
        }

        public List<TREST_RESERVACION> obtenerReservaciones_Rest()
        {
            List<TREST_RESERVACION> lRespuesta = new List<TREST_RESERVACION>();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_RESERVACION.ToList();
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
        public TREST_RESERVACION obtenerReservacion_RestID(int pIdReservacion)
        {
            TREST_RESERVACION lRespuesta = new TREST_RESERVACION();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_RESERVACION.ToList().Find(x => x.TN_NumReservacion == pIdReservacion);
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
        public bool agregarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.TREST_RESERVACION.Add(pReservacion);
                var lRegistroEncontrado = _gConeccionRest.TREST_RESERVACION.Find(pReservacion.TN_NumReservacion);
                if (lRegistroEncontrado == null) 
                {
                    _gConeccionRest.TREST_RESERVACION.Add(pReservacion);
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
        public bool modificarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_RESERVACION.Find(pReservacion.TN_NumReservacion);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pReservacion);
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
        public bool eliminarReservacion_Rest(TREST_RESERVACION pReservacion)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_RESERVACION.Find(pReservacion.TN_NumReservacion);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pReservacion);
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
