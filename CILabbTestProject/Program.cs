using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CILabbTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = new HelloWorld();
            Console.WriteLine(hello.SayHello());
        }
    }
}
