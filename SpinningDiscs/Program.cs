using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("Test CD", 100, false);
            DVD dvd = new DVD("Test DVD", 4000, true);

            cd.SpinDisc();
            dvd.SpinDisc();

            cd.ReadDisc();
            dvd.ReadDisc();

            List<byte> testBytes = new List<byte>();
            testBytes.Add(0);
            testBytes.Add(1);
            testBytes.Add(2);
            testBytes.Add(3);

            Console.WriteLine(cd.WriteData(testBytes, 4));
            Console.WriteLine(dvd.WriteData(testBytes, 4));
            Console.WriteLine(dvd.WriteData(testBytes, 8000));
        }
    }
}
