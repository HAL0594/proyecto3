using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Catalogo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSConsulta.DBSoapClient WSconsulta = new WSConsulta.DBSoapClient();
            DataSet ds = WSconsulta.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}