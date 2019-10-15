using System.Collections.Generic;

namespace Contacts
{
    public class ContactsBook
    {
        private List<Contact> contactsList = new List<Contact>();

        public void addContact(Contact contact)
        {
            contactsList.Add(contact);
        }
    }
}