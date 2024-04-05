using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvReservaciones" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvReservaciones
{
    [OperationContract]
    List<TREST_RESERVACION> obtenerReservacion();
    [OperationContract]
    TREST_RESERVACION obtenerReservacionID(int id);
    [OperationContract]
    bool agregarReservacion(TREST_RESERVACION reservacion);
    [OperationContract]
    bool modificarReservacion(TREST_RESERVACION reservacion);
    [OperationContract]
    bool eliminarReservacion(TREST_RESERVACION reservacion);
}
