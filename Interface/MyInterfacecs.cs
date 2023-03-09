using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Interface
{
    public abstract class MyBaseClass
    {
        protected int myInt;

        public MyBaseClass(int value)
        {
            myInt = value;
        }

        public abstract void MyAbstractMethod();
    }

    public interface IMyInterface
    {
        int myInterfaceInt { get; set; }
    }

    public class MyImplementationClass : MyBaseClass, IMyInterface
    {
        public int myInterfaceInt;

        public MyImplementationClass(int value) : base(value)
        {
            myInterfaceInt = 0;
        }

        public override void MyAbstractMethod()
        {
            int sum = myInt + myInterfaceInt;
            Console.WriteLine("Sum : " + sum);
        }
    }
}
