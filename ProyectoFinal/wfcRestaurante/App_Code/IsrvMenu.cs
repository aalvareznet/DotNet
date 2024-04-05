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
    List<TREST_MENU> obtenerMenu();
    [OperationContract]
    TREST_MENU obtenerItemMenu(int itemID);
    [OperationContract]
    bool agregarItemMenu(TREST_MENU item);
    [OperationContract]
    bool modificarItemMenu(TREST_MENU item);
    [OperationContract]
    bool elimiarItemMenu(TREST_MENU item);
    

}
