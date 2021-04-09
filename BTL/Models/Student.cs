using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    public class Student : Person
    {
        public string Address { get; set; }
        public string University { get; set; }

    }
}