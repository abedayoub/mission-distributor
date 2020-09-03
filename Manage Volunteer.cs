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
    public partial class Manage_Volunteer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABEDA\\SQLEXPRESS;Initial Catalog=MissionsDistributor;Integrated Security=True");


        public Manage_Volunteer()
        {
            InitializeComponent();
        }

        string name;
        int id;
        int position;
        DateTime Join;
        string bloodtype;
        string address;
        int pn, pn2;
        DateTime BOD;

        public void addVolunteer()
        {
            name = Name_txt.Text;
            id = Convert.ToInt32(ID_txt.Text);
            position = Convert.ToInt32(PositionCB.SelectedValue);
            Join = Convert.ToDateTime(Join_Date.Value.ToLongDateString());
            bloodtype = BloodCB.Text;
            address = Address_txt.Text;
            pn = Convert.ToInt32(phone_txt.Text);
            pn2 = Convert.ToInt32(altPhone_txt.Text);
            BOD = Convert.ToDateTime(DOB_date.Value.ToLongDateString());

            SqlCommand addVolunteer_query = new SqlCommand("insert into Volunteers(ID,Name,DateOfVolunteering,Position,BloodType,Address,PhoneNumber,DOB,PhoneNumber2) values (@id,@name,@date,@pos,@BD,@Add,@PN,@DOB,@PN2)", con);
            addVolunteer_query.Parameters.AddWithValue("@id", id);
            addVolunteer_query.Parameters.AddWithValue("@name", name);
            addVolunteer_query.Parameters.AddWithValue("@pos", position);
            addVolunteer_query.Parameters.AddWithValue("@date", Join);
            addVolunteer_query.Parameters.AddWithValue("@Add",address);
            addVolunteer_query.Parameters.AddWithValue("@PN",pn);
            addVolunteer_query.Parameters.AddWithValue("@BD", bloodtype);
            addVolunteer_query.Parameters.AddWithValue("@DOB",BOD);
            addVolunteer_query.Parameters.AddWithValue("@PN2",pn2);
            addVolunteer_query.ExecuteNonQuery();
            MessageBox.Show("Volunteer Added Successfully!");
            Name_txt.Clear();
            ID_txt.Clear();
        }
        private void Manage_Volunteer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'positions.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.positions.Position);
            con.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            PositionCB.Text = PositionCB.Items[0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addVolunteer();
        }
    }
}
