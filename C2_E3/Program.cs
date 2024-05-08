// Chapter 2 - Programming Exercise 3

using System;

class Program
{
    static void Main()
    {

        // initialize the 5 exam values
        int score1 = 60;
        int score2 = 70;
        int score3 = 80;
        int score4 = 90;
        int score5 = 100;

        // calculate average with 2 decimal places to the right
        double average = (score1 + score2 + score3 + score4 + score5) / 5.0;

        // print all scores
        Console.WriteLine($"Score 1: {score1}");
        Console.WriteLine($"Score 2: {score2}");
        Console.WriteLine($"Score 3: {score3}");
        Console.WriteLine($"Score 4: {score4}");
        Console.WriteLine($"Score 5: {score5}");

        // print average score
        Console.WriteLine("Average exam score is: " + "{0:F2}", average);

    }
}