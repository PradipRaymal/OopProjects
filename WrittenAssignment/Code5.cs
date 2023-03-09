using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.WrittenAssignment
{
    internal class Code5
    {
        static void Main(string[] args)
        {
            int n = 156;
            int sum = 0;

            while (n > 0)
            {
                int rem = n % 10;
                sum += rem;
                n = n / 10;
            }

            if (n % sum == 0)
            {
                Console.WriteLine("is a harshad num");
            }
            else
            {
                Console.WriteLine("not harshad");
            }
        }
    }
}
