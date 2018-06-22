using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contestent
{
    class Sweepstakes
    {
        Dictionary<string, string> contestents = new Dictionary<string, string>();
        public Sweepstakes()
        {
            
        }
        public void RegisterContestent(Contestent contestent)
        {
            contestents.Add(contestent.RegistrationNumber, contestent.LastName);
        }
        public string PickWinner()
        {
            Console.WriteLine("Enter the winners registration number : ");
            string winnersRegistration = Console.ReadLine();

            foreach(KeyValuePair<string, string> person in contestents)
            {
                if (person.Key == winnersRegistration)
                {
                    Console.WriteLine(person.Value + " won the sweepstakes!");
                    Console.ReadLine();
                    return person.Key;
                }
            }
            return "Winning contestents registration number did not match user input.";
        }
        public void PrintContestentInfo(Contestent contestent)
        {
            Console.Write("Registration Number : " + contestent.RegistrationNumber);
            Console.WriteLine(contestent.FirstName + " " + contestent.LastName);
            Console.WriteLine("Email Address : " + contestent.EmailAddress);
        }
    }
}
