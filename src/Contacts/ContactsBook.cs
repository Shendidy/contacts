using System.Collections.Generic;

namespace Contacts
{
    public class ContactsBook
    {
        private List<Contact> contactsList = new List<Contact>();

        public void addContact(Contact contact)
        {
            bool availableContact = checkAvailable(contact.getName());
            if(!availableContact) contactsList.Add(contact);
        }

        public bool checkAvailable(string name)
        {
            bool available = false;
            foreach(Contact contact in contactsList)
            {
               if(contact.getName() == name) available = true;
            }
        
            return available;
        }

        public List<Contact> getContactsList()
        {
            return contactsList;
        }
    }
}