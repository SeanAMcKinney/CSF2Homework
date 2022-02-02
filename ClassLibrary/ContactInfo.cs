using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ContactInfo
    {
        //Fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        //Properties
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //FQCTOR
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;

        }//end ContactInfor()

        //Unqualified Constructor
        public ContactInfo() { }

        //Methods
        public override string ToString()
        {
            return string.Format($"Contact Information:\n" +
                $"Street Address: {StreetAddress}\n" +
                $"City: {City}\n" +
                $"State: {State}\n" +
                $"Zipcode: {Zip}\n" +
                $"Phone Number: {Phone}\n" +
                $"Email Address: {Email}\n" +
                $"");
        }

    }//end class
}//end namespace
