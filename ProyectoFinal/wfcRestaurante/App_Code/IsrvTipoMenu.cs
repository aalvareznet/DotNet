using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvTipoMenu" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvTipoMenu
{
    [OperationContract]
    TREST_TIPOMENU obtenerTipoMenuID(int id);
    [OperationContract]
    bool agregarTipoMenu(TREST_TIPOMENU tipo);
    [OperationContract]
    bool modificarTipoMenu(TREST_TIPOMENU tipo);
    [OperationContract]
    bool eliminarTipoMenu(TREST_TIPOMENU tipo);
}
