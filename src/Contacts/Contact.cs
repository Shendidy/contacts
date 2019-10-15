namespace Contacts
{
    public class Contact
    {
        public Contact(string name)
        {
            setName(name);
        }
        string name { get; set; }
        int mobile { get; set; }
        string dob { get; set; }
        string address1 { get; set; }
        string address2 { get; set; }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}