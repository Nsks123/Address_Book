﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook.Greet();
            AddressBook person=new AddressBook();
            person.Addressbook();
            

            Console.ReadLine();
        }
    }
}
