using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface ILogicaNegocioReservacion
    {
        List<TREST_RESERVACION> obtenerReservacion();
        TREST_RESERVACION obtenerReservacionID(int id);
        bool agregarReservacion(TREST_RESERVACION reservacion);
        bool modificarReservacion(TREST_RESERVACION reservacion);
        bool eliminarReservacion(TREST_RESERVACION reservacion);
    }
}
