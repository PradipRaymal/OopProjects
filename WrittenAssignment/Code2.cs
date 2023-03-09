using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.WrittenAssignment
{
    class Code2
    {
        public static int isFact(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isFact(5));

        }
    }

}
