namespace Lab_10;

public sealed class Booking
{
    public string Client { get; }
    public string Plate { get; }
    public DateTime StartTime { get; }
    public bool ChildSeat { get; }
    public bool ExtraInsurance { get; }
    public string? DeliveryAddress { get; }
    public string? Comment { get; }

    internal Booking(string client, string plate, DateTime startTime,
        bool childSeat, bool extraInsurance, string? deliveryAddress, string? comment)
    {
        Client = client;
        Plate = plate;
        StartTime = startTime;
        ChildSeat = childSeat;
        ExtraInsurance = extraInsurance;
        DeliveryAddress = deliveryAddress;
        Comment = comment;
    }

    public override string ToString() =>
        $"Бронювання: клієнт {Client}, авто {Plate}, початок {StartTime:dd.MM.yyyy HH:mm}\n" +
        $"  Дитяче крісло: {(ChildSeat ? "так" : "ні")}\n" +
        $"  Додаткове страхування: {(ExtraInsurance ? "так" : "ні")}\n" +
        $"  Подача до адреси: {DeliveryAddress ?? "ні"}\n" +
        $"  Коментар: {Comment ?? "-"}";
}