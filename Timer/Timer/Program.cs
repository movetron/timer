using System.Runtime.CompilerServices;
using System.Timers;

Console.Write("Время:");
void time(int h, int m, int s)
{
    int countingTime = h * 3600 + m * 60 + s;
    var timer = new System.Timers.Timer(1000);
    timer.Elapsed += (sender, eventArgs) =>
    {
        if (countingTime == 1)
        {
            timer.Dispose();
            Console.Clear();
            Console.WriteLine("Время вышло");
            return;
        }
        countingTime--;
        Console.Clear();
        Console.WriteLine($"Осталось {countingTime} секунды");
    };
    timer.Start();
    Console.ReadLine();
    Console.WriteLine("Повторить, изменить время или выйти?");
    var repeat = Console.ReadLine();
    if (repeat.Contains("повторить") || repeat.Contains("Повторить"))
    {
        time(0, 0, 2);
        Console.ReadKey();
    }
    if (repeat.Contains("изменить") || repeat.Contains("Изменить"))
    {
        Console.WriteLine("Введите часы,минуты,секунды через Enter:");
        h = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        s = int.Parse(Console.ReadLine());
        time(h, m, s);
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Выход");
    }
    Console.ReadKey();
}
time(0, 0, 2);
