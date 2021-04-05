using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("Donhangs")]
    public class Donhang
    {
        [Key]
        public string MaDH { get; set; }
        public string GiatriDH { get; set; }
        public string TinhtrangDH { get; set; }
        public string Ghichu { get; set; }
    }
}