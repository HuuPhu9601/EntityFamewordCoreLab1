using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class DongSanPham
    {
        public int ID { get; set; }

        public int MADSP { get; set; }

        public string TENDSP { get; set; }

        public int IDTRANGTHAI { get; set; }

        public List<SanPham> SanPhams { get; set; }
    }
}
