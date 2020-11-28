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
    }
}
