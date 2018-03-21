using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HostelMgtSys.Security_Page
{
    public partial class HomeSecurity : MetroForm
    {
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        GlobalClass gc = new GlobalClass();
        public HomeSecurity()
        {
            InitializeComponent();
            timer1.Start();
        }

        public string Mydate => lbltime.Text;

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            {
                if (txtfname.Text == "")
                {
                    errorProvider1.SetError(txtfname, "Please Enter First Name");
                }
                else if (txtlname.Text == "")
                {
                    errorProvider1.SetError(txtlname, "Please Enter Last Name");
                }
                else if (txtaddress.Text == "")
                {
                    errorProvider1.SetError(txtaddress, "Please Enter Address");
                }
                else if (txtphone.Text == "")
                {
                    errorProvider1.SetError(txtphone, "Please Enter Phone Number");
                }
                else if (txtstudentid.Text == "")
                {
                    errorProvider1.SetError(txtstudentid, "Student ID Can't be left blank");
                }
                else if (txtroomid.Text == "")
                {
                    errorProvider1.SetError(txtroomid, "Room ID cant be left blank");
                }
                else
                {
                    try
                    {
                        var logtime = Mydate;
                        //setting up sql connection


                        using (var sqlcon = new SqlConnection(strcon))
                        {
                            sqlcon.Open();
                            var query =
                                "insert into visitor_details (first_name, last_name, other_name, address, phone_no, room_id, student_id, room_no, time_in) values (@fname, @lname, @oname, @address, @phone, @room, @host, @roomno, @timein)";
                            var cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@fname", txtfname.Text.Trim());
                            cmd.Parameters.AddWithValue("@lname", txtlname.Text.Trim());
                            cmd.Parameters.AddWithValue("@oname", txtoname.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", txtphone.Text.Trim());
                            cmd.Parameters.AddWithValue("@room", txtroomid.Text.Trim());
                            cmd.Parameters.AddWithValue("@host", txtstudentid.Text.Trim());
                            cmd.Parameters.AddWithValue("@roomno", txtroomno.Text.Trim());
                            cmd.Parameters.AddWithValue("@timein", logtime);
                            cmd.Connection = sqlcon;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show(@"Visitor Signed In Successfully", @"Confirmation");
                            gc.ClearAllTextBoxes(this);
                            sqlcon.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void GetActiveRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                var dgr = gr1.Rows[row];

                txtstudentid.Text = dgr.Cells[0].Value.ToString();
                txtroomid.Text = dgr.Cells[6].Value.ToString();
                txtroomno.Text = dgr.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetActiveVRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var rw = e.RowIndex;
                var dgr = gr1.Rows[rw];

                txtvsid.Text = dgr.Cells[0].Value.ToString();
                txtvsfirstname.Text = dgr.Cells[1].Value.ToString();
                txtvslname.Text = dgr.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //creating sql connection 
                 using (var sqlcon = new SqlConnection(strcon))
                {
                    //retriving roomid, category and price from rooms_tbl table in the Crystalbeam database
                    using (var query = new SqlCommand("select * from student_details where first_name like '%" + txtsearch.Text + "%' or last_name like '%" + txtsearch.Text + "%' or other_name like '%" + txtsearch.Text + "%'"))
                    {
                        using (var sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (var dt = new DataTable())
                            {
                                sda.Fill(dt);
                                userGridstudent.DataSource = dt;
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
        
        private void btnsearchvisitor_Click(object sender, EventArgs e)
        {
            try
            {
                //creating sql connection 
                using (var sqlcon = new SqlConnection(strcon))
                {
                    using (var query = new SqlCommand("select * from visitor_details where time_out IS NULL"))
                    {
                        using (var sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (var dt = new DataTable())
                            {
                                sda.Fill(dt);
                                userGridVisitorsignout.DataSource = dt;
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

        private void HomeSecurity_Load(object sender, EventArgs e)
        {
            gc.GetActiveUser(lbluser);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var dtime = DateTime.Now;
            lbltime.Text = dtime.ToString();
        }

        private void userGridstudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveRow(userGridstudent, e);
        }

        private void userGridVisitorsignout_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveVRow(userGridVisitorsignout, e);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            gc.ClearAllTextBoxes(this);
            gc.ClearAllComboBoxes(this);
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Are you sure you want to sign out visitor ? ", @"Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    var logtime = Mydate;
                   
                    var vid = Convert.ToInt32(txtvsid.Text);
                    using (var sqlcon = new SqlConnection(strcon))
                    {
                        sqlcon.Open();
                        var query = "update visitor_details set time_out = @timeout where visitor_id =  "+ vid + "";
                        var cmd = new SqlCommand(query, sqlcon);

                        cmd.Parameters.AddWithValue("@timeout", logtime);
                        cmd.Connection = sqlcon;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(@"Visitor Signed Out Successfully", @"Confirmation");
                        gc.ClearAllTextBoxes(this);

                        sqlcon.Close();
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

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
