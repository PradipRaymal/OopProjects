using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Code
{
    internal class OverLoad
    {
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static int add(int x, int y, int z)
        {
            return x + y + z;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("for two value : "+OverLoad.add(35, 35));
            Console.WriteLine("for three value : "+OverLoad.add(35, 35, 35));
        }
    }
}
