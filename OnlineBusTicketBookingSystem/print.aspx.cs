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
    public partial class print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                TextBox2.Text = Session["a"].ToString();
                TextBox3.Text = Session["b"].ToString();
                TextBox4.Text = Session["c"].ToString();
                TextBox5.Text = Session["d"].ToString();
                TextBox6.Text = Session["e"].ToString();
                TextBox7.Text = Session["f"].ToString();
                TextBox8.Text = Session["g"].ToString();
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select sl from ticket where bus_license_no='" + TextBox5.Text + "' and Sit_no='" + TextBox2.Text + "' and travel_date='" + TextBox3.Text + "' and stop_time='" + TextBox4.Text + "' and start_location='" + TextBox6.Text + "' and end_location='" + TextBox7.Text + "' and taka='" + TextBox8.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                this.GridView1.SelectedIndex = 0;

                TextBox1.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                HttpContext.Current.Response.Write("<script>window.print();</script>");

            }
            catch { }
           
          
             if (Session["ID"] != null)
             {

                 Class1 ssjk = new Class1();
                 ssjk.login_id = Session["ID"].ToString();
                 if (ssjk.QueryInlogin13()) { Session["f"] = ssjk.log_type; }
                 if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                 SqlConnection conjk = new SqlConnection(Properties.Settings.Default._ConnectionString);
                 SqlDataAdapter sdajk = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", conjk);
                 DataTable dtjk = new DataTable();
                 sdajk.Fill(dtjk);
             }
         
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

       

      
    }
}