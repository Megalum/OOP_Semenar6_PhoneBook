namespace PhoneBook.model.contact
{
    class User
    {
		private string firstName;
		private string lastName;

		public User(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public string getFirstName()
		{
			return firstName;
		}

		public string getLastName()
		{
			return lastName;
		}
	}
}
