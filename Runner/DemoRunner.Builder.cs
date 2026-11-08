namespace Lab_10;

public static partial class DemoRunner
{
    public static void RunBookingScenario()
    {
        Log.Section("Завдання 3. Builder: бронювання авто");

        // Фіксований умовний «зараз» робить сценарій відтворюваним
        var now = new DateTime(2026, 11, 20, 9, 0, 0);
        Func<DateTime> clock = () => now;

        // 1. Бронювання з дитячим кріслом і подачею до адреси
        var booking = new BookingBuilder(clock)
            .ForClient("Ткачук")
            .WithCar("CE1234AA")
            .StartingAt(now.AddHours(2))
            .WithChildSeat()
            .DeliveredTo("Чернівці, вул. Головна, 10")
            .Build();
        Log.Write("Builder", "Сформовано бронювання:");
        Console.WriteLine(booking);

        // 2. Типове бронювання «Аеропорт» через Director
        var director = new BookingDirector();
        var airport = director.BuildAirportTrip(
            new BookingBuilder(clock), "Мельник", "CE2345BB", now.AddHours(5), "Аеропорт Чернівці");
        Log.Write("Director", "Сформовано типове бронювання «Аеропорт»:");
        Console.WriteLine(airport);

        // 3. Спроба завершити без авто
        try
        {
            new BookingBuilder(clock)
                .ForClient("Шевченко")
                .StartingAt(now.AddHours(1))
                .Build();
        }
        catch (BookingBuildException ex)
        {
            Log.Write("Builder", ex.Message);
        }
    }
}