namespace Lab_10;

public abstract class RentalService
{
    // Загальний процес: описаний один раз і не знає конкретних класів поїздок
    public decimal Rent(string plate, string client, int durationMinutes)
    {
        ValidateRequest(plate, client, durationMinutes);

        Log.Write(Name, $"Перевірено авто {plate} і клієнта {client}");

        Trip trip = CreateTrip(plate, client, durationMinutes);   // фабричний метод
        Log.Write(Name, $"Відкрито поїздку ({trip.RentalKind}): {client} на {plate}");

        Log.Write(Name, $"Поїздку завершено, тривалість {trip.DurationMinutes} хв");

        decimal cost = trip.CalculateCost();
        Log.Write(Name, $"Виставлено оплату: {cost:F2} грн");
        return cost;
    }

    protected abstract string Name { get; }

    // Фабричний метод: підклас вирішує, яку поїздку створити
    protected abstract Trip CreateTrip(string plate, string client, int durationMinutes);

    private static void ValidateRequest(string plate, string client, int durationMinutes)
    {
        if (string.IsNullOrWhiteSpace(plate)) throw new ArgumentException("Не вказано авто.", nameof(plate));
        if (string.IsNullOrWhiteSpace(client)) throw new ArgumentException("Не вказано клієнта.", nameof(client));
        if (durationMinutes <= 0) throw new ArgumentException("Тривалість має бути додатною.", nameof(durationMinutes));
    }
}

public class MinuteRentalService : RentalService
{
    protected override string Name => "Оренда-хвилинна";
    protected override Trip CreateTrip(string plate, string client, int minutes) => new MinuteTrip(plate, client, minutes);
}

public class HourlyRentalService : RentalService
{
    protected override string Name => "Оренда-погодинна";
    protected override Trip CreateTrip(string plate, string client, int minutes) => new HourlyTrip(plate, client, minutes);
}

public class DailyRentalService : RentalService
{
    protected override string Name => "Оренда-добова";
    protected override Trip CreateTrip(string plate, string client, int minutes) => new DailyTrip(plate, client, minutes);
}