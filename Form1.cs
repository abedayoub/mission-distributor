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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABEDA\\SQLEXPRESS;Initial Catalog=MissionsDistributor;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            con.Open();
        }
        List<int> team = new List<int>();
        int AdminID = 0;

        string EMTDriver = "dd", EMTTeamLeader = "tt", EMT1 = "ee1", EMT2 = "ee2", EMT3 = "ee3";

        public void changeTab(int index)
        {
            tabControl1.SelectedIndex = index;
        }

        //classifications
        List<int> EMS_drivers = new List<int>();
        List<int> EMS_TeamLeaders = new List<int>();
        List<int> FF_TeamLeaders = new List<int>();
        List<int> FF_drivers = new List<int>();
        List<int> EMTs = new List<int>();
        List<int> FFs = new List<int>();
        List<int> Trainees = new List<int>();

        public Form1(int ID)
        {
            InitializeComponent();
            AdminID = ID;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'missionsDistributorDataSet2.Volunteers' table. You can move, or remove it, as needed.
            this.volunteersTableAdapter1.Fill(this.missionsDistributorDataSet2.Volunteers);
            // TODO: This line of code loads data into the 'missionsDistributorDataSet1.Volunteers' table. You can move, or remove it, as needed.
            this.volunteersTableAdapter.Fill(this.missionsDistributorDataSet1.Volunteers);
            // TODO: This line of code loads data into the 'attendanceDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.attendanceDataSet.Attendance);
            // TODO: This line of code loads data into the 'missionsDistributorDataSet1.Attendance' table. You can move, or remove it, as needed.            // TODO: This line of code loads data into the 'missionsDistributorDataSet.MissionsType' table. You can move, or remove it, as needed.
            this.missionsTypeTableAdapter.Fill(this.missionsDistributorDataSet.MissionsType);
            refreshLabels();

            label1.Text = DateTime.Today.ToLongDateString();
            if(AdminID != 0)
            {
                button4.Show();
                VolunteersList.Show();
                label8.Show();
                mngVol_btn.Show();
            }


        }

        public void clearTeam()
        {
            team.Clear();
        }
        public void refreshLabels()
        {

            SqlCommand getTeam_query = new SqlCommand("select Volunteers.Name,Attendance.Volunteer, Attendance.Time, Attendance.Position from Attendance, Volunteers where Attendance.Volunteer= Volunteers.ID order by Time asc", con);
            SqlDataAdapter getTeam_da = new SqlDataAdapter(getTeam_query);
            DataTable getTeam_dt = new DataTable();
            getTeam_da.Fill(getTeam_dt);
            int j = 0;
            try
            {
                for (int i = 0; i < getTeam_dt.Rows.Count; i++)
                {
                    int position = Convert.ToInt32(getTeam_dt.Rows[i][3].ToString());
                    int personID = Convert.ToInt32(getTeam_dt.Rows[i][1].ToString());

                    if (position.Equals(1))
                    {
                        Trainees.Add(personID);
                        EMT3 = getName(personID);
                    }
                    else if (position.Equals(2))
                    {
                        EMTs.Add(personID);
                        if (j == 0)
                        {
                            EMT1 = getName(personID);
                            j++;
                        }
                        else if (j == 1)
                        {
                            EMT2 = getName(personID);
                            j++;
                        }
                        else if (j == 2)
                        {
                            if (EMT3 == "" || EMT3 == null)
                                EMT3 = getName(personID);
                            j++;
                        }
                    }
                    else if (position.Equals(3) || position.Equals(2) || position.Equals(3))
                    {
                        FFs.Add(personID);
                    }
                    else if (position.Equals(4))
                    {
                        EMS_TeamLeaders.Add(personID);
                        EMTTeamLeader = getName(personID);
                    }
                    else if (position.Equals(5))
                    {
                        FF_TeamLeaders.Add(personID);
                    }
                    else if (position.Equals(6))
                    {
                        EMS_drivers.Add(personID);
                        EMTDriver = getName(personID);
                    }
                    else if (position.Equals(7))
                    {
                        FF_drivers.Add(personID);
                    }

                }

                EMTTeamLeader = getName(EMS_TeamLeaders[0]);
                EMTDriver = getName(EMS_drivers[0]);
                EMT1 = getName(EMTs[0]);
                EMT2 = getName(EMTs[1]);
                if (Trainees.Count > 1)
                {
                    EMT3 = getName(Trainees[0]);
                }
                else
                {
                    EMT3 = getName(EMTs[2]);
                }

                //


            }
            catch (Exception eaa)
            {
                MessageBox.Show(eaa.ToString());
            }



            Volunteer2_lbl.Text = EMT2;
            Volunteer3_lbl.Text = EMT3;
            TeamLeader_lbl.Text = EMTTeamLeader;
            Driver_lbl.Text = EMTDriver;
            Volunteer1_lbl.Text = EMT1;
            j = 0;
        }

        public String getName(int id)
        {
            SqlCommand getNameQuery = new SqlCommand("select name from Volunteers where ID=@id", con);
            getNameQuery.Parameters.AddWithValue("@id", id);
            return getNameQuery.ExecuteScalar().ToString();
        }

        public void refreshList() {
            SqlCommand getTeam_query = new SqlCommand("select Volunteers.Name,Attendance.Volunteer, Attendance.Time, Attendance.Position from Attendance, Volunteers where Attendance.Volunteer= Volunteers.ID order by Time asc", con);
            SqlDataAdapter getTeam_da = new SqlDataAdapter(getTeam_query);
            DataTable getTeam_dt = new DataTable();
            getTeam_da.Fill(getTeam_dt);


            try
            {
                for (int i = 0; i < getTeam_dt.Rows.Count; i++)
                {
                    int position = Convert.ToInt32(getTeam_dt.Rows[i][3].ToString());
                    int personID = Convert.ToInt32(getTeam_dt.Rows[i][1].ToString());

                    if (position.Equals(1))
                    {
                        Trainees.Add(personID);
                    }
                    else if (position.Equals(2))
                    {
                        EMTs.Add(personID);
                    }
                    else if (position.Equals(3) || position.Equals(2) || position.Equals(3))
                    {
                        FFs.Add(personID);
                    }
                    else if (position.Equals(4))
                    {
                        EMS_TeamLeaders.Add(personID);
                    }
                    else if (position.Equals(5))
                    {
                        FF_TeamLeaders.Add(personID);
                    }
                    else if (position.Equals(6))
                    {
                        EMS_drivers.Add(personID);
                    }
                    else if (position.Equals(7))
                    {
                        FF_drivers.Add(personID);
                    }

                }

            }catch(Exception ex)
            {
                ex.ToString();
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand getTeam_query = new SqlCommand("select Volunteers.Name,Attendance.Volunteer, Attendance.Time, Attendance.Position from Attendance, Volunteers where Attendance.Volunteer= Volunteers.ID order by Time asc", con);
            SqlDataAdapter getTeam_da = new SqlDataAdapter(getTeam_query);
            DataTable getTeam_dt = new DataTable();
            getTeam_da.Fill(getTeam_dt);

            
            try
            {
                for (int i=0; i< getTeam_dt.Rows.Count; i++)
                {
                    int position = Convert.ToInt32(getTeam_dt.Rows[i][3].ToString());
                    int personID = Convert.ToInt32(getTeam_dt.Rows[i][1].ToString());

                    if (position.Equals(1))
                    {
                        Trainees.Add(personID);
                    }
                    else if (position.Equals(2))
                    {
                        EMTs.Add(personID);
                    }
                    else if(position.Equals(3) || position.Equals(2) || position.Equals(3))
                    {
                        FFs.Add(personID);
                    }
                    else if (position.Equals(4))
                    {
                        EMS_TeamLeaders.Add(personID);
                    }
                    else if(position.Equals(5))
                    {
                        FF_TeamLeaders.Add(personID);
                    }
                    else if (position.Equals(6))
                    {
                        EMS_drivers.Add(personID);
                    }
                    else if (position.Equals(7))
                    {
                        FF_drivers.Add(personID);
                    }

                    

                }
                if (comboBox1.Text == "EMS")
                {
                    
                    team.Add(EMS_drivers[0]);
                    team.Add(EMS_TeamLeaders[0]);
                    team.Add(EMTs[0]);
                    team.Add(EMTs[1]);
                    if(Trainees.Count<1)
                        team.Add(EMTs[2]);
                    else
                    {
                        team.Add(Trainees[0]);
                    }

                    //EMTDriver = EMS_drivers[0].ToString();
                    //EMTTeamLeader = EMTTeamLeader[0].ToString();
                    //EMT1 = EMTs[0].ToString();
                    //EMT2 = EMTs[1].ToString();
                    //EMT3 = EMTs[2].ToString();
                    
                    for (int i=0; i < team.Count; i++)
                    {
                        string update_Time = DateTime.Now.ToString();
                        SqlCommand resetTime = new SqlCommand("update Attendance set Attendance.Time=@d where Volunteer=@v", con);
                        resetTime.Parameters.AddWithValue("@d", Convert.ToDateTime(update_Time));
                        resetTime.Parameters.AddWithValue("@v", team[i]);
                        resetTime.ExecuteNonQuery();
                    }
                }
                else if(comboBox1.Text == "Fire Fighting 906")
                {
                    team.Add(FF_drivers[0]);
                    team.Add(FF_TeamLeaders[0]);
                    team.Add(FFs[0]);
                    for (int i=0; i < team.Count; i++)
                    {
                        string update_Time = DateTime.Now.ToLongDateString();
                        SqlCommand resetTime = new SqlCommand("update Attendance set Attendance.Time=@d where Volunteer=@v", con);
                        resetTime.Parameters.AddWithValue("@d", update_Time);
                        resetTime.Parameters.AddWithValue("@v", team[i]);
                        resetTime.ExecuteNonQuery();
                    }
                }
                else if (comboBox1.Text == "Fire Fighting 332")
                {
                    team.Add(FF_drivers[0]);
                    team.Add(FF_TeamLeaders[0]);
                    team.Add(FFs[0]);
                    team.Add(FFs[1]);
                    team.Add(FFs[2]);
                    team.Add(FFs[3]);
                    for (int i = 0; i < team.Count; i++)
                    {
                        string update_Time = DateTime.Now.ToLongDateString();
                        SqlCommand resetTime = new SqlCommand("update Attendance set Attendance.Time=@d where Volunteer=@v", con);
                        resetTime.Parameters.AddWithValue("@d", update_Time);
                        resetTime.Parameters.AddWithValue("@v", team[i]);
                        resetTime.ExecuteNonQuery();
                    }
                }
                else if (comboBox1.Text == "UMM")
                {
                    team.Add(FF_drivers[0]);
                    team.Add(FF_TeamLeaders[0]);
                    team.Add(FFs[0]);
                    team.Add(FFs[1]);
                    team.Add(FFs[2]);
                    team.Add(FFs[3]);
                }
                else if(comboBox1.Text == "Rescue")
                {
                    MessageBox.Show("Coming Soon!");
                }
                MissionTeam m = new MissionTeam(team);
                m.Show();
                this.Hide();
                //team.RemoveAt(0);
                //team.RemoveAt(1);
                //team.RemoveAt(2);
                //team.RemoveAt(3);
                //team.RemoveAt(4);
                //team.RemoveAt(5);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            //SqlCommand timequery = new SqlCommand("select Volunteers.Name, Attendance.Time, Volunteers.ID from Volunteers, Attendance where Volunteers.ID=Attendance.Volunteer order by Attendance.Time asc", con);
            //SqlDataAdapter timequery_da = new SqlDataAdapter(timequery);
            //DataTable timequery_dt = new DataTable();
            //timequery_da.Fill(timequery_dt);

            //try
            //{

            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //    {
            //        string thisInsertPosition = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //        string thisInsertID = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //        if (Convert.ToInt32(thisInsertPosition) == 1)
            //        {
            //            Trainees.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 2)
            //        {
            //            EMTs.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 3)
            //        {
            //            FFs.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 4)
            //        {
            //            EMS_TeamLeaders.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 5)
            //        {
            //            FF_TeamLeaders.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 6)
            //        {
            //            EMS_drivers.Add(Convert.ToInt32(thisInsertID));
            //        }
            //        else if (Convert.ToInt32(thisInsertPosition) == 7)
            //        {
            //            FF_drivers.Add(Convert.ToInt32(thisInsertID));
            //        }

            //    }



            //    //select emt team
            //    //select ems trainees and emts
            //    //SqlCommand teamLeaderGET_query = new SqlCommand("select top 1 Volunteers.Name, Attendance.Time, Volunteers.ID from Volunteers, Attendance where Volunteers.ID=Attendance.Volunteer and Volunteer.Position=4 order by Attendance.Time asc", con);
            //    //SqlDataAdapter teamLeaderGET_da = new SqlDataAdapter(teamLeaderGET_query);
            //    //DataTable teamLeaderGET_dt = new DataTable();
            //    //teamLeaderGET_da.Fill(teamLeaderGET_dt);




            //    if (comboBox1.SelectedText.ToString() == "EMS")
            //    {
            //        List<string> EMT_team = new List<string>();
            //        EMT_team.Add(EMS_drivers[0].ToString());
            //        EMT_team.Add(EMS_TeamLeaders[0].ToString());
            //        EMT_team.Add(EMTs[0].ToString());
            //        EMT_team.Add(EMTs[1].ToString());
            //        EMT_team.Add(EMTs[2].ToString());
            //        team = EMT_team;
            //    }



            //    //Fire fighting team selection 
            //    else if (comboBox1.SelectedItem.ToString() == "Fire Fighting")
            //    {
            //        List<string> FF_team = new List<string>();
            //        FF_team.Add(FF_drivers[0].ToString());
            //        FF_team.Add(FF_TeamLeaders[0].ToString());
            //        FF_team.Add(FFs[0].ToString());
            //        FF_team.Add(FFs[1].ToString());
            //        FF_team.Add(FFs[2].ToString());
            //        team = FF_team;
            //    }

            //    //Rescue Team
            //    else if (comboBox1.SelectedItem.ToString() == "Rescue")
            //    {
            //        List<string> Rescue_team = new List<string>();
            //        MessageBox.Show("Coming Soon!");
            //    }


            //    //reset Team Attendance Time
            //    for (int i = 0; i < team.Count; i++)
            //    {

            //        string update_Time = DateTime.Now.ToLongTimeString();
            //        SqlCommand resetTime = new SqlCommand("update Attendance set Attendance.Time=@d where Volunteer=@v", con);
            //        resetTime.Parameters.AddWithValue("@d", update_Time);
            //        resetTime.Parameters.AddWithValue("@v", team[i]);
            //        resetTime.ExecuteNonQuery();
            //    }


            //    this.Hide();
            //    MissionTeam m = new MissionTeam(team);
            //    m.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            team.Clear();
}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand attend_query = new SqlCommand("insert into [Attendance]([Volunteer],[Time],[Position]) values(@v, @d, @p)", con);
            attend_query.Parameters.AddWithValue("@v", Convert.ToInt16(textBox1.Text));
            attend_query.Parameters.AddWithValue("@d", DateTime.Now);

            SqlCommand position_query = new SqlCommand("select Position from Volunteers where ID=@Uid", con);
            //SqlDataAdapter pos_da = new SqlDataAdapter(position_query);
            //DataTable pos_dt = new DataTable();
            //pos_da.Fill(pos_dt);
            //dataGridView2.DataSource = pos_dt;
            position_query.Parameters.AddWithValue("@Uid", Convert.ToInt16(textBox1.Text));

            attend_query.Parameters.AddWithValue("@p", position_query.ExecuteScalar());
            attend_query.ExecuteNonQuery();

            this.attendanceTableAdapter.Fill(this.attendanceDataSet.Attendance);
                refreshList();
            }
            catch (Exception)
            {
                MessageBox.Show("Entered ID is unavailable!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand clear_query = new SqlCommand("DELETE FROM Attendance", con);
            clear_query.ExecuteNonQuery();
            button4.Visible = false;
            this.attendanceTableAdapter.Fill(this.attendanceDataSet.Attendance);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand delete_query = new SqlCommand("delete from attendance where volunteer=@id", con);
            delete_query.Parameters.AddWithValue("@id", Convert.ToInt16(textBox1.Text));
            delete_query.ExecuteNonQuery();
            this.attendanceTableAdapter.Fill(this.attendanceDataSet.Attendance);
            refreshList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void missionsTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void attendanceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void attendanceBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void VolunteersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
