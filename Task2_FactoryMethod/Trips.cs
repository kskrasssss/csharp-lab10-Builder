namespace Lab_10;

public abstract class Trip
{
    public string Plate { get; }
    public string Client { get; }
    public int DurationMinutes { get; }

    protected Trip(string plate, string client, int durationMinutes)
    {
        Plate = plate;
        Client = client;
        DurationMinutes = durationMinutes;
    }

    public abstract string RentalKind { get; }
    public abstract decimal CalculateCost();
}

public class MinuteTrip : Trip
{
    public const decimal PricePerMinute = 3.00m;

    public MinuteTrip(string plate, string client, int minutes) : base(plate, client, minutes) { }

    public override string RentalKind => "Хвилинна";
    public override decimal CalculateCost() => DurationMinutes * PricePerMinute;
}

public class HourlyTrip : Trip
{
    public const decimal PricePerHour = 120.00m;

    public HourlyTrip(string plate, string client, int minutes) : base(plate, client, minutes) { }

    public override string RentalKind => "Погодинна";

    // Кожна розпочата година оплачується повністю
    public override decimal CalculateCost() => (int)Math.Ceiling(DurationMinutes / 60.0) * PricePerHour;
}

public class DailyTrip : Trip
{
    public const decimal PricePerDay = 900.00m;

    public DailyTrip(string plate, string client, int minutes) : base(plate, client, minutes) { }

    public override string RentalKind => "Добова";

    // Кожна розпочата доба оплачується повністю
    public override decimal CalculateCost() => (int)Math.Ceiling(DurationMinutes / 1440.0) * PricePerDay;
}