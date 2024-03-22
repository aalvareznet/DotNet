using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface ILogicaNegocioClientes
    {
        List<TREST_CLIENTES> obtenerClientes();
        TREST_CLIENTES obtenerClientesID(int Id);
        bool agregarCliente(TREST_CLIENTES cliente);
        bool modificarCliente(TREST_CLIENTES cliente);
        bool eliminarCliente(TREST_CLIENTES cliente);
    }
}
