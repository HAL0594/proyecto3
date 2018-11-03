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

        //**************************************Conexiona DB************************************************************

        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=TEST; user id=sa;password=Sa123456789;");
        
        //****************************************Carga de Datagridiews*************************************************

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


        //************************************************Afiliados******************************************************
        [WebMethod]
        public void ADDAfiliado(string DPI, string NombreCom, string FechaNac, int Telefono, float MontoCob,  string TipoPoliza)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_AFILIADOS]([DPI],[NombreCom],[FechaNac],[Telefono],[MontoCob],[TipoPoliza]) VALUES('"+DPI+"','"+NombreCom+"','"+FechaNac+"', "+Telefono+","+MontoCob+",'"+TipoPoliza+"')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void DELAfiliado(string DPI)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '"+DPI+"'");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void Actualiza_Afiliado(string DPI, string NombreCom, string FechaNac, int Telefono, string InicioCob, string FinCobertura, float MontoCob, string TipoPoliza)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[TBL_AFILIADOS] SET [DPI] = '"+DPI+"' ,[NombreCom] = '"+NombreCom+"',[FechaNac] ='"+ FechaNac + "' ,[Telefono] = "+Telefono+",[InicioCob] = '"+InicioCob+"',[FinCobertura] ='"+FinCobertura+"',[MontoCob] = "+MontoCob+",[TipoPoliza] = '"+TipoPoliza+"' WHERE [DPI] = "+DPI+"");
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //**********************************Proveedores********************************************************

        [WebMethod]
        public void AddProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_PROVEEDORES] ([NIT],[Nombre],[Dirreccion],[Telefono],[Pais],[Ciudad],[Correo],[Encargado],[Estado]) VALUES('"+NIT+"','"+Nombre+"','"+Dirreccion+"',"+Telefono+",'"+Pais+"','"+Ciudad+"','"+Correo+"','"+Encargado+"',"+Estado+")");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
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

        [WebMethod]
        public void ModProveedor(string NIT, string Nombre, string Dirreccion, int Telefono, string Pais, string Ciudad, string Correo, string Encargado, int Estado)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE [dbo].[TBL_PROVEEDORES] SET [NIT] = '"+NIT+ "',[Nombre] = '"+Nombre+ "',[Dirreccion] = '"+Dirreccion+"',[Telefono] = "+Telefono+ ",[Pais] = '"+Pais+ "',[Ciudad] = '"+Ciudad+ "',[Correo] = '"+Correo+ "',[Encargado] = '"+Encargado+"',[Estado] = "+Estado+ " WHERE NIT = '"+NIT+"'");
            cmd.ExecuteNonQuery();
            conn.Close();
         }

        
        public void AddTran(string NIT, string DPI,string respuesta, string FechCob)
        {
           
            DateTime fechaActual = DateTime.Now;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [dbo].[TBL_TRANSACCIONES]([NIT_Proveedor],[DPI_Paciente],[Fecha_Cobertura],[Respuesta],[Fecha_Consulta])VALUES('"+NIT+"','"+DPI+"','"+fechaActual+"','"+respuesta+"','"+fechaActual+"')");
            cmd.ExecuteNonQuery();
           
        }

        [WebMethod]
        public string GetAfililiado(string NIT, string DPI, string FechNac, string FechCob)
        {
            
            conn.Open();
            DataTable TablaNIT;
            SqlDataAdapter cmdNIT;
            DataSet dsNIT;
            string Permite;
            try
            {
                cmdNIT = new SqlDataAdapter("SELECT [NIT],[Estado] FROM [dbo].[TBL_PROVEEDORES] WHERE NIT = '" + NIT + "'", conn);
                dsNIT = new DataSet();
                cmdNIT.Fill(dsNIT);
                TablaNIT = dsNIT.Tables[0];
                Permite = TablaNIT.Rows[0]["Estado"].ToString();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "No Esta registrado como Proveedor o Aun no tiene Permisos";
            }

            
                if (Permite == "1")
                {
                SqlDataAdapter cmdDPI;
                DataSet dsDPI;
                DataTable Tabla;
                string stado;
                try
                {
                    cmdDPI = new SqlDataAdapter("SELECT [DPI],[EstadoPoliza] FROM [dbo].[TBL_AFILIADOS] WHERE DPI = '" + DPI + "'", conn);
                    dsDPI = new DataSet();
                    cmdDPI.Fill(dsDPI);
                    Tabla = dsDPI.Tables[0];
                    stado = Tabla.Rows[0]["EstadoPoliza"].ToString();

                }
                catch (Exception ex)
                {
                    conn.Close();
                    return "El DPI no esta registrado";
                }
               
                    string respuesta = "";
                    if (stado == "1")
                    {        
                        respuesta = "Cubierto";   
                    }
                    else
                    {
                        respuesta = "Sin Cobertura";
                    }

             //   try {
             //       AddTran(NIT, DPI, respuesta, FechCob);
             //      } catch (Exception ex)
               //    {
               //     conn.Close();
              //      return "Asegurese de llenar correctamente los campos" + ex;
               //    }
                conn.Close();
                return respuesta;
                    
                }
                else
                {
                conn.Close();
                return "Su NIT Aparece como Inactivo";
                }


             

             }

        }
    }

