// Chapter 5 - Programming Exercise 7

using System;


// Month class
class Month
{

    // Store month number here
    private int monthNumber;

    // initialize month number
    public Month(int monthNumber)
    {
        this.monthNumber = monthNumber;
    }


    // get name of the month
    public string returnMonthName()
    {

        // List of all the month names
        string[] monthNames = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
                               "October", "November", "December"};

        // return month name if valid number between 1-12
        if (monthNumber >= 1 && monthNumber <= 12)
        {
            return monthNames[monthNumber - 1]; // index starts at 0
        }
        else
        {
            return null; // return null if invalid
        }
    }


    // return number of days in the month
    public int numDaysInMonth()
    {

        // Handle different month numbers to return days in that month
        switch (monthNumber)
        {
            case 2: return 28; // If February (month 2), then return 28 days
            case 4: case 6: case 9: case 11: return 30; // If April, June, September, or November then return 30 days
            default: return 31; // Every other month not listed, return 31 days
        }
    }


    // represent months as strings
    public override string ToString()
    {
        string monthName = returnMonthName(); // get month name
        int daysInMonth = numDaysInMonth(); // get number of days in month

        // if valid, return month name and days in that month
        if (monthName != null)
        {
            return monthName + " has " + daysInMonth + " days";
        }

        else // else return error message
        {
            return "Please enter a month number between 1 and 12";
        }
    }
}


// Another class to test
class monthTest
{
    public void Test()
    {

        Console.Write("Enter month number: ");
        int monthNumber;

        // take str console input and store it in monthNumber
        if (int.TryParse(Console.ReadLine(), out monthNumber))
        {
            // Month object for the user inputed month number
            Month month = new Month(monthNumber);

            // get month name
            string monthName = month.returnMonthName();

            // return name and number if valid, else return errors
            if (monthName != null)
            {
                Console.WriteLine(monthName + " has " + month.numDaysInMonth() + " days");
            }
            else
            {
                Console.WriteLine("Please enter a month number between 1 and 12");
            }
        }
        else
        {
            Console.WriteLine("Error, enter valid number");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // variable called testing to call the monthTest class
        monthTest testing = new monthTest();
        testing.Test(); // test Month class
    }
}