﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        System.Data.DataTable LoadData(string query, string[] parameter, object[] values, string table);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ADDAfiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void ADDAfiliado(long DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DELAfiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void DELAfiliado(int DPI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualiza_Afiliado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void Actualiza_Afiliado(int DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza);
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
        
        public System.Data.DataSet GetData() {
            return base.Channel.GetData();
        }
        
        public System.Data.DataTable LoadData(string query, string[] parameter, object[] values, string table) {
            return base.Channel.LoadData(query, parameter, values, table);
        }
        
        public void ADDAfiliado(long DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza) {
            base.Channel.ADDAfiliado(DPI, NombreCom, FechaNac, Telefono, MontoCob, TipoPoliza);
        }
        
        public void DELAfiliado(int DPI) {
            base.Channel.DELAfiliado(DPI);
        }
        
        public void Actualiza_Afiliado(int DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza) {
            base.Channel.Actualiza_Afiliado(DPI, NombreCom, FechaNac, Telefono, MontoCob, TipoPoliza);
        }
    }
}
