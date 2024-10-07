using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Please provide a number.");
        int userNum = Convert.ToInt32(Console.ReadLine());
        DateTime addTime = DateTime.Now.AddHours(userNum);
        Console.WriteLine(addTime);
        Console.ReadLine();
    }
}