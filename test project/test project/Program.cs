using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project
{
    class Program
    {
        
        static void StreamWriteLine(){
            Console.WriteLine("Ik hou van jou mijn Irina\n");
        }
        
        static void Main(string[] args)
        {
            //initial line of code
            Console.WriteLine("Hello World!\n");
            
            for(int i = 0; i < 100; i++) 
                StreamWriteLine();

            int j = 0;
            for (int i = 0; i < 100; i++)
                j = j + Console.Read();


            //show collection keys
            Console.WriteLine(j);

            Console.WriteLine("End program");
        }
    }
}
