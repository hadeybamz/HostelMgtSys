using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HostelMgtSys.Admin_Page
{
    public partial class HomeAdmin : MetroForm
    {
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        GlobalClass gc = new GlobalClass();
        public HomeAdmin()
        {
            var dtime = DateTime.Now;
            InitializeComponent();
            lbltime.Text = dtime.ToString(CultureInfo.InvariantCulture);
        }
        public string Mydate => lbltime.Text;
        //
        public int StaffID
        {
            get
            {
                return StaffID1;
            }

            set
            {
                StaffID1 = value;
            }
        }

        public int StaffID1
        {
            get
            {
                return staffID;
            }

            set
            {
                staffID = value;
            }
        }
   
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
            if (txtuname.Text == "")
            {
                errorProvider1.SetError(txtuname, "Please Enter Username");
            }
            if (txtpass.Text == "")
            {
                errorProvider1.SetError(txtpass, "Please Enter Password");
                /*if (txtpass. < 8)
                {
                    errorProvider1.SetError(txtpass, "Password too short");
                }*/
            }
            if (txtpass.Text != txtrepass.Text)
            {
                errorProvider1.SetError(txtrepass, "Password Doesn't match");
            }
            else
            {
                errorProvider1.Dispose();
                try
                {
                    var logtime = Mydate;
                    //setting up sql connection


                    using (var con = new SqlConnection(strcon))
                    {
                        con.Open();
                        var query =
                            "insert into staff_details (first_name, last_name, other_name, phone_no, username, password, user_previledge, date_time) values (@fname, @lname, @oname, @phone, @username, @password, @role, @time)";
                        var cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@fname", txtfname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtlname.Text.Trim());
                        cmd.Parameters.AddWithValue("@oname", txtoname.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtuname.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpass.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", cmbrole.Text.Trim());
                        cmd.Parameters.AddWithValue("@time", logtime);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(@"User Add Successfully...");
                        gc.ClearAllTextBoxes(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
            gc.ClearAllComboBoxes(this);
        }

        private void btnstaffupdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Do you want to update user " + StaffID + @" ?", @"Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        var query =
                            "update staff_details set first_name=@fname, last_name = @lname, other_name = @oname, phone_no = @phone, username = @uname, password = @password where staff_id = @staffid";

                        var cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@staffid", StaffID);
                        cmd.Parameters.AddWithValue("@fname", txtstafffname.Text);
                        cmd.Parameters.AddWithValue("@lname", txtstafflname.Text);
                        cmd.Parameters.AddWithValue("@oname", txtstaffoname.Text);
                        cmd.Parameters.AddWithValue("@phone", txtstaffphone.Text);
                        cmd.Parameters.AddWithValue("@uname", txtstaffuname.Text);
                        cmd.Parameters.AddWithValue("@password", txtstaffpassword.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(this, @"Operation Successful.", @"Notification", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dr == DialogResult.No)
            {
                
            }
        }

        private int staffID;
        private void GetActiveStaffRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                var dgr = gr1.Rows[row];

                StaffID = Convert.ToInt32(dgr.Cells[0].Value.ToString());
                txtstafffname.Text = dgr.Cells[1].Value.ToString();
                txtstafflname.Text = dgr.Cells[2].Value.ToString();
                txtstaffoname.Text = dgr.Cells[3].Value.ToString();
                txtstaffphone.Text = dgr.Cells[4].Value.ToString();
                txtstaffuname.Text = dgr.Cells[5].Value.ToString();
                txtstaffpassword.Text = dgr.Cells[6].Value.ToString();
                txtstaffrole.Text = dgr.Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetActiveHostellerRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                var dgr = gr1.Rows[row];

                //HostellerID = Convert.ToInt32(dgr.Cells[0].Value.ToString());
                txthostellerID.Text = dgr.Cells[0].Value.ToString();
                txthostfname.Text = dgr.Cells[1].Value.ToString();
                txthostlname.Text = dgr.Cells[2].Value.ToString();
                txthostoname.Text = dgr.Cells[3].Value.ToString();
                txthostnationalty.Text = dgr.Cells[4].Value.ToString();
                txthostphone.Text = dgr.Cells[5].Value.ToString();
                txthostroomid.Text= dgr.Cells[6].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnstaffdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete user?" +staffID + " ?", "Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        string query = "delete from staff_details where staff_id = @staffID";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("staffID", staffID);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(this, "User Deleted Successfully", "Notification", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dr == DialogResult.No)
            {
                
            }
        }
        private void btnstaffrefresh_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
            gc.ClearAllComboBoxes(this);
            HomeAdmin_Load(this.crystalBeamDataSet.staff_details, e);

        }

        private void staffGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveStaffRow(staffGridView, e);
            cbshowpwd.Visible = true;
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crystalBeamRoomDetails.room_details' table. You can move, or remove it, as needed.
            this.room_detailsTableAdapter1.Fill(this.crystalBeamRoomDetails.room_details);
            // TODO: This line of code loads data into the 'crystalBeamDataSet2.room_details' table. You can move, or remove it, as needed.
            this.room_detailsTableAdapter.Fill(this.crystalBeamDataSet2.room_details);
            // TODO: This line of code loads data into the 'crystalBeamDataSet1.student_details' table. You can move, or remove it, as needed.
         //   this.student_detailsTableAdapter.Fill(this.crystalBeamDataSet1.student_details);
            gc.GetActiveUser(lbluser);
            // TODO: This line of code loads data into the 'crystalBeamDataSet.staff_details' table. You can move, or remove it, as needed.
            this.staff_detailsTableAdapter.Fill(this.crystalBeamDataSet.staff_details);
            AvailableRooms();
            Occupiedroom();
        }
        private void AvailableRooms()
        {
            try
            {
                //DataGridView RoomsGrid = new DataGridView();
                //RoomsGrid.Visible = true;
                //creating sql connection to authenticate user
                using (var sqlcon = new SqlConnection(strcon))
                {
                    //retriving roomid, category and price from rooms_tbl table in the Crystalbeam database
                    using (var query = new SqlCommand("select room_id, room_no, category, price from room_details where status = 'True'"))
                    {
                        using (var sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (var dt = new DataTable())
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

        private void Occupiedroom()
        {
            try
            {
                //creating sql connection to authenticate user
                using (var sqlcon = new SqlConnection(strcon))
                {
                    //retriving roomid, category and price from rooms_tbl table in the Crystalbeam database
                    using (var query = new SqlCommand("select room_id, room_no, category, price from room_details where status = 'False'"))
                    {
                        using (var sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (var dt = new DataTable())
                            {
                                sda.Fill(dt);
                                ocupiedGridView.DataSource = dt;
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

        private void btnstaffsearch_Click(object sender, EventArgs e)
        {
            try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        var query = "select* from staff_details where first_name like '%" + txtsearchstaff.Text +
                                    "%' or last_name like '%" + txtsearchstaff.Text + "%' or other_name like '&" + txtsearchstaff + "%'";
                        var sda = new SqlDataAdapter(query, conn);
                        var dt = new DataTable();

                        sda.Fill(dt);
                        staffGridView.DataSource = dt;
                        staffGridView.Visible = true;

                        conn.Close();
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbcategory.Text == "" || cmbcategory.Text == "-Select Room Category-" || txtprice.Text == "" || txtroomno.Text == "")
            {
                lblerrormessage.Text = "Please Select A room category";
                lblerrormessage.Visible = true;
            }
            else
            {
                try
                {
                    var available = 1;
                    //setting up sql connection
                    using (SqlConnection sqlcon = new SqlConnection(strcon))
                    {
                        var qry =
                            "insert into room_details (category, room_no, price, status) values (@category, @roomno, @price, @availability)";
                        sqlcon.Open();
                        var cmd = new SqlCommand(qry, sqlcon);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@category", cmbcategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@roomno", txtroomno.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", txtprice.Text.Trim());
                        cmd.Parameters.AddWithValue("@availability", available);
                        cmd.Connection = sqlcon;
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Room Added Successfully", "Confirmation");
                        gc.ClearAllTextBoxes(this);
                        gc.ClearAllComboBoxes(this);
                        loadtable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcategory.Text == "Single room with fan")
            {
                txtprice.Text = "1500.00";
            }
            if (cmbcategory.Text == "Single room wih air con.")
            {
                txtprice.Text = "2000.00";
            }
            if (cmbcategory.Text == "Double room with fan")
            {
                txtprice.Text = "1200.00";
            }
            if (cmbcategory.Text == "Double room with air con.")
            {
                txtprice.Text = "1500.00";
            }
        }
        void loadtable()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(strcon))
                {
                    //retriving username and password from the staff_tbl table in the Crystalbeam database
                    using (SqlCommand query = new SqlCommand("select * from room_details"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                roomGridView.DataSource = dt;
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

        private void btnresetroom_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
            gc.ClearAllComboBoxes(this);
        }
        
        private void btnhostellerupdate_Click(object sender, EventArgs e)
        {
            //HostellerID = Convert.ToInt32(dgr.Cells[0].Value.ToString());
            var HostellerID = Convert.ToInt32(txthostellerID.Text);
            DialogResult dr = MessageBox.Show(@"Do you want to update user " + HostellerID + @" ?", @"Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
            var roomid = Convert.ToInt32(txthostroomid.Text);
                try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        var query =
                            "update student_details set first_name=@fname, last_name = @lname, other_name = @oname, nationalty = @nationalty, phone_no = @phone, room_id= @roomid where student_id = @studentid";

                        var cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@studentid", HostellerID);
                        cmd.Parameters.AddWithValue("@fname", txthostfname.Text);
                        cmd.Parameters.AddWithValue("@lname", txthostlname.Text);
                        cmd.Parameters.AddWithValue("@oname", txthostoname.Text);
                        cmd.Parameters.AddWithValue("@phone", txthostphone.Text);
                        cmd.Parameters.AddWithValue("@nationalty", txthostnationalty.Text);
                        cmd.Parameters.AddWithValue("@roomid", roomid);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(this, @"Operation Successful.", @"Notification", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void btnhostellerrefresh_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
            gc.ClearAllComboBoxes(this);
            HomeAdmin_Load(this.crystalBeamDataSet1.student_details, e);
        }

        private void btnhostellersearch_Click(object sender, EventArgs e)
        {
            try
            {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        var query = "select* from student_details where first_name like '%" + txthostsearch.Text +
                                    "%' or last_name like '%" + txthostsearch.Text + "%' or other_name like '%" + txthostsearch.Text + "%'";
                        var sda = new SqlDataAdapter(query, conn);
                        var dt = new DataTable();

                        sda.Fill(dt);
                        hostellerGridView.DataSource = dt;
                        hostellerGridView.Visible = true;

                        conn.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hostellerGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveHostellerRow(hostellerGridView, e);
        }

        private void btnhostellerdelete_Click(object sender, EventArgs e)
        {
            var HostellerID = Convert.ToInt32(txthostellerID.Text);
            DialogResult dr = MessageBox.Show("Do you want to delete Hosteller?" + HostellerID + " ?", "Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        string query = "delete from student_details where student_id = @HostellerID";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("HostellerID", HostellerID);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(this, "Hosteller Deleted Successfully", "Notification", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void cbshowpwd_CheckedChanged(object sender, EventArgs e)
        {
          if(cbshowpwd.Checked)
            {
                lblpassword.Text = txtstaffpassword.Text;
                lblpassword.Visible = true;
            }
            else
            {
                lblpassword.Visible = false;
            }
        }

        private void hostreport_Click(object sender, EventArgs e)
        {
            var rep = new frmhostellerreport();
            rep.ShowDialog();
        }


        private void btnsearchvisit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(strcon))
                {
                    conn.Open();
                    var query = "select* from visitor_details where first_name like '%" + txtsearchvisit.Text +
                                "%' or last_name like '%" + txtsearchvisit.Text + "%' or other_name like '%" + txtsearchvisit.Text + "%'";
                    var sda = new SqlDataAdapter(query, conn);
                    var dt = new DataTable();

                    sda.Fill(dt);
                    visitorGridView.DataSource = dt;
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetActiveVisitorRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                var dgr = gr1.Rows[row];

                //HostellerID = Convert.ToInt32(dgr.Cells[0].Value.ToString());
                lblfname.Text = dgr.Cells[1].Value.ToString() + " " + dgr.Cells[3].Value.ToString() + " " + dgr.Cells[2].Value.ToString();
                lbladdress.Text = dgr.Cells[4].Value.ToString();
                lblphoneno.Text = dgr.Cells[5].Value.ToString();
                lblstudentid.Text = dgr.Cells[6].Value.ToString();
                lblroomid.Text = dgr.Cells[7].Value.ToString();
                lblroomno.Text = dgr.Cells[8].Value.ToString();
                lbltimein.Text = dgr.Cells[9].Value.ToString();
                lbltimeout.Text = dgr.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void visitorGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveVisitorRow(visitorGridView, e);
        }
    }
}
