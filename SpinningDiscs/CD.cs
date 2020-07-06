using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public CD(string name, int totalSize, bool writeable) : base(name, totalSize, writeable)
        {
        }

        public void ReadDisc()
        {
            Console.WriteLine("Reading CD");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }
    }
}
