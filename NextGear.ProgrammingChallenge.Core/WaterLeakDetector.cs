using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NextGear.ProgrammingChallenge.Core
{
    [DataContract]
    public class WaterLeakDetector : IDevice
    {
        [JsonConstructor]
        public WaterLeakDetector(IEnumerable<WaterLeakDetectorReading> readings)
        {
            Readings = readings;
        }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "deviceType")]
        public DeviceType DeviceType { get; set; }

        [DataMember(Name = "deviceState")]
        public DeviceState DeviceState { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "isFaulted")]
        public bool IsFaulted { get; set; }

        [DataMember(Name = "faultCode")]
        public string FaultCode { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "readings")]
        public IEnumerable<WaterLeakDetectorReading> Readings { get; set; } 
    }
}
