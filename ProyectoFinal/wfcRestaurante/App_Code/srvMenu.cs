    using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMenu" en el código, en svc y en el archivo de configuración a la vez.
public class srvMenu : IsrvMenu
{
    private readonly ILogicaNegocioMenu _menu = new LogicaNegocioMenu();

    public bool agregarItemMenu(TREST_MENU item)
    {
        bool resultado = false;
        try
        {
            resultado = _menu.agregarItemMenu(item);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public bool elimiarItemMenu(TREST_MENU item)
    {
        bool respuesta = false;
        try
        {
            respuesta = _menu.elimiarItemMenu(item);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return respuesta;
    }

    public bool modificarItemMenu(TREST_MENU item)
    {
        bool resultado = false;
        try
        {
            resultado = _menu.modificarItemMenu(item);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public TREST_MENU obtenerItemMenu(int itemID)
    {
        TREST_MENU item = new TREST_MENU();
        try
        {
            item = _menu.obtenerItemMenu(itemID);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return item;
    }

    public List<TREST_MENU> obtenerMenu()
    {
        List<TREST_MENU> listaMenu = new List<TREST_MENU>();

        try
        {
            listaMenu = _menu.obtenerMenu();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return listaMenu;
    }
}
