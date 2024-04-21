internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int secret = random.Next(50); // Generate a number inside 0 to 49

        Console.WriteLine("Let's Play!");
        Console.WriteLine("Try to guess the secret number");
        Console.WriteLine("Let's try enter with a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number == secret)
        {
            Console.WriteLine("Yeah! You got it!");
        }
        else if(number < secret)
        {
            Console.WriteLine("Sorry, the secret number is more high.");
        }
        else
        {
            Console.WriteLine("Sorry, the secret number is a litte low.");
        }


    }
}