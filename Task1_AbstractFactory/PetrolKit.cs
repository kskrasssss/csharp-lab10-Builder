namespace Lab_10;

public class PetrolTelematics : ITelematicsModule
{
    public string Describe() => "Телематика ICE (CAN-шина двигуна внутрішнього згоряння)";
}

public class FuelCard : IEnergyCard
{
    public string Describe() => "Паливна картка (АЗС)";
}

public class FuelLevelSensor : ILevelSensor
{
    public string Describe() => "Датчик рівня пального (поплавковий)";
}

public class PetrolKitFactory : IVehicleKitFactory
{
    public string VehicleType => "Бензинове авто";
    public ITelematicsModule CreateTelematics() => new PetrolTelematics();
    public IEnergyCard CreateEnergyCard() => new FuelCard();
    public ILevelSensor CreateLevelSensor() => new FuelLevelSensor();
}