using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using AccesoDatos;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LogicaNegocio.Implementacion
{
    public class LogicaNegocioReservacion : ILogicaNegocioReservacion
    {
        public static EntidadesRestaurante entidad = new EntidadesRestaurante();
        private readonly IAccesoDatosReservacion _entidad = new AccesoDatosReservacion(entidad);

        public bool agregarReservacion(TREST_RESERVACION reservacion)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.agregarReservacion(reservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool eliminarReservacion(TREST_RESERVACION reservacion)
        {
            bool respuesta = false;
            try
            {
                respuesta = _entidad.eliminarReservacion(reservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return respuesta;
        }

        public bool modificarReservacion(TREST_RESERVACION reservacion)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.modificarReservacion(reservacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public List<TREST_RESERVACION> obtenerReservacion()
        {
            List<TREST_RESERVACION> listaReservaciones = new List<TREST_RESERVACION>();

            try
            {
                listaReservaciones = _entidad.obtenerReservacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaReservaciones;
        }

        public TREST_RESERVACION obtenerReservacionID(int id)
        {
            TREST_RESERVACION reservacion = new TREST_RESERVACION();
            try
            {
                reservacion = _entidad.obtenerReservacionID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return reservacion;
        }
    }
}
