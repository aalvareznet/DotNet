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
    public class LogicaNegocioMenu : ILogicaNegocioMenu
    {
        public static EntidadesRestaurante entidad;
        private readonly IAccesoDatosMenu _entidad = new AccesoDatosMenu(entidad);

        public bool agregarItemMenu(TREST_MENU item)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.agregarItemMenu(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public bool elimiarItemMenu(TREST_MENU item)
        {
            bool respuesta = false;
            try
            {
                respuesta = _entidad.elimiarItemMenu(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return respuesta;
        }

        public bool modificarItemMenu(TREST_MENU item)
        {
            bool resultado = false;
            try
            {
                resultado = _entidad.modificarItemMenu(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

        public TREST_MENU obtenerItemMenu(int itemID)
        {
            TREST_MENU item = new TREST_MENU();
            try
            {
                item = _entidad.obtenerItemMenu(itemID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return item;
        }

        public List<TREST_MENU> obtenerMenu()
        {
            List<TREST_MENU> listaMenu = new List<TREST_MENU>();

            try
            {
                listaMenu = _entidad.obtenerMenu();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaMenu;
        }
    }
}
