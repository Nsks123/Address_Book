using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class AddressBook
    {
        public void Addressbook()
        {
            Console.WriteLine("Enter Details: ");
            Console.WriteLine("Enter F_name: ");
            string f_name=Console.ReadLine();
            
            Console.WriteLine("Enter L_name: ");
            string l_name=Console.ReadLine();
            
            Console.WriteLine("Enter Address: ");
            string Address=Console.ReadLine();
            
            Console.WriteLine("Enter City: ");
            string city=Console.ReadLine();
            
            Console.WriteLine("Enter State: ");
            string state=Console.ReadLine();
            
            Console.WriteLine("Enter Zip: ");
            long zip=Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Enter Phonenumber: ");
            long phonenumber=Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Enter Email: ");
            string email=Console.ReadLine();    

            Console.WriteLine("Enter Phonenumber: ");
            
        }
        public static void Greet()
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("Welcome to AddressBook");
        }
    }
}
