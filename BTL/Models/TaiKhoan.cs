using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("TaiKhoans")]
    public class TaiKhoan
    {
        [Key]
        [StringLength(20)]
        public string Tendangnhap { get; set; }
        public string Matkhau { get; set; }
    }
}