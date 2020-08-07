using System.Collections.Generic;

namespace NextGear.ProgrammingChallenge.Core
{
    public interface IDeviceRepository
    {
        IDevice GetDeviceById(string deviceId);
        IEnumerable<IDevice> GetAllDevices();
        IEnumerable<IDeviceReading> GetDeviceReadings(IDevice device);
    }
}
