using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Author
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime DOB { get; set; }
        public string Country { get; set; }
        public ICollection<Book> books { get; set; }
    }
}