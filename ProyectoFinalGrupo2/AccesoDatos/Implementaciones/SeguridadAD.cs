using AccesoDatos.Interfaces;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementaciones
{
    public class SeguridadAD : ISeguridadAD
    {
        private SeguridadEntities gObjCnnSeg;

        public SeguridadAD(SeguridadEntities lObjCnnSeg)
        {
            gObjCnnSeg = lObjCnnSeg;
        }
        public TUSR_USUARIOS recUsuario(string pLogin)
        {
            TUSR_USUARIOS lObjRespuesta = new TUSR_USUARIOS();
            try
            {
                gObjCnnSeg.Configuration.ProxyCreationEnabled = false;
                lObjRespuesta = gObjCnnSeg.TUSR_USUARIOS.ToList().Find(
                    us => us.TC_Usuario == pLogin
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                gObjCnnSeg.Configuration.ProxyCreationEnabled = true;
            }
            return lObjRespuesta;
        }

        public List<PA_recPerfilesXUsuario_Result> recPerfilesPorUsuario(string pLogin)
        {
            List<PA_recPerfilesXUsuario_Result> lObjRespuesta = new List<PA_recPerfilesXUsuario_Result>();
            try
            {
                lObjRespuesta = gObjCnnSeg.PA_recPerfilesXUsuario(pLogin).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lObjRespuesta;
        }
    }
}
