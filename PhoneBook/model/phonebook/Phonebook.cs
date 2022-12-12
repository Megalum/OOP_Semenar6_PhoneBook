using System.Collections.Generic;
using PhoneBook.model.contact;

namespace PhoneBook.model.phonebook
{
    class Phonebook
    {
		private string name;
		private List<Contact> contacts;

		public Phonebook(string name)
		{
			this.name = name;
			contacts = new List<Contact>();
		}

		public void addContact(Contact contact)
		{
			contacts.Add(contact);
		}

		public List<Contact> getContacts()
		{
			return contacts;
		}

		public string getName()
        {
			return name;
        }
	}
}
