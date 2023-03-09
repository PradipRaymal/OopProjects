using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OopProjects.Code
{
    internal class Order
    {

        int oid;
        int quant;
        Menue m;

        public Order(int oid, int quant, Menue m) 
        {
            this.oid = oid;
            this.quant = quant; 
            this.m = m;
        }


       
        public void Show() 
        {
            Console.WriteLine(oid+" "+quant);
            Menue mm = new Menue(212, "Dosa", 40);
            mm.ShowMenue(); 
        }
            
        
    }

    class Menue 
    {
        int mid;
        string item;
        double price;

        public Menue(int mid, string item, double price) 
        { 
            this.mid = mid;
            this.item = item;   
            this.price = price;

        }
        public void ShowMenue() 
        {
            Console.WriteLine(mid+" "+item+" "+price+"rs");
        }

        static void Main(string[] args)
        {
            Menue m = new Menue(212, "Dosa", 40);
            Order oo = new Order(1, 1, m);
            oo.Show();
        }

    }
}
