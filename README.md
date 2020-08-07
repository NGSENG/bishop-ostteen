#Programming Challenge

Scenario:

This is a fictitious project in which our team contracted with a fictitious vendor to build us a REST service and a website.  The website allows Next Gear Solutions customers to know what is going on in their home via their devices.  The fictitious vendor completed the work, but the result was not satisfactory.  Neither the website nor the REST service work as expected.

Your challenge is to:

•	Review the code for the REST service and the website.  Write up any comments you may have concerning the code and any ideas you can think of to improve it.  The code was very poorly written and doesn’t conform to any accepted standard.  We expect a lot of comments.
•	Get the code working and send us the fixed code.  Be prepared to discuss and defend your approach with a team of developers.
•	Write unit tests to verify the REST service and the website work as expected.  Bonus points if you include unit tests for the JavaScript.

Extra credit if you can:

•	Refactor the code so that it is clean, maintainable, and extensible.  Ideally, the refactored code should conform to SOLID principles.
•	Identify ways to make the system more secure and scalable.  Assume the finished product will be used by millions of users in a cloud-based environment.  Performance, security, and scalability will be very important.
•	Include mocks in your unit tests.
•	Add support for additional device types, such as lightbulbs, security cameras, baby monitors, etc.

Application Overview and Assumptions

The application is an Internet website that allows our customers to know what is going on in their homes via their Next Gear Solutions Internet connected devices.  
Assumptions
Assume that Next Gear Solutions currently only manufactures a thermostat and a water leak detector for home use.

Assume the system only supports one thermostat and one water leak detector per customer.  Additional device types and/or multiple devices are not yet supported.

Also, for the purpose of this exercise, the data provided by the devices are in text files.  Assume the data cannot be modified.  The application will need to account for dirty data, such as control characters, etc.

Assume all dates provided by the devices are UTC.  The website will need to display dates in the customer’s local time zone.
Website Requirements
Thermostat
•	Display the most recent temperature measured by the thermostat.  The temperature should be viewable in both Fahrenheit and Celsius
•	Display the average temperature for the current day
•	Display a grid showing the current day’s temperature based on times
•	Display a fault notification if the thermostat detects a fault in its sensor

Water Leak Detector
•	Display a notification if a water leak is detected.  The notification should consist of the time the leak was detected as well as the location of the leak
•	Display a fault notification if the water leak detector detects a sensor fault

Device Data Format

Thermostat
The thermostat provides data as XML.  Here is an example of the data:

<thermostat>
	<id=”Living Room” />
	<currentStatus state=”OK”>
		<faultCode />
	</currentStatus>
	<readings>
		<reading dateTime=”2016-01-31T14:00:22Z”>
			<temperature>65</temperature>
			<temperatureFormat>Fahrenheit</temperatureFormat>
</reading>
<reading dateTime=”2016-01-31T13:00:22Z”>
			<temperature>64</temperature>
			<temperatureFormat>Fahrenheit</temperatureFormat>
</reading>
	</readings>
</thermostat>

Water Leak Detector
The water leak detector provides data as JSON:

[{
	isFaulted:false,
	faultCode:””,
	location:”Basement Laundry”,
	readings:[
		{
			timestamp: ”2016-01-31T13:00:22Z”,
			leakDetected:false
		}
]
},
{
isFaulted:true,
	faultCode:”0x65F”,
	location:”Basement Family Room”,
	readings:[
		{
			timestamp: ”2016-01-31T14:00:22Z”,
			leakDetected:false
		}
]
}]
