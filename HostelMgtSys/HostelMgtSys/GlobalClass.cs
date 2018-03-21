using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostelMgtSys
{
    class GlobalClass
    {
        private readonly string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        private SqlConnection conn;

        private string uname = Login.GlobalUname.GlobalVar;

        public void GetActiveUser(Label actuname)
        {
            conn = new SqlConnection {ConnectionString =  strcon };
            var query = "select first_name, last_name from staff_details where username = '" + uname + "'";

            conn.Open();
            var cmd = new SqlCommand(query, conn);

            var dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    actuname.Text = (string) dr["first_name"] + " " + (string) dr["last_name"];
                    actuname.Visible = true;
                }
            }
            conn.Close();
        }

        public void ClearAllComboBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox) control).SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    ClearAllComboBoxes(control);
                }
            }
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();   
                }
                else if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }


    }
}
