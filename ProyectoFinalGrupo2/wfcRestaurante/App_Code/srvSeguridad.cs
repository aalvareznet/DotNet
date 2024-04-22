using Entidades;
using LogicaNegocio.Implementaciones;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvSeguridad" en el código, en svc y en el archivo de configuración a la vez.
public class srvSeguridad : IsrvSeguridad
{
    private readonly ISeguridadLN gObjCnnLN = new SeguridadLN();
    public TUSR_USUARIOS recUsuario(string pLogin)
    {
        TUSR_USUARIOS lObjRespuesta = new TUSR_USUARIOS();
        try
        {
            lObjRespuesta = gObjCnnLN.recUsuario(pLogin);
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
            lObjRespuesta = gObjCnnLN.recPerfilesPorUsuario(pLogin);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lObjRespuesta;
    }
}
