using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            
            //================== Task-1 Odd-Even message print ============

            Console.WriteLine("Enter the number");
            string userinput = Console.ReadLine();
            int numb = Convert.ToInt32(userinput);

            if (numb % 2 == 0)
            {
                Console.WriteLine(numb + " " + " Entered Number is Even");
            }
            else
            {
                Console.WriteLine(numb + " " + " Entered Number is Odd");
            }

            // in-built 

            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dm2 = new DateTime(2022, 03, 03, 3, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dm2);

            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime curruntDateTime = DateTime.Now;
            Console.WriteLine(curruntDateTime.Ticks);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUTC);

            var st = "4/4/1977";
            DateTime dm;

            var isValidDate = DateTime.TryParse(st, out dm);

            if (isValidDate)
                Console.WriteLine(dm);
            else
                Console.WriteLine("entered date is valid");

            //calculate the age 
            Console.WriteLine("Enter Your Birthdate:");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(birthdate);
            var year = today.Year - birthdate.Year;
            var month = today.Month - birthdate.Month;
            var day = today.Day - birthdate.Day;
            Console.WriteLine("Age is " + year + " Years " + month + " Months " + day + " Days .");


            //date convert to string
            Console.WriteLine("Enter your birth date");
            string dateInput = Console.ReadLine();
            Console.WriteLine("parsedDate = dateInput.ToString(dateInput)");


            //date convert to integer
            Console.WriteLine("Enter Date:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(date);
            string datestr = date.ToString("dd/MMM/yyyy");
            Console.WriteLine(datestr);
           
            


            //================= Task 2 Male Female check  ======================

            string[] male = { };
            string[] female = { };
            List<string> maleList = male.ToList();
            List<string> femaleList = female.ToList();

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Who do you want to add details for?(male/female)");
                string gender = Console.ReadLine();
                if (gender == "male" || gender == "m")
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    maleList.Add(name);
                    male = maleList.ToArray();
                    int index = Array.BinarySearch(male, name);
                    Console.WriteLine($"{name} is at index {index}");
                }
                else if (gender == "female" || gender == "f")
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    femaleList.Add(name);
                    female = maleList.ToArray();
                    int index = Array.BinarySearch(male, name);
                    Console.WriteLine($"{name} is at index {index}");
                }
            }
            for (i = 0; i < male.Length; i++)
            {
                Console.WriteLine($"{male[i]}");
            }

        }
        
    }
}

        
    


   




