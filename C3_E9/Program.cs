// Chapter 3 - Programming Exercise 9

using System;

class Program
{
    static void Main(string[] args)
    {
        // Employee name
        string employeeName;

        // Sales amount for the week
        double salesAmount;

        // What we want employee name to be
        Console.WriteLine("Enter employee name: ");

        // Storing the input value
        employeeName = Console.ReadLine();

        // How much sales there were
        Console.WriteLine("Enter sales amount of the week");

        // Store sales amount input value with 2 decimal places to the right
        salesAmount = Convert.ToDouble(Console.ReadLine());

        // constants
        double employeeCommission = 0;
        double federalTaxRate = 0;
        double retirementContribution = 0;
        double socialSecurityRate = 0;

        // Employees take home 7% of sales
        employeeCommission = 0.07 * salesAmount;

        // Federal tax rate is 18%
        federalTaxRate = employeeCommission * 0.18;

        // Retirement contribution is 15%
        retirementContribution = employeeCommission * 0.15;

        // Social security tax rate is 9%
        socialSecurityRate = employeeCommission * 0.09;

        // Calculating total take home pay for employee after taxes and retirement
        employeeCommission = employeeCommission - (federalTaxRate + retirementContribution + socialSecurityRate);

        // Printing the initial sales amount, tax deductions, and finalized amount taken home
        Console.WriteLine("Sales amount before taxes: " + salesAmount);
        Console.WriteLine("Amount taken out for federal taxes: " + federalTaxRate);
        Console.WriteLine("Amount taken out for retirement: " + retirementContribution);
        Console.WriteLine("Amount taken out for social security tax: " + socialSecurityRate);
        Console.WriteLine("Total take home pay is: " + employeeCommission);

        // Wait for user input before exiting
        Console.ReadLine();

    }
}