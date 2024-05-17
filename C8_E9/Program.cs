using System;

class Program
{
    static void Main(string[] args)
    {
        // 4 dollars per zumba class
        double zumbaPrice = 4.00;
        // 5 dollars per spinning class
        double spinningPrice = 5.00;

        // multidimensional array of zumba class attendees. 6 rows for 6 days of week and 4 columns for the 4 times its offered
        int[,] zumbaAttendees =
            {{12, 10, 17, 22},
            {11, 13, 17, 22},
            {12, 10, 22, 22},
            {9, 14, 17, 22},
            {12, 10, 21, 12},
            {12, 10, 5, 10}};

        // same thing as above, just for the spinning class attendees
        int[,] spinningAttendees =
            {{7, 11, 15, 8},
            {9, 9, 9, 9},
            {3, 12, 13, 7},
            {2, 9, 9, 10},
            {8, 4, 9, 4},
            {4, 5, 9, 3}};


        // Zumba class and column titles. Tried aligning everything so it was readable
        Console.WriteLine("Zumba Class\nDay       Time    Attendees  Revenue");
        // call method to calculate revenue from zumba classes based on price per class and number of people attending
        double zumbaRevenue = AttendeesAndRevenue(zumbaAttendees, zumbaPrice);

        // Spinning class and column titles
        Console.WriteLine("\n\nSpinning Class\nDay       Time    Attendees  Revenue");
        // call method to calculate revenue from spinning classes based on price per class and number of people attending
        double spinningRevenue = AttendeesAndRevenue(spinningAttendees, spinningPrice);


        // Total attendees for each day of the week
        Console.WriteLine("\nTotal number of attendees by day and class:");

        // Call method to find total attendees for day of week
        int[] zumbaTotalByDay = TotalAttendeesByDay(zumbaAttendees); // number of zumba each day
        int[] spinningTotalByDay = TotalAttendeesByDay(spinningAttendees); // number of spinning each day
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }; // 6 days of week we want
        Console.WriteLine("Day   \t\tZumba\tSpinning"); // \t is tab

        for (int i = 0; i < daysOfWeek.Length; i++)
        {
            // get name of week from daysOfWeek array at index i. the negative numbers are adding padding to try and align everything
            // prints the number of zumba and spinning attendees each day of week 
            Console.WriteLine($"{daysOfWeek[i],-10}\t{zumbaTotalByDay[i],-6}\t{spinningTotalByDay[i],-8}");
        }


        // Combined revenue of both zumba and spinning classes
        double totalRevenue = zumbaRevenue + spinningRevenue;

        // Display revenues
        Console.WriteLine("\nRevenue for the week:");
        Console.WriteLine("Zumba revenue: "+"$"+ zumbaRevenue);
        Console.WriteLine("Spinning revenue: "+"$" + spinningRevenue);
        Console.WriteLine("Combined revenue: "+"$" + totalRevenue);
    }


    // method to display attendees and calculate the revenue 
    static double AttendeesAndRevenue(int[,] attendees, double price)
    {
        // days and times arrays
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        string[] times = { "1:00pm", "3:00pm", "5:00pm", "7:00pm" };

        // initialize revenue
        double revenue = 0.0;

        // column widths to try and align everything
        const int dayWidth = 10;
        const int timeWidth = 8;

        // loop through the days
        for (int i = 0; i < attendees.GetLength(0); i++)
        {
            // loop through the times
            for (int j = 0; j < attendees.GetLength(1); j++)
            {
                // Align columns with the outputs
                Console.Write($"{days[i],-dayWidth}"); // day
                Console.Write($"{times[j],-timeWidth}"); // time
                Console.Write($"{attendees[i, j],-10}"); // number of attendees

                // Calculate revenue for times
                double timeRevenue = attendees[i, j] * price;
                Console.WriteLine($"${timeRevenue,-8:f2}");

                // add to total revenue
                revenue += timeRevenue;
            }
        }

        // return total revenue
        return revenue;
    }


    // Calculate number of attendees per day of week
    static int[] TotalAttendeesByDay(int[,] attendees)
    {
        // array to store attendees by day
        int[] attendeesByDay = new int[attendees.GetLength(0)];

        // loop through day
        for (int i = 0; i < attendees.GetLength(0); i++)
        {
            int dailyTotal = 0;

            // loop through time of each day
            for (int j = 0; j < attendees.GetLength(1); j++)
            {
                // daily total of attendees
                dailyTotal += attendees[i, j];
            }
            attendeesByDay[i] = dailyTotal;
        }

        // return attendees for each day
        return attendeesByDay;
    }
}