using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace NextGear.ProgrammingChallenge.Core
{
    public class FileBasedDeviceRepository : IDeviceRepository
    {
        private IConfigurationService _configurationService;
        private IEnumerable<IDevice> _devices;

        public FileBasedDeviceRepository(IConfigurationService configurationService)
        {
        }

        public IDevice GetDeviceById(string deviceId)
        {
            return _devices.First(d => d.Id == deviceId);
        }

        public IEnumerable<IDevice> GetAllDevices()
        {
            _devices = LoadDevices();

            return _devices;
        }

        public IEnumerable<IDeviceReading> GetDeviceReadings(IDevice objDev)
        {
            if (objDev == null)
            {
                throw new ArgumentNullException(nameof(objDev));
            }

            switch (objDev.DeviceType)
            {
                case DeviceType.Thermostat:
                    foreach (var reading in ((Thermostat)objDev).Readings)
                    {
                        yield return new GeneralDeviceReading(DateTime.Parse(reading.ReadingDate),
                            String.Format("{0} {1}", reading.Temperature, reading.TemperatureFormat));
                    }
                    break;
                case DeviceType.WaterLeakDetector:
                    foreach (var reading in ((WaterLeakDetector)objDev).Readings)
                    {
                        yield return new GeneralDeviceReading(DateTime.Parse(reading.Timestamp), reading.LeakDetected.ToString());
                    }
                    break;
                default:
                    throw new Exception("Device not supported yet.");
            }
        }

        private IEnumerable<IDevice> LoadDevices()
        {
            var filePath = _configurationService.DeviceFilesPath;
            var filesToLoad = Directory.GetFiles(filePath);
            var devices = new List<IDevice>();

            foreach (var fileToLoad in filesToLoad)
            {
                var file = File.ReadAllBytes(fileToLoad);
                var data = Encoding.UTF8.GetString(file);

                if (data.IndexOf("Thermostat", StringComparison.Ordinal) >= 0)
                {
                    devices.Add(JsonConvert.DeserializeObject<Thermostat>(data));
                }
                else
                {
                    devices.Add(JsonConvert.DeserializeObject<WaterLeakDetector>(data));
                }
            }

            return devices;
        }
    }
}
