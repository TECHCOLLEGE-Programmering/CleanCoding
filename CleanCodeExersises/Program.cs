using System;
using System.Linq;

/*
 * This project is a collection of exersises that will teach students how to write clean and DRY code.
 * These exersises are stutable for beginer to experienced programmers.
 */
namespace CleanCodeExersises
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /*
         * Magic Number exercise
         */
        public bool IsLegalDrikingAgeDirty(int age)
        {
            if (age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to Magic Number exercise
         * Use consts to describe the numbers you are using to your programs.
         */
        public bool IsLegalDrikingAgeClean(int age)
        {
            const int legalDrinkingAge = 21; //use variable to describe numbers in your code.
            return age > legalDrinkingAge;
        }
        /*
         * Intermediate exercise
         * What is the question answering?
         */
        public bool eligibleDirty(Employee employee)
        {
            if (employee.Age > 55
                && employee.YearsEmployed > 10
                && employee.IsRetired == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to Intermediate exercise
         * An intermediate Variable says a lot more them a long expression.
         */
        public bool eligibleClean(Employee employee)
        {
            bool isEligibleForPension = employee.Age > 55 //Be clear about the information that is being conveyed.
                && employee.YearsEmployed > 10
                && employee.IsRetired;
            return isEligibleForPension;
        }
        /*
         * Be positive exersise
         */
        public bool IsLoggedInDirty(bool isNotloggedIn)
        {
            if (!isNotloggedIn == true)
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Failed to logged in.");
                return false;
            }
        }
        /*
         * Solution to Be positive exersise
         */
        public bool IsLoggedInClean(bool loggedIn)
        {
            if (loggedIn) //don't use double negatives.
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Failed to logged in.");
                return false;
            }
        }
        /*
         * Ternary exersise
         */
        public double GetPriceDirty(bool isPreordered)
        {
            if (isPreordered == true)
            {
                return 200.00;
            }
            else
            {
                return 350.00;
            }
        }
        /*
         * Solution to Ternary exersise
         * Use a oneline Ternary.
         */
        public double GetPriceClean(bool isPreordered)
        {
            double price = isPreordered ? 200 : 350; //load the result into a variable to make the code more readable.
            return price;
        }
        /*
         * Strong type exersise - not done
         */
    }
}


