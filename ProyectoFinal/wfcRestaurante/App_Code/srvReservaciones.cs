using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvReservaciones" en el código, en svc y en el archivo de configuración a la vez.
public class srvReservaciones : IsrvReservaciones
{
    private readonly ILogicaNegocioReservacion _reservacion = new LogicaNegocioReservacion();

    public bool agregarReservacion(TREST_RESERVACION reservacion)
    {
        bool resultado = false;
        try
        {
            resultado = _reservacion.agregarReservacion(reservacion);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public bool eliminarReservacion(TREST_RESERVACION reservacion)
    {
        bool respuesta = false;
        try
        {
            respuesta = _reservacion.eliminarReservacion(reservacion);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return respuesta;
    }

    public bool modificarReservacion(TREST_RESERVACION reservacion)
    {
        bool resultado = false;
        try
        {
            resultado = _reservacion.modificarReservacion(reservacion);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public List<TREST_RESERVACION> obtenerReservacion()
    {
        List<TREST_RESERVACION> listaReservaciones = new List<TREST_RESERVACION>();

        try
        {
            listaReservaciones = _reservacion.obtenerReservacion();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return listaReservaciones;
    }

    public TREST_RESERVACION obtenerReservacionID(int id)
    {
        TREST_RESERVACION reservacion = new TREST_RESERVACION();
        try
        {
            reservacion = _reservacion.obtenerReservacionID(id);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return reservacion;
    }
}
