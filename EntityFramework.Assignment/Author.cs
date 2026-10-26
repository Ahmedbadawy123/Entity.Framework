using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Assignment
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

    }
}
