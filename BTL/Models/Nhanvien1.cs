using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL.Models
{
    public class Nhanvien1 : Person
    {
        public string NhanvienID { get; set; }
        [AllowHtml]
        public string Congty { get; set; }
    }
}