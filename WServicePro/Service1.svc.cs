using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Web;
using System.Data.SqlClient;

namespace WServicePro
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        SqlConnection conn = new SqlConnection("Data Source=LOCALHOST; Initial Catalog=TEST; Integrated Security=True;");
        public void Actualiza_Afiliado(string DPI, string NombreCom, string FechaNac, int Telefono, string InicioCob, string FinCobertura, float MontoCob, string TipoPoliza)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[TBL_AFILIADOS] SET [DPI] = '" + DPI + "' ,[NombreCom] = '" + NombreCom + "',[FechaNac] ='" + FechaNac + "' ,[Telefono] = " + Telefono + ",[InicioCob] = '" + InicioCob + "',[FinCobertura] ='" + FinCobertura + "',[MontoCob] = " + MontoCob + ",[TipoPoliza] = '" + TipoPoliza + "' WHERE [DPI] = " + DPI + "");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ADDAfiliado(string DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_AFILIADOS]([DPI],[NombreCom],[FechaNac],[Telefono],[MontoCob],[TipoPoliza]) VALUES('" + DPI + "','" + NombreCom + "','" + FechaNac + "', " + Telefono + "," + MontoCob + ",'" + TipoPoliza + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_PROVEEDORES] ([NIT],[Nombre],[Dirreccion],[Telefono],[Pais],[Ciudad],[Correo],[Encargado],[Estado]) VALUES('" + NIT + "','" + Nombre + "','" + Dirreccion + "'," + Telefono + ",'" + Pais + "','" + Ciudad + "','" + Correo + "','" + Encargado + "'," + Estado + ")");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DELAfiliado(string DPI)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + DPI + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DelProveddor(string NIT)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[TBL_PROVEEDORES] WHERE NIT = '" + NIT + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable LoadData(string query, string[] parameter, object[] values, string table)
        {
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            if (parameter != null)
                for (var i = 0; i < parameter.Length; i++)
                    cmd.Parameters.AddWithValue(parameter[i], values[i]);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable(table);
            dt.Load(dr);
            dr.Dispose();
            conn.Close();
            return dt;
        }

        public void ModProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[TBL_PROVEEDORES] SET [NIT] = '" + NIT + "',[Nombre] = '" + Nombre + "',[Dirreccion] = '" + Dirreccion + "',[Telefono] = " + Telefono + ",[Pais] = '" + Pais + "',[Ciudad] = '" + Ciudad + "',[Correo] = '" + Correo + "',[Encargado] = '" + Encargado + "',[Estado] = " + Estado + " WHERE NIT = '" + NIT + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
