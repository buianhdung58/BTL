using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("Nhanviens")]
    public class Nhanvien
    {
        [Key]
        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public string SdtNV { get; set; }
        public string email { get; set; }
        public string Vitri { get; set; }
    }
}