//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace lectorxml.WebReference {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EstCuenta_OutBinding", Namespace="urn:gaseras.ceoc.com:srvemp:crm:financiacion")]
    public partial class CEOPORTALWEBVTAS_Q_EstCuenta_Out : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EstCuenta_SyncOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CEOPORTALWEBVTAS_Q_EstCuenta_Out() {
            this.Url = global::lectorxml.Properties.Settings.Default.lectorxml_WebReference_CEOPORTALWEBVTAS_Q_EstCuenta_Out;
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
        public event EstCuenta_SyncCompletedEventHandler EstCuenta_SyncCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("MT_EstadoCuenta_res", Namespace="urn:gaseras.ceoc.com:srvemp:base")]
        public DT_EstadoCuenta_res EstCuenta_Sync([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:gaseras.ceoc.com:srvemp:base")] DT_EstadoCuenta_req MT_EstadoCuenta_req) {
            object[] results = this.Invoke("EstCuenta_Sync", new object[] {
                        MT_EstadoCuenta_req});
            return ((DT_EstadoCuenta_res)(results[0]));
        }
        
        /// <remarks/>
        public void EstCuenta_SyncAsync(DT_EstadoCuenta_req MT_EstadoCuenta_req) {
            this.EstCuenta_SyncAsync(MT_EstadoCuenta_req, null);
        }
        
        /// <remarks/>
        public void EstCuenta_SyncAsync(DT_EstadoCuenta_req MT_EstadoCuenta_req, object userState) {
            if ((this.EstCuenta_SyncOperationCompleted == null)) {
                this.EstCuenta_SyncOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEstCuenta_SyncOperationCompleted);
            }
            this.InvokeAsync("EstCuenta_Sync", new object[] {
                        MT_EstadoCuenta_req}, this.EstCuenta_SyncOperationCompleted, userState);
        }
        
        private void OnEstCuenta_SyncOperationCompleted(object arg) {
            if ((this.EstCuenta_SyncCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EstCuenta_SyncCompleted(this, new EstCuenta_SyncCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:gaseras.ceoc.com:srvemp:base")]
    public partial class DT_EstadoCuenta_req {
        
        private string contratoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:gaseras.ceoc.com:srvemp:base")]
    public partial class DT_EstadoCuenta_res {
        
        private string oclFactDataField;
        
        private string onuErrorcodeField;
        
        private string osbErrorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OclFactData {
            get {
                return this.oclFactDataField;
            }
            set {
                this.oclFactDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OnuErrorcode {
            get {
                return this.onuErrorcodeField;
            }
            set {
                this.onuErrorcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string osbErrorMessage {
            get {
                return this.osbErrorMessageField;
            }
            set {
                this.osbErrorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EstCuenta_SyncCompletedEventHandler(object sender, EstCuenta_SyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EstCuenta_SyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EstCuenta_SyncCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DT_EstadoCuenta_res Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DT_EstadoCuenta_res)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591