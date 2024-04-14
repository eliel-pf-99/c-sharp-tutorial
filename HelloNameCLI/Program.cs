using System; // import System library.

namespace HelloNameCLI // namespace declaration.
{
    class Program // Program class declaration.
    {
        static void Main(string[] args) // Main method is the entry-point of the application, it's essential for executing the program.
        {
            Console.WriteLine("Please enter your name: "); // Print to the console what is inside the quotes. ("") 

            var name = Console.ReadLine(); // Reads what the user enters into the console.

            Console.WriteLine($"Hello {name}"); // Print to the console what is inside the quotes with interpolatio, with the user's response.

            Console.ReadKey(); // Keeps the program running...
        }
    }
}