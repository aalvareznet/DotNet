using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IReservacionLN
    {
        List<TREST_RESERVACION> obtenerReservaciones_Rest();
        TREST_RESERVACION obtenerReservacion_RestID(int pIdReservacion);
        bool agregarReservacion_Rest(TREST_RESERVACION pReservacion);
        bool modificarReservacion_Rest(TREST_RESERVACION pReservacion);
        bool eliminarReservacion_Rest(TREST_RESERVACION pReservacion);
    }
}
