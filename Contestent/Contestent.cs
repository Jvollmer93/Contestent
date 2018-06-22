using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contestent
{
    class Contestent
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string registrationNumber;
        public string FirstName
        {
            get { return firstName; }
            set { value = firstName; }
        }
        public string LastName
        {
            get { return lastName; }
            set { value = lastName; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { value = emailAddress; }
        }
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { value = registrationNumber; }
        }
        public void SetFirstName()
        {
            Console.WriteLine("What is the contestent's first name? : ");
            firstName = Console.ReadLine();
        }
        public void SetLastName()
        {
            Console.WriteLine("What is the contestent's last name? : ");
            lastName = Console.ReadLine();
        }
        public void SetEmailAddress()
        {
            Console.WriteLine("What is the contestent's email address? : ");
            emailAddress = Console.ReadLine();
        }
        public void SetRegistrationNumber()
        {
            Console.WriteLine("What is the contestent's registration number? : ");
            registrationNumber = Console.ReadLine();
        }
        public void SetInformation()
        {
            SetFirstName();
            SetLastName();
            SetEmailAddress();
            SetRegistrationNumber();
        }
    }
}
