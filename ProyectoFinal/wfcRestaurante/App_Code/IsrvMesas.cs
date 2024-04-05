using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMesas" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMesas
{
    [OperationContract]
    List<TREST_MESAS> obtenerMesas();
    [OperationContract]
    TREST_MESAS obtenerMesaID(int mesaID);
    [OperationContract]
    bool agregarMesa(TREST_MESAS mesa);
    [OperationContract]
    bool modificarMesa(TREST_MESAS mesa);
    [OperationContract]
    bool eliminarMesa(TREST_MESAS mesa);

}
