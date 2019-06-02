using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook_Application.ConsoleWriter_Interface;

namespace Phonebook_Application.Interface
{
    public class NewPhonebook : IPhonebook
    {
        public string Name { get; set; }
        public long Phonenumber { get; set; }
        readonly IConsoleWriter consoleWriter;
        
        public NewPhonebook(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
            consoleWriter.LogMessage("Hi from NewPhonebook Constructor");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string returnName(string name)
        {
            return name;
        }
        public long returnPhonenumber(long phonenumber)
        {
            return phonenumber;
        }

    }
}
