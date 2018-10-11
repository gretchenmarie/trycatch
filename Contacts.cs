using System;
using System.Collections.Generic;

namespace TryCatch {
    public class Contact {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

         public Contact(string firstName, string lastName, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;


        }

        // public string FullName {
        // get
        // {
        //     return $"{firstName} {lastName}";
        // }
    }


    }
