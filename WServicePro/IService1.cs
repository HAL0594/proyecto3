using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Web;
using System.Data.SqlClient;

namespace WServicePro
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataTable LoadData(string query, string[] parameter, object[] values, string table);
        [OperationContract]
        void ADDAfiliado(string DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza);
        [OperationContract]
        void DELAfiliado(string DPI);
        [OperationContract]
        void Actualiza_Afiliado(string DPI, string NombreCom, string FechaNac, int Telefono, string InicioCob, string FinCobertura, float MontoCob, string TipoPoliza);
        [OperationContract]
        void AddProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado);
        [OperationContract]
        void DelProveddor(string NIT);
        [OperationContract]
        void ModProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado);

    }

}
