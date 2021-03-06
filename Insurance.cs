using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    //interface
     internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Purva", "12/11/1998");
            user.calcAge();
            user.calcPremium();
        }
    }
}
    interface Insurance
    {
        void calcAge();
    }
    interface InsuranceOne
    {
        void calcPremium();
    }

    class User : Insurance, InsuranceOne
    {
        string name;
        int age;
        string dob;
        int premium = 5000;

        public User(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }
        public void calcAge()
        {
            DateTime input = DateTime.Parse(dob);
            age = DateTime.Now.Subtract(input).Days;
            age = age / 365;
            Console.WriteLine($"Your age {age}");
        }
        public void calcPremium()
        {
            if (age <= 15)
            {
                Console.WriteLine("You are early");
            }
            else if (age > 15 && age <= 30)
            {
                Console.WriteLine($"Your premiun is ${premium}");
            }
            else if (age > 30 && age <= 45)
            {
                Console.WriteLine($"Your premiun is ${premium * 2}");
            }
            else if (age > 45 && age <= 60)
            {
                Console.WriteLine($"Your premiun is ${premium * 3}");
            }
            else if (age > 60)
            {
                Console.WriteLine($"Your premiun is ${premium * 3}");
            }

        }
    }
    
}
