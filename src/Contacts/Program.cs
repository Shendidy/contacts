using System;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = @"Please choose an option:
    (1) Display all contacts.
    (2) Serach for a specific contact.
    (3) Add a contact.
    (4) Delete a contact.";
            Console.WriteLine(mainMenu);
        }
    }
}
