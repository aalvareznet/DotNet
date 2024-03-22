using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class AccesoDatosMesas : IAccesoDatosMesas
    {
        private EntidadesRestaurante _entidad;
        public AccesoDatosMesas(EntidadesRestaurante entidad) 
        {
            _entidad = entidad;
        }
        public bool agregarMesa(TREST_MESAS mesa)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var mesaEncontrada = _entidad.TREST_MESAS.Find(mesa.TN_IdMesa);
                if (mesaEncontrada == null)
                {
                    _entidad.TREST_MESAS.Add(mesa);
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

        public bool eliminarMesa(TREST_MESAS mesa)
        {
            bool respuesta = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var mesaEncontrada = _entidad.TREST_MESAS.Find(mesa.TN_IdMesa);
                if (mesaEncontrada != null)
                {
                    _entidad.Entry(mesaEncontrada).CurrentValues.SetValues(mesa);
                    _entidad.Entry(mesaEncontrada).State = System.Data.Entity.EntityState.Deleted;
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

        public bool modificarMesa(TREST_MESAS mesa)
        {
            bool resultado = false;
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                var mesaEncontrada = _entidad.TREST_CLIENTES.Find(mesa.TN_IdMesa);
                if (mesaEncontrada != null)
                {
                    _entidad.Entry(mesaEncontrada).CurrentValues.SetValues(mesa);
                    _entidad.Entry(mesaEncontrada).State = System.Data.Entity.EntityState.Modified;
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

        public TREST_MESAS obtenerMesaID(int mesaID)
        {
            TREST_MESAS mesa = new TREST_MESAS();
            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                mesa = _entidad.TREST_MESAS.ToList().Find(x => x.TN_IdMesa == mesaID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return mesa;
        }

        public List<TREST_MESAS> obtenerMesas()
        {
            List<TREST_MESAS> listaMesas = new List<TREST_MESAS>();

            try
            {
                _entidad.Configuration.ProxyCreationEnabled = false;
                listaMesas = _entidad.TREST_MESAS.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _entidad.Configuration.ProxyCreationEnabled = true;
            }
            return listaMesas;
        }
    }
}
