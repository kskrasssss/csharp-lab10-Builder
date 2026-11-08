namespace Lab_10;

public class BookingBuilder
{
    private readonly Func<DateTime> _clock;

    private string? _client;
    private string? _plate;
    private DateTime? _startTime;
    private bool _childSeat;
    private bool _extraInsurance;
    private string? _deliveryAddress;
    private string? _comment;

    // Годинник передається ззовні, щоб перевірка «не в минулому» була відтворюваною
    public BookingBuilder(Func<DateTime>? clock = null)
    {
        _clock = clock ?? (() => DateTime.Now);
    }

    public BookingBuilder ForClient(string client) { _client = client; return this; }
    public BookingBuilder WithCar(string plate) { _plate = plate; return this; }
    public BookingBuilder StartingAt(DateTime time) { _startTime = time; return this; }
    public BookingBuilder WithChildSeat() { _childSeat = true; return this; }
    public BookingBuilder WithExtraInsurance() { _extraInsurance = true; return this; }
    public BookingBuilder DeliveredTo(string address) { _deliveryAddress = address; return this; }
    public BookingBuilder WithComment(string comment) { _comment = comment; return this; }

    // Завершальний крок: перевірка обов'язкового. Неповний об'єкт отримати неможливо
    public Booking Build()
    {
        if (string.IsNullOrWhiteSpace(_client))
            throw new BookingBuildException("Неможливо сформувати бронювання: не вказано клієнта");
        if (string.IsNullOrWhiteSpace(_plate))
            throw new BookingBuildException("Неможливо сформувати бронювання: не обрано автомобіль");
        if (_startTime is null)
            throw new BookingBuildException("Неможливо сформувати бронювання: не вказано час початку");
        if (_startTime.Value < _clock())
            throw new BookingBuildException("Неможливо сформувати бронювання: час початку в минулому");

        return new Booking(_client, _plate, _startTime.Value,
            _childSeat, _extraInsurance, _deliveryAddress, _comment);
    }
}

public class BookingBuildException : Exception
{
    public BookingBuildException(string message) : base(message) { }
}