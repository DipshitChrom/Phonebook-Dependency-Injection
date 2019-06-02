using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Phonebook_Application.Interface;
using Phonebook_Application.ConsoleWriter_Interface;

namespace Phonebook_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phonebook myphonebook = new Phonebook();
            var container = new WindsorContainer();

            container.Register(Component.For<IPhonebook>().ImplementedBy<NewPhonebook>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());


            var phonebooksetup = container.Resolve<IPhonebook>();

            phonebooksetup.LogMessage("Phonebook class was resolved");

            Console.ReadLine();
        }
    }
}
