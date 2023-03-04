using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update login_table set e_h='0' where l='1'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            catch 
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("Connection fail");
                Application.Exit();
            }
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update login_table set l='0' where e_h='0'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
            catch
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("Connection fail");
                Application.Exit();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            } 
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                float a, b; string s;
                a = float.Parse(DateTime.Now.ToString("hh.mm"));
                b = float.Parse(DateTime.Now.ToString("hh.mm"));
                s = DateTime.Now.ToString("tt");
                if (a >= 12.05 && b <= 12.30 && s == "AM")
                {

                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass=''  delete from b_status update gps set latitude='',longitude=''   ", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                }
            }
            catch
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("Connection fail");
                Application.Exit();
            }
          
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("update L_approved set g='off'  ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
        }
    }
}
