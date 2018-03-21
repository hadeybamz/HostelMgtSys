using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HostelMgtSys.Cashier_Page
{
    public partial class HomeCashier : MetroForm
    {
        //creating object of the string connection
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        //creating an object of the globalclass
        GlobalClass gc = new GlobalClass();

        public Admin_Page.HomeAdmin HpHomeAdmin;

        public HomeCashier()
        {
            
            InitializeComponent();
            timer1.Start();
            
        }

        public string Mydate => lbltime.Text;

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                errorProvider1.SetError(txtfname, "Please Enter First Name");
            }
            if (txtlname.Text == "")
            {
                errorProvider1.SetError(txtlname, "Please Enter Last Name");
            }
            if (txtnationalty.Text == "")
            {
                errorProvider1.SetError(txtnationalty, "Please Enter Nationalty");
            }
            if (txtphone.Text == "")
            {
                errorProvider1.SetError(txtphone, "Please Enter phone Number.");
                Regex regex = new Regex("[^0-9.-]+");
                if (!regex.IsMatch(txtphone.Text))
                {
                    errorProvider1.SetError(txtphone, "Enter A Valid Phone Number");
                }
            }
            try
            {
                HpHomeAdmin = new Admin_Page.HomeAdmin();
                //creating variable to get the value of the active datetime
                
                using (var con = new SqlConnection(strcon))
                {

                    //converting the string variable to an int
                    int rmid = Convert.ToInt32(txtroomid.Text);
                    var regtime = Convert.ToDateTime(Mydate);
                    //variable to set the expiring date of rooms
                    var endDate = regtime.AddMonths(4);
                    //variable to update room status
                    var available = 0;

                    con.Open();
                    //query to insert into the student_details table of the crystalbeam database
                    var query =
                        "insert into student_details(first_name, last_name, other_name, nationalty, phone_no, room_id, room_no, time_in, time_out) values (@fname, @lname, @oname, @nationalty, @phone, @room, @roomno, @timein, @endDate); update room_details set status = @status where room_id = @roomid";
                    var cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fname", txtfname.Text.Trim());
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text.Trim());
                    cmd.Parameters.AddWithValue("@oname", txtoname.Text.Trim());
                    cmd.Parameters.AddWithValue("@nationalty", txtnationalty.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                    cmd.Parameters.AddWithValue("@room", rmid);
                    cmd.Parameters.AddWithValue("@roomno", txtroomno.Text.Trim());
                    cmd.Parameters.AddWithValue("@timein", regtime);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@status", available);
                    cmd.Parameters.AddWithValue("@roomid", rmid);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                    MessageBox.Show(@"Hosteller Registered Successfully Successfully", @"Confirmation");
                    
                    loadavailablerooms();
                    gc.ClearAllTextBoxes(this);
                    cbprintreceipt.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    readonly AvaRooms _room = new AvaRooms();

        private void btnavailableroom_Click(object sender, EventArgs e)
        {
            try
            {
                _room.ShowDialog();
                txtroomid.Text = _room.Rmid.ToString();
                txtroomno.Text = _room.roomno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnreset_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Do you want to Logout?", "Information", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                var lg = new Login();
                lg.Show();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void HomeCashier_Load(object sender, EventArgs e)
        {
            gc.GetActiveUser(lbluser);
            loadavailablerooms();
        }

        public void loadavailablerooms()
        {
            // TODO: This line of code loads data into the 'crystalbeamdbDataSet.rooms_tbl' table. You can move, or remove it, as needed.
            //this.rooms_tblTableAdapter.Fill(this.crystalbeamdbDataSet.rooms_tbl);

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(strcon))
                {
                    //retriving roomid, category and price from rooms_tbl table in the Crystalbeam database
                    using (SqlCommand query =
                        new SqlCommand("select room_id, category, price from room_details where status = 'True'"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                DataGridAvailableRoom.DataSource = dt;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbprintreceipt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbprintreceipt.Checked)
            {
                btnprintreceiptp.Visible = true;
            }
            else
            {
                btnprintreceiptp.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var dtime = DateTime.Now;
            lbltime.Text = dtime.ToString();
        }

        private void btnprintreceiptp_Click(object sender, EventArgs e)
        {
            var rep = new frmhostellerreport();
            rep.ShowDialog();
        }
    }
}
