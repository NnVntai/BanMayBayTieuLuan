using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banvemaybay.DAO;
using banvemaybay.RF;


namespace banvemaybay.GUIRP
{
    public partial class THONGTINCHUYENBAY : Form
    {
        public THONGTINCHUYENBAY()
        {
            InitializeComponent();
        }

        private void THONGTINCHUYENBAY_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            RF.THONGTINCHUYENBAY cry = new RF.THONGTINCHUYENBAY();
            DT = CHUYENBAYDAO.CHONG();
            cry.SetDataSource(DT);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
