using System;

class MainProgram
{
    static void Main(string[] args)
    {

        //variables 

        var name = "John";

        Console.WriteLine(name);

        name = name + " Doe";

        Console.WriteLine(name);
        var height = 1.75;
        var isStudent = true;
        var grade = 'A';
        var message = "Hello, World!";
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var person = new { Name = "Alice", Age = 25 };
        var nullableInt = (int?)null;


        //data types

        //INTEGERS
        int age = 30;
        //VARIABLES
        var city = "New York";

        //double 
        double pi = 3.14159;
        //BOOLEAN
        bool isRaining = false;
        //string
        string greeting = "Hello, World!";
        //character
        char initial = 'J';




        //loops and conditionals

        //if else statement
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote and drive.");

        }
        else if (age >= 16)
        {
            Console.WriteLine("You are eligible to drive.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        //for loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        //while loop
        while (age < 32)
        {
            Console.WriteLine($"You are {age} years old.");
            age++;
        }

        //do while loop
        do
        {
            Console.WriteLine("This will execute at least once.");
            age++;
        } while (age < 34);

        //switch statement
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Good job!");
                break;
            case 'C':
                Console.WriteLine("You can do better.");
                break;
            default:
                Console.WriteLine("Invalid grade.");
                break;
        }

        //foreach loop
        int[] num = { 1, 2, 3, 4, 5 };

        foreach (var x in num) // 'var' automatically becomes 'int'
        {
            Console.WriteLine(x);
        }


        //break / continue
        for(int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // exits the loop when i is 5
            }
            Console.WriteLine(i);
            if(i == 6)
            {
                continue; // skips the rest of the loop when i is 6
            }
        }

        //comparison operators
        int a = 10;
        int b = 5;

        Console.WriteLine(a == b); // false
        Console.WriteLine(a != b); // true
        Console.WriteLine(a > b);  // true
        Console.WriteLine(a < b);  // false
        Console.WriteLine(a >= b); // true
        Console.WriteLine(a <= b); // false


        //logical operators 
        //AND (&&), OR (||), NOT (!)
        int ages = 20;
        bool hasLicense = true;

        if (ages >= 18 && hasLicense)
        {
            Console.WriteLine("Can drive");

        }

        int marks = 35;

        if (marks >= 40 || marks == 35)
        {
            Console.WriteLine("Grace pass");
        }

        bool isLoggedIn = false;

        if (!isLoggedIn)
        {
            Console.WriteLine("Please login");
        }


    }
}
