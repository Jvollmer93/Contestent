using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contestent
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestent contestent1 = new Contestent();
            Contestent contestent2 = new Contestent();
            Sweepstakes sweepstakes = new Sweepstakes();

            contestent1.SetInformation();
            contestent2.SetInformation();
            sweepstakes.RegisterContestent(contestent1);
            sweepstakes.RegisterContestent(contestent2);

            string winner = sweepstakes.PickWinner();
        }
    }
}
