using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project
{
    class Program
    {
        
        void StreamWriteLine(){
            Console.WriteLine("Ik hou van kou mijn Irina\n");
        }
        
        static void Main(string[] args)
        {
            //initial line of code
            Console.WriteLine("Hello World!\n");

            int j = 0;
            for (int i = 0; i < 100; i++)
                j = j + Console.Read();


            //show collection keys
            Console.WriteLine(j);

            Console.WriteLine("End program");
        }
    }
}
