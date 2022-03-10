using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        private static int numbone;

        Program() //constructor
        {
    
        }
        static void Main(string[] args)
        {
            String messageone = "hello purva";
            Console.WriteLine("hello");
            Console.WriteLine(messageone);
            //access modifiers - public,private,internal,protexted
            //data type
            int numberone = 100;
            Console.WriteLine(numberone);

            //explicit type

            int m = 150;
            Console.WriteLine(m);   

            //implicit type
            var j = 10009;
            Console.WriteLine(j);

            Int32 hu = 1220;
            uint gi = 100u;
            float f = 10.0f;
            double d = 12222222.4d;
            long l = 1234543234l;
            ulong ul = 23432ul;
            decimal de = 100.12m;


            //defult value

            int im = default(int);
            float ie = default(float);

            int ip = 1234;
            float rrr = ip;

            //string

            string s = "messege1";
            char[] ch = { 'h', 'e', 'l', 'l', 'o' };

            string s1 = new string(ch);

            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }

            string s2 = @"test@gmail.com";
            Console.Write(s2);

            string s3 = "hi \n" + "hello\n "+"value";
            Console.WriteLine(s3);
            string s4 = @"hi hello purva";
            Console.WriteLine(s4);

            string ename = "miss" + "patel" + "idd";
            string fname = "purva";
            string lname = "patel";

            string persone = fname + lname;

            string fullname =$"miss { fname} { lname}";


            int hk = 10, jj = 45;
            if (hk < jj)
            {
                Console.WriteLine("hk is less");

            }
            //odd even
            int i = 5;

            if (i % 2 == 0) 
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

           //Length of string

           
            Console.WriteLine("Enter number");
            string sname = Console.ReadLine();

            if (sname.Length > 5)
            {
                Console.WriteLine(sname);
            }
            else if (sname.Length == 5) ;

            //factorial number
             Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
             for (int x = 1; x <= a; x++)
             {
            fact *= x;
             }
            Console.WriteLine(fact);
            Console.ReadLine();

            


        }
    }
}