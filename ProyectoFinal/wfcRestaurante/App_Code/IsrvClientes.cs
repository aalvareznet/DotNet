using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvClientes" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvClientes
{
    [OperationContract]
    List<TREST_CLIENTES> obtenerClientes();

    [OperationContract]
    TREST_CLIENTES obtenerClientesID(int Id);

    [OperationContract]
    bool agregarCliente(TREST_CLIENTES cliente);

    [OperationContract]
    bool modificarCliente(TREST_CLIENTES cliente);

    [OperationContract]
    bool eliminarCliente(TREST_CLIENTES cliente);
}