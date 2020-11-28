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

namespace GUI_QLBaiXe
{
    public partial class frm_XeVao : Form
    {
        public frm_XeVao()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoSourceTruoc = new VideoCaptureDevice();
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
            videoSourceTruoc.Stop();
        }

        private void frm_XeVao_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSourceTruoc.Stop();
        }

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
                this.ActiveControl = textBox3;
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

    }
}
