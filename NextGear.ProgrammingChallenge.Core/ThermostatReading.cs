using System.Runtime.Serialization;

namespace NextGear.ProgrammingChallenge.Core
{
    [DataContract]
    public class ThermostatReading
    {
        [DataMember(Name = "dateTime")]
        public string ReadingDate { get; set; }

        [DataMember(Name = "temperature")]
        public string Temperature { get; set; }

        [DataMember(Name = "temperatureFormat")]
        public string TemperatureFormat { get; set; }
    }
}
