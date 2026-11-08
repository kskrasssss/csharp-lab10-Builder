namespace Lab_10;

public class HybridTelematics : ITelematicsModule
{
    public string Describe() => "Телематика Hybrid (двигун + тягова батарея)";
}

public class HybridEnergyCard : IEnergyCard
{
    public string Describe() => "Комбінована картка (АЗС + зарядні станції)";
}

public class HybridLevelSensor : ILevelSensor
{
    public string Describe() => "Подвійний датчик (пальне + заряд батареї)";
}

public class HybridKitFactory : IVehicleKitFactory
{
    public string VehicleType => "Гібрид";
    public ITelematicsModule CreateTelematics() => new HybridTelematics();
    public IEnergyCard CreateEnergyCard() => new HybridEnergyCard();
    public ILevelSensor CreateLevelSensor() => new HybridLevelSensor();
}