﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfazUsuario.ReferenciaSrvMesa {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TREST_MESAS", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class TREST_MESAS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_DscMesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdMesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACIONField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_DscMesa {
            get {
                return this.TC_DscMesaField;
            }
            set {
                if ((object.ReferenceEquals(this.TC_DscMesaField, value) != true)) {
                    this.TC_DscMesaField = value;
                    this.RaisePropertyChanged("TC_DscMesa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdMesa {
            get {
                return this.TN_IdMesaField;
            }
            set {
                if ((this.TN_IdMesaField.Equals(value) != true)) {
                    this.TN_IdMesaField = value;
                    this.RaisePropertyChanged("TN_IdMesa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACION {
            get {
                return this.TREST_RESERVACIONField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_RESERVACIONField, value) != true)) {
                    this.TREST_RESERVACIONField = value;
                    this.RaisePropertyChanged("TREST_RESERVACION");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TREST_RESERVACION", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class TREST_RESERVACION : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TF_FecReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdMesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_NumReservacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_CLIENTES TREST_CLIENTESField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_MENU TREST_MENUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS TREST_MESASField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TF_FecReserva {
            get {
                return this.TF_FecReservaField;
            }
            set {
                if ((this.TF_FecReservaField.Equals(value) != true)) {
                    this.TF_FecReservaField = value;
                    this.RaisePropertyChanged("TF_FecReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_Cantidad {
            get {
                return this.TN_CantidadField;
            }
            set {
                if ((this.TN_CantidadField.Equals(value) != true)) {
                    this.TN_CantidadField = value;
                    this.RaisePropertyChanged("TN_Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdCliente {
            get {
                return this.TN_IdClienteField;
            }
            set {
                if ((this.TN_IdClienteField.Equals(value) != true)) {
                    this.TN_IdClienteField = value;
                    this.RaisePropertyChanged("TN_IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdMenu {
            get {
                return this.TN_IdMenuField;
            }
            set {
                if ((this.TN_IdMenuField.Equals(value) != true)) {
                    this.TN_IdMenuField = value;
                    this.RaisePropertyChanged("TN_IdMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdMesa {
            get {
                return this.TN_IdMesaField;
            }
            set {
                if ((this.TN_IdMesaField.Equals(value) != true)) {
                    this.TN_IdMesaField = value;
                    this.RaisePropertyChanged("TN_IdMesa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_NumReservacion {
            get {
                return this.TN_NumReservacionField;
            }
            set {
                if ((this.TN_NumReservacionField.Equals(value) != true)) {
                    this.TN_NumReservacionField = value;
                    this.RaisePropertyChanged("TN_NumReservacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_CLIENTES TREST_CLIENTES {
            get {
                return this.TREST_CLIENTESField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_CLIENTESField, value) != true)) {
                    this.TREST_CLIENTESField = value;
                    this.RaisePropertyChanged("TREST_CLIENTES");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_MENU TREST_MENU {
            get {
                return this.TREST_MENUField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_MENUField, value) != true)) {
                    this.TREST_MENUField = value;
                    this.RaisePropertyChanged("TREST_MENU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS TREST_MESAS {
            get {
                return this.TREST_MESASField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_MESASField, value) != true)) {
                    this.TREST_MESASField = value;
                    this.RaisePropertyChanged("TREST_MESAS");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TREST_CLIENTES", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class TREST_CLIENTES : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_Ap1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_Ap2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_CorreoElectronicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tc_NumTelefonicoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_Ap1 {
            get {
                return this.TC_Ap1Field;
            }
            set {
                if ((object.ReferenceEquals(this.TC_Ap1Field, value) != true)) {
                    this.TC_Ap1Field = value;
                    this.RaisePropertyChanged("TC_Ap1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_Ap2 {
            get {
                return this.TC_Ap2Field;
            }
            set {
                if ((object.ReferenceEquals(this.TC_Ap2Field, value) != true)) {
                    this.TC_Ap2Field = value;
                    this.RaisePropertyChanged("TC_Ap2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_CorreoElectronico {
            get {
                return this.TC_CorreoElectronicoField;
            }
            set {
                if ((object.ReferenceEquals(this.TC_CorreoElectronicoField, value) != true)) {
                    this.TC_CorreoElectronicoField = value;
                    this.RaisePropertyChanged("TC_CorreoElectronico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_Nombre {
            get {
                return this.TC_NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.TC_NombreField, value) != true)) {
                    this.TC_NombreField = value;
                    this.RaisePropertyChanged("TC_Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdCliente {
            get {
                return this.TN_IdClienteField;
            }
            set {
                if ((this.TN_IdClienteField.Equals(value) != true)) {
                    this.TN_IdClienteField = value;
                    this.RaisePropertyChanged("TN_IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACION {
            get {
                return this.TREST_RESERVACIONField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_RESERVACIONField, value) != true)) {
                    this.TREST_RESERVACIONField = value;
                    this.RaisePropertyChanged("TREST_RESERVACION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tc_NumTelefonico {
            get {
                return this.Tc_NumTelefonicoField;
            }
            set {
                if ((object.ReferenceEquals(this.Tc_NumTelefonicoField, value) != true)) {
                    this.Tc_NumTelefonicoField = value;
                    this.RaisePropertyChanged("Tc_NumTelefonico");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TREST_MENU", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class TREST_MENU : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TC_DscMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TD_PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdTipoMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_TIPOMENU TREST_TIPOMENUField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TC_DscMenu {
            get {
                return this.TC_DscMenuField;
            }
            set {
                if ((object.ReferenceEquals(this.TC_DscMenuField, value) != true)) {
                    this.TC_DscMenuField = value;
                    this.RaisePropertyChanged("TC_DscMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TD_Precio {
            get {
                return this.TD_PrecioField;
            }
            set {
                if ((this.TD_PrecioField.Equals(value) != true)) {
                    this.TD_PrecioField = value;
                    this.RaisePropertyChanged("TD_Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdMenu {
            get {
                return this.TN_IdMenuField;
            }
            set {
                if ((this.TN_IdMenuField.Equals(value) != true)) {
                    this.TN_IdMenuField = value;
                    this.RaisePropertyChanged("TN_IdMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdTipoMenu {
            get {
                return this.TN_IdTipoMenuField;
            }
            set {
                if ((this.TN_IdTipoMenuField.Equals(value) != true)) {
                    this.TN_IdTipoMenuField = value;
                    this.RaisePropertyChanged("TN_IdTipoMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_RESERVACION[] TREST_RESERVACION {
            get {
                return this.TREST_RESERVACIONField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_RESERVACIONField, value) != true)) {
                    this.TREST_RESERVACIONField = value;
                    this.RaisePropertyChanged("TREST_RESERVACION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_TIPOMENU TREST_TIPOMENU {
            get {
                return this.TREST_TIPOMENUField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_TIPOMENUField, value) != true)) {
                    this.TREST_TIPOMENUField = value;
                    this.RaisePropertyChanged("TREST_TIPOMENU");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TREST_TIPOMENU", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class TREST_TIPOMENU : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TN_IdTipoMenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private InterfazUsuario.ReferenciaSrvMesa.TREST_MENU[] TREST_MENUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tc_DscTipoMenuField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TN_IdTipoMenu {
            get {
                return this.TN_IdTipoMenuField;
            }
            set {
                if ((this.TN_IdTipoMenuField.Equals(value) != true)) {
                    this.TN_IdTipoMenuField = value;
                    this.RaisePropertyChanged("TN_IdTipoMenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public InterfazUsuario.ReferenciaSrvMesa.TREST_MENU[] TREST_MENU {
            get {
                return this.TREST_MENUField;
            }
            set {
                if ((object.ReferenceEquals(this.TREST_MENUField, value) != true)) {
                    this.TREST_MENUField = value;
                    this.RaisePropertyChanged("TREST_MENU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tc_DscTipoMenu {
            get {
                return this.Tc_DscTipoMenuField;
            }
            set {
                if ((object.ReferenceEquals(this.Tc_DscTipoMenuField, value) != true)) {
                    this.Tc_DscTipoMenuField = value;
                    this.RaisePropertyChanged("Tc_DscTipoMenu");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaSrvMesa.IsrvMesa")]
    public interface IsrvMesa {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/obtenerMesas_Rest", ReplyAction="http://tempuri.org/IsrvMesa/obtenerMesas_RestResponse")]
        InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS[] obtenerMesas_Rest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/obtenerMesas_Rest", ReplyAction="http://tempuri.org/IsrvMesa/obtenerMesas_RestResponse")]
        System.Threading.Tasks.Task<InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS[]> obtenerMesas_RestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/obtenerMesa_RestID", ReplyAction="http://tempuri.org/IsrvMesa/obtenerMesa_RestIDResponse")]
        InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS obtenerMesa_RestID(int pIdMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/obtenerMesa_RestID", ReplyAction="http://tempuri.org/IsrvMesa/obtenerMesa_RestIDResponse")]
        System.Threading.Tasks.Task<InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS> obtenerMesa_RestIDAsync(int pIdMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/agregarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/agregarMesa_RestResponse")]
        bool agregarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/agregarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/agregarMesa_RestResponse")]
        System.Threading.Tasks.Task<bool> agregarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/modificarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/modificarMesa_RestResponse")]
        bool modificarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/modificarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/modificarMesa_RestResponse")]
        System.Threading.Tasks.Task<bool> modificarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/eliminarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/eliminarMesa_RestResponse")]
        bool eliminarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvMesa/eliminarMesa_Rest", ReplyAction="http://tempuri.org/IsrvMesa/eliminarMesa_RestResponse")]
        System.Threading.Tasks.Task<bool> eliminarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsrvMesaChannel : InterfazUsuario.ReferenciaSrvMesa.IsrvMesa, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsrvMesaClient : System.ServiceModel.ClientBase<InterfazUsuario.ReferenciaSrvMesa.IsrvMesa>, InterfazUsuario.ReferenciaSrvMesa.IsrvMesa {
        
        public IsrvMesaClient() {
        }
        
        public IsrvMesaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsrvMesaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvMesaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvMesaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS[] obtenerMesas_Rest() {
            return base.Channel.obtenerMesas_Rest();
        }
        
        public System.Threading.Tasks.Task<InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS[]> obtenerMesas_RestAsync() {
            return base.Channel.obtenerMesas_RestAsync();
        }
        
        public InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS obtenerMesa_RestID(int pIdMesa) {
            return base.Channel.obtenerMesa_RestID(pIdMesa);
        }
        
        public System.Threading.Tasks.Task<InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS> obtenerMesa_RestIDAsync(int pIdMesa) {
            return base.Channel.obtenerMesa_RestIDAsync(pIdMesa);
        }
        
        public bool agregarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.agregarMesa_Rest(pMesa);
        }
        
        public System.Threading.Tasks.Task<bool> agregarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.agregarMesa_RestAsync(pMesa);
        }
        
        public bool modificarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.modificarMesa_Rest(pMesa);
        }
        
        public System.Threading.Tasks.Task<bool> modificarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.modificarMesa_RestAsync(pMesa);
        }
        
        public bool eliminarMesa_Rest(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.eliminarMesa_Rest(pMesa);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarMesa_RestAsync(InterfazUsuario.ReferenciaSrvMesa.TREST_MESAS pMesa) {
            return base.Channel.eliminarMesa_RestAsync(pMesa);
        }
    }
}