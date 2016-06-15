using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            Console.WriteLine(add(1, 2));

        }

        public static int add(int i, int j)
        {
            return i + j;
        }
    }
}
