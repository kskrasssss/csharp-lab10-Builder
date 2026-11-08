namespace Lab_10;

public interface ITelematicsModule
{
    string Describe();
}

public interface IEnergyCard
{
    string Describe();
}

public interface ILevelSensor
{
    string Describe();
}

public interface IVehicleKitFactory
{
    string VehicleType { get; }
    ITelematicsModule CreateTelematics();
    IEnergyCard CreateEnergyCard();
    ILevelSensor CreateLevelSensor();
}