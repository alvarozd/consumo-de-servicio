//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lectorxml.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://xd1ds01:50000/XISOAPAdapter/MessageServlet?senderParty=&senderService=CEOP" +
            "ORTALWEBVTAS_Q&receiverParty=&receiverService=&interface=EstCuenta_Out&interface" +
            "Namespace=urn%3Agaseras.ceoc.com%3Asrvemp%3Acrm%3Afinanciacion")]
        public string lectorxml_WebReference_CEOPORTALWEBVTAS_Q_EstCuenta_Out {
            get {
                return ((string)(this["lectorxml_WebReference_CEOPORTALWEBVTAS_Q_EstCuenta_Out"]));
            }
        }
    }
}
