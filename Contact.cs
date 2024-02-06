using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contact
    {
        private string f_name;
        private string l_name;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phonenumber;
        private string email;
        
        public string firstName
        {
            get { return f_name; }
            set { f_name = value; }

        }
        public string lastname
        {
            get { return l_name; }
            set { l_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public long Zip
        {
            get { return Zip; }
            set { zip = value; }
        }
        public long Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        Contact(string f_name,string l_name, string address, string city, string state, long zip, long phonenumber,string email)
        {
            this.f_name = f_name;
            this.l_name = l_name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phonenumber = phonenumber;
            this.email = email;

        }

    }      

        
    
}
