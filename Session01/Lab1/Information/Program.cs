// See https://aka.ms/new-console-template for more information
using System;
class Information
{
    static void Main(string[] args)
    {
        string name;
        string address;
        string phone;
        var i1 = new { name = "Kien", address = "Bac Giang", phone = "0963398856" };
        Console.WriteLine(i1);
    }
}
