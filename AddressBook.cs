using System;
using System.Collections.Generic;
using TryCatch;

namespace trycatch {
    public class AddressBook {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact> ();

        public void AddContact (string email, Contact contact) {
            try {
                Contacts.Add (email, contact);
            } catch (ArgumentException ex) {
                Console.WriteLine ("This contact could not be added");
            }
        }


    }
}