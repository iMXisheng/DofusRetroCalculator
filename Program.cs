using System;

namespace CritCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitCalculator;

            Write("Hello and welcome to the 1.29 Dofus mini helper!");
            Write("Created by Sheng");

            Write("Press any key to continue");
            Console.ReadKey();

            do
            {
                Write("Would you like to access the Drop rate calculator or the Critical strike calculator");

                Write("1. Critical Strike chance calculator");
                Write("2. Drop rate calculator");

                var questionResponse = PromptUserForIntValue("Please enter the number");

                if (questionResponse == 1)
                {
                    var baseCritical = (int)PromptUserForIntValue("Please enter Base Critical Strike chance for the spell/weapon");
                    var equipCritical = (int)PromptUserForIntValue("Please enter your Equipment Critical Strike chance total");

                    int agiFinal = (int)PromptUserForIntValue("Please enter your Agility");
                    int finalCrit = baseCritical - equipCritical;

                    var criticalResult = DamageCalcHelper.CalculateCriticalStrike(finalCrit, agiFinal);
                    criticalResult = Math.Min(Math.Max(criticalResult, 2), baseCritical);

                    if (agiFinal >= 0)
                    {
                        Write($"Your Critical Strike chance is 1/{criticalResult}");
                    }
                }
                else
                {
                    var dropProbability = PromptUserForIntValue("Please enter the drop probabilty");
                    var characterProspectingInt = PromptUserForIntValue("Please enter your Prospecting");

                    var dropRateResult = DropRateCalc.CalculateDropChance(characterProspectingInt, dropProbability);
                    dropRateResult = Math.Min(Math.Max(dropRateResult, 0), 100);

                    Write($"Your final drop chance is {dropRateResult}%");
                }

                exitCalculator = (int)PromptUserForIntValue("Press 1 to return to main menu or press 2 to exit.");

            } while (exitCalculator == 1);
        }


        private static double PromptUserForIntValue(string message)
        {
            double value = 0.00;
            string valueHolder = string.Empty;

            do
            {
                Write(message);
                valueHolder = Console.ReadLine();

            }
            while (!double.TryParse(valueHolder, out value));

            return value;
        }

        private static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
