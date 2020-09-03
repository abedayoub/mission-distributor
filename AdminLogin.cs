using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MissionDistributor
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABEDA\\SQLEXPRESS;Initial Catalog=MissionsDistributor;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                SqlCommand login_query = new SqlCommand("select * from AdminLogin where ID=@id and password=@pass", con);
                login_query.Parameters.AddWithValue("@id", Convert.ToInt64(textBox1.Text));
                login_query.Parameters.AddWithValue("@pass", textBox2.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter login_da = new SqlDataAdapter(login_query);
                login_da.Fill(dt);
            
                if (dt.Rows.Count > 0)
                {
                    Form1 f = new Form1(Convert.ToInt16(textBox1.Text));
                    f.changeTab(3);
                    this.Hide();
                    f.Show();
                
                
                }
                else
                {
                    label3.Visible = true;
               
                }
            }catch(Exception ess)
            {
                MessageBox.Show("Wrong Credentials");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Volunteer m = new Manage_Volunteer();
            m.Show();
            this.Hide();
        }
    }
}
