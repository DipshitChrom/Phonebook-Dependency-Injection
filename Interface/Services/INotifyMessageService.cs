using Phonebook_Application.ConsoleWriter_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Application.Interface.Services
{
    public interface INotifyMessageService
    {
        string Message { get; set; }
        string NoficationTitle { get; set; }

        string SendNotifyMessage(string message);
        string SendConsoleMessage(IConsoleWriter consoleWriter);
        
    }
}
