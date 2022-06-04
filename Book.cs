using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Book
    {
        public int id;
        public String name;
        public int author_id;

        public Book(int id, String name, int author_id)
        {
            this.id = id;
            this.name = name;
            this.author_id = author_id;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
