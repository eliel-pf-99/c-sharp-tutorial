internal class Program
{

    struct ImperialMeasurment
    {
        public float feet;

        public ImperialMeasurment(float r)
        {
            this.feet = r;
        }

        public static implicit operator ImperialMeasurment(int m) 
        {
            float convertionResult = 3.28f * m;
            ImperialMeasurment temp = new ImperialMeasurment(convertionResult);
            return temp;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a whole number measuremnt in meters");

        int mm = Convert.ToInt32(Console.ReadLine());

        ImperialMeasurment im = mm;

        Console.WriteLine($"This measurment of {mm} in meters is {im.feet} in feet.");

        Console.ReadKey();
    }
}