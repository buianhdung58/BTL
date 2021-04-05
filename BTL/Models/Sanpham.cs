using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("Sanphams")]
    public class Sanpham
    {
        [Key]
        public string TenSP { get; set; }
        public string MaSP { get; set; }
        public string LoaiSP { get; set; }
        public string Mausac { get; set; }
        public string GiaSP { get; set; }
        public string Soluong { get; set; }
    }
}