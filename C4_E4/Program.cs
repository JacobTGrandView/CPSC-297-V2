using System;

class Employee
{
    int EmpNumber { get; }
    string FirstName { get; }
    string LastName { get; }
    DateTime DateOfHire { get; }
    string JobDescription { get; }
    string Department { get; }
    decimal MonthlySalary { get; }

    public Employee(int empNumber,
                    string firstName,
                    string lastName,
                    DateTime dateOfHire,
                    string jobDescription,
                    string department,
                    decimal monthlySalary)

    {
        EmpNumber = empNumber;
        FirstName = firstName;
        LastName = lastName;
        DateOfHire = dateOfHire;
        JobDescription = jobDescription;
        Department = department;
        MonthlySalary = monthlySalary;
    }

    string FullName => $"{FirstName} {LastName}";

    // Different format for sorting
    string SortableName => $"{LastName}, {FirstName}";

    public override string ToString()
    {
        return $"Employee Number: {EmpNumber}\n" + // new lines
                $"Full Name: {FullName}\n" +
                $"Sortable Name: {SortableName}\n" +
                $"Date of Hire: {DateOfHire.ToShortDateString()}\n" +
                $"Job Description: {JobDescription}\n" +
                $"Department: {Department}\n" +
                $"Monthly Salary: {MonthlySalary:C}"; // Display as currency string
    }

    public static void Main(string[] args)
    {
        var employee1 = new Employee(1, "J", "T", new DateTime(2002, 5, 8),
                                        "Coding man", "Coding department", 6000);

        var employee2 = new Employee(2, "Jacob", "Thomas", new DateTime(2024, 4, 7),
                                        "Man of code", "Department of Code", 5500);

        Console.WriteLine(employee1);
        Console.WriteLine(employee2);
    }
}