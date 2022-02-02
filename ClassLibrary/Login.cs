using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login
    {
        //Fields
        private string _username;
        private string _password;

        //Properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //FQCTOR
        public Login(string username, string password)
        {
            Password = password;
            Username = username;
        }

        //Un-qulified constructor
        public Login() { }

        //Method
        public override string ToString()
        {
            return string.Format($"Username: {Username}\n" +
                $"Password: {Password}\n");
        }


    }//end class
}//end 
