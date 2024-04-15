using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IMenuAD
    {
        List<TREST_MENU> obtenerMenu_Rest();
        TREST_MENU obtenerMenu_RestID(int pIdMenu);
        bool agregarMenu_Rest(TREST_MENU pMenu);
        bool modificarMenu_Rest(TREST_MENU pMenu);
        bool eliminarMenu_Rest(TREST_MENU pMenu);
    }
}
