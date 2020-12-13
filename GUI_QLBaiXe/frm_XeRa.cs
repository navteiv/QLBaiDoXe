using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using DAL_QLBaiXe;
using BUS_QLBaiXe;


namespace GUI_QLBaiXe
{
    public partial class frm_XeRa : Form
    {
        public frm_XeRa()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DBConnect cn = new DBConnect();
        FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice videoSourceTruoc = new VideoCaptureDevice();
        DAL_XeRaVao dll = new DAL_XeRaVao();
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picboxCam.Image = (Bitmap)eventArgs.Frame.Clone();         
        }
        private void frm_XeRa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            //if (videoSourceTruoc.IsRunning)
           // {
                videoSourceTruoc.Stop();

            //picBoxCam.Image = null;
            //picBoxCam.Invalidate();
            // }
            Application.Exit();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }
        private bool checkMaThe(string Mathe)
        {
            string check = cn.loadLabel("Select count(*) from THE where sothe='" + Mathe + "'");
            if (check == "0")
            { return false; }
            else
            { return true; }
        }
        string ID = ""; int GiaTien = 0;
        public void LockText()
        {
            txtSoThe.Focus();
            txtBienSo.Enabled = false;
            txtGiaTien.Enabled = false;
            txtLoaiXe.Enabled = false;
            txtGioVao.Enabled = false;
        }


        private void frm_XeRa_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            cbCamera.SelectedIndex = 0;

            if (videoSourceTruoc.IsRunning)
            {
                videoSourceTruoc.Stop();
                //videoSourceTruoc = null;
                //videoSourceTruoc = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
                //videoSourceTruoc.NewFrame += videoSource_NewFrame;
                //videoSourceTruoc.Start();
                picboxCam.Image = null;
                picboxCam.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            else
            {
                videoSourceTruoc = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
                videoSourceTruoc.NewFrame += videoSource_NewFrame;
                videoSourceTruoc.Start();
            }
            LockText();
        }

        private void txtSoThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1.Image = picboxCam.Image;
                //Bitmap img = (Bitmap)pictureBox2.Image;
                if (checkMaThe(txtSoThe.Text.ToUpper()))
                {                 
                    dt.Clear();
                    dt = dll.CheckXeRa(txtSoThe.Text.ToUpper());
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtLoaiXe.Text = dr["loaixe"].ToString();
                            txtGiaTien.Text = dr["giatien"].ToString();
                            txtBienSo.Text = dr["biensoxe"].ToString();
                            try
                            {
                                txtGioVao.Value = (DateTime)dr["NgayGioVao"];
                            }
                            catch
                            { }
                            pictureBox2.Image = byteArrayToImage((byte[])dr["AnhPhiaTruoc"]);
                            ID = dr["ID"].ToString();
                            int soNgay = Convert.ToInt16(dr["SoNgay"]);
                            if (soNgay == 0)
                            {
                                soNgay = 1;
                            }
                            GiaTien = Convert.ToInt16(txtGiaTien.Text) * soNgay;
                            txtGiaTien.Text = GiaTien.ToString();
                        }
                    }
                    else
                    { MessageBox.Show("Số thẻ không tồn tại hoặc thẻ chưa được sử dụng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); }
                }
                else
                {
                    MessageBox.Show("Số thẻ không tồn tại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }
        }

        private void btnChoXeRa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))           
            { MessageBox.Show("Chưa nhập số thẻ hoặc số thẻ không đúng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); }
            else
            {
                dll.XeRa(int.Parse(ID), GiaTien);
                MessageBox.Show("Thành công", "Kiểm tra xe ra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtLoaiXe.Text = "";
                txtGiaTien.Text = "";
                txtBienSo.Text = "";
                txtSoThe.Text = "";
                txtGioVao.Text = DateTime.Now.ToString();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                ID = string.Empty;
            }
        }

        private void frm_XeRa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();

        }
    }
}
