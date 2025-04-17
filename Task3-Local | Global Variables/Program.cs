using System;

class VariableScope
{
    // it is a global variable:
    static int globalVariable = 0;
    //Main method:
    static void Main()
    {
        Console.WriteLine("Global Variable (before): " + globalVariable);

        // Local variable
        int localCounter = 5;

        Console.WriteLine("Local Counter (inside Main): " + localCounter);

        // Modify global variable
        globalVariable = 10;

        // Call another method
        DisplayValues();

        // Local variable not accessible here:
        // Console.WriteLine(otherLocal); // here you will get error that is why i commented it.
    }

    static void DisplayValues()
    {
        // Access global variable
        Console.WriteLine("Global Variable (in DisplayValues): " + globalVariable);

        // Local variable
        int otherLocal = 20;
        Console.WriteLine("Local variable in DisplayValues: " + otherLocal);
    }
}
