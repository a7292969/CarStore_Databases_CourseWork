using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Author
    {
        public int id;
        public String name;

        public Author(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
