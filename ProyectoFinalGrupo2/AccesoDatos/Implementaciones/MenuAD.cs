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
    public class MenuAD:IMenuAD
    {
        private RestEntidad _gConeccionRest;
        public MenuAD(RestEntidad lConeccionRest)
        {
            _gConeccionRest = lConeccionRest;
        }
        public List<TREST_MENU> obtenerMenu_Rest() 
        {
            List<TREST_MENU> lRespuesta = new List<TREST_MENU>();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_MENU.ToList();
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
        public TREST_MENU obtenerMenu_RestID(int pIdMenu)
        {
            TREST_MENU lRespuesta = new TREST_MENU();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_MENU.ToList().Find(x => x.TN_IdMenu == pIdMenu);
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
        public bool agregarMenu_Rest(TREST_MENU pMenu)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MENU.Find(pMenu.TN_IdMenu);
                if (lRegistroEncontrado == null)
                {
                    _gConeccionRest.TREST_MENU.Add(pMenu);
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
        public bool modificarMenu_Rest(TREST_MENU pMenu)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MENU.Find(pMenu.TN_IdMenu);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pMenu);
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
        public bool eliminarMenu_Rest(TREST_MENU pMenu) 
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MENU.Find(pMenu.TN_IdMenu);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pMenu);
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
