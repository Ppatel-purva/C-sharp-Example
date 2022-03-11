using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5
{
    internal class Program
    {
        public class container
        {
            public string from { get; set; }
            public string to { get; set; }
            public string goby { get; set; }

        }
        private static object kv;
        

        static void Main(string[] args)
        {
            /*
            Hashtable ht = new Hashtable();
            ht.Add(1, "monday");
            ht.Add(2, "Tuesday");
            ht.Add(3, "WednesDay");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key " + entry.Key + " Value " + entry.Value);
            }


            //Stack //LIFO
            Console.WriteLine("Stack:");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            foreach (var s in stack)

                Console.WriteLine(s + " ");

            Console.WriteLine("Queue:");
            //Queue -FIFO

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine(q.Count());

            foreach (var s in q) ;
            Console.WriteLine(q);
            Console.WriteLine(q.Contains(3));//true


            var customer = Tuple.Create(1, 2, 3, 4, 5, 6, 7);

            var store = Tuple.Create(1, 2, "purva");

            var customernew = Tuple.Create(1, 2, 3, 4, 5, 6, 7,
                Tuple.Create(10, 20, 30));

            Console.WriteLine(customernew.Rest.Item1);
            Console.WriteLine(customernew.Rest.Item1.Item1);
            Console.WriteLine(customernew.Item1);

            //--------------------Task-1 Shippment transfer 8 time free after the 8 time he will bi charged----------------

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();

            Console.WriteLine("You want to book a shipp? (y/n)");
            String ship = Console.ReadLine();
            if (ship == "y")
            {
                Console.WriteLine("Enter the shipment");
                String bookship = Console.ReadLine();     
                int bookedship = Convert.ToInt32(bookship);
                for (bookedship = 1; bookedship < 8; bookedship++)
                {
                    Console.WriteLine(bookedship);
                    Console.WriteLine("Book again");
                    String shipagain = Console.ReadLine();
                    if (shipagain == "y")                                      
                    {
                        Console.WriteLine("Enter again");
                        String againbookship = Console.ReadLine();
                        Console.WriteLine(againbookship);
                    }
                }
                var cost = 10000;
                Console.WriteLine("You book shipp more then 8 times,So from now you are charged");
                String extrabookship = Console.ReadLine();
                Console.WriteLine(extrabookship);
                Console.WriteLine(cost);
            }
            //---------------------Task-2 user and ports at run time -----n----------------------

            Console.WriteLine("Enter user1:");
            string uname = Console.ReadLine();

            Console.WriteLine("Enter port1:");
            string pname = Console.ReadLine();

            Console.WriteLine("Enter user2:");
            string uname1 = Console.ReadLine();

           


            //============================task 3 to store data in to text file=======================================================


            //var path = "C:/Backend/Day_5_task 3.txt";
            //var text = File.ReadAllText(path, Encoding.UTF8);
            //Console.WriteLine(text);

           
                
            StreamWriter sw = new StreamWriter("C:/Backend/Day_5_task 3.txt");

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            sw.WriteLine(userName);

            Console.WriteLine("You want to book a shipp? (y/n)");
            String ship = Console.ReadLine();
            sw.WriteLine(ship);
            if (ship == "y")
            {
                Console.WriteLine("Enter the shipment");
                String bookship = Console.ReadLine();
                sw.WriteLine(bookship);
                int bookedship = Convert.ToInt32(bookship);
                for (bookedship = 1; bookedship < 8; bookedship++)
                {
                    Console.WriteLine(bookedship);
                    Console.WriteLine("Book again");
                    String shipagain = Console.ReadLine();
                    sw.WriteLine(shipagain);
                    if (shipagain == "y")
                    {
                        Console.WriteLine("Enter again");
                        String againbookship = Console.ReadLine();
                        sw.WriteLine(againbookship);
                        Console.WriteLine(againbookship);
                    }
                }
                var cost = 10000;
                Console.WriteLine("You book shipp more then 8 times,So from now you are charged");
                sw.WriteLine();
                String extrabookship = Console.ReadLine();
                sw.WriteLine(extrabookship);
                Console.WriteLine(extrabookship);
                sw.WriteLine(cost);
                Console.WriteLine(cost);
            }
            
            sw.Close();
            */
            //-----------------------------------Task-4 destination inbetwwen ports -------------------------------------------

            var container = new List<container>()
            {
            new container(){from="USA",to="UK",goby="DUBAI"},
            new container(){from="INDIA",to="USA",goby="UK"},
            new container(){from="UK",to="INDIA",goby="MALLDIVS"},
            }; 
           
            Console.WriteLine("Enter FirstName :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lname = Console.ReadLine();
           
            Console.WriteLine("USA TO UK");
            Console.WriteLine("INDIA TO UK");
            Console.WriteLine("UK TO INDIA");
            Console.WriteLine("===Enter from the list===");
                Console.WriteLine("Entre From Place:");
                string ufrom = Console.ReadLine();
                Console.WriteLine("Entre To Place: ");
                string uto = Console.ReadLine();
                foreach (var cont in container)
                {
                    if (ufrom.Equals(cont.from) && uto.Equals(cont.to))
                    {
                        Console.WriteLine("YOU CAN GO BY  " + cont.goby);
                    }
                }
        }   
    }
}

