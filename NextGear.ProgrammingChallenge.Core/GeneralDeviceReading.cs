using System;

namespace NextGear.ProgrammingChallenge.Core
{
    public class GeneralDeviceReading : IDeviceReading
    {
        public GeneralDeviceReading(DateTime dtTimeStamp, string strVal)
        {
            timeStamp = dtTimeStamp;
            Value = strVal;
        }

        public DateTime timeStamp { get; set; }
        public string Value { get; }
    }
}
