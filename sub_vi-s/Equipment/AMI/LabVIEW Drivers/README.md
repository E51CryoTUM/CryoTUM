## LabVIEW Drivers for AMI Magnet Systems

### Version 6.00, 12 Dec 2018

The included drivers are designed to operate with LabVIEW version 8.2.1 or higher, and require a LabVIEW-supported serial interface or an Ethernet interface.

------

The virtual instruments (VI) should be compatible with LabVIEW installations on other operating systems, however this is not presently tested.

These "example" VI's illustrate one way to use the lower level VI's for each instrument in an integrated control panel. The user may customize the examples or develop a custom panel to perform the specific actions required by an experiment.

The VI's are self-documenting. You can discover details about the exact function of the VI by exploring the contents of each including the context Help.

#### Communication Connection Options

The Model 430 or Model 1700 can be directly connected to the host computer via either Ethernet (TCP/IP), which is preferred, or RS-232. Static IP address assignment is recommended in order to avoid the DHCP server from assigning different IP addresses the the same instrument over time.

**Firmware version 3.07 or later is required in the Model 430 (firmware 2.57 or later in legacy devices).** Use the [Magnet-DAQ](https://bitbucket.org/americanmagneticsinc/magnet-daq) application's integrated Firmware Upgrade Wizard to easily upgrade the Model 430 firmware. These VI's make use of alternate port 7185 for stateless Model 430 remote communications without the "Welcome" message.

An example VISA string for the Model 430 is:

**TCPIP0::192.168.1.12::7185::SOCKET**

where 192.168.1.12 is the instrument address, 7185 is the port ID, and SOCKET is the connection type. You can use NI-MAX (Measurement & Automation Explorer) to create an alias for this string under My System > Devices and Interfaces > Network Devices.



### A short description of each example VI:

------

### AMI Instrument Test.vi

This VI provides an interface for testing commands and queries by manual input.



### Current Example.vi

This VI provides an example of controlling current in a superconducting magnet with an AMI Model 430 Power Supply Programmer.



### Field Example.vi

Identical to the previous VI, except the control and display is in units of kilogauss.



### Field and LHe Level Example.vi

Requires an AMI Model 1700 and AMI Model 430.  It provides an example of controlling the field in a magnet and monitoring the liquid helium level in a dewar.  Automatic rampdown of the magnet is initiated if the low level alarm of the AMI Model 1700 is triggered.



### Folder Descriptions

------

### 3-Axis Control

A complex example VI library that builds support for operating a 3-axis AMI Maxes(tm) magnet with all coordinate transformations and ramping calculations performed within LabVIEW. Further development of this approach will likely be minimal, instead focusing on the [Multi-Axis Operation](https://bitbucket.org/americanmagneticsinc/multi-axis-operation) application.



### Common VIs

Command and query VI's used by both Model 430 and Model 1700 communications that utilize NI-VISA.



### LV Process Folder

VI's from a 3rd party that support the creation of persistent pipes on Windows. This is required for the Multi-Axis Operation example.



### Model 430

A collection of command and query VI's to support communication with the AMI Model 430. Refer to the Remote Interface section of the Model 430 manual for detailed descriptions of each function.



### Model 1700

A collection of command and query VI's to support communication with the AMI Model 1700. Refer to the Remote Interface section of the Model 1700 manual for detailed descriptions of each function.



### Multi-Axis Operation

Two examples (1 & 2) of how to communicate from LabVIEW to the [Multi-Axis Operation](https://bitbucket.org/americanmagneticsinc/multi-axis-operation) open source application provided by AMI, which allows use of a higher level API to drive AMI Maxes(tm) multi-axis superconducting magnet systems. All coordinate transformations and ramp rate management is handled from within the Multi-Axis Operation application.

An example settings file, 12345.sav, is included. Replace this file with a saved settings file from within the Multi-Axis Operation application with *specific settings for your target magnet system*.

This example is presently only tested on 32-bit LabVIEW for Windows products as it requires a DLL (lv_proc.dll in the LV Process Folder) to manage pipe-based communication on Windows.



### If you have questions, contact:

American Magnetics, Inc.
(865) 482-1056

Internet e-mail:
support@americanmagnetics.com

World Wide Web:
http://www.americanmagnetics.com/