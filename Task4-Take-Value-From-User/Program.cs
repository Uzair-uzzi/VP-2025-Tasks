using System;

class UserInputExample
{
    static void Main()
    {
        // Read a string
        Console.Write("Enter your name: ");
        //Here we are taking value from user:
        string name = Console.ReadLine();

        // Read an integer
        Console.Write("Enter your age: ");
        //Here we are taking value from user:
        int age = int.Parse(Console.ReadLine());

        // Output the values
        Console.WriteLine();
        Console.WriteLine("Here is your entered information");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
