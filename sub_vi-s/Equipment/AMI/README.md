## AMI Drivers

These folders include example LabVIEW VI's for AMI equipment. All provided VI's are fully editable. The folder hierarchy is important, so download all files under each top level folder (if not the [entire repository](https://bitbucket.org/americanmagneticsinc/ami-drivers/get/21ca0f87278d.zip)) in order to ensure all necessary VI's are available to load in LabVIEW.



### LabVIEW Drivers

Latest version 6.0 collection of LabVIEW VI's for remote control of the Model 430 and Model 1700. The connection method is now exclusively through [NI-VISA](https://www.ni.com/visa/) via Ethernet or serial interface.

**Firmware version 3.07 or later is required in the Model 430 (firmware 2.57 or later in legacy devices).** Use the [Magnet-DAQ](https://bitbucket.org/americanmagneticsinc/magnet-daq) application's integrated Firmware Upgrade Wizard to easily upgrade the Model 430 firmware.

Also included is an example of how to communicate from LabVIEW to the [Multi-Axis Operation](https://bitbucket.org/americanmagneticsinc/multi-axis-operation) open source application provided by AMI, which allows use of a higher level API to drive AMI Maxes(tm) multi-axis superconducting magnet systems. This example is presently only tested on 32-bit LabVIEW for Windows products as it requires a DLL to manage pipe-based communication on Windows.

Requires LabVIEW version 8.2.1 or later. Further documentation is available within the folder.



### Legacy LabVIEW Drivers

Version 5.03 legacy drivers for various AMI instruments with older firmware (*Model 430 prior to firmware version 2.57*) or are currently out of active production such as the Model 420, Model 13x, and Model 18x series.

Limited support of some selected 3rd party instruments is also provided which are now also out of active production.

Requires LabVIEW version 8.2.1 or later. Further documentation is available within the folder.



## Who do I talk to?

<support@americanmagnetics.com>