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
        private void frm_XeRa_Load(object sender, EventArgs e)
        {

        }
    }
}
