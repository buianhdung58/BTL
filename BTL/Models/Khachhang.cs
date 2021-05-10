using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("Khachangs")]
    public class Khachhang
    {
        [Key]
        public string TenKH { get; set; }
        public string MaKH { get; set; }
        public string SdtKH { get; set; }
        public string Diachi { get; set; }
    }
}