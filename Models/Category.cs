using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTask1.Models
{
    public class Category
    {
        public int id { get; set; }
        public int name { get; set; }
        public int description { get; set; }
        public bool isActive { get; set; }
    }
}