using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class AccesoDatosReservacion : IAccesoDatosReservacion
    {
        private EntidadesRestaurante _entidad;

        public AccesoDatosReservacion(EntidadesRestaurante entidad) 
        {
            _entidad = entidad;
        }

        public bool agregarReservacion(TREST_RESERVACION reservacion)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var reservacionEncontrada = _entidad.TREST_RESERVACION.Find(reservacion.TN_NumReservacion);
                if (reservacionEncontrada == null)
                {
                    _entidad.TREST_RESERVACION.Add(reservacion);
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

        public bool eliminarReservacion(TREST_RESERVACION reservacion)
        {
            bool respuesta = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var reservacionEncontrada = _entidad.TREST_RESERVACION.Find(reservacion.TN_NumReservacion);
                if (reservacionEncontrada != null)
                {
                    _entidad.Entry(reservacionEncontrada).CurrentValues.SetValues(reservacion);
                    _entidad.Entry(reservacionEncontrada).State = System.Data.Entity.EntityState.Deleted;
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

        public bool modificarReservacion(TREST_RESERVACION reservacion)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var reservacionEncontrada = _entidad.TREST_RESERVACION.Find(reservacion.TN_NumReservacion);
                if (reservacionEncontrada != null)
                {
                    _entidad.Entry(reservacionEncontrada).CurrentValues.SetValues(reservacion);
                    _entidad.Entry(reservacionEncontrada).State = System.Data.Entity.EntityState.Modified;
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

        public List<TREST_RESERVACION> obtenerReservacion()
        {
            List<TREST_RESERVACION> listaReservaciones = new List<TREST_RESERVACION>();

            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                listaReservaciones = _entidad.TREST_RESERVACION.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return listaReservaciones;
        }

        public TREST_RESERVACION obtenerReservacionID(int id)
        {
            TREST_RESERVACION reservacion = new TREST_RESERVACION();
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                reservacion = _entidad.TREST_RESERVACION.ToList().Find(x => x.TN_NumReservacion == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return reservacion;
        }
    }
}
