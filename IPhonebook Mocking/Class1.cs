using NUnit.Framework;
using Moq;
using Phonebook_Application.Interface;
using Phonebook_Application.Interface.Services;
using Phonebook_Application.ConsoleWriter_Interface;

namespace IPhonebook_Mocking
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void PhonebookMocking()
        {
            Mock<NewPhonebook> phonebookmock = new Mock<NewPhonebook>(MockBehavior.Strict);
            phonebookmock.Setup(p => p.ReturnName("Mark")).Returns("Mark");
            phonebookmock.Setup(p => p.ReturnPhoneNumber(101010)).Returns(101010);
         
        }


        [Test]
        public void ReturnPhonebookNumberbyName()
        {
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>(MockBehavior.Strict);
            phonebookmock.Setup(phone => phone.StoreEntry("James", 442102011));
            
            long result = 442102011;
            Assert.AreEqual(phonebookmock.Object.ReturnPhonenumberbyName("James"), result); 
        }

       

        [Test]
        public void ReturnPhonebookNameByNumber()
        {
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>(MockBehavior.Strict);
            phonebookmock.Setup(phone => phone.StoreEntry("Mark", 12102121123));
            string result = "Mark";
            Assert.AreEqual(phonebookmock.Object.ReturnNamebyPhonenumber(12102121123), result);
        }

        [Test]
        public void NonExistentPhonebookNameEntry()
        {
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>(MockBehavior.Strict);
            Mock<INotifyMessageService> messagemock = new Mock<INotifyMessageService>(MockBehavior.Strict);
            string name = "Johnny";
            phonebookmock.Setup(phone => phone.StoreEntry("Mark", 12102121123));
            Assert.IsFalse(phonebookmock.Object.DoesNameExistInPhonebook("Johnny"), messagemock.Object.SendNotifyMessage("The name " + name + " does not exist in the phonebook"), false);

        }

        [Test]
        public void SendEmailMessageToUser()
        {
            Mock<IEmailService> emailmessagemock = new Mock<IEmailService>(MockBehavior.Default);
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>(MockBehavior.Strict);
            phonebookmock.Setup(phone => phone.StoreEntry("Mark", 12102121123));
            string email = "test@email.com";
            string message = "The name entered does not exist";
            Assert.IsFalse(phonebookmock.Object.DoesNameExistInPhonebook("Johnny"), emailmessagemock.Object.SendEmail(email, message), false);

        }

        [Test]
        public void ConsoleMessageService()
        {
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>(MockBehavior.Strict);
            Mock<INotifyMessageService> messagemock = new Mock<INotifyMessageService>(MockBehavior.Strict);
            Mock<IConsoleWriter> consolewritemock = new Mock<IConsoleWriter>(MockBehavior.Strict);

            phonebookmock.Setup(phone => phone.StoreEntry("Mark", 12102121123));
            Assert.IsFalse(phonebookmock.Object.DoesNameExistInPhonebook("Johnny"), messagemock.Object.SendConsoleMessage(consolewritemock.Object), false);
        }

   
    }
}
