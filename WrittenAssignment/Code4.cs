﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.WrittenAssignment
{
    class Code4
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            for (int i = 3; i <= 20; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);

                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
        }
    }


}
