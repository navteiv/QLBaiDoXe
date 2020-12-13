using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QLBaiXe;

namespace GUI_QLBaiXe
{
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void Frm_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
        DBConnect cn = new DBConnect();
        string SQL = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.SoThe, LOAIXE.LoaiXe, LOAIXE.GiaTien,XeRaVao.BienSoXe, XeRaVao.TinhTrang 
                               FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (op2.Checked)
                {
                    string Sqltimkiem = SQL + " where XeRaVao.biensoxe = '" + txtTim.Text + "'";
                    dataGridView1.DataSource = cn.createTable(Sqltimkiem);

                }
                if (op1.Checked)
                {
                    string Sqltimkiem = SQL + " where XeRaVao.sothe = '" + txtTim.Text + "'";
                    dataGridView1.DataSource = cn.createTable(Sqltimkiem);
                }
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            { }
        }
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && op1.Checked)
            {               
                string Sqltimkiem = SQL + " where XeRaVao.sothe = '" + txtTim.Text + "'";
                dataGridView1.DataSource = cn.createTable(Sqltimkiem);
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        private void Frm_Search_Load(object sender, EventArgs e)
        {
            //foreach (DataGridViewColumn col in dataGridView1.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
        }
    }
 }
