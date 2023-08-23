string name;
decimal hourlyCost;
double numberHours;
decimal minimumSalary;
decimal salary;

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.WriteLine("Exercise 06");
Console.WriteLine("===========");

Console.ForegroundColor = ConsoleColor.White;
Console.Write($"Enter minimun Salary...........: ");
minimumSalary = Convert.ToDecimal(Console.ReadLine());
do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    RequestData(out name, out hourlyCost, out numberHours);
    salary = CalculateSalary(numberHours, hourlyCost);
    ShowResults(name, minimumSalary, salary);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
} while (true);

void RequestData(out string name, out decimal hourlyCost, out double numberHours)
{
    Console.Write($"Enter Name.....................: ");
    name = Console.ReadLine();
    Console.Write($"Enter the hourly Cost..........: ");
    hourlyCost = Convert.ToDecimal(Console.ReadLine());
    Console.Write($"Enter number of hours worked...: ");
    numberHours = Convert.ToDouble(Console.ReadLine());
}


void ShowResults(string name, decimal minimumSalary, decimal salary)
{
    Console.WriteLine($"Name...........................: {name}");
    if (salary > minimumSalary)
    {
        Console.WriteLine($"Salary.........................: {salary:C2}");
    }
    else 
    {
        Console.WriteLine($"Salary.........................: {minimumSalary:C2}");
    }
    Console.WriteLine("Press enter to calculate another salary or Ctrl + C to finish.");
    Console.ReadKey();
}

decimal CalculateSalary(double numberHours, decimal hourlyCost)
{
    return (decimal)numberHours * hourlyCost;
}

