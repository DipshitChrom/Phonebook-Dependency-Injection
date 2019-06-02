using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Application
{
    public class Phonebook
    {
        public Phonebook()
        {
            Dictionary<string, long> phonebooklog = new Dictionary<string, long>();
            string phonebookentry;
            string phonebookquery;
            Console.WriteLine("Welcome to the Phonebook Application");
            Console.WriteLine("For a query enter a blank space");
            Console.WriteLine("Enter your name and phone number");
            phonebookentry = Console.ReadLine();
            Console.WriteLine();

            while (phonebookentry != "quit")
            {

                if (phonebookentry.Equals(""))
                {
                    Console.WriteLine("Please enter the name or number you would like to query");
                    phonebookquery = Console.ReadLine();

                    bool containsletters = phonebookquery.Any(x => char.IsLetter(x));

                    if (phonebooklog.ContainsKey(phonebookquery))
                    {
                        long phonebooknumber = phonebooklog[phonebookquery];
                        Console.WriteLine(phonebooknumber);
                    }

                    else if (containsletters == false)
                    {
                        foreach (KeyValuePair<string, long> names in phonebooklog)
                        {
                            if (phonebookquery.Equals(Convert.ToString(names.Value)))
                            {
                                Console.WriteLine("Name: " + names.Key);
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("The name or number you entered does not exist in the phone book");
                    }
                }

                else
                {
                    string[] entry = phonebookentry.Split(' ');
                    string pbookname = entry[0];
                    string pbooknumber = entry[1];

                    if (pbooknumber.Length != 11)
                    {
                        Console.WriteLine("Please enter a number which is 11 or more digits");
                    }

                    else
                    {
                        long phonebooknumber = long.Parse(pbooknumber);
                        phonebooklog.Add(pbookname, phonebooknumber);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Welcome to the Phonebook Application");
                    Console.WriteLine("For a query enter a blank space");
                    Console.WriteLine("Enter your name and phone number");
                    phonebookentry = Console.ReadLine();

                }

                
            }

            

        }

    }

}



