﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace KillerClient.KillerService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IKillerService", Namespace="http://tempuri.org/")]
    public partial class KillerService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetProcessusOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProcessusByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback StopProcessusByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback StopProcessusByIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public KillerService() {
            this.Url = "http://localhost:8733/ProcessusKillerService/";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetProcessusCompletedEventHandler GetProcessusCompleted;
        
        /// <remarks/>
        public event GetProcessusByNameCompletedEventHandler GetProcessusByNameCompleted;
        
        /// <remarks/>
        public event StopProcessusByNameCompletedEventHandler StopProcessusByNameCompleted;
        
        /// <remarks/>
        public event StopProcessusByIdCompletedEventHandler StopProcessusByIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IKillerService/GetProcessus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/ProcessusKillerService")]
        public ProcessusModel[] GetProcessus() {
            object[] results = this.Invoke("GetProcessus", new object[0]);
            return ((ProcessusModel[])(results[0]));
        }
        
        /// <remarks/>
        public void GetProcessusAsync() {
            this.GetProcessusAsync(null);
        }
        
        /// <remarks/>
        public void GetProcessusAsync(object userState) {
            if ((this.GetProcessusOperationCompleted == null)) {
                this.GetProcessusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProcessusOperationCompleted);
            }
            this.InvokeAsync("GetProcessus", new object[0], this.GetProcessusOperationCompleted, userState);
        }
        
        private void OnGetProcessusOperationCompleted(object arg) {
            if ((this.GetProcessusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProcessusCompleted(this, new GetProcessusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IKillerService/GetProcessusByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/ProcessusKillerService")]
        public ProcessusModel[] GetProcessusByName([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name) {
            object[] results = this.Invoke("GetProcessusByName", new object[] {
                        name});
            return ((ProcessusModel[])(results[0]));
        }
        
        /// <remarks/>
        public void GetProcessusByNameAsync(string name) {
            this.GetProcessusByNameAsync(name, null);
        }
        
        /// <remarks/>
        public void GetProcessusByNameAsync(string name, object userState) {
            if ((this.GetProcessusByNameOperationCompleted == null)) {
                this.GetProcessusByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProcessusByNameOperationCompleted);
            }
            this.InvokeAsync("GetProcessusByName", new object[] {
                        name}, this.GetProcessusByNameOperationCompleted, userState);
        }
        
        private void OnGetProcessusByNameOperationCompleted(object arg) {
            if ((this.GetProcessusByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProcessusByNameCompleted(this, new GetProcessusByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IKillerService/StopProcessusByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopProcessusByName([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, out bool StopProcessusByNameResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool StopProcessusByNameResultSpecified) {
            object[] results = this.Invoke("StopProcessusByName", new object[] {
                        name});
            StopProcessusByNameResult = ((bool)(results[0]));
            StopProcessusByNameResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void StopProcessusByNameAsync(string name) {
            this.StopProcessusByNameAsync(name, null);
        }
        
        /// <remarks/>
        public void StopProcessusByNameAsync(string name, object userState) {
            if ((this.StopProcessusByNameOperationCompleted == null)) {
                this.StopProcessusByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStopProcessusByNameOperationCompleted);
            }
            this.InvokeAsync("StopProcessusByName", new object[] {
                        name}, this.StopProcessusByNameOperationCompleted, userState);
        }
        
        private void OnStopProcessusByNameOperationCompleted(object arg) {
            if ((this.StopProcessusByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StopProcessusByNameCompleted(this, new StopProcessusByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IKillerService/StopProcessusById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopProcessusById(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, out bool StopProcessusByIdResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool StopProcessusByIdResultSpecified) {
            object[] results = this.Invoke("StopProcessusById", new object[] {
                        id,
                        idSpecified});
            StopProcessusByIdResult = ((bool)(results[0]));
            StopProcessusByIdResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void StopProcessusByIdAsync(int id, bool idSpecified) {
            this.StopProcessusByIdAsync(id, idSpecified, null);
        }
        
        /// <remarks/>
        public void StopProcessusByIdAsync(int id, bool idSpecified, object userState) {
            if ((this.StopProcessusByIdOperationCompleted == null)) {
                this.StopProcessusByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStopProcessusByIdOperationCompleted);
            }
            this.InvokeAsync("StopProcessusById", new object[] {
                        id,
                        idSpecified}, this.StopProcessusByIdOperationCompleted, userState);
        }
        
        private void OnStopProcessusByIdOperationCompleted(object arg) {
            if ((this.StopProcessusByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StopProcessusByIdCompleted(this, new StopProcessusByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/ProcessusKillerService")]
    public partial class ProcessusModel {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string nameField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProcessusCompletedEventHandler(object sender, GetProcessusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProcessusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProcessusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProcessusModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProcessusModel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProcessusByNameCompletedEventHandler(object sender, GetProcessusByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProcessusByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProcessusByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProcessusModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProcessusModel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void StopProcessusByNameCompletedEventHandler(object sender, StopProcessusByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StopProcessusByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StopProcessusByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool StopProcessusByNameResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool StopProcessusByNameResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void StopProcessusByIdCompletedEventHandler(object sender, StopProcessusByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StopProcessusByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StopProcessusByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool StopProcessusByIdResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool StopProcessusByIdResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591