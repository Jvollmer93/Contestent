﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contestent
{
    class SweepstakesQueueManager : ISweepstakesStackManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
    }
}
