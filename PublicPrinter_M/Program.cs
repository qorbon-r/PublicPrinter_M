using System;
using static System.Console;
using static System.Math;


namespace PublicPrinter_M
{
    public class Program
    {
        static void Main(string[] args)
        {
            var printer = new Copy();

            printer.WelcomeUser();
            printer.InformationForUser();
            printer.ValidCurrency();
            printer.AmountOfDuplicates();
        }
    }
}
