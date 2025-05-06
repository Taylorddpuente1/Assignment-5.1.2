// Write a program to create a function to calculate the sum of individual digits of a given number.

using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    { 
 Console.WriteLine(" Please enter numbers:  ");
  int myNum = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        while  (myNum > 0)
        {
            sum = sum + myNum % 10; 
            myNum  /= 10;
        }
        Console.WriteLine("The sum of the digits is : " + sum);
        }
    }

