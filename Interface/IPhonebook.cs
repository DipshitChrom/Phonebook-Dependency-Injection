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
        void StoreEntry(string name, long phonenumber);
        long ReturnPhonenumberbyName(string name);
        string ReturnNamebyPhonenumber(long phonenumber);
        string ReturnName(string name);
        long ReturnPhoneNumber(long phonenumber);
        bool DoesNameExistInPhonebook(string name);
        bool DoesNumberExistInPhonebook(long number);
    }
}
