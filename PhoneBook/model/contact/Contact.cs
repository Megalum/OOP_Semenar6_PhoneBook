using System.Collections.Generic;

namespace PhoneBook.model.contact
{
    class Contact
    {
		private User user;
		private List<Phone> phones;

		public Contact(User user)
		{
			this.user = user;
			phones = new List<Phone>();
		}

		public void addPhone(Phone phone)
		{
			phones.Add(phone);
		}

		public string getName()
        {
            return user.getFirstName() + " " + user.getLastName() + ": ";
		}

		public List<Phone> getPhones()
        {
			return phones;
        }
	}
}
