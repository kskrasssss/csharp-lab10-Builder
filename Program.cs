using Lab_10;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n=== Лабораторна робота №10 (варіант 8, породжувальні шаблони, ч.2) ===");
    Console.WriteLine("1 - Abstract Factory: обслуговування авто різних типів");
    Console.WriteLine("2 - Factory Method: види оренди");
    Console.WriteLine("3 - Builder: бронювання авто");
    Console.WriteLine("0 - Вихід");
    Console.Write("Ваш вибір: ");

    switch (Console.ReadLine()?.Trim())
    {
        case "1": DemoRunner.RunFleetServiceScenario(); break;
        case "2": DemoRunner.RunRentalScenario(); break;
        case "3": DemoRunner.RunBookingScenario(); break;
        case "0": return;
        default: Console.WriteLine("Невірний вибір"); break;
    }
}