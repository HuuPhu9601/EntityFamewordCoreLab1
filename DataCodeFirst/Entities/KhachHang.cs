using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class KhachHang
    {
        public int ID { get; set; }

        public int MaKH { get; set; }

        public string TenKH { get; set; }

        public string TenDemKH { get; set; }

        public string HoKH { get; set; }

        public int GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Diachi { get; set; }

        public int sodt { get; set; }

        public string ThanhPho { get; set; }

        public int Macty { get; set; }

        public string Tencty { get; set; }

        public int Mst { get; set; }

        public int IDTrangThai { get; set; }

        public List<HoaDon> HoaDons { get; set; }
    }
}
