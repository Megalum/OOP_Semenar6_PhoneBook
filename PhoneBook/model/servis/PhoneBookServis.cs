using System.Collections.Generic;
using PhoneBook.model.phonebook;
using PhoneBook.model.contact;


namespace PhoneBook.model.servis
{
    class PhoneBookServis
    {
		public Phonebook createPhonebook(string name, List<Contact> contacts)
		{
			Phonebook phonebook = new Phonebook(name);
			foreach(Contact i in contacts)
			{
				if (!isExist(phonebook.getContacts(), i))
				{
					phonebook.addContact(i);
				}
			}
			return phonebook;
		}

		public bool isExist(List<Contact> contacts, Contact contact)
		{
			return (contacts.Contains(contact));
		}
	}
}
