using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CarStore
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        List<Manufacturer> manufacturers;
        List<Car> cars;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: set localhost

            var connString = "Host=192.168.1.104;Username=postgres;Password=admin;Database=car-store";
            conn = new NpgsqlConnection(connString);
            conn.Open();

            updateCustomersUI();
            updateCarsUI();
            updateManufacturersUI();
            proceduresCB.SelectedIndex = 0;
        }

        private void customersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersLB.SelectedIndex != -1)
            {
                var customer = (Customer)customersLB.SelectedItem;
                editCustomerNameTB.Text = customer.name;
                editCustomerPhoneTB.Text = customer.phone;
                editCustomerAddressTB.Text = customer.address;
                updateCustomerBoughtCarsUI();
            }
            deleteCustomerB.Enabled = customersLB.SelectedIndex != -1;
            saveCustomerB.Enabled = customersLB.SelectedIndex != -1;
            addCustomerBoughtCarB.Enabled = customersLB.SelectedIndex != -1;
        }

        private void addCustomerB_Click(object sender, EventArgs e)
        {
            var name = addCustomerNameTB.Text;
            var phone = addCustomerPhoneTB.Text;
            var address = addCustomerAddressTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO customer (name, phone, address) VALUES('{name}', '{phone}', '{address}')", conn);
            cmd.ExecuteNonQuery();
            updateCustomersUI();
        }

        private void saveCustomerB_Click(object sender, EventArgs e)
        {
            var customer = (Customer)customersLB.SelectedItem;
            var name = editCustomerNameTB.Text;
            var phone = editCustomerPhoneTB.Text;
            var address = editCustomerAddressTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE customer SET name='{name}',phone='{phone}',address='{address}' WHERE id = {customer.id}", conn);
            cmd.ExecuteNonQuery();
            updateCustomersUI();
        }

        private void deleteCustomerB_Click(object sender, EventArgs e)
        {
            if (customersLB.SelectedIndex != -1)
            {
                var customer = (Customer)customersLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM customer WHERE id = {customer.id}", conn);
                cmd.ExecuteNonQuery();
                updateCustomersUI();
            }
        }

        private void customerBoughtCarsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteCustomerBoughtCarB.Enabled = customerBoughtCarsLB.SelectedIndex != -1;
        }

        private void addCustomerBoughtCarB_Click(object sender, EventArgs e)
        {
            var customer = (Customer)customersLB.SelectedItem;
            var car = (Car)addCustomerBoughtCarCarCB.SelectedItem;
            var price = addCustomerBoughtCarPriceNB.Value.ToString();
            var cmd = new NpgsqlCommand($"INSERT INTO bought_cars (customer_id, car_id, price) VALUES({customer.id}, {car.id}, {price})", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException)
            {
                MessageBox.Show("Ця покупка вже існує.", "Помилка");
            }

            updateCustomerBoughtCarsUI();
        }
        
        private void deleteCustomerBoughtCarB_Click(object sender, EventArgs e)
        {
            var boughtCar = (BoughtCar)customerBoughtCarsLB.SelectedItem;
            var cmd = new NpgsqlCommand($"DELETE FROM bought_cars WHERE customer_id = {boughtCar.customerId} AND car_id={boughtCar.car.id}", conn);
            cmd.ExecuteNonQuery();
            updateCustomerBoughtCarsUI();
        }

        private void manufacturersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manufacturersLB.SelectedIndex != -1)
            {
                var manufacturer = (Manufacturer)manufacturersLB.SelectedItem;
                editManufacturerNameTB.Text = manufacturer.name;
            }
            deleteManufacturerB.Enabled = manufacturersLB.SelectedIndex != -1;
            saveManufacturerB.Enabled = manufacturersLB.SelectedIndex != -1;
        }

        private void addManufacturerB_Click(object sender, EventArgs e)
        {
            var name = addManufacturerNameTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO manufacturer (name) VALUES('{name}')", conn);
            cmd.ExecuteNonQuery();
            updateManufacturersUI();
        }

        private void saveManufacturerB_Click(object sender, EventArgs e)
        {
            var manufacturer = (Manufacturer)manufacturersLB.SelectedItem;
            var name = editManufacturerNameTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE manufacturer SET name='{name}' WHERE id = {manufacturer.id}", conn);
            cmd.ExecuteNonQuery();
            updateManufacturersUI();
        }

        private void deleteManufacturerB_Click(object sender, EventArgs e)
        {
            if (manufacturersLB.SelectedIndex != -1)
            {
                var manufacturer = (Manufacturer)manufacturersLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM manufacturer WHERE id = {manufacturer.id}", conn);
                cmd.ExecuteNonQuery();
                updateManufacturersUI();
                updateCarsUI();
            }
        }

        private void carsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsLB.SelectedIndex != -1)
            {
                var car = (Car)carsLB.SelectedItem;
                editCarNameTB.Text = car.name;
                editCarManufacturerCB.SelectedIndex = manufacturers.FindIndex((v) => v.id == car.manufacturer_id);
            }
            deleteCarB.Enabled = carsLB.SelectedIndex != -1;
            saveCarB.Enabled = carsLB.SelectedIndex != -1;
        }

        private void addCarB_Click(object sender, EventArgs e)
        {
            var name = addCarNameTB.Text;
            var manufacturer = (Manufacturer)addCarManufacturerCB.SelectedItem;
            var cmd = new NpgsqlCommand($"INSERT INTO car (name, manufacturer_id) VALUES('{name}', {manufacturer.id})", conn);
            cmd.ExecuteNonQuery();
            updateCarsUI();
        }

        private void deleteCarB_Click(object sender, EventArgs e)
        {
            if (carsLB.SelectedIndex != -1)
            {
                var car = (Car)carsLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM car WHERE id = {car.id}", conn);
                cmd.ExecuteNonQuery();
                updateCarsUI();
                updateCustomerBoughtCarsUI();
            }
        }

        private void saveCarB_Click(object sender, EventArgs e)
        {
            var car = (Car)carsLB.SelectedItem;
            var name = editCarNameTB.Text;
            var manufacturer = (Manufacturer)editCarManufacturerCB.SelectedItem;
            var cmd = new NpgsqlCommand($"UPDATE car SET name='{name}', manufacturer_id={manufacturer.id} WHERE id = {car.id}", conn);
            cmd.ExecuteNonQuery();
            updateCarsUI();
        }

        private void callProcedureB_Click(object sender, EventArgs e)
        {
            var procName = proceduresCB.SelectedItem.ToString();
            var cmd = new NpgsqlCommand($"CALL {procName}()", conn);
            cmd.ExecuteNonQuery();
            updateCustomersUI();
            updateCustomerBoughtCarsUI();
            updateCarsUI();
            updateManufacturersUI();
        }

        void updateCarsUI()
        {
            cars = loadCars();

            var selectedCarId = ((Car)carsLB.SelectedItem)?.id ?? -1;
            carsLB.Items.Clear();
            carsLB.Items.AddRange(cars.ToArray());
            carsLB.SelectedIndex = cars.FindIndex((v) => v.id == selectedCarId);
            deleteCarB.Enabled = carsLB.SelectedIndex != -1;
            saveCarB.Enabled = carsLB.SelectedIndex != -1;

            addCustomerBoughtCarCarCB.Items.Clear();
            addCustomerBoughtCarCarCB.Items.AddRange(cars.ToArray());
            addCustomerBoughtCarCarCB.SelectedIndex = addCustomerBoughtCarCarCB.Items.Count > 0 ? 0 : -1;
        }

        void updateManufacturersUI()
        {
            manufacturers = loadManufacturers();

            var selectedManufacturerId = ((Manufacturer)manufacturersLB.SelectedItem)?.id ?? -1;
            manufacturersLB.Items.Clear();
            manufacturersLB.Items.AddRange(manufacturers.ToArray());
            manufacturersLB.SelectedIndex = manufacturers.FindIndex((v) => v.id == selectedManufacturerId);
            deleteManufacturerB.Enabled = manufacturersLB.SelectedIndex != -1;
            saveManufacturerB.Enabled = manufacturersLB.SelectedIndex != -1;

            editCarManufacturerCB.Items.Clear();
            editCarManufacturerCB.Items.AddRange(manufacturers.ToArray());
            editCarManufacturerCB.SelectedIndex = editCarManufacturerCB.Items.Count > 0 ? 0 : -1;

            addCarManufacturerCB.Items.Clear();
            addCarManufacturerCB.Items.AddRange(manufacturers.ToArray());
            addCarManufacturerCB.SelectedIndex = addCarManufacturerCB.Items.Count > 0 ? 0 : -1;
        }

        void updateCustomersUI()
        {
            var selected = (Customer)customersLB.SelectedItem;
            int selectedIndex = -1;
            int i = 0;

            var cmd = new NpgsqlCommand("SELECT * FROM customer", conn);
            var reader = cmd.ExecuteReader();
            customersLB.Items.Clear();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                customersLB.Items.Add(new Customer(id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));

                if (selected != null && selected.id == id)
                {
                    selectedIndex = i;
                }
                i++;
            }
            reader.Close();

            customersLB.SelectedIndex = selectedIndex;
            deleteCustomerB.Enabled = customersLB.SelectedIndex != -1;
            saveCustomerB.Enabled = customersLB.SelectedIndex != -1;
            addCustomerBoughtCarB.Enabled = customersLB.SelectedIndex != -1;
        }

        List<Manufacturer> loadManufacturers()
        {
            var manufacturers = new List<Manufacturer>();
            var cmd = new NpgsqlCommand($"SELECT * FROM manufacturer", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                manufacturers.Add(new Manufacturer(reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            return manufacturers;
        }

        List<Car> loadCars()
        {
            var cars = new List<Car>();
            var cmd = new NpgsqlCommand($"SELECT * FROM car", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cars.Add(new Car(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }
            reader.Close();
            return cars;
        }

        void updateCustomerBoughtCarsUI()
        {
            customerBoughtCarsLB.Items.Clear();
            Customer customer = (Customer)customersLB.SelectedItem;

            if (customer != null)
            {
                var cmd = new NpgsqlCommand($"SELECT * FROM bought_cars WHERE customer_id = {customer.id}", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var car_id = reader.GetInt32(1);
                    var car = cars.Find((v) => v.id == car_id);
                    customerBoughtCarsLB.Items.Add(new BoughtCar(reader.GetInt32(0), car, reader.GetDecimal(2)));
                }
                reader.Close();
            }
        }
    }
}
