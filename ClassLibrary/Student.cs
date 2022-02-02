using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private string _iD;
        private float _gPA;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public float GPA
        {
            get { return _gPA; }
            set
            {
                if (value >= 0.00f && value <= 4.00f)
                {
                    _gPA = value;
                }
                else
                {
                    _gPA = 0.00f;
                }
            }
        }

        //Construtors
        //FQCTOR 
        public Student(string firstName, string lastName, string iD, float gPA)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            GPA = gPA;
        }//end Student()

        //Unqualified 
        public Student() { }

        //Methods

        public override string ToString()
        {
            return string.Format($"Students full name: {FirstName} {LastName}\n" +
                $"GPA: {GPA}\n" +
                $"ID: {ID}\n");
        }


    }//end class
}//end namespace
