//@CodeCopy
using System;

namespace SnQTradingCompany.ConApp
{
	partial class Program
    {
        static void Main(/*string[] args*/)
        {
            Console.WriteLine("SnQTradingCompany");
            Console.WriteLine(DateTime.Now);

            BeforeRun();

            AfterRun();
            Console.WriteLine(DateTime.Now);
        }

        static partial void BeforeRun();
        static partial void AfterRun();
    }
}
