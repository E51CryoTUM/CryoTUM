## "Legacy" LabVIEW Drivers for AMI Magnet Systems

### Version 5.04, 12 Dec 2018

NOTE: These drivers are identical in features to the 5.03 release, however they now will load in LabVIEW version 8.2.1 or later (instead of 8.5). Also, some minor issues were fixed including the loading path -- all VI's now should load from the filesystem hierarchy herein rather than relying on user library locations.

Some of the instruments supported (such as the AMI Model 420, Neocera LTC-21, and Lakeshore 332) are no longer in production as of 2018. Therefore, this driver tree is labeled "legacy".

--------------------------------
The included drivers are designed to operate with LabVIEW version 8.2.1 or higher, and require a LabVIEW-supported GPIB card, serial interface or an Ethernet interface.

The virtual instruments (VI) should be compatible with LabVIEW installations on other operating systems, but this is untested. 

Drivers and example integrated panels are included for the AMI Model 420/430 Digital Power Supply Programmer, the AMI 135 Liquid Helium Level Monitor, the Lakeshore 332 Temperature Controller, and the Neocera LTC-21 Temperature Controller.

The "example" VI's illustrate one way to use the lower level VI's for each instrument in an integrated control panel. The user may customize the examples or develop a custom panel to perform the specific actions required by an experiment.

The VI's are self-documenting. You can discover details about the exact function of the VI by exploring the contents of each.

Only a subset of commands for the Model 420/430, the Neocera LTC-21 and the Lakeshore 332 are currently supported. However, note that the Command and Query VI's for the instruments can be easily customized by simply modifying the command string sent to the instrument as well as the input control types and labels.


### Model 420/430 Connection Options:
The VIs provide a number of options for interfacing a host computer to the AMI Model 420 and Model 430 Power Supply Programmers.

The Model 430 can be directly connected to the host computer via either Ethernet (TCP/IP) or RS-232.  If an IEEE488 (GPIB) connection to a Model 430 is desired, a GPIB-RS232 converter from National Instruments can be inserted between the GPIB network and the RS-232 port on the Model 430.  This solution requires the user to select the IEEE488 "active comm interface" in the VI.

The Model 420 can be directly connected to the host computer via either RS-232 or IEEE488 (GPIB).  If an Ethernet (TCP/IP) connection to a Model 420 is desired, a GPIB-ENET/100 converter from National Instruments can be inserted between the Ethernet network and the GPIB interface to the Model 420.  This solution requires the user to select the IEEE488 "active comm interface" in the VI.



Included is a short description of each example VI:



Current Example.vi
------------------
This VI provides an example of controlling current in a superconducting magnet with an AMI Model 420/430 Power Supply Programmer (see Model 420/430 Connection Options discussion above).




Field Example.vi
-----------------------
Identical to the previous VI, except the control and display is in units of kilogauss.




Field and Temp (332) Example.vi
-------------------------------
Requires a Lakeshore 332 Temperature Controller on a GPIB bus. It also requires connection to an AMI Model 420/430 (see Model 420/430 Connection Options discussion above).  It provides an example of controlling the field in a magnet, and monitoring/controlling a single temperature.




Field and Temp (LTC-21) Example.vi
----------------------------------
Requires a Neocera LTC-21 Temperature Controller on a GPIB bus. It also requires connection to an AMI Model 420/430 (see Model 420/430 Connection Options discussion above).  It provides an example of controlling the field in a magnet, and monitoring/controlling a single temperature.




Field, Temp (332), and Level Example.vi
------------------------------------------
Requires an AMI Model 135 and Lakeshore 332 on a GPIB bus. It also requires connection to an AMI Model 420/430 (see Model 420/430 Connection Options discussion above).  It provides an example of controlling the field in a magnet, monitoring/controlling a temperature, and monitoring the liquid helium level in a dewar.  Automatic rampdown of the magnet is initiated if the low level alarm of the AMI Model 135 is triggered.




Field, Temp (LTC-21), and Level Example.vi
------------------------------------------
Requires an AMI Model 135 and Neocera LTC-21 on a GPIB bus. It also requires connection to an AMI Model 420/430, (see Model 420/430 Connection Options discussion above).  It provides an example of controlling the field in a magnet, monitoring/controlling a temperature, and monitoring the liquid helium level in a dewar.  Automatic rampdown of the magnet is initiated if the low level alarm of the AMI Model 135 is triggered.




Known problems:

1. The Model 420 will sometimes indicate a "Query Interrupted" error. The cause of this problem is under investigation. The problem only seems to occur within LabVIEW during tests at AMI, and the frequency of the error changes from computer to computer. This error does not cause the VI to exit, however it may result in rare momentary pauses and/or incomplete query results.




If you have questions, contact:

American Magnetics, Inc.
(865) 482-1056

Internet e-mail:
support@americanmagnetics.com

World Wide Web:
http://www.americanmagnetics.com/
