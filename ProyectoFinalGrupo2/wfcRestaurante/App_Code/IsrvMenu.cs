using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvMenu" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvMenu
{
    [OperationContract]
    List<TREST_MENU> obtenerMenu_Rest();
    [OperationContract]
    TREST_MENU obtenerMenu_RestID(int pIdMenu);
    [OperationContract]
    bool agregarMenu_Rest(TREST_MENU pMenu);
    [OperationContract]
    bool modificarMenu_Rest(TREST_MENU pMenu);
    [OperationContract]
    bool eliminarMenu_Rest(TREST_MENU pMenu);
}
