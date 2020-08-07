using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NextGear.ProgrammingChallenge.Core;

namespace NextGear.ProgrammingChallenge.Web.Api.Controllers
{
    public class DeviceController : ControllerBase
    {
        private IDeviceRepository _repository;

        public DeviceController(IDeviceRepository deviceRepository)
        {
            _repository = deviceRepository;
        }

        [Route("api/devices")]
        public IActionResult GetDevices()
        {
            return Ok(_repository.GetAllDevices());
        }

        [Route("api/device/{deviceName}")]
        public IActionResult GetDeviceByName(string deviceId)
        {
            try
            {
                return Ok(_repository.GetDeviceById(deviceId));
            }
            catch { }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [Route("api/device/{id}/readings")]
        public IActionResult GetDeviseReadings(string deviceId)
        {
            try
            {
                return Ok(_repository.GetDeviceReadings(_repository.GetDeviceById(deviceId)));
            }
            catch (Exception)
            {
                throw new ApplicationException("Something happend");
            }
        }
    }
}
