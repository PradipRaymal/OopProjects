using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.WrittenAssignment
{
    class Krishnamurti
    {
        static void Main(string[] args)
        {

            if (Iskrishnamurti(145))
            {
                Console.WriteLine("krishnamurti");
            }
            else
            {
                Console.WriteLine("not Krishnamurti");
            }

        }
        public static bool Iskrishnamurti(int num)
        {
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {



                int rem = temp % 10;
                int fact = 1;

                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
            return sum == num;

        }
    }
}
