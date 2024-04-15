using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMesa" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMesa
{
    [OperationContract]
    List<TREST_MESAS> obtenerMesas_Rest();
    [OperationContract]
    TREST_MESAS obtenerMesa_RestID(int pIdMesa);
    [OperationContract]
    bool agregarMesa_Rest(TREST_MESAS pMesa);
    [OperationContract]
    bool modificarMesa_Rest(TREST_MESAS pMesa);
    [OperationContract]
    bool eliminarMesa_Rest(TREST_MESAS pMesa);
}
