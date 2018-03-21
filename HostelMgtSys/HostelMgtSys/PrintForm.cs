using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelMgtSys
{
    public partial class PrintForm : MetroForm
    {
        private List<GetHostDetails> hd;
        private GetHostPrintData pd;

        public PrintForm(GetHostPrintData gpd, List<GetHostDetails> ghd)
        {
            InitializeComponent();
            pd = gpd;
            hd = ghd;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                //pPaymentType
                hotellerrpt1.SetDataSource(hd);
                hotellerrpt1.SetParameterValue("RoomID", pd.room_id);
                hotellerrpt1.SetParameterValue("RoomNo", pd.room_no);
                hotellerrpt1.SetParameterValue("Fulllname", pd.lname + " " + pd.fname + " " + pd.oname);
                hotellerrpt1.SetParameterValue("RoomCategory",  pd.roomcat);
                hotellerrpt1.SetParameterValue("Amount", pd.amount);
                hotellerrpt1.SetParameterValue("DateOfEntry", pd.dateofentry);
                hotellerrpt1.SetParameterValue("ExpDate", pd.expiringdate);

                crystalReportViewer1.ReportSource = hotellerrpt1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
