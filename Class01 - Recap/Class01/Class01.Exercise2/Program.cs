List<(int Day, int Month)> holidays = new List<(int, int)>()
{
    (1, 1),
    (7, 1),
    (20, 4),
    (1, 5),
    (25, 5),
    (3, 8),
    (8, 9),
    (12, 10),
    (23, 10),
    (8, 12)
};

while (true)
{
    Console.WriteLine("Enter a date (day.month):");
    DateTime date = Convert.ToDateTime(Console.ReadLine());

    bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    bool isHoliday = false;

    if ((date.Day == 1 && date.Month == 1) ||
          (date.Day == 7 && date.Month == 1) ||
          (date.Day == 20 && date.Month == 4) ||
          (date.Day == 1 && date.Month == 5) ||
          (date.Day == 25 && date.Month == 5) ||
          (date.Day == 3 && date.Month == 8) ||
          (date.Day == 8 && date.Month == 9) ||
          (date.Day == 12 && date.Month == 10) ||
          (date.Day == 23 && date.Month == 10) ||
          (date.Day == 8 && date.Month == 12))
    {
        isHoliday = true;
    }

    if (isWeekend || isHoliday)
    {
        Console.WriteLine("Not a working day!");
    }
    else
    {
        Console.WriteLine("Working day!");
    }

    Console.WriteLine("Check another date (yes/no): ");
    string answer = Console.ReadLine();

    if (answer != "yes")
    {
        break;
    }

    Console.WriteLine();
}


