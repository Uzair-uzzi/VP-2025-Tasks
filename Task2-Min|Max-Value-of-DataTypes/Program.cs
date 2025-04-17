using System;

class Program
{
    static void Main()
    {
        // Integer Types:
        Console.WriteLine("Integer Types:");
        //Min & Max Value in Byte:
        Console.WriteLine("byte:    Min = {byte.MinValue},    Max = {byte.MaxValue}");
        //Min & Max Value in sByte:
        Console.WriteLine("sbyte:   Min = {sbyte.MinValue},   Max = {sbyte.MaxValue}");
        //Min & Max Value in Short:
        Console.WriteLine("short:   Min = {short.MinValue},   Max = {short.MaxValue}");
        //Min & Max Value in uShort:
        Console.WriteLine("ushort:  Min = {ushort.MinValue},  Max = {ushort.MaxValue}");
        //Min & Max Value in Int:
        Console.WriteLine("int:     Min = {int.MinValue},     Max = {int.MaxValue}");
        //Min & Max Value in Long
        Console.WriteLine("long:    Min = {long.MinValue},    Max = {long.MaxValue}");
        Console.WriteLine();

        // Floating Point Types
        Console.WriteLine("Floating-Point Types:");
        //Min & Max Value in float:
        Console.WriteLine("float:   Min = {float.MinValue},   Max = {float.MaxValue}");
        //Min & Max Value in double:
        Console.WriteLine("double:  Min = {double.MinValue},  Max = {double.MaxValue}");
        //Min & Max Value in decimal:
        Console.WriteLine("decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");
        Console.WriteLine();

        // Char Type
        Console.WriteLine("Char Type:");
        //Min & Max Value in char:
        Console.WriteLine("char:    Min = {(int)char.MinValue}, Max = {(int)char.MaxValue}");
        Console.WriteLine();

        // Bool Type (only true/false)
        Console.WriteLine("Boolean Type:");
        //Min & Max Value in bool:
        Console.WriteLine("bool:    Values = true, false");
    }
}
