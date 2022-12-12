using System.Collections.Generic;
using PhoneBook.model.contact;

namespace PhoneBook.model.servis
{
    interface ServisContact
    {
        public bool isCorrect(string name, List<Phone> phones);
        public Contact createContact(User user, List<Phone> phones);
    }
}
