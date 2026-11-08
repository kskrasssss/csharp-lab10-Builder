namespace Lab_10;

public class BookingDirector
{
    public Booking BuildChildTrip(BookingBuilder builder, string client, string plate, DateTime start) =>
        builder.ForClient(client)
               .WithCar(plate)
               .StartingAt(start)
               .WithChildSeat()
               .WithExtraInsurance()
               .WithComment("Поїздка з дитиною")
               .Build();

    public Booking BuildAirportTrip(BookingBuilder builder, string client, string plate, DateTime start, string address) =>
        builder.ForClient(client)
               .WithCar(plate)
               .StartingAt(start)
               .DeliveredTo(address)
               .WithComment("Аеропорт")
               .Build();
}