using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvClientes" en el código, en svc y en el archivo de configuración a la vez.
public class srvClientes : IsrvClientes
{
    private readonly ILogicaNegocioClientes _clientes = new LogicaNegocioClientes();

    public bool agregarCliente(TREST_CLIENTES cliente)
    {
        bool resultado = false;
        try
        {
            resultado = _clientes.agregarCliente(cliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public bool eliminarCliente(TREST_CLIENTES cliente)
    {
        bool respuesta = false;
        try
        {
            respuesta = _clientes.eliminarCliente(cliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return respuesta;
    }

    public bool modificarCliente(TREST_CLIENTES cliente)
    {
        bool resultado = false;
        try
        {
            resultado = _clientes.modificarCliente(cliente);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return resultado;
    }

    public List<TREST_CLIENTES> obtenerClientes()
    {
        List<TREST_CLIENTES> listaClientes = new List<TREST_CLIENTES>();

        try
        {
            listaClientes = _clientes.obtenerClientes();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return listaClientes;
    }

    public TREST_CLIENTES obtenerClientesID(int Id)
    {
        TREST_CLIENTES cliente = new TREST_CLIENTES();
        try
        {
            cliente = _clientes.obtenerClientesID(Id);
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return cliente;
    }
}
