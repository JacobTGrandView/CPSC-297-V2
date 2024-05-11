using System;

// class for take home pay of an employee
class TakeHomePay
{

    // storing employee info here
    public string FirstName { get; set; } // first name
    public string LastName { get; set; } // last name
    public string Id { get; set; } // employee id
    public string Type { get; set; } // salaried or hourly employee


    // Calculate take home pay based on employee type
    public void computePay()
    {

        // take home pay before taxes and all that
        double payBeforeTaxes = 0;

        // if type of employee is salaried, let user enter their salary amount
        if (Type == "salaried")
        {
            Console.Write("Enter salary: ");
            payBeforeTaxes = Convert.ToDouble(Console.ReadLine()) / 52; /* cant divide a string. 52 weeks a year, so
            divide total salary by 52 to find about how much per week */
        }

        // if type of employee is hourly, enter hourly rate and hours per week
        else if (Type == "hourly")
        {
            // how much $ per hour
            Console.Write("Enter hourly rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            // how many hours worked this week
            Console.Write("Enter hours clocked this week: ");
            double weeklyHours = Convert.ToDouble(Console.ReadLine());

            // overtime pay for hourly employees, hours > 40 then pay is 1.5 times base rate
            if (weeklyHours > 40)
            {
                payBeforeTaxes = 40 * hourlyRate + (weeklyHours - 40) * (hourlyRate * 1.5);
            }
            else
            {
                payBeforeTaxes = weeklyHours * hourlyRate;
            }
        }

        // if input isn't either salaried or hourly, return error
        else
        {
            Console.WriteLine("Input hourly or salaried for the type");
            return;
        }


        // Pay deductions
        double federalTax = 0.18 * payBeforeTaxes; // 18% federal tax
        double retirementContribution = 0.10 * payBeforeTaxes; // 10% retirement
        double socialSecurityTax = 0.06 * payBeforeTaxes; // 6% social security

        // Pay afer deductions
        double actualTakeHomePay = payBeforeTaxes - (federalTax + retirementContribution + socialSecurityTax);

        // Display all the info about the employee
        Console.WriteLine("\nFirst name: " + FirstName);
        Console.WriteLine("\nLast name: " + LastName);
        Console.WriteLine("\nId: " + Id);
        Console.WriteLine("\nPay before taxes: " + payBeforeTaxes);
        Console.WriteLine("\nFederal tax: " + federalTax);
        Console.WriteLine("\nRetirement contribution: " + retirementContribution);
        Console.WriteLine("\nSocial security tax: " + socialSecurityTax);
        Console.WriteLine("\nTotal pay after deductions: " + actualTakeHomePay);
    }
}


// Another class to test
class testingClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter id: ");
        string employeeId = Console.ReadLine();

        Console.Write("Enter type: ");
        string employeeType = Console.ReadLine();

        // employee variable refers to the TakeHomePay class
        TakeHomePay employee = new TakeHomePay
        {
            FirstName = firstName,
            LastName = lastName,
            Id = employeeId,
            Type = employeeType
        };

        employee.computePay();
    }
}
