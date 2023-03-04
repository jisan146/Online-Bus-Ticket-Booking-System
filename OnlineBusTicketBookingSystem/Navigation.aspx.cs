using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["bus"] != null)
            {

                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from gps where id='" + Session["bus"].ToString() + "' ", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                rptMarkers.DataSource = dt1;
                rptMarkers.DataBind();

            }
            else { Response.Redirect("home.aspx"); }
        }
    }
}