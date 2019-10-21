README12.TXT     

This cumulative file contains information e.g. about changes between 
revisions.


2009-03-07
==========

INSTALLATION NOTES

Version 1.2 for LabView 7.1 is delivered as one .zip file for convenient
downloading from our WEB site.

This driver needs no special installation. Create a new subfolder in instr.lib
(e.g. C:\Program Files\National Instruments\Labview 7.1\instr.lib\AVS47IB). Copy
this zip file into the new directory. Do not destroy the
AVS47IB_LV71Driver_ver12.zip file. Future revisions of this driver will have same
names for the INNER  .llb, VI and menu files. The
revision number is shown in the name of the dis. When unzipping a revision,
the new .llb and menu files will overwrite the older ones (unless you use a
new folder with a different name). In case of compatibility problems,
comparison with older libraries is possible only if you have saved the
distribution file of the old revision.

After having unzipped the distribution file, launch LabView 7.1. The AVS47IB
driver should appear in the Instrument Drivers subpalette, which is found inside
the Functions palette. Test the new driver using first the "Discuss with
AVS47IB.vi". After having verified a working communication with the AVS47-IB
box, try the "Getting Started.vi". 
   
The easiest and fastest way to use our driver's VIs in your own application
is by opening the VI-Tree.vi block diagram and by picking the required VIs
from it by using copy and paste. Then you can also read the VI descriptions from
the online help.

In addition so a few cosmetic changes:
- a bug in the VI for reading buffer contents has been corrected
- the VI for reading scan channel results has been changed so, that when 
  the first channel is read, the VI waits for OPC (there was a delay in
  the previous version). After that, waiting must
  be disabled. Then the next channels are read immediately. 
- the driver was tested with AVS47-IB firmware 3R3. No compatibility problems
  with earlier firmware versions are known when writing this.


18 April 2005
==============
Driver version 1.2 for LabView version 7.1 and AVS47-IB firmware
versions 2R0...2R2.

The previous driver versions were compiled with LV5.0. Loading this
driver into LV7.1 produces a lot of warnings and other messages,
all of which are unnecessary and disappear as soon as the old driver
is saved by LV7.1. Driver version 1.2 is saved with LV7.1 and no
messages should appear when opening it.
    Driver 1.1 was written on a 486 computer. Version 1.2 has been 
tested on a 1GHz Pentium III (model LB700 LittleBoard from Ampro 
Computers Inc., USA) and PC104-GPIB controller board from National 
Instruments. 
    The VIs have only some minor cosmetic changes. A history graph 
pane was added to the "Getting Started.vi".    


31 July 1999
==============
Driver version 1.1 for AVS47-IB firmware version 2R0.

LabView uses by default the "system decimal point" in some of its functions.
The AVS47-IB interface, on the other hand, uses only period as the decimal
point. If Windows has been instructed to use comma, an error will result.
The only difference between versions 1.0 and 1.1 is that string conversion
functions are now forced to use period.
    The "Read Scan Results.vi" was equipped with a timeout, which was 
useful when the VI was used for the first time after scan. However, reading
of other scan channels was problematic. The timeout was now changed so
that if it is set to zero, no timeout is signalled. Also the 
"Wait for MAV/OPC/TMO.vi" was changed similarly.

31 July 1999
=============
Driver version 1.1 for AVS47-IB. 

AVS47IB.LLB	1,181,135	1999-07-31	18:08
A47IB_U.LLB	  302,960	1999-07-31	18:08
A47IB_C.LLB	  514,662	1999-02-01	13:29
A47IB_A.LLB	  299,424	1999-07-30	10:56
plus the required menu files .mnu



1 February 1999
===============
Driver version 1.0 for AVS47-IB firmware version 2R0 is launched.

AVS47IB  LLB     1,172,339 02-01-99   1:43p
A47IB_U  LLB       302,560 02-01-99   2:22p
A47IB_C  LLB       514,662 02-01-99   1:29p
A47IB_A  LLB       299,432 02-01-99   2:21p



