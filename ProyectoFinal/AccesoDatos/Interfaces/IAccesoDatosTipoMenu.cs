using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IAccesoDatosTipoMenu
    {
        TREST_TIPOMENU obtenerTipoMenuID(int id);
        bool agregarTipoMenu(TREST_TIPOMENU tipo);
        bool modificarTipoMenu(TREST_TIPOMENU tipo);
        bool eliminarTipoMenu(TREST_TIPOMENU tipo);
    }
}
