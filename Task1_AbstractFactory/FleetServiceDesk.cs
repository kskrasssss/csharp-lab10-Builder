namespace Lab_10;

public class FleetServiceDesk
{
    public void CommissionCar(string plate, IVehicleKitFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory);

        Log.Write("Служба парку", $"Введення в роботу {plate} ({factory.VehicleType})");

        var telematics = factory.CreateTelematics();
        var card = factory.CreateEnergyCard();
        var sensor = factory.CreateLevelSensor();

        Log.Write("Служба парку", $"  Телематика: {telematics.Describe()}");
        Log.Write("Служба парку", $"  Картка:     {card.Describe()}");
        Log.Write("Служба парку", $"  Датчик:     {sensor.Describe()}");
        Log.Write("Служба парку", $"  Набір {plate} повністю належить типу «{factory.VehicleType}»");
    }
}