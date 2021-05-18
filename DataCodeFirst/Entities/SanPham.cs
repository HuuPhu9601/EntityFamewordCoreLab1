using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class SanPham
    {
        public int ID { get; set; }

        public int MASP { get; set; }

        public string TENSP { get; set; }

        public int MAHINH { get; set; }

        public string MOTA { get; set; }

        public float TRONGLUONGSP { get; set; }

        public float GIANHAP { get; set; }

        public float GIABAN { get; set; }

        public int SOLUONG { get; set; }

        public int DongSanPhamId { get; set; }

        public int ThuongHieuId { get; set; }

        public DongSanPham DongSanPham { get; set; }

        public ThuongHieu ThuongHieu { get; set; }



        public int IDTRANGTHAI { get; set; }

        public List<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
    }
}
