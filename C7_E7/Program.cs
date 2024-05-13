using System;

class stateAreaCodes // state area code class
{

    // data member array to store area codes
    private string[] areaCodes;

    // initialize class with array of area codes
    public stateAreaCodes(string[] codes)

    {
        areaCodes = codes;
    }

    // method to test if area code is in the state exchange
    public bool testCode(string code)
    {
        // predefined method of array class to see if code exists in array
        return Array.IndexOf(areaCodes, code) != -1; // if value found, it won't return -1. If not found, return -1. true and false
    }

    // override ToString method for full list of area codes
    public override string ToString()
    {
        // each area code surrounded by parentheses
        return "(" + string.Join("), (", areaCodes) + ")";
    }
}


class testingCodes
{
    static void Main(string[] args)
    {
        // test array of codes
        string[] stateCodes = { "515", "414", "313" };

        // instance of our first class with testing array from above
        stateAreaCodes areaCodesState = new stateAreaCodes(stateCodes);

        // test the testCode method
        Console.WriteLine("Area code '515': " + areaCodesState.testCode("515")); // 515 in stateCodes array. returns true
        Console.WriteLine("Area code '111': " + areaCodesState.testCode("111")); // 111 not in the stateCodes array. returns false

        // test ToString method
        Console.WriteLine("Area codes: " + areaCodesState.ToString());
    }
}