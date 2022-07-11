﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class SwapNumber
{
    static void Swap<T>(ref T valOne, ref T valTwo)
    {
        T temp = valOne;
        valOne = valTwo;
        valTwo = temp;
    }

    static void Main(string[] args)
    {
        int numOne = 32;
        int numTwo = 40;
        Console.WriteLine("Values before swapping: " + numOne + "&" + numTwo);
        Swap<int>(ref numOne, ref numTwo);
        Console.WriteLine("Values after swapping: " + numOne + "&" + numTwo);
    }
}
