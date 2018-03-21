using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using HostelMgtSys.Admin_Page;
using HostelMgtSys.Cashier_Page;
using HostelMgtSys.Security_Page;
using MetroFramework.Forms;

namespace HostelMgtSys
{
    public partial class Login : MetroForm
    {
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        private SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }
        public static class GlobalUname
        {
            private static string _activeUname;

            public static string GlobalVar
            {
                get { return _activeUname; }
                set { _activeUname = value; }
            }
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == string.Empty)
            {
                ErrorCheckTextBox.SetError(txtusername, "username field is required!!");
            }
            else if (txtpassword.Text == String.Empty)
            {
                ErrorCheckTextBox.SetError(txtpassword, "password field is required!!");
            }
            else
            {
                try
                {
                    con = new SqlConnection();
                    con.ConnectionString = strcon;

                    var qry = "select * from staff_details where username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                    var cmd = new SqlCommand(qry, con);
                    con.Open();

                    var dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        GlobalUname.GlobalVar = txtusername.Text;
                        while (dr.Read())
                        {
                            GetLoginData(dr);
                            txtusername.Text = string.Empty;
                            txtpassword.Text = string.Empty;
                        }

                    }
                    else
                    {
                        lblErrorMessage.Text = @"Wrong username or Password!!";
                        lblErrorMessage.Visible = true;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void GetLoginData(SqlDataReader dr)
        {
            if ((string)dr["user_previledge"] == "Admin")
            {
                var adm = new HomeAdmin();
                adm.Show();
                this.Hide();
            }
            else if ((string) dr["user_previledge"] == "Cashier")
            {
                var cashier = new HomeCashier();
                cashier.Show();
                this.Hide();
            }
            else if ((string) dr["user_previledge"] == "Security")
            {
                var sec = new HomeSecurity();
                sec.Show();
                this.Hide();
            }
        }
        private void btnexit_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Do you want to exist?", @"Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    //
                    break;
            }
        }
    }
}
    