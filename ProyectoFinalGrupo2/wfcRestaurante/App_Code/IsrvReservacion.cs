using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvReservacion" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvReservacion
{
    [OperationContract]
    List<TREST_RESERVACION> obtenerReservaciones_Rest();
    [OperationContract]
    TREST_RESERVACION obtenerReservacion_RestID(int pIdReservacion);
    [OperationContract]
    bool agregarReservacion_Rest(TREST_RESERVACION pReservacion);
    [OperationContract]
    bool modificarReservacion_Rest(TREST_RESERVACION pReservacion);
    [OperationContract]
    bool eliminarReservacion_Rest(TREST_RESERVACION pReservacion);
}
