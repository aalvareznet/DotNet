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
    public class LogicaNegocioTipoMenu : ILogicaNegocioTipoMenu
    {
        public static EntidadesRestaurante entidad = new EntidadesRestaurante();
        private readonly IAccesoDatosTipoMenu _entidad = new AccesoDatosTipoMenu(entidad);

        public bool agregarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.agregarTipoMenu(tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool eliminarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool respuesta = false;
            try
            {
                respuesta = _entidad.eliminarTipoMenu(tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return respuesta;
        }

        public bool modificarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.modificarTipoMenu(tipo);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public TREST_TIPOMENU obtenerTipoMenuID(int id)
        {
            TREST_TIPOMENU tipo = new TREST_TIPOMENU();
            try
            {
                tipo = _entidad.obtenerTipoMenuID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tipo;
        }
    }
}
