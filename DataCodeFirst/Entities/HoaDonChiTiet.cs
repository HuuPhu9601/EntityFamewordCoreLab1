using DataCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public HoaDon HoaDon { get; set; }

        public SanPham SanPham { get; set; }

        public int SOLUONG { get; set; }

        public float DONGIA { get; set; }
    }
}
