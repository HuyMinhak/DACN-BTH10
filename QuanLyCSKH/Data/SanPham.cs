using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSKH.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; } // Thêm mới
        public string? HinhAnh { get; set; } // Thêm mới
       
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
  
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
       
    }
}