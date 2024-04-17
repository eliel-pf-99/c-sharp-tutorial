using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int employeeId = 0;
        string firstName = String.Empty;
        string lastName = String.Empty;
        decimal annualSalary = 0;
        char gender = '\0';
        bool isManager=  false;

        Console.WriteLine("Please enter a unique Id for this employee");

        employeeId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the employee's first name");

        firstName = Console.ReadLine();

        Console.WriteLine("Please enter the employee's last name");

        lastName = Console.ReadLine();

        Console.WriteLine("Please enter the employee's annual salary");

        annualSalary = Decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

        Console.WriteLine("Please enter the employee's gender ('f' = female, 'm' = male)");

        gender = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("The employee is a manager (true/false)");

        isManager = Convert.ToBoolean(Console.ReadLine());

        string genderTerm = (gender == 'f') ? "female" : "male";

        string managerNarrative = (isManager) ? "part of the management team" : "currently not part of management team";

        string narrative = $"Employee with an Id of {employeeId} ";
        narrative += $"who's full name is {firstName} {lastName}. {Environment.NewLine}";
        narrative += $"is a {genderTerm} employee who is {managerNarrative}.{Environment.NewLine}";
        narrative += $"This employee earns an annual salary of {annualSalary} pounds.";

        Console.Clear();

        Console.WriteLine(narrative);

        Console.ReadKey();


    }
}