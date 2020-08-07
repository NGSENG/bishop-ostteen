namespace NextGear.ProgrammingChallenge.Core
{
    public interface IDevice
    {
        string Id { get; set; }
        DeviceType DeviceType { get; set; }
        DeviceState DeviceState { get; set; }
        string Name { get; set; }
}
}
