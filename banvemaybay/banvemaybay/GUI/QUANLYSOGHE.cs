using banvemaybay.BUS;
using banvemaybay.DAO;
using banvemaybay.DTO;
using System;
using System.Data;
using System.Windows.Forms;
namespace banvemaybay.GUI
{
    public partial class QUANLYSOGHE : Form
    {
        public QUANLYSOGHE()
        {
            InitializeComponent();
        }
        //
        public void TT_chuyenbay()
        {
            DataTable cb = new DataTable();
            cb = CHUYENBAYDAO.TT_CHUYENBAY();
            int sodong = cb.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                cbmachuyenbay.Items.Add(cb.Rows[i][0].ToString());
            }


        }
        public void LOadtreview(TreeView tree)
        {
            TreeNode nodcha = new TreeNode();
            DataTable dt = new DataTable();
            dt = CHUYENBAYDAO.TT_CHUYENBAY();
            int soluong = dt.Rows.Count;
            DataTable dtnv = new DataTable();
            dtnv = CHITIETSLDAO.TT_CHITIETtheohv();
            int soluong_nv = dtnv.Rows.Count;

            for (int i = 0; i < soluong; i++)
            {
                nodcha = tre.Nodes.Add(dt.Rows[i]["MACHUYENBAY"].ToString());
                nodcha.Tag = dt.Rows[i]["MACHUYENBAY"].ToString();
                for (int j = 0; j < soluong_nv; j++)
                {
                    if (dt.Rows[i]["MACHUYENBAY"].ToString() == dtnv.Rows[j]["MACHUYENBAY"].ToString())
                    {
                        TreeNode nodcon = new TreeNode();
                        nodcon.Text = dtnv.Rows[j]["TENHANGVE"].ToString();
                        nodcon.Tag = dtnv.Rows[j]["MASLGHE"].ToString();
                        nodcha.Nodes.Add(nodcon);
                    }

                }
            }
        }
        
        public void TT_HANGVE()
        {
            DataTable sa = new DataTable();
            sa = HANGVEDAO.TTHANGVE();
            cbhangve.DataSource = sa;
            cbhangve.ValueMember = "MAHANGVE";
            cbhangve.DisplayMember = "TENHANGVE";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QUANLYSOGHE_Load(object sender, EventArgs e)
        {
            TT_HANGVE();
            TT_chuyenbay();
          
            LOadtreview(tre);

        }

        private void btthem_Click(object sender, EventArgs e)
        {

            DataTable max = new DataTable();

            max = CHITIETSLDAO.TT_CHITIETMAX();
            if (max.Rows.Count == 0)
            { txMaSL.Text = "SL001"; }
            else
            {
                string maxx = max.Rows[0][0].ToString();

                txMaSL.Text = "SL" + (Convert.ToInt32(maxx.Substring(maxx.Length - 3, 3)) + 1).ToString("000");
                cbhangve.Text = "";
                cbmachuyenbay.Text = "";
                nusoluong.Value = 1;
            }
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            CHITIETSLDTO tg = new CHITIETSLDTO();
            tg.MASOLUONGGHE = txMaSL.Text;
            tg.MACHUYENBAY = cbmachuyenbay.Text;
            tg.MAHANGVE = cbhangve.SelectedValue.ToString();
            tg.SOLUONG = Convert.ToString(nusoluong.Value);
            CHITIETSLBUS.Them_SL(tg);
            tre.Nodes.Clear();
            LOadtreview(tre);
           
          
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            CHITIETSLDTO tg = new CHITIETSLDTO();
            tg.MASOLUONGGHE = txMaSL.Text;
            CHITIETSLBUS.Xoa_SL(tg);
            tre.Nodes.Clear();
            LOadtreview(tre);
     
            
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            CHITIETSLDTO tg = new CHITIETSLDTO();
            tg.MASOLUONGGHE = txMaSL.Text;
            tg.MACHUYENBAY = cbmachuyenbay.Text;
            tg.MAHANGVE = cbhangve.SelectedValue.ToString();
            tg.SOLUONG = Convert.ToString(nusoluong.Value);
            CHITIETSLBUS.CapNhat_SL(tg);
            tre.Nodes.Clear();
            LOadtreview(tre);
           
        }

        private void li_Click(object sender, EventArgs e)
        {
           
        }

        private void tre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtnv = new DataTable();
            string mkh;

            if (tre.SelectedNode.Parent == null)
            {
                dt = CHITIETSLDAO.TT_SL_theoCHUYENBAY(tre.SelectedNode.Tag.ToString());
                dataGridView1.DataSource = dt;


            }
            else
            {
                mkh = tre.SelectedNode.Tag.ToString();
                dtnv = CHITIETSLDAO.TT_SL_THEOSL(mkh);
                txMaSL.Text = dtnv.Rows[0]["MaSLGhe"].ToString();
                cbhangve.Text = dtnv.Rows[0]["TenHangve"].ToString();
                cbmachuyenbay.Text = dtnv.Rows[0]["MachuyenBay"].ToString();
                nusoluong.Value = Convert.ToInt32(dtnv.Rows[0]["Soluong"].ToString());

            }
        }
    }
}
