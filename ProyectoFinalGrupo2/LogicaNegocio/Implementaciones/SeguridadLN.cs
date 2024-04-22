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
    public class SeguridadLN : ISeguridadLN
    {
        private static SeguridadEntities lObjCnn = new SeguridadEntities();
        private ISeguridadAD gObjCnnAD = new SeguridadAD(lObjCnn);
        public TUSR_USUARIOS recUsuario(string pLogin)
        {
            TUSR_USUARIOS lObjRespuesta = new TUSR_USUARIOS();
            try
            {
                lObjRespuesta = gObjCnnAD.recUsuario(pLogin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lObjRespuesta;
        }
        public List<PA_recPerfilesXUsuario_Result> recPerfilesPorUsuario(string pLogin)
        {
            List<PA_recPerfilesXUsuario_Result> lObjRespuesta = new List<PA_recPerfilesXUsuario_Result>();
            try
            {
                lObjRespuesta = gObjCnnAD.recPerfilesPorUsuario(pLogin);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lObjRespuesta;
        }
    }
}
