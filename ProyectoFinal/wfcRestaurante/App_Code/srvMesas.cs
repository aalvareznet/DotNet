using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMesas" en el código, en svc y en el archivo de configuración a la vez.
public class srvMesas : IsrvMesas
{
    private readonly ILogicaNegocioMesas _mesas = new LogicaNegocioMesas();

    public bool agregarMesa(TREST_MESAS mesa)
    {
        bool resultado = false;
        try
        {
            resultado = _mesas.agregarMesa(mesa);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public bool eliminarMesa(TREST_MESAS mesa)
    {
        bool respuesta = false;
        try
        {
            respuesta = _mesas.eliminarMesa(mesa);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return respuesta;
    }

    public bool modificarMesa(TREST_MESAS mesa)
    {
        bool resultado = false;
        try
        {
            resultado = _mesas.modificarMesa(mesa);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public TREST_MESAS obtenerMesaID(int mesaID)
    {
        TREST_MESAS mesa = new TREST_MESAS();
        try
        {
            mesa = _mesas.obtenerMesaID(mesaID);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return mesa;
    }

    public List<TREST_MESAS> obtenerMesas()
    {
        List<TREST_MESAS> listaMesas = new List<TREST_MESAS>();

        try
        {
            listaMesas = _mesas.obtenerMesas();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return listaMesas;
    }
}
