using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface ILogicaNegocioMenu
    {
        List<TREST_MENU> obtenerMenu();
        TREST_MENU obtenerItemMenu(int itemID);
        bool agregarItemMenu(TREST_MENU item);
        bool modificarItemMenu(TREST_MENU item);
        bool elimiarItemMenu(TREST_MENU item);
    }
}
