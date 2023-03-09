using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Interface
{
    public interface Able
    {
        void Draw();
    }
    public interface FigureAble:Able  
    {
         void Draw();
    }
    public class Test :Able, FigureAble
    {
        public  void Draw()
            {
            Console.WriteLine("Draw");
            }
         void FigureAble.Draw()
        { 
            Console.WriteLine("Reactange");
        }

        public class Demo 
        {

            static void Main(string[] args)
            {
                Test t=new Test();
                t.Draw();   
                t.Draw();
            }
        }

    }
}
