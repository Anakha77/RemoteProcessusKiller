﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceClientTest.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProcessusModel", Namespace="http://schemas.datacontract.org/2004/07/ProcessusKillerService")]
    [System.SerializableAttribute()]
    public partial class ProcessusModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IKillerService")]
    public interface IKillerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/GetProcessus", ReplyAction="http://tempuri.org/IKillerService/GetProcessusResponse")]
        ServiceClientTest.ServiceReference1.ProcessusModel[] GetProcessus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/GetProcessus", ReplyAction="http://tempuri.org/IKillerService/GetProcessusResponse")]
        System.Threading.Tasks.Task<ServiceClientTest.ServiceReference1.ProcessusModel[]> GetProcessusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/GetProcessusByName", ReplyAction="http://tempuri.org/IKillerService/GetProcessusByNameResponse")]
        ServiceClientTest.ServiceReference1.ProcessusModel[] GetProcessusByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/GetProcessusByName", ReplyAction="http://tempuri.org/IKillerService/GetProcessusByNameResponse")]
        System.Threading.Tasks.Task<ServiceClientTest.ServiceReference1.ProcessusModel[]> GetProcessusByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/StopProcessus", ReplyAction="http://tempuri.org/IKillerService/StopProcessusResponse")]
        bool StopProcessus(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKillerService/StopProcessus", ReplyAction="http://tempuri.org/IKillerService/StopProcessusResponse")]
        System.Threading.Tasks.Task<bool> StopProcessusAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKillerServiceChannel : ServiceClientTest.ServiceReference1.IKillerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KillerServiceClient : System.ServiceModel.ClientBase<ServiceClientTest.ServiceReference1.IKillerService>, ServiceClientTest.ServiceReference1.IKillerService {
        
        public KillerServiceClient() {
        }
        
        public KillerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KillerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KillerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KillerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceClientTest.ServiceReference1.ProcessusModel[] GetProcessus() {
            return base.Channel.GetProcessus();
        }
        
        public System.Threading.Tasks.Task<ServiceClientTest.ServiceReference1.ProcessusModel[]> GetProcessusAsync() {
            return base.Channel.GetProcessusAsync();
        }
        
        public ServiceClientTest.ServiceReference1.ProcessusModel[] GetProcessusByName(string name) {
            return base.Channel.GetProcessusByName(name);
        }
        
        public System.Threading.Tasks.Task<ServiceClientTest.ServiceReference1.ProcessusModel[]> GetProcessusByNameAsync(string name) {
            return base.Channel.GetProcessusByNameAsync(name);
        }
        
        public bool StopProcessus(string name) {
            return base.Channel.StopProcessus(name);
        }
        
        public System.Threading.Tasks.Task<bool> StopProcessusAsync(string name) {
            return base.Channel.StopProcessusAsync(name);
        }
    }
}
