using System;

namespace NextGear.ProgrammingChallenge.Core
{
    public interface IDeviceReading
    {
        DateTime timeStamp { get; set; }
        string Value { get; }
    }
}
