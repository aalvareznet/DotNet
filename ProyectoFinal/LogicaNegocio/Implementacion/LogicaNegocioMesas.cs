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
    public class LogicaNegocioMesas : ILogicaNegocioMesas
    {
        public static EntidadesRestaurante entidad;
        private readonly IAccesoDatosMesas _entidad = new AccesoDatosMesas(entidad);

        public bool agregarMesa(TREST_MESAS mesa)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.agregarMesa(mesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool eliminarMesa(TREST_MESAS mesa)
        {
            bool respuesta = false;
            try
            {
                respuesta = _entidad.eliminarMesa(mesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return respuesta;
        }

        public bool modificarMesa(TREST_MESAS mesa)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.modificarMesa(mesa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public TREST_MESAS obtenerMesaID(int mesaID)
        {
            TREST_MESAS mesa = new TREST_MESAS();
            try
            {
                mesa = _entidad.obtenerMesaID(mesaID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return mesa;
        }

        public List<TREST_MESAS> obtenerMesas()
        {
            List<TREST_MESAS> listaMesas = new List<TREST_MESAS>();

            try
            {
                listaMesas = _entidad.obtenerMesas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaMesas;
        }
    }
}
