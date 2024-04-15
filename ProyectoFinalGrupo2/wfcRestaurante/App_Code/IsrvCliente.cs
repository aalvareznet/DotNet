using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvCliente" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvCliente
{
    [OperationContract]
    List<TREST_CLIENTES> obtenerClientes_Rest();
    [OperationContract]
    TREST_CLIENTES obtenerCliente_RestID(int pIdCliente);
    [OperationContract]
    bool agregarCliente_Rest(TREST_CLIENTES pCliente);
    [OperationContract]
    bool modificarCliente_Rest(TREST_CLIENTES pCliente);
    [OperationContract]
    bool eliminarCliente_Rest(TREST_CLIENTES pCliente);
}
