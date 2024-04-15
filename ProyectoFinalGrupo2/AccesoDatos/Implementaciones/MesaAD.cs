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
    public class MesaAD:IMesaAD
    {
        private RestEntidad _gConeccionRest;

        public MesaAD(RestEntidad lConeccionRest)
        {
            _gConeccionRest = lConeccionRest;
        }
        public List<TREST_MESAS> obtenerMesas_Rest() 
        {
            List<TREST_MESAS> lRespuesta = new List<TREST_MESAS>();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_MESAS.ToList();
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
        public TREST_MESAS obtenerMesa_RestID(int pIdMesa)
        {
            TREST_MESAS lRespuesta = new TREST_MESAS();
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                lRespuesta = _gConeccionRest.TREST_MESAS.ToList().Find(x => x.TN_IdMesa == pIdMesa);
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
        public bool agregarMesa_Rest(TREST_MESAS pMesa)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MESAS.Find(pMesa.TN_IdMesa);
                if (lRegistroEncontrado == null)
                {
                    _gConeccionRest.TREST_MESAS.Add(pMesa);
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
        public bool modificarMesa_Rest(TREST_MESAS pMesa) 
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MESAS.Find(pMesa.TN_IdMesa);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pMesa);
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
        public bool eliminarMesa_Rest(TREST_MESAS pMesa)
        {
            bool lRespuesta = false;
            try
            {
                _gConeccionRest.Configuration.ProxyCreationEnabled = false;
                var lRegistroEncontrado = _gConeccionRest.TREST_MESAS.Find(pMesa.TN_IdMesa);
                if (lRegistroEncontrado != null)
                {
                    _gConeccionRest.Entry(lRegistroEncontrado).CurrentValues.SetValues(pMesa);
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
