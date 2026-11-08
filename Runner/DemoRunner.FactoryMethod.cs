namespace Lab_10;

// Розширення: нова оренда «вихідні», RentalService не змінюється
public class WeekendTrip : Trip
{
    public const decimal PricePerWeekend = 1500.00m;

    public WeekendTrip(string plate, string client, int minutes) : base(plate, client, minutes) { }

    public override string RentalKind => "Вихідні";
    public override decimal CalculateCost() => PricePerWeekend;   // фіксована ціна за вихідні
}

public class WeekendRentalService : RentalService
{
    protected override string Name => "Оренда-вихідні";
    protected override Trip CreateTrip(string plate, string client, int minutes) => new WeekendTrip(plate, client, minutes);
}

public static partial class DemoRunner
{
    public static void RunRentalScenario()
    {
        Log.Section("Завдання 2. Factory Method: види оренди");

        const int threeHours = 180;

        RentalService[] services =
        {
            new MinuteRentalService(),
            new HourlyRentalService(),
            new DailyRentalService()
        };

        foreach (var service in services)
            service.Rent("CE1234AA", "Ткачук", threeHours);   // один і той самий процес

        Log.Write("Сценарій", "Додаємо оренду «вихідні»: нові класи, загальний процес не змінюється");
        new WeekendRentalService().Rent("CE2345BB", "Мельник", threeHours);
    }
}