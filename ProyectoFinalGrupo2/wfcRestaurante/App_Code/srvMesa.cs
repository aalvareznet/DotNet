using Entidades;
using LogicaNegocio.Implementaciones;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMesa" en el código, en svc y en el archivo de configuración a la vez.
public class srvMesa : IsrvMesa
{
    private readonly IMesaLN _gMesaLN = new MesaLN();

    public List<TREST_MESAS> obtenerMesas_Rest()
    {
        List<TREST_MESAS> lRespuesta = new List<TREST_MESAS>();
        try
        {
            lRespuesta = _gMesaLN.obtenerMesas_Rest();
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public TREST_MESAS obtenerMesa_RestID(int pIdMesa)
    {
        TREST_MESAS lRespuesta = new TREST_MESAS();
        try
        {

            lRespuesta = _gMesaLN.obtenerMesa_RestID(pIdMesa);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool agregarMesa_Rest(TREST_MESAS pMesa)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMesaLN.agregarMesa_Rest(pMesa);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }
    public bool modificarMesa_Rest(TREST_MESAS pMesa)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMesaLN.modificarMesa_Rest(pMesa);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }
    public bool eliminarMesa_Rest(TREST_MESAS pMesa)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMesaLN.eliminarMesa_Rest(pMesa);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }
}
