using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Application.ConsoleWriter_Interface
{
    public interface IConsoleWriter
    {
        void LogMessage(string message);
    }
}
