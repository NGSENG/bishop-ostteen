using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NextGear.ProgrammingChallenge.Core
{
    [DataContract]
    public class Thermostat : IDevice
    {
        [DataMember(Name = "readings")]
        public List<ThermostatReading> Readings { get; set; }

        [DataMember(Name = "deviceId")]
        public string Id { get; set; }

        [DataMember(Name = "deviceClass")]
        public DeviceType DeviceType { get; set; }

        [IgnoreDataMember]
        public DeviceState DeviceState { get; set; }

        [DataMember(Name = "location")]
        public string Name { get; set; }
    }
}
