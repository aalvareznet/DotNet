using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IMesaAD
    {
        List<TREST_MESAS> obtenerMesas_Rest();
        TREST_MESAS obtenerMesa_RestID(int pIdMesa);
        bool agregarMesa_Rest(TREST_MESAS pMesa);
        bool modificarMesa_Rest(TREST_MESAS pMesa);
        bool eliminarMesa_Rest(TREST_MESAS pMesa);
    }
}
