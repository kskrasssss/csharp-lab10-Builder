namespace Lab_10;

public class ElectricTelematics : ITelematicsModule
{
    public string Describe() => "Телематика EV (BMS, контроль батареї)";
}

public class ChargingCard : IEnergyCard
{
    public string Describe() => "Зарядна картка (мережа зарядних станцій)";
}

public class BatteryLevelSensor : ILevelSensor
{
    public string Describe() => "Датчик заряду батареї (%)";
}

public class ElectricKitFactory : IVehicleKitFactory
{
    public string VehicleType => "Електромобіль";
    public ITelematicsModule CreateTelematics() => new ElectricTelematics();
    public IEnergyCard CreateEnergyCard() => new ChargingCard();
    public ILevelSensor CreateLevelSensor() => new BatteryLevelSensor();
}