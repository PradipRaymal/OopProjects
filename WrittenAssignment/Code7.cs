using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.WrittenAssignment
{
    class Order
    {
        int order_id;
        string city;
        string cust_name;
        bool isdelivered;

        public int Id
        {
            set { order_id = value; }
            get { return order_id; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string CustName
        {
            set { cust_name = value; }
            get { return cust_name; }
        }
        public bool Isdelivered
        {
            set { isdelivered = value; }
            get
            {
                return isdelivered;
            }
        }

        static void Main(string[] args)
        {
            Order o = new Order();
            o.Id = 1;
            o.CustName = "Test";
            o.City = "daman";
            o.Isdelivered = true;

            Console.WriteLine(o.Id);
            Console.WriteLine(o.CustName);
            Console.WriteLine(o.City);
            Console.WriteLine(o.Isdelivered);
        }

    }
}
