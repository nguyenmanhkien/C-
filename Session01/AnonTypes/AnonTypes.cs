﻿// See https://aka.ms/new-console-template for more information
class AnonTypes
{
    static void Main(string[] args)
    {
        var pl = new { Name = "A", Price = 3 };
        Console.WriteLine("Name = {0} \nPrice = {1}", pl.Name.ToLower(), pl.Price);
        Console.ReadLine();
    }
}
