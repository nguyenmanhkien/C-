// See https://aka.ms/new-console-template for more information
namespace BookStore
{
    ///<summary>The program demonstrates the use of Array class.Class Authors acc
    class Authors
    {
        ///<summary>The entry point for the application.
        static void Main(string[] args)
        {
            // Creating an object of Array class for storing author IDs of type integer
            Array objAuthorID = Array.CreateInstance(typeof(int), 3);
            // Creating objects of Array class for storing author name,address,and state name of type string
            Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);
            // String variable to store user inputs
            string input = "";
            // Accepting the details of authors using the SetValue()method
            for (int i = 0; i < objAuthorNames.Length; i++)
            {
                Console.Write("Enter the ID of author:");
                input = Console.ReadLine();
                objAuthorID.SetValue(Convert.ToInt32(input), i);
                Console.Write("Enter the name of author:");
                input = Console.ReadLine();
                objAuthorNames.SetValue(input, i);
                Console.Write("Enter the address:");
                input = Console.ReadLine();
                objAddress.SetValue(input, i);
                Console.Write("Enter the name of state:");
                input = Console.ReadLine();
                objState.SetValue(input, i);
                Console.WriteLine();
            }

            Console.WriteLine("\n Details of the authors: \n");
            Console.WriteLine("Author ID \tName \tAddress \t\t\tState");
            for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
            {
                Console.Write(objAuthorID.GetValue(i) + "\t \t");
                Console.Write(objAuthorNames.GetValue(i) + "\t");
                Console.Write(objState.GetValue(i) + "\t");
                Console.Write(objState.GetValue(i));
            }

            Array.Sort(objAuthorNames);

             Console.WriteLine("\n Author names after sorting: \n");
             for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
             {
                Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
             }
            
        }
    }
}