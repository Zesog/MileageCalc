// Zeso Gane
// TINFO-200 Mileage Calculator - first Lab assignment
//
////////////////////////////////////////////////////////
// Change History
// Date          Developer     Description
// 2025-01-09    Zeso     Created the initial file and implemented the calculator's code
// 2025-01-14    Zeso     Completed the coding process and initiated unit testing
// 2025-01-16    Zeso     Completed the coding process and initiated unit testing


using System;
using System.Text;


namespace MileageCalc
{
    // ==> Got this code from T-Info Costarella...
    // The MileageCalc calculator will determine fuel efficiency for a typical
    // automobile trip so that you can monitor your gas mileage and see if you
    // are using the best vehicle and route  to reach your destinations.
    internal class Program
    {
        // main entry point of the program - every method should have at least a comment
        // explaining the high level purpose of the method or procedure
        static void Main(string[] args)
        {
            // User Interface that describesd the program -
            // 1 - WHY  the user should want to use the software
            // 2 - Give the user help in How to use the software.
            // Console.WriteLine("USER INTERFACE goes here...");
            Console.WriteLine();
            Console.WriteLine(
@"******************************************************************************
******************** Amazing Trip Mileage Calculator **************************
*******************************************************************************
The MileageCalc calculator will determine fuel efficiency for a typical
automobile trip so that you can monitor your gas mileage and see if you
are using the best vehicle and route  to reach your destinations.
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
");

            // INPUT section - get data from the user for the calculations
            // get the whole number of miles driven
            Console.WriteLine("ENTER number of whole miles driven (ex: 297, 325, etc.): ");
            int milesDriven = int.Parse(Console.ReadLine());

            // get the amount of fuel consumed - we'll use a real number
            Console.WriteLine("ENTER amount of gallons used (ex: 12.5, 9.76, etc.): ");
            double gallonsUsed = double.Parse(Console.ReadLine());

            // PROCESSING - do the actual calculations
            double mpg = milesDriven / gallonsUsed;

            // OUTPUT section - Display the results of the calculation to the user.
            Console.WriteLine($"The results of your trip of {milesDriven} miles that " +
                $"used {gallonsUsed} gallons is a fuel efficiency of {mpg} miles per gallon.");


        }
    }
}
