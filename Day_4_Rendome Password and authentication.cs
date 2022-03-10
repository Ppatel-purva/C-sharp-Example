using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4._1
{
    internal class Program
    {

        //========class of rendom password=========================
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {

          
             //-------------------------task Enter password genarat the rendom password authentication and update new password--------------
            Program program = new Program();
            String AutoPassword = program.CreatePassword(7);
          
            Console.WriteLine("Enter FirstName :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----FIRST TIME LOGIN----");
            Console.WriteLine("Enter User Name : ");
            double username = Convert.ToDouble(Console.ReadLine());
            if (username.Equals(number))
            {
                Console.WriteLine("Your Password is :" + AutoPassword);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Username");
            }
            Console.WriteLine("---For Second Time Login---");
            Console.WriteLine("Enter UserName : ");
            double username1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Password : ");
            string pwd = Console.ReadLine();

            if (username1.Equals(username) && pwd.Equals(AutoPassword))
            {
                Console.WriteLine("WelCome");
                Console.WriteLine("Enter your new password");

                string newPassword = Console.ReadLine();
                Console.WriteLine("===Your Password is Upadated Successfullly===");
                Console.WriteLine(newPassword);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Username And PAssword");
            }
            
                Console.WriteLine("----Enter your Secrat Question----");

                Console.WriteLine("Question 1:  Enter your Pet name: ");
                string q1 = Console.ReadLine();

                Console.WriteLine("Question 2: Enter your school name: ");
                string q2 = Console.ReadLine();

                Console.WriteLine("Question 3:Enter your DOB: ");
                string q3 = Console.ReadLine();

            if (q1.Equals(q1) && q2.Equals(q2) && q3.Equals(q3))
            {
                Console.WriteLine("Reset Password");
            }
            else
            {
                Console.WriteLine("Your ans is not match");
            }
            
           


    }
    
}

