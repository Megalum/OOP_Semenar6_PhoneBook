namespace PhoneBook.model.contact
{
    class Phone
    {
		private string phoneNumber;
		public Phone(string phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public string getPhoneNumber()
		{
			return phoneNumber;
		}
	}
}
