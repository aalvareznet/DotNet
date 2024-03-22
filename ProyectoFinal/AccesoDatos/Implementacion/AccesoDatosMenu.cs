using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class AccesoDatosMenu : IAccesoDatosMenu
    {
        private EntidadesRestaurante _entidad;
        public AccesoDatosMenu(EntidadesRestaurante entidad) 
        {
            _entidad = entidad;
        }
        public bool agregarItemMenu(TREST_MENU item)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var itemEncontrado = _entidad.TREST_MENU.Find(item.TN_IdMenu);
                if (itemEncontrado == null)
                {
                    _entidad.TREST_MENU.Add(item);
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

        public bool elimiarItemMenu(TREST_MENU item)
        {
            bool respuesta = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var itemEncontrado = _entidad.TREST_MENU.Find(item.TN_IdMenu);
                if (itemEncontrado != null)
                {
                    _entidad.Entry(itemEncontrado).CurrentValues.SetValues(item);
                    _entidad.Entry(itemEncontrado).State = System.Data.Entity.EntityState.Deleted;
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

        public bool modificarItemMenu(TREST_MENU item)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var itemEncontrado = _entidad.TREST_CLIENTES.Find(item.TN_IdMenu);
                if (itemEncontrado != null)
                {
                    _entidad.Entry(itemEncontrado).CurrentValues.SetValues(item);
                    _entidad.Entry(itemEncontrado).State = System.Data.Entity.EntityState.Modified;
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

        public TREST_MENU obtenerItemMenu(int itemID)
        {
            TREST_MENU item = new TREST_MENU();
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                item = _entidad.TREST_MENU.ToList().Find(x => x.TN_IdMenu == itemID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return item;
        }

        public List<TREST_MENU> obtenerMenu()
        {
            List<TREST_MENU> listaMenu = new List<TREST_MENU>();

            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                listaMenu = _entidad.TREST_MENU.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return listaMenu;
        }
    }
}
