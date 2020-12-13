using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBaiXe
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        Frm_NhanVien frmNV = new Frm_NhanVien();
        Frm_TheXe frmTX = new Frm_TheXe();
        void FrmClosed (object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            panel1.Visible = false;
            panel1.Controls.Clear();
        }
        private void btnNV_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmNV.TopLevel = false;
            panel1.Controls.Add(frmNV);
            //frmNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNV.Dock = DockStyle.Fill;
           // frmNV.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmNV.Show();
            frmNV.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        Frm_LoaiXe frmLX = new Frm_LoaiXe();
        private void btnLX_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmLX.TopLevel = false;
            panel1.Controls.Add(frmLX);
            frmLX.Dock = DockStyle.Fill;
            frmLX.Show();
            frmLX.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void btnTX_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmTX.TopLevel = false;
            panel1.Controls.Add(frmTX);
            frmTX.Dock = DockStyle.Fill;
            frmTX.Show();
            frmTX.FormClosed += new FormClosedEventHandler(FrmClosed);
        }
        frm_XeVao frmXeVao = new frm_XeVao();
        frm_XeRa frmXeRa = new frm_XeRa();
        private void btnXeVao_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmXeVao.TopLevel = false;
            panel1.Controls.Add(frmXeVao);
            frmXeVao.Dock = DockStyle.Fill;
            frmXeVao.Show();
            frmXeVao.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmXeRa.TopLevel = false;
            panel1.Controls.Add(frmXeRa);
            frmXeRa.Dock = DockStyle.Fill;
            frmXeRa.Show();
            frmXeRa.FormClosed += new FormClosedEventHandler(FrmClosed);
        }
        Frm_Search frmSearch = new Frm_Search();
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmSearch.TopLevel = false;
            panel1.Controls.Add(frmSearch);
            frmSearch.Dock = DockStyle.Fill;
            frmSearch.Show();
            frmSearch.FormClosed += new FormClosedEventHandler(FrmClosed);
        }
        Frm_DoanhThu frmDoanhThu = new Frm_DoanhThu();

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            frmDoanhThu.TopLevel = false;
            panel1.Controls.Add(frmDoanhThu);
            frmDoanhThu.Dock = DockStyle.Fill;
            frmDoanhThu.Show();
            frmSearch.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
