using System;
using System.Collections.Generic;
using PhoneBook.utils;
using PhoneBook.model.contact;
using PhoneBook.model.phonebook;
using PhoneBook.model.servis;
using System.Text.RegularExpressions;

namespace PhoneBook.controler
{
    class Controller
    {
		public static void buttonClick()
		{
			string message = new ReadFromConsole().getMessage();
			List<Contact> listContacts = new List<Contact>();
			if (isCorrectContact(message))
			{
				listContacts.Add(addContact(message));
			}
			string contact = "Ford;Mrow;123456;954321;654285;123512";
			if (isCorrectContact(contact))
			{
				listContacts.Add(addContact(contact));
			}
			contact = "Kel/Raf/956421/365214/854652/975648*";
			if (isCorrectContact(contact))
			{
				listContacts.Add(addContact(contact));
			}
			contact = "Gor Vil 362525 365495 352162";
			if (isCorrectContact(contact))
			{
				listContacts.Add(addContact(contact));
			}
			Phonebook phonebook = new PhoneBookServis().createPhonebook("Phonebook", listContacts);
			printPhonebook(phonebook);
		}

		private static void printPhonebook(Phonebook phonebook)
        {
			Console.WriteLine(phonebook.getName());
			foreach(Contact contact in phonebook.getContacts())
			{
				Console.Write(contact.getName());
				foreach (Phone phone in contact.getPhones())
				{
					Console.Write(phone.getPhoneNumber() + " ");
				}
				Console.WriteLine();
			}			
		}

		private static Contact addContact(string message)
		{
			string separator = splitLine(message);
			List<string> line = new List<string>(message.Split(separator));
			User user = new User(line[0], line[1]);
			List<Phone> phones = new List<Phone>();
			ServisContactImpl sci = new ServisContactImpl();
			for (int i = 2; i < line.Count; i++)
			{
				phones.Add(new Phone(line[i]));
			}			
			Contact contact = sci.createContact(user, phones);
			return contact;
		}

		private static bool isCorrectContact(string output)
        {
			Contact contact = addContact(output);
			ServisContactImpl sci = new ServisContactImpl();
			if (new ServisContactImpl().isCorrect(contact.getName(), contact.getPhones()))
			{
				return true;
			}
			else
			{
				return false;
			}
        }

		private static string splitLine(string message)
		{
			string f = "";
			foreach (char s in message)
			{
				if (!Regex.IsMatch(s.ToString(), @"^[a-zA-Z]+$"))
				{
					f = s + "";
					break;
				}
			}
			return f;
		}
    }
}
