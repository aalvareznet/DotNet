using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IAccesoDatosMesas
    {
        List<TREST_MESAS> obtenerMesas();
        TREST_MESAS obtenerMesaID(int mesaID);
        bool agregarMesa(TREST_MESAS mesa);
        bool modificarMesa(TREST_MESAS mesa);
        bool eliminarMesa(TREST_MESAS mesa);
    }
}
