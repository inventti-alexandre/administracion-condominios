﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServiceTest.SRResidente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DResidente", Namespace="http://schemas.datacontract.org/2004/07/SOAPService.Dominio")]
    [System.SerializableAttribute()]
    public partial class DResidente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
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
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Clave {
            get {
                return this.ClaveField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaveField, value) != true)) {
                    this.ClaveField = value;
                    this.RaisePropertyChanged("Clave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRResidente.IResidentes")]
    public interface IResidentes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidentes/CrearResidente", ReplyAction="http://tempuri.org/IResidentes/CrearResidenteResponse")]
        SOAPServiceTest.SRResidente.DResidente CrearResidente(SOAPServiceTest.SRResidente.DResidente dresidente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidentes/ObtenerResidente", ReplyAction="http://tempuri.org/IResidentes/ObtenerResidenteResponse")]
        SOAPServiceTest.SRResidente.DResidente ObtenerResidente(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidentes/ModificarResidente", ReplyAction="http://tempuri.org/IResidentes/ModificarResidenteResponse")]
        SOAPServiceTest.SRResidente.DResidente ModificarResidente(SOAPServiceTest.SRResidente.DResidente dresidente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidentes/EliminarResidente", ReplyAction="http://tempuri.org/IResidentes/EliminarResidenteResponse")]
        SOAPServiceTest.SRResidente.DResidente EliminarResidente(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResidentes/ListarTodosLosResidentes", ReplyAction="http://tempuri.org/IResidentes/ListarTodosLosResidentesResponse")]
        SOAPServiceTest.SRResidente.DResidente[] ListarTodosLosResidentes();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResidentesChannel : SOAPServiceTest.SRResidente.IResidentes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResidentesClient : System.ServiceModel.ClientBase<SOAPServiceTest.SRResidente.IResidentes>, SOAPServiceTest.SRResidente.IResidentes {
        
        public ResidentesClient() {
        }
        
        public ResidentesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResidentesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResidentesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResidentesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServiceTest.SRResidente.DResidente CrearResidente(SOAPServiceTest.SRResidente.DResidente dresidente) {
            return base.Channel.CrearResidente(dresidente);
        }
        
        public SOAPServiceTest.SRResidente.DResidente ObtenerResidente(string codigo) {
            return base.Channel.ObtenerResidente(codigo);
        }
        
        public SOAPServiceTest.SRResidente.DResidente ModificarResidente(SOAPServiceTest.SRResidente.DResidente dresidente) {
            return base.Channel.ModificarResidente(dresidente);
        }
        
        public SOAPServiceTest.SRResidente.DResidente EliminarResidente(string codigo) {
            return base.Channel.EliminarResidente(codigo);
        }
        
        public SOAPServiceTest.SRResidente.DResidente[] ListarTodosLosResidentes() {
            return base.Channel.ListarTodosLosResidentes();
        }
    }
}
