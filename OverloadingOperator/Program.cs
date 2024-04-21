internal class Program
{

    private static void Main(string[] args)
    {
        Rectangle one = new Rectangle(50,50);
        Rectangle two = new Rectangle(25,25);
        Rectangle three = one + two;

        string narrative = $"The first Rectangle is Height: {one.Height} and Weight: {one.Width} \n";
        narrative += $"The second Rectangle is Height: {two.Height} and Weight: {two.Width} \n";
        narrative += $"And the sum of them are: {three.Height} and Weight: {three.Width}";

        Console.WriteLine(narrative);

        Console.ReadKey();
    }
}

public class Rectangle
{
    public int Height = 0;
    public int Width = 0;

    public Rectangle(int Height, int Width)
    {
        this.Height = Height;
        this.Width = Width;
    }

    public static Rectangle operator +(Rectangle left, Rectangle right)
    {
        return new Rectangle(left.Height + right.Height, left.Width + right.Width);
    }
}