using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Phonebook_Application.Interface
{
    public interface IPhonebook
    {
        string Name { get; set; }
        long Phonenumber { get; set; }
        void LogMessage(string message);
    }
}
