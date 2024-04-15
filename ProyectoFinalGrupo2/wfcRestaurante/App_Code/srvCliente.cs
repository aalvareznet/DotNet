using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using LogicaNegocio.Implementaciones;
using LogicaNegocio.Interfaces;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvCliente" en el código, en svc y en el archivo de configuración a la vez.
public class srvCliente : IsrvCliente
{
    private readonly IClienteLN _gClienteLN = new ClienteLN();

    public List<TREST_CLIENTES> obtenerClientes_Rest()
    {
        List<TREST_CLIENTES> lRespuesta = new List<TREST_CLIENTES>();
        try
        {
            lRespuesta = _gClienteLN.obtenerClientes_Rest();
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public TREST_CLIENTES obtenerCliente_RestID(int pIdCliente)
    {
        TREST_CLIENTES lRespuesta = new TREST_CLIENTES();
        try
        {

            lRespuesta = _gClienteLN.obtenerCliente_RestID(pIdCliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
    public bool agregarCliente_Rest(TREST_CLIENTES pCliente)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gClienteLN.agregarCliente_Rest(pCliente);

        }
        catch (Exception ex)
        {

            throw ex;
        }
        return lRespuesta;
    }
    public bool modificarCliente_Rest(TREST_CLIENTES pCliente)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gClienteLN.modificarCliente_Rest(pCliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }

    public bool eliminarCliente_Rest(TREST_CLIENTES pCliente)
    {
        bool lRespuesta = false;
        try
        {
            lRespuesta = _gClienteLN.eliminarCliente_Rest(pCliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return lRespuesta;
    }
}
