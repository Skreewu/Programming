using System;
using ObjectOrientedPractics.View.Tabs;
using System.Runtime.Serialization.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            _store.Items = new List<Item>();
            _store.Customers = new List<Customer>();
            ReadFileCustomers();
            ReadFileItems();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_store.Items.Count == 0 && _store.Customers.Count == 0) return;
            string filePathItems = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.json");
            try
            {
                if (File.Exists(filePathItems))
                {
                    File.Delete(filePathItems);
                }
            }
            catch (Exception)
            {
                throw new Exception("Ошибка при удалении файла");
            }
            WriteOnFileItems();
            string filePathCustomers = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.json");
            try
            {
                if (File.Exists(filePathCustomers))
                {
                    File.Delete(filePathCustomers);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при удалении файла");
            }
            WriteOnFileCustomers();
        }
        private void WriteOnFileItems()
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Item>));
                using (FileStream fs = new FileStream("items.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(fs, _store.Items);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ReadFileItems()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.json");
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream("items.json", FileMode.Open))
                    {
                        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Item>));
                        _store.Items.AddRange((List<Item>)deserializer.ReadObject(fs));
                        Item.SetId(_store.Items[_store.Items.Count - 1].Id + 1);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        private void WriteOnFileCustomers()
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Customer>));
                using (FileStream fs = new FileStream("customers.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(fs, _store.Customers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        private void ReadFileCustomers()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.json");
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream("customers.json", FileMode.Open))
                    {
                        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Customer>));
                        _store.Customers = (List<Customer>)deserializer.ReadObject(fs);
                        Customer.SetId(_store.Customers[_store.Customers.Count - 1].Id + 1);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
