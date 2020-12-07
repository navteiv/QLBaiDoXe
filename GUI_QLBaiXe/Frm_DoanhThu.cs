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
    public partial class Frm_DoanhThu : Form
    {
        public Frm_DoanhThu()
        {
            InitializeComponent();
        }

        private void Frm_DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
        DBConnect cn = new DBConnect();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                int DoanhThu = 0;
                string tungay = dtTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string DenNgay = dtDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
                sql = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, LOAIXE.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
                        FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
                        WHERE( XeRaVao.NgayGioVao >= '"+ tungay + "' AND XeRaVao.NgayGioVao <= '"+ DenNgay +"')";
                dataGridView1.DataSource = cn.createTable(sql);
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                int sc = dataGridView1.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                    DoanhThu += int.Parse(dataGridView1.Rows[i].Cells["giatien"].Value.ToString());
                lblDoanhThu.Text = DoanhThu.ToString();
            }
            catch (Exception)
            {

            }
            

        }
    }
}
