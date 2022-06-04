using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class User
    {
        public int id;
        public String name;
        public String phone;
        public String address;

        public User(int id, String name, String phone, String address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
