using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    { 
        //Main method where compiler enters
        static void Main(string[] args)
        {
         // this is variable declaration:   
            int age = 20;
            string name = "Boy";
            string semester = "3rd";
            bool pass = true;
            //we cam store values of desired type in a variable which we can use anywhere in the program
            
            //here we gonna use variables:
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Semester : " + semester);
            Console.WriteLine("Promoted : " + pass);

        }
    }
}
