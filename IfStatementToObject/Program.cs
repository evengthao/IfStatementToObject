using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementToObject
{
    class Program
    {
        static void Main(string[] args)
        {

            //var type = "dog";

            //if (type == "dog")
            //{
            //    Console.WriteLine("bark");
            //} else if (type == "cat")
            //{
            //    Console.Write("Meow");
            //} else if (type == "bird")
            //{
            //    Console.Write("Cheep Cheep");
            //}


            //refactor
            IActionable mysound = AnimalCreator.Create("dog");
            
            Console.WriteLine(mysound.MakeSound());

            Console.ReadKey();
        }
    }


}
