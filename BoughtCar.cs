using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    internal class BoughtCar
    {
        public int customerId;
        public Car car;
        public decimal price;

        public BoughtCar(int customerId, Car car, decimal price)
        {
            this.customerId = customerId;
            this.car = car;
            this.price = price;
        }

        public override string ToString()
        {
            return car.name + " - $" + price;
        }
    }
}
