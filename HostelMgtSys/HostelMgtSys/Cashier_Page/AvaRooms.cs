using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HostelMgtSys.Cashier_Page
{
    public partial class AvaRooms : MetroForm
    {
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        GlobalClass gc = new GlobalClass();
        public int Rmid;
        public string roomno;
        public AvaRooms()
        {
            InitializeComponent();
        }

        private void AvaRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crystalbeamdbDataSet.rooms_tbl' table. You can move, or remove it, as needed.
            //this.rooms_tblTableAdapter.Fill(this.crystalbeamdbDataSet.rooms_tbl);

            try
            {
                //DataGridView RoomsGrid = new DataGridView();
                //RoomsGrid.Visible = true;
                //creating sql connection to authenticate user
                using (var sqlcon = new SqlConnection(strcon))
                {
                    //retriving roomid, category and price from rooms_tbl table in the Crystalbeam database
                    using (var query = new SqlCommand("select room_id, room_no, category, price, room_no from room_details where status = 1"))
                    {
                        using (var sda = new SqlDataAdapter())
                        {
                            query.Connection = sqlcon;
                            sda.SelectCommand = query;
                            using (var dt = new DataTable())
                            {
                                sda.Fill(dt);
                                RoomsGrid.DataSource = dt;
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

       private void btnselect_Click(object sender, EventArgs e)
        {
            
            Rmid = Convert.ToInt32(
                txtgridroom.Text);
            roomno = txtgridroomno.Text;
            //Rmid = Convert.ToInt32(txtgridroom.Text);
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RoomsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            var grd = RoomsGrid.Rows[index];

            txtgridroom.Text = grd.Cells[0].Value.ToString();
            txtgridroomno.Text = grd.Cells[1].Value.ToString();

        }
    }
}
