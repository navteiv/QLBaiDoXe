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
                if (cbLoaiXe.Text == "ALL")
                {
                    sql = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, XeRaVao.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
                        FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
                        WHERE( XeRaVao.NgayGioVao >= '" + tungay + "' AND XeRaVao.NgayGioVao <= '" + DenNgay + "')";
                }
                else if (cbLoaiXe.Text == "Xe máy")
                {
                    sql = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, XeRaVao.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
                        FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
                        WHERE( XeRaVao.NgayGioVao >= '" + tungay + "' AND XeRaVao.NgayGioVao <= '" + DenNgay + "') AND LOAIXE.loaixe = N'Xe Máy'";
                }
                else if (cbLoaiXe.Text == "Xe hơi")
                {
                    sql = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, XeRaVao.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
                        FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
                        WHERE( XeRaVao.NgayGioVao >= '" + tungay + "' AND XeRaVao.NgayGioVao <= '" + DenNgay + "') AND LOAIXE.loaixe = N'Xe Hơi'";
                }
                else
                {
                    sql = @"SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, XeRaVao.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
                        FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
                        WHERE( XeRaVao.NgayGioVao >= '" + tungay + "' AND XeRaVao.NgayGioVao <= '" + DenNgay + "') AND LOAIXE.loaixe = N'Xe Đạp'";
                }
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

                lblXeTon.Text = cn.loadLabel("SELECT COUNT(*) FROM XERAVAO WHERE NgayGioRa is NULL");

            }
            catch (Exception)
            {

            }
            
        }

        private void Frm_DoanhThu_Load(object sender, EventArgs e)
        {
            cbLoaiXe.Items.Add("Xe máy");
            cbLoaiXe.Items.Add("Xe đạp");
            cbLoaiXe.Items.Add("Xe hơi");
            int nReturn = cbLoaiXe.Items.Add("ALL");
            cbLoaiXe.SelectedIndex = nReturn;
        }
    }
}
