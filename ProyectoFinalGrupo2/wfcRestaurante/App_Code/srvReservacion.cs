using Entidades;
using LogicaNegocio.Implementaciones;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvReservacion" en el código, en svc y en el archivo de configuración a la vez.
public class srvReservacion : IsrvReservacion
{
    private readonly IReservacionLN _gReservacionLN = new ReservacionLN();

    public List<TREST_RESERVACION> obtenerReservaciones_Rest()
    {
        List<TREST_RESERVACION> lRespuesta = new List<TREST_RESERVACION>();
        try
        {
            lRespuesta = _gReservacionLN.obtenerReservaciones_Rest();
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public TREST_RESERVACION obtenerReservacion_RestID(int pIdReservacion)
    {
        TREST_RESERVACION lRespuesta = new TREST_RESERVACION();
        try
        {

            lRespuesta = _gReservacionLN.obtenerReservacion_RestID(pIdReservacion);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool agregarReservacion_Rest(TREST_RESERVACION pReservacion)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gReservacionLN.agregarReservacion_Rest(pReservacion);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }
    public bool modificarReservacion_Rest(TREST_RESERVACION pReservacion)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gReservacionLN.modificarReservacion_Rest(pReservacion);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }

    public bool eliminarReservacion_Rest(TREST_RESERVACION pReservacion)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gReservacionLN.eliminarReservacion_Rest(pReservacion);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
}
