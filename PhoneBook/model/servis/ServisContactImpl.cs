using PhoneBook.model.contact;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhoneBook.model.servis
{
    class ServisContactImpl: ServisContact
    {
        public Contact createContact(User user, List<Phone> phones)
        {
            Contact contact = new Contact(user);
            foreach(Phone i in phones)
            {
                contact.addPhone(i);
            }
            return contact;
        }

        public bool isCorrect(string name, List<Phone> phones)
        {
            bool isCorrect = true;
            List<string> line = new List<string>(name.Split(" "));
            if (line[0].Contains("\\W") || line[1].Contains("\\W"))
            {
                isCorrect = false;
            }
            foreach(Phone phone in phones)
            {
                if (!Regex.IsMatch(phone.getPhoneNumber(), @"^[0-9]+$"))
                {
                    isCorrect = false;
                }
            }
            return isCorrect;
        }
    }
}
