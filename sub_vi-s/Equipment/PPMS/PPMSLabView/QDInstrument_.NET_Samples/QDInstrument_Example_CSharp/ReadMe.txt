Quantum Design
QDInstrument.dll sample programs

This file contains quick start instructions for sample programs that control Quantum Design 
MultiVu software using QDInstrument.dll and .NET programming languages.

For more detailed instructions on each function, see instructions for the corresponding
LabVIEW VIs in document 1070-210, "Interfacing LabVIEW Programs with PPMS, DynaCool, 
VersaLab, and MPMS3 Systems".

These instructions apply to two projects, one for VB.NET and the other for C#. The projects
are QDInstrument_Example_VB and QDInstrument_Example_CSharp.

Follow these steps to run one of the examples:
1. Start MultiVu. If you want to test this on a desktop computer (no instrument connected),
start MultiVu in simulation mode.

1. Start Visual Studio. These projects will work with Visual Studio Express or one of the 
full versions of Visual Studio, version 2012 or later.

2. Open the project (either QDInstrument_Example_VB.vbproj or 
QDInstrument_Example_CSharp.csproj).

3. Open the main form in code view (either MainForm.vb or MainForm.cs).

4. Set the instrument type. In the method btnConnect_Click, locate the line that starts with 
Instrument = QDInstrumentFactory.GetQDInstrument(QDInstrumentBase.QDInstrumentType.PPMS
If necessary, replace PPMS with either DynaCool, VersaLab, or SVSM. (You might need to press
the "+" next to "Instrument Connection" in order to open that region.)

5. Compile and run the program from Visual Studio.

6. With the example program running, connect to MultiVu by pressing the "Connect" button.
Since you are running MultiVu on the same computer as the program, do not check the "Remote"
checkbox.

7. Press the "Get Temperature" button and verify that the example program reads the same
temperature as MultiVu.

8. Try setting and reading temperature, field, and chamber to verify that these commands
also work.

9 Be sure to close the example program before closing MultiVu. MultiVu acts as an OLE server,
and the example program as client. The client must close before the server.


Tips:

1. QDInstrument.dll must be in the same folder as the executable. The example projects 
accomplish this by setting the "Copy Local" property to be true on the reference to
QDInstrument.dll. If you move the program executable, be sure to copy QDInstrument.dll with
it.

2. Look in the various button click handlers (e.g. btnSetField_Click)  to see how each 
function (e.g. SetField) is used. You can copy the code in these handlers into your program.
(You might need to press "+" buttons next to region names in order to see the code.)

3. The "Position" and "SDO and PPMS Data" tabs on the example program window contain more 
advanced features. See the document 1070-210, "Interfacing LabVIEW Programs with PPMS, 
DynaCool, VersaLab, and MPMS3 Systems" for more details.

4. It is also possible to run the QDInstrument.dll program on a separate computer from
MultiVu. In the example, you do this by checking the "Remote" checkbox and setting the
IP address of the MultiVu computer. The program QDInstrument_Server.exe must be running
on the MultiVu computer. See the document 1070-210, "Interfacing LabVIEW Programs with 
PPMS, DynaCool, VersaLab, and MPMS3 Systems" for more details.
