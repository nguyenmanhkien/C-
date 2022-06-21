// See https://aka.ms/new-console-template for more information
class implicitilyTypedLocal
{
    static void Main(string[] args)
    {
        var i = 5;
        var s = "hello";
        var d = 1.0;
        Console.WriteLine("i*i: "+i*i);
        Console.WriteLine("s in upper case: " + s.ToUpper());
        Console.WriteLine("type of d: " + d.GetType());
        Console.ReadLine();
    }
}
