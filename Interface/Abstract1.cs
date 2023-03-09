using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Interface
{
    public abstract class Abstract1
    {
        public abstract  void Teacher();
    }

    public abstract class Abstract2 : Abstract1
    {
        public abstract void Student();

    }

    public class Driver:Abstract2
    {
        public override void Teacher() 
        {
            Console.WriteLine("Im Teacher");
        }
        public override void Student() 
        {
            Console.WriteLine("im Student");
        }
    }
}