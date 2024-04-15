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
    public class MenuLN:IMenuLN
    {
        public static RestEntidad lConeccionRest = new RestEntidad();
        private readonly IMenuAD _gMenuAD = new MenuAD(lConeccionRest);
        public List<TREST_MENU> obtenerMenu_Rest()
        {
            List<TREST_MENU> lRespuesta = new List<TREST_MENU>();
            try
            {
                lRespuesta = _gMenuAD.obtenerMenu_Rest();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }
        public TREST_MENU obtenerMenu_RestID(int pIdMenu)
        {
            TREST_MENU lRespuesta = new TREST_MENU();
            try
            {
                lRespuesta = _gMenuAD.obtenerMenu_RestID(pIdMenu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool agregarMenu_Rest(TREST_MENU pMenu)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMenuAD.agregarMenu_Rest(pMenu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
        public bool modificarMenu_Rest(TREST_MENU pMenu)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMenuAD.modificarMenu_Rest(pMenu);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lRespuesta;
        }
        public bool eliminarMenu_Rest(TREST_MENU pMenu)
        {
            bool lRespuesta = false;
            try
            {
                lRespuesta = _gMenuAD.eliminarMenu_Rest(pMenu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lRespuesta;
        }
    }
}
