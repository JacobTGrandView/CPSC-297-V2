using System;

// Money class
class Money
{
    // Data members
    int dollars;
    int cents;

    // Single value to represent the total amount
    public Money(int fullAmount)
    {
        dollars = fullAmount / 100;
        cents = fullAmount % 100;
    }

    // Separate dollar and cent amounts to represent the total value
    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    // Increase money amount method
    public void IncrementMoney(int dollars = 0, int cents = 0)
    {
        this.dollars += dollars;
        this.cents += cents;

        // 100 cents is a dollar
        if (this.cents >= 100)
        {
            this.dollars += this.cents / 100;
            this.cents %= 100;
        }
    }

    // Method to decrease money amount
    public void DecrementMoney(int dollars = 0, int cents = 0)
    {
        this.dollars -= dollars;
        this.cents -= cents;

        // Adjust if less than 0 cents
        if (this.cents < 0)
        {
            this.dollars--;
            this.cents += 100;
        }
    }

    // New method to get the dollars, quarters, dimes, nickels, and pennies
    public string coinBreakdown()
    {
        int leftoverCents = dollars * 100 + cents;

        int quarters = leftoverCents / 25;
        leftoverCents %= 25;

        int dimes = leftoverCents / 10;
        leftoverCents %= 10;

        int nickels = leftoverCents / 5;
        leftoverCents %= 5;

        // 1 cent = 1 penny
        int pennies = leftoverCents;

        return $"Dollars: {dollars}, Quarters: {quarters}, Dimes: {dimes}, Nickels: {nickels}, Pennies: {pennies}";
    }

    // Override toString() method for $ symbol
    public override string ToString()
    {
        return $"${dollars}.{cents.ToString("00")}";
    }
}


// Second class to test Money class
public class MoneyTester
{
    static void Main(string[] args)
    {

        // New instance called money. Testing with only 1 value for the full amount
        Money money = new Money(123);
        Console.WriteLine(money);
        Console.WriteLine(money.coinBreakdown()); // Shows the full coin breakdown (quarters, dimes, etc)

        // Create a new instance called money_. We are testing with separate dollar/cent amounts
        Money money_ = new Money(2, 18); // 2 dollars and 18 cents
        Console.WriteLine(money_);

        // Test increase by 2 dollars and 2 cents
        money_.IncrementMoney(2, 2);
        Console.WriteLine($"After increment: {money_}");

        // Breakdown of all the values
        Console.WriteLine($"Breakdown: {money_.coinBreakdown()}");

        // Test decrease by 1 dollar and 3 cents
        money_.DecrementMoney(1, 3);
        Console.WriteLine($"After decrement: {money_}");

        // Breakdown of all the values
        Console.WriteLine($"Breakdown: {money_.coinBreakdown()}");
    }
}