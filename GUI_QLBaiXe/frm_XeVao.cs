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
    public partial class frm_XeVao : Form
    {
        public frm_XeVao()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice videoSourceTruoc = new VideoCaptureDevice();
        DAL_XeRaVao dll = new DAL_XeRaVao();
        void VideoSourceTruoc_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picBoxCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void frm_XeVao_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbbCamera.Items.Add(filterInfo.Name);
            }
            cbbCamera.SelectedIndex = 0;

            if (videoSourceTruoc.IsRunning)
            {
                videoSourceTruoc.Stop();

                picBoxCam.Image = null;
                picBoxCam.Invalidate();
            }
            else
            {
                videoSourceTruoc = new VideoCaptureDevice(filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
                videoSourceTruoc.NewFrame += VideoSourceTruoc_NewFrame;
                videoSourceTruoc.Start();
            }
        }

        private void frm_XeVao_FormClosing(object sender, FormClosingEventArgs e)
        { 
           // videoSourceTruoc.Stop();
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            if (videoSourceTruoc.IsRunning)
            {
                videoSourceTruoc.Stop();

                picBoxCam.Image = null;
                picBoxCam.Invalidate();
            }
        }

        //private void frm_XeVao_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    videoSourceTruoc.Stop();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            pictureBox2.Image = picBoxCam.Image;
        }

      
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox2.Image = picBoxCam.Image;
                this.ActiveControl = txtBienSo;
                Bitmap img = (Bitmap)pictureBox2.Image;
            }
        }
        // Convert -> ByteArray to save DataBase
        public byte[] ImageToByteArray(Image img)
        {
            byte[] b;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                b = ms.ToArray();
            }
            return b;
        }
        public byte[] GetImg()
        {
            return ImageToByteArray((Image)pictureBox2.Image.Clone());
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            GetImg();
            try
            {
                BUS_XeRaVao ck = new BUS_XeRaVao();
                ck.ngayGioVao = DateTime.Now;
                ck.maLoai = cbLoaiXe.SelectedValue.ToString();
                ck.soThe = txtSoThe.Text.ToUpper();
                //ck.maNV = frm_DangNhap.MANV;
                ck.bienSoXe = txtBienSo.Text;
                ck.anhTruoc = GetImg();
                dll.XeVao(ck);
                MessageBox.Show("Thành công.", "Tiếp nhận xe vào bãi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtSoThe.Text = "";
                txtBienSo.Text = "";
            }
            catch (Exception)
            { }
        }
    }
}
