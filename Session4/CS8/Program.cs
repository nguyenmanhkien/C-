﻿// See https://aka.ms/new-console-template for more information
public int num = 1;
Console.WriteLine("Even Numbers”);
while (num <= 11)
{
    if ((num % 2) == 0)
    {
        Console.WriteLine(num);
    }
    num = num + 1;
}
