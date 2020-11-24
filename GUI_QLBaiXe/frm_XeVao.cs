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
    }
}
