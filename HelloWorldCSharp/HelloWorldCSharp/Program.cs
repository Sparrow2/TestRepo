using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCSharp
{

    class Test
    {
        public int value=5;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine("Testing my branch stuff one more time...");
            Console.WriteLine(t.value);
            Console.ReadLine();
            return;
        }
    }
}
