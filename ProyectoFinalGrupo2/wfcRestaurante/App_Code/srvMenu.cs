using Entidades;
using LogicaNegocio.Implementaciones;
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
    private readonly IMenuLN _gMenuLN = new MenuLN();

    public List<TREST_MENU> obtenerMenu_Rest()
    {
        List<TREST_MENU> lRespuesta = new List<TREST_MENU>();
        try
        {
            lRespuesta = _gMenuLN.obtenerMenu_Rest();
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public TREST_MENU obtenerMenu_RestID(int pIdMenu)
    {
        TREST_MENU lRespuesta = new TREST_MENU();
        try
        {
            lRespuesta = _gMenuLN.obtenerMenu_RestID(pIdMenu);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool agregarMenu_Rest(TREST_MENU pMenu)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMenuLN.agregarMenu_Rest(pMenu);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool modificarMenu_Rest(TREST_MENU pMenu)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMenuLN.modificarMenu_Rest(pMenu);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool eliminarMenu_Rest(TREST_MENU pMenu)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gMenuLN.eliminarMenu_Rest(pMenu);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
}
