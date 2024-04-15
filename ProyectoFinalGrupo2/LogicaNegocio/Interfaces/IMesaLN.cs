using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IMesaLN
    {
        List<TREST_MESAS> obtenerMesas_Rest();
        TREST_MESAS obtenerMesa_RestID(int pIdMesa);
        bool agregarMesa_Rest(TREST_MESAS pMesa);
        bool modificarMesa_Rest(TREST_MESAS pMesa);
        bool eliminarMesa_Rest(TREST_MESAS pMesa);
    }
}
