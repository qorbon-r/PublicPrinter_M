using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PublicPrinter_M
{
    internal class Copy
    {
        public void WelcomeUser()
        {
            ForegroundColor = ConsoleColor.Green;
            Write("============  Willkommen  ============");
            ResetColor();
            WriteLine(Environment.NewLine);
        }
        public void InformationForUser()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Preis:\v20 Cent pro Kopie.");
            ResetColor();
            Write(Environment.NewLine);

            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Die maximale Anzahl von Kopien bei einem Kopiervorgang beträgt 5 Stück.");
            ResetColor();
            Write(Environment.NewLine);

        }

        public void ValidCurrency()
        {
            WriteLine("Wir akzeptieren folgende Münzen: ");
            WriteLine();
            BackgroundColor = ConsoleColor.DarkCyan;
            WriteLine("10 Cent:\v20 Cent:\v50 Cent:\v1 Euro:\v2 Eruo:\v");
            ResetColor();
        }
        public void AmountOfDuplicates()
        {
            // Variable für User-Input
            int userInput = 0;

            // Konstanten
            const double pricePerDuplicate = 0.2;
            const int oneEuro = 1;
            const int twoEuro = 2;
            const double fiftyCent = 0.5;

            double productOne = 0;
            double productTwo = 0;
            double productThree = 0;

            double remainingMoney = 0;
            double moneyOfUser = 0;
            
            // Behandlung von Ausnahmen
            try
            {
                Write("Anzahl von Kopien eingeben: ");
                userInput = int.Parse(ReadLine());

                if (userInput > 5)
                    WriteLine("Bitte die maximale Anzahl von Kopien beachten.");
                else if (userInput < 1)
                    WriteLine("Die Zahl muss größer als 1 sein.");
            }
            catch (FormatException)
            {
                WriteLine("Bitte das richtige Format (eine Zahl eingeben) beachten. ");
            }
            catch (OverflowException)
            {
                WriteLine("Die eingegebene Zahl ist zu groß für den Datentyp Int32.");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            if (userInput == 1)
            {
                Write("Bitte 0,20 Cent einwerfen: ");
                moneyOfUser = double.Parse(ReadLine());

                if (moneyOfUser < 0.2)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Bitte den Betrag von {pricePerDuplicate} Cent pro Kopie beachten.");
                    ResetColor();
                }
                else if (moneyOfUser == oneEuro)
                {
                    productOne = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productOne;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == twoEuro)
                {
                    productTwo = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productTwo;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == fiftyCent)
                {
                    productThree = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productThree;
                    WriteLine($"Restgeld: {remainingMoney} ");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser != twoEuro || moneyOfUser != oneEuro || moneyOfUser != fiftyCent)
                    WriteLine("Ungültig! Bitte die Tabelle der Münzen beachten.");
            }
            if (userInput == 2)
            {
                Write("Bitte 0,40 Cent einwerfen: ");
                moneyOfUser = double.Parse(ReadLine());
                if (moneyOfUser < 0.4)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Bitte den Betrag von {pricePerDuplicate} Cent pro Kopie beachten.");
                    ResetColor();
                }
                else if (moneyOfUser == oneEuro)
                {
                    productOne = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productOne;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == twoEuro)
                {
                    productTwo = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productTwo;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == fiftyCent)
                {
                    productThree = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productThree;
                    WriteLine($"Restgeld: {remainingMoney} ");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser != twoEuro || moneyOfUser != oneEuro || moneyOfUser != fiftyCent)
                    WriteLine("Ungültig! Bitte die Tabelle der Münzen beachten.");

            }
            if (userInput == 3)
            {
                Write("Bitte 0,60 Cent einwerfen: ");
                moneyOfUser = double.Parse(ReadLine());
                if (moneyOfUser < 0.6)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Bitte den Betrag von {pricePerDuplicate} Cent pro Kopie beachten.");
                    ResetColor();
                }
                else if (moneyOfUser == oneEuro)
                {
                    productOne = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productOne;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == twoEuro)
                {
                    productTwo = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productTwo;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == fiftyCent)
                {
                    productThree = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productThree;
                    WriteLine($"Restgeld: {remainingMoney} ");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser != twoEuro || moneyOfUser != oneEuro || moneyOfUser != fiftyCent)
                    WriteLine("Ungültig! Bitte die Tabelle der Münzen beachten.");
            }
            if (userInput == 4)
            {
                Write("Bitte 0,80 Cent einwerfen: ");
                moneyOfUser = double.Parse(ReadLine());
                if (moneyOfUser < 0.8)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Bitte den Betrag von {pricePerDuplicate} Cent pro Kopie beachten.");
                    ResetColor();
                }
                else if (moneyOfUser == oneEuro)
                {
                    productOne = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productOne;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == twoEuro)
                {
                    productTwo = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productTwo;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == fiftyCent)
                {
                    productThree = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productThree;
                    WriteLine($"Restgeld: {remainingMoney} ");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser != twoEuro || moneyOfUser != oneEuro || moneyOfUser != fiftyCent)
                    WriteLine("Ungültig! Bitte die Tabelle der Münzen beachten.");

            }
            if (userInput == 5)
            {
                Write("Bitte 1 Euro einwerfen: ");
                moneyOfUser = double.Parse(ReadLine());
                if (moneyOfUser < 1)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"Bitte den Betrag von {pricePerDuplicate} Cent pro Kopie beachten.");
                    ResetColor();
                }
                else if (moneyOfUser == oneEuro)
                {
                    productOne = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productOne;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == twoEuro)
                {
                    productTwo = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productTwo;
                    WriteLine($"Restgeld: {remainingMoney}");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser == fiftyCent)
                {
                    productThree = userInput * pricePerDuplicate;
                    remainingMoney = moneyOfUser - productThree;
                    WriteLine($"Restgeld: {remainingMoney} ");
                    WriteLine("Danke fürs Kopieren und einen schönen Tag!");
                }
                else if (moneyOfUser != twoEuro || moneyOfUser != oneEuro || moneyOfUser != fiftyCent)
                    WriteLine("Ungültig! Bitte die Tabelle der Münzen beachten.");
            }

        }
    }
}
