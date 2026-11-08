namespace Lab_10;

// Розширення: новий тип авто додається лише новими класами
public class GasTelematics : ITelematicsModule
{
    public string Describe() => "Телематика LPG (контроль газової системи)";
}

public class GasCard : IEnergyCard
{
    public string Describe() => "Картка газових заправок (ГБО)";
}

public class GasLevelSensor : ILevelSensor
{
    public string Describe() => "Датчик рівня газу в балоні";
}

public class GasKitFactory : IVehicleKitFactory
{
    public string VehicleType => "Авто на газу";
    public ITelematicsModule CreateTelematics() => new GasTelematics();
    public IEnergyCard CreateEnergyCard() => new GasCard();
    public ILevelSensor CreateLevelSensor() => new GasLevelSensor();
}

public static partial class DemoRunner
{
    public static void RunFleetServiceScenario()
    {
        Log.Section("Завдання 1. Abstract Factory: обслуговування авто різних типів");

        var desk = new FleetServiceDesk();

        desk.CommissionCar("CE1234AA", new PetrolKitFactory());
        desk.CommissionCar("CE2345BB", new HybridKitFactory());
        desk.CommissionCar("CE3456CC", new ElectricKitFactory());

        Log.Write("Сценарій", "Додаємо тип «авто на газу»: нові класи, FleetServiceDesk не змінюється");
        desk.CommissionCar("CE4567DD", new GasKitFactory());
    }
}