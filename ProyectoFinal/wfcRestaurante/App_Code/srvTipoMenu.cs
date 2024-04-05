using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvTipoMenu" en el código, en svc y en el archivo de configuración a la vez.
public class srvTipoMenu : IsrvTipoMenu
{
    private readonly ILogicaNegocioTipoMenu _tipoMenu = new LogicaNegocioTipoMenu();

    public bool agregarTipoMenu(TREST_TIPOMENU tipo)
    {
        bool resultado = false;
        try
        {
            resultado = _tipoMenu.agregarTipoMenu(tipo);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public bool eliminarTipoMenu(TREST_TIPOMENU tipo)
    {
        bool respuesta = false;
        try
        {
            respuesta = _tipoMenu.eliminarTipoMenu(tipo);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return respuesta;
    }

    public bool modificarTipoMenu(TREST_TIPOMENU tipo)
    {
        bool resultado = false;
        try
        {
            resultado = _tipoMenu.modificarTipoMenu(tipo);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public TREST_TIPOMENU obtenerTipoMenuID(int id)
    {
        TREST_TIPOMENU tipo = new TREST_TIPOMENU();
        try
        {
            tipo = _tipoMenu.obtenerTipoMenuID(id);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return tipo;
    }
}
