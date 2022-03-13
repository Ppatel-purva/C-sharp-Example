using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Task-1 sepret with the comma and store in variable---------------
            /*
             var path = "C:/Backend/Day-6.txt";

             var text = File.ReadAllText(path, Encoding.UTF8);
             Console.WriteLine(text);

             char[] delimiterChars = { ',' };
             string[] words = text.Split(delimiterChars);
             Console.WriteLine(delimiterChars);
             foreach (var word in words)
             {
                 System.Console.WriteLine($"{word}");
             } 
            */

            Console.WriteLine("===================File 1============================");
            var path = "C:/Backend/file 1.txt";

            var text = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            char[] delimiterChars = { '~' };
            
            string[] words = text.Split(delimiterChars);
            Console.WriteLine(delimiterChars);
            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }

            Console.WriteLine("=================File 2======================");
            var path1 = "C:/Backend/file 2.txt";

            var text1 = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            char[] delimiterChars1 = { '~' };

            string[] words1 = text.Split(delimiterChars);
            Console.WriteLine(delimiterChars);
            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
        }
    }
}
