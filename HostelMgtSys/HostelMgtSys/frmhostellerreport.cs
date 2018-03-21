using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
namespace HostelMgtSys
{

    public partial class frmhostellerreport : MetroForm
    {
        private string strcon = ConfigurationManager.ConnectionStrings["CrystalConstr"].ToString();
        GlobalClass gc = new GlobalClass();
       
        public frmhostellerreport()
        {
            InitializeComponent();
        }

        private void frmhostellerreport_Load(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("Please Enter Hosteller Name");
            }
            else
            {
                try
                {
                    using (var conn = new SqlConnection(strcon))
                    {
                        conn.Open();
                        var query = "select student_details.first_name, student_details.last_name, student_details.other_name, student_details.time_in, student_details.time_out, room_details.category, room_details.room_id, room_details.room_no, room_details.price from student_details INNER JOIN room_details ON student_details.room_id = room_details.room_id";
                            //where student_details.first_name like '%" +
                            //txtsearch.Text + "%' or student_details.last_name like '%" + txtsearch.Text + "%' or student_details.other_name like '&" + txtsearch + "%' ";
                        var sda = new SqlDataAdapter(query, conn);
                        var dt = new DataTable();
                        //  where first_name like '%" + txtsearch.Text + "%' or last_name like '%" + txtsearch.Text + "%' or other_name like '&" + txtsearch + "%' AND 
                        hostrepdataGrid.DataSource = dt;
                        sda.Fill(dt);
                        hostrepdataGrid.Visible = true;

                        getDataSourceBindingSource.DataSource = conn.Query<GetHostPrintData>(query, commandType: CommandType.Text);
                     //   getDataSourceBindingSource.DataSource = conn.Query<GetHostPrintData>(query, commandType: CommandType.Text);

                        conn.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GetActiveHostellerRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                var dgr = gr1.Rows[row];

                lblfullname.Text = dgr.Cells[0].Value.ToString() + " " + dgr.Cells[2].Value.ToString() + " " + dgr.Cells[1].Value.ToString();
                lblentry.Text = dgr.Cells[3].Value.ToString();
                lblexpires.Text = dgr.Cells[4].Value.ToString();
                lblroomcat.Text = dgr.Cells[5].Value.ToString();
                lblroomid.Text = dgr.Cells[6].Value.ToString();
                lblamount.Text = dgr.Cells[8].Value.ToString();
                lblroomno.Text = dgr.Cells[7].Value.ToString();
                lblfullname.Visible = true;
                lblentry.Visible = true;
                lblexpires.Visible = true;
                lblentry.Visible = true;
                lblroomcat.Visible = true;
                lblroomid.Visible = true;
                lblroomno.Visible = true;
                roomno.Visible = true;
                lblamount.Visible = true;
                metroLabel1.Visible = true;
                metroLabel2.Visible = true;
                metroLabel3.Visible = true;
                metroLabel4.Visible = true;
                metroLabel5.Visible = true;
                metroLabel6.Visible = true;
                btnprint.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hostrepdataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveHostellerRow(hostrepdataGrid, e);
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            GetHostPrintData pd = getDataSourceBindingSource.Current as GetHostPrintData;
            //GetHostPrintData pd = getDataSourceBindingSource.Current as GetHostPrintData;
            if (pd != null)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strcon))
                    {
                        conn.Open();

                        var qry = "select student_details.first_name, student_details.last_name, student_details.other_name, student_details.time_in, student_details.time_out, room_details.category, room_details.room_id, room_details.room_no, room_details.price from student_details INNER JOIN room_details ON student_details.room_id = room_details.room_id";

                        //getPrintDataBindingSource.DataSource = con.Query<GetPrintData>(qry, commandType: CommandType.Text);

                        List<GetHostDetails> list_host = conn.Query<GetHostDetails>(qry, commandType: CommandType.Text).ToList();

                        PrintForm pf = new PrintForm(pd, list_host);
                        pf.ShowDialog();

                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void hostrepdataGrid_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveHostellerRow(hostrepdataGrid, e);
        }
    }
}
