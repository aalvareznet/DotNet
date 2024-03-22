using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class AccesoDatosTipoMenu : IAccesoDatosTipoMenu
    {
        private EntidadesRestaurante _entidad;
        public AccesoDatosTipoMenu(EntidadesRestaurante entidad) 
        {
            _entidad = entidad;
        }
        public bool agregarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var tipoMenuEncontrado = _entidad.TREST_TIPOMENU.Find(tipo.TN_IdTipoMenu);
                if (tipoMenuEncontrado == null)
                {
                    _entidad.TREST_TIPOMENU.Add(tipo);
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

        public bool eliminarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool respuesta = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var tipoMenuEncontrado = _entidad.TREST_TIPOMENU.Find(tipo.TN_IdTipoMenu);
                if (tipoMenuEncontrado != null)
                {
                    _entidad.Entry(tipoMenuEncontrado).CurrentValues.SetValues(tipo);
                    _entidad.Entry(tipoMenuEncontrado).State = System.Data.Entity.EntityState.Deleted;
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

        public bool modificarTipoMenu(TREST_TIPOMENU tipo)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var tipoMenuEncontrado = _entidad.TREST_TIPOMENU.Find(tipo.TN_IdTipoMenu);
                if (tipoMenuEncontrado != null)
                {
                    _entidad.Entry(tipoMenuEncontrado).CurrentValues.SetValues(tipo);
                    _entidad.Entry(tipoMenuEncontrado).State = System.Data.Entity.EntityState.Modified;
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

        public TREST_TIPOMENU obtenerTipoMenuID(int id)
        {
            TREST_TIPOMENU tipo = new TREST_TIPOMENU();
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                tipo = _entidad.TREST_TIPOMENU.ToList().Find(x => x.TN_IdTipoMenu == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return tipo;
        }
    }
}
