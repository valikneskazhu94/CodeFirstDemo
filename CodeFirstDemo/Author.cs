﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Author
    {
        private List<Author> author;

        public Author()
        {

        }

     

        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
