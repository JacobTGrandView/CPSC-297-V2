using System;

class CustomerCode
{
    // user input full name, birthdate, subscription month (number of month), & zip code
    public string FullName { get; set; }
    public string BirthDate { get; set; }
    public int SubscriptionMonthNumber { get; set; }
    public string ZipCode { get; set; }

    // initialize the customerCode class info
    public CustomerCode(string fullName, string birthDate, int subscriptionMonthNumber, string zipCode)
    {
        FullName = fullName;
        BirthDate = birthDate;
        SubscriptionMonthNumber = subscriptionMonthNumber;
        ZipCode = zipCode;
    }

    // method for making customer code info
    public string MakeCustomerCode()
    {
        // split first and last name using the space between since we want last name only for the code
        string[] name = FullName.Split(' ');

        // Extract last name from the full name and store it in lastName variable
        string lastName = name[name.Length - 1];

        // year of birth. Split the string into array of substrings using / character.
        // Index of 2 is the year since we split it into 3 parts (mm/dd/yyyy)
        // Substring of 2 is accessing the last 2 elements of the year. So 1975 would get 75
        string yearOfBirth = BirthDate.Split('/')[2].Substring(2);

        // Number of characters in full name
        int lengthOfName = FullName.Length;

        // first 3 characters of subscription month. We only care about the subscriptionMonthNumber.
        // 2024 before it and the 1 after it are just placeholders for year and day.
        // .ToString("MMM") Converts month number to month string. Substring(0, 3) says take only first 3 letters of month
        string first3Month = new DateTime(2024, SubscriptionMonthNumber, 1).ToString("MMM").Substring(0, 3);

        // last 2 digits of zip code
        string last2Zip = ZipCode.Substring(ZipCode.Length - 2);

        // generate customer code
        string customerCode = lastName + yearOfBirth + lengthOfName + first3Month + last2Zip;
        return customerCode;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Enter user input
        Console.Write("Enter first and last name with a space in between: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter birthdate using (mm/dd/yyyy) format: ");
        string birthDate = Console.ReadLine();

        Console.Write("Enter month number of subscription purchase: ");
        int subscriptionMonthNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter zip code: ");
        string zipCode = Console.ReadLine();

        // Creating customer object based off customerCode class
        CustomerCode customer = new CustomerCode(fullName, birthDate, subscriptionMonthNumber, zipCode);

        // Print customer code info
        string customerCode = customer.MakeCustomerCode();
        Console.WriteLine($"Customer code is: {customerCode}");
    }
}
