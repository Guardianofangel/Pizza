using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Customer
    {
        private string last;
        private string first;

        public Customer()
        {
        }

        public Customer(string c)
        {
            C = c;
        }

        public Customer(string lastName, string firstName) 
        {
            last = lastName;
            first = firstName;
        }

        public string C { get; }


        /*  //Vi får oprettet objekter i vores i vores Customer klasse
        private string _customerName;
        private string _customerAdress;
        private int _customerNumber;
        private string _customerEmail;
        //Vi sætter properties på for at kunne genkende vores objekter
        public Customer(string customerName, string customerAdress, int customerNumber, string customerEmail)
        {
            _customerName = customerName;
            _customerAdress = customerAdress;
            _customerNumber = customerNumber;
            _customerEmail = customerEmail;
        }
         
         public string customerName
        { 
            get { return _customerName; }
            set { _customerName = customerName; }
        }
        public string customerAdress
        {
            get { return _customerAdress; }
            set { _customerAdress = customerAdress; }
        }
        public int customerNumber
        {
            get {return _customerNumber;}
            set { _customerNumber = customerNumber; }
        }
        public string customerEmail
        {
            get {return _customerEmail; }
            set {_customerEmail = customerEmail; }
        
       
        */
    }

    }

