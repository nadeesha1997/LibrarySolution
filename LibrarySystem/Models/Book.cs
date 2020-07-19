using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string Auther { get; set; }
        [key]
        public int id { get; set; }
        public string ISBN { get; set; }
    }
}
