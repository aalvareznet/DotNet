using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IClienteLN
    {
        List<TREST_CLIENTES> obtenerClientes_Rest();
        TREST_CLIENTES obtenerCliente_RestID(int pIdCliente);
        bool agregarCliente_Rest(TREST_CLIENTES pCliente);
        bool modificarCliente_Rest(TREST_CLIENTES pCliente);
        bool eliminarCliente_Rest(TREST_CLIENTES pCliente);
    }
}
