using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    internal class Customer
    {
        public int id;
        public string name;
        public string phone;
        public string address;

        public Customer(int id, string name, string phone, string address)
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
