using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    internal class Car
    {
        public int id;
        public string name;
        public int manufacturer_id;

        public Car(int id, string name, int manufacturer_id)
        {
            this.id = id;
            this.name = name;
            this.manufacturer_id = manufacturer_id;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
