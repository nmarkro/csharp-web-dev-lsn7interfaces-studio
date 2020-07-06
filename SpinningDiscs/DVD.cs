using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string name, int totalSize, bool writeable) : base(name, totalSize, writeable)
        {
        }

        public void ReadDisc()
        {
            Console.WriteLine("Reading DVD");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
    }
}
