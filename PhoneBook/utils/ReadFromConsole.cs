using System;

namespace PhoneBook.utils
{
    class ReadFromConsole
    {
        public string getMessage()
        {
            Console.Write("Insert: ");
            string scanner = Console.ReadLine();
            return scanner;
        }
    }
}
