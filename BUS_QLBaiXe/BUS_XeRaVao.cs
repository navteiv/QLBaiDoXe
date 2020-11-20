using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBaiXe
{
    class BUS_XeRaVao
    {
        public int ID { get; set; }
        public DateTime ngayGioVao { get; set; }
        public DateTime ngayGioRa { get; set; }
        public string maLoai { get; set; }
        public string soThe { get; set; }
        public string maNV { get; set; }
        public string bienSoXe { get; set; }
        public string anhTruoc { get; set; }
        public string anhSau { get; set; }
        public bool tinhTrangXe { get; set; }
    }
}
