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
        Frm_LoaiXe frmLX = new Frm_LoaiXe();
        Frm_TheXe frmTX = new Frm_TheXe();
        private void btnNV_Click(object sender, EventArgs e)
        {
            frmNV.TopLevel = false;
            panel1.Controls.Add(frmNV);
            //frmNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmNV.Dock = DockStyle.Fill;
           // frmNV.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frmNV.Show();
        }
        private void btnLX_Click(object sender, EventArgs e)
        {

            frmLX.TopLevel = false;
            panel1.Controls.Add(frmLX);
            frmLX.Dock = DockStyle.Fill;
            frmLX.Show();
        }

        private void btnTX_Click(object sender, EventArgs e)
        {
            frmTX.TopLevel = false;
            panel1.Controls.Add(frmTX);
            frmTX.Dock = DockStyle.Fill;
            frmTX.Show();
        }
        frm_XeVao frmXeVao = new frm_XeVao();
        frm_XeRa frmXeRa = new frm_XeRa();
        private void btnXeVao_Click(object sender, EventArgs e)
        {
            frmXeVao.TopLevel = false;
            panel1.Controls.Add(frmXeVao);
            frmXeVao.Dock = DockStyle.Fill;
            frmXeVao.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmXeRa.TopLevel = false;
            panel1.Controls.Add(frmXeRa);
            frmXeRa.Dock = DockStyle.Fill;
            frmXeRa.Show();
        }
    }
}
