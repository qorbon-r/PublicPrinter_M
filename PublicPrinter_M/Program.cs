using System;
using static System.Console;
using static System.Math;


namespace PublicPrinter_M
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a printer object
            var printer = new Copy();
            
            // My instance methods    
            printer.WelcomeUser();
            printer.InformationForUser();
            printer.ValidCurrency();
            printer.AmountOfDuplicates();
        }
    }
}
