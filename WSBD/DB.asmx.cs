using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WSBD
{
    /// <summary>
    /// Descripción breve de DB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DB : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        SqlConnection conn = new SqlConnection("Data Source=LOCALHOST; Initial Catalog=TEST; Integrated Security=True;");
        

        [WebMethod]
        public DataSet GetData() {
     
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_USERS",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataTable LoadData(string query, string[] parameter, object[] values, string table) {
            conn.Open();
            var cmd = new SqlCommand(query,conn);
            if (parameter != null) 
                for (var i=0; i < parameter.Length; i++)
                    cmd.Parameters.AddWithValue(parameter[i], values[i]);
                    var dr = cmd.ExecuteReader();
                    var dt = new DataTable(table);
                    dt.Load(dr);
                    dr.Dispose();
                    conn.Close();
            return dt;
        }

        [WebMethod]
        public void ADDAfiliado(int DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob,  string TipoPoliza)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_AFILIADOS]([DPI],[NombreCom],[FechaNac],[Telefono],[MontoCob],[TipoPoliza])VALUES("+DPI+",'"+NombreCom+"','"+FechaNac+"', "+Telefono+","+MontoCob+",'"+TipoPoliza+"')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void DELAfiliado(int DPI)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[TBL_AFILIADOS] WHERE DPI = "+DPI+"");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void Actualiza_Afiliado(int DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob, string TipoPoliza)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[TBL_AFILIADOS] SET [DPI] = ,[NombreCom] = ,[FechaNac] = ,[Telefono] = ,[InicioCob] = ,[FinCobertura] =,[MontoCob] = ,[EstadoPoliza] = ,[TipoPoliza] =  WHERE [DPI] =");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
