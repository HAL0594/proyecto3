﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.WSLoad {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSLoad.DBSoap")]
    public interface DBSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        System.Data.DataTable LoadData(string query, string[] parameter, object[] values, string table);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ADDAfiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void ADDAfiliado(string DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DELAfiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void DELAfiliado(string DPI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualiza_Afiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void Actualiza_Afiliado(string DPI, string NombreCom, string FechaNac, int Telefono, string InicioCob, string FinCobertura, float MontoCob, string TipoPoliza);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddProveedor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void AddProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelProveddor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void DelProveddor(string NIT);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModProveedor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void ModProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DBSoapChannel : Prueba.WSLoad.DBSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBSoapClient : System.ServiceModel.ClientBase<Prueba.WSLoad.DBSoap>, Prueba.WSLoad.DBSoap {
        
        public DBSoapClient() {
        }
        
        public DBSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Data.DataTable LoadData(string query, string[] parameter, object[] values, string table) {
            return base.Channel.LoadData(query, parameter, values, table);
        }
        
        public void ADDAfiliado(string DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza) {
            base.Channel.ADDAfiliado(DPI, NombreCom, FechaNac, Telefono, MontoCob, TipoPoliza);
        }
        
        public void DELAfiliado(string DPI) {
            base.Channel.DELAfiliado(DPI);
        }
        
        public void Actualiza_Afiliado(string DPI, string NombreCom, string FechaNac, int Telefono, string InicioCob, string FinCobertura, float MontoCob, string TipoPoliza) {
            base.Channel.Actualiza_Afiliado(DPI, NombreCom, FechaNac, Telefono, InicioCob, FinCobertura, MontoCob, TipoPoliza);
        }
        
        public void AddProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado) {
            base.Channel.AddProveedor(NIT, Nombre, Dirreccion, Telefono, Pais, Ciudad, Correo, Encargado, Estado);
        }
        
        public void DelProveddor(string NIT) {
            base.Channel.DelProveddor(NIT);
        }
        
        public void ModProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado) {
            base.Channel.ModProveedor(NIT, Nombre, Dirreccion, Telefono, Pais, Ciudad, Correo, Encargado, Estado);
        }
    }
}
