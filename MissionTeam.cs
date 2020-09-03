using System;
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
    public partial class MissionTeam : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABEDA\\SQLEXPRESS;Initial Catalog=MissionsDistributor;Integrated Security=True");
        List<int> ReadyList = new List<int>();
        List<string> names = new List<string>();
        List<string> test = new List<string>();
        public MissionTeam(List<int> String_list)
        {
            InitializeComponent();
            con.Open();
            ReadyList = String_list;
        }

        public MissionTeam()
        {
            InitializeComponent();
        }

        private void MissionTeam_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ReadyList.Count; i++) {
                SqlCommand get_names = new SqlCommand("select Volunteers.Name from Volunteers, Attendance where Volunteers.ID=Attendance.Volunteer and Volunteers.ID=@id", con);
                get_names.Parameters.AddWithValue("@id", ReadyList[i]);
                names.Add(get_names.ExecuteScalar().ToString());
            }
            label1.Text = names[0].ToString();
            label2.Text = names[1].ToString();
            label3.Text = names[2].ToString();
            label4.Text = names[3].ToString();
            label5.Text = names[4].ToString();
        }

        private void MissionTeam_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.clearTeam();
            this.Close();
            f.Show();
        }
    }
}
