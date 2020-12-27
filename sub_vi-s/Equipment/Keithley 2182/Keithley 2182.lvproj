<?xml version='1.0'?>
<Project Type="Project" LVVersion="8208002">
	<Property Name="Instrument Driver" Type="Str">True</Property>
	<Property Name="NI.Project.Description" Type="Str">This project is used by developers to edit API and example files for LabVIEW Plug and Play instrument drivers.</Property>
	<Item Name="My Computer" Type="My Computer">
		<Property Name="CCSymbols" Type="Str">OS,Win;CPU,x86;</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Examples" Type="Folder">
			<Item Name="Keithley 2182 Data Buffer Store and Acquire.vi" Type="VI" URL="Examples/Keithley 2182 Data Buffer Store and Acquire.vi"/>
			<Item Name="Keithley 2182 Relative Measurement.vi" Type="VI" URL="Examples/Keithley 2182 Relative Measurement.vi"/>
			<Item Name="Keithley 2182 Ratio Calculation.vi" Type="VI" URL="Examples/Keithley 2182 Ratio Calculation.vi"/>
			<Item Name="Keithley 2182.bin3" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Examples/Keithley 2182.bin3"/>
		</Item>
		<Item Name="Keithley 2182.lvlib" Type="Library" URL="Keithley 2182.lvlib">
			<Item Name="Public" Type="Folder">
				<Item Name="Action-Status" Type="Folder">
					<Item Name="Action-Status.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Action-Status/Action-Status.mnu"/>
					<Item Name="Clear Buffer.vi" Type="VI" URL="Public/Action-Status/Clear Buffer.vi"/>
					<Item Name="Enable Buffer Storage.vi" Type="VI" URL="Public/Action-Status/Enable Buffer Storage.vi"/>
					<Item Name="Clear Limit.vi" Type="VI" URL="Public/Action-Status/Clear Limit.vi"/>
					<Item Name="Acquire Relative Reading.vi" Type="VI" URL="Public/Action-Status/Acquire Relative Reading.vi"/>
					<Item Name="Bypass Trigger Source.vi" Type="VI" URL="Public/Action-Status/Bypass Trigger Source.vi"/>
				</Item>
				<Item Name="Configure" Type="Folder">
					<Item Name="Calculations" Type="Folder">
						<Item Name="Calculations.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Configure/Calculations/Calculations.mnu"/>
						<Item Name="Configure Math Calculations.vi" Type="VI" URL="Public/Configure/Calculations/Configure Math Calculations.vi"/>
						<Item Name="Configure Linear Math Calculation.vi" Type="VI" URL="Public/Configure/Calculations/Configure Linear Math Calculation.vi"/>
						<Item Name="Configure Percent Math Calculation.vi" Type="VI" URL="Public/Configure/Calculations/Configure Percent Math Calculation.vi"/>
						<Item Name="Configure Limit Testing.vi" Type="VI" URL="Public/Configure/Calculations/Configure Limit Testing.vi"/>
					</Item>
					<Item Name="Measurements" Type="Folder">
						<Item Name="Measurements.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Configure/Measurements/Measurements.mnu"/>
						<Item Name="Configure Measurements.vi" Type="VI" URL="Public/Configure/Measurements/Configure Measurements.vi"/>
						<Item Name="Configure Voltage Parameters.vi" Type="VI" URL="Public/Configure/Measurements/Configure Voltage Parameters.vi"/>
						<Item Name="Configure Temperature Parameters.vi" Type="VI" URL="Public/Configure/Measurements/Configure Temperature Parameters.vi"/>
						<Item Name="Configure Relative Reading.vi" Type="VI" URL="Public/Configure/Measurements/Configure Relative Reading.vi"/>
						<Item Name="Configure Analog Filter.vi" Type="VI" URL="Public/Configure/Measurements/Configure Analog Filter.vi"/>
						<Item Name="Configure Digital Filter.vi" Type="VI" URL="Public/Configure/Measurements/Configure Digital Filter.vi"/>
						<Item Name="Configure Reading Hold.vi" Type="VI" URL="Public/Configure/Measurements/Configure Reading Hold.vi"/>
						<Item Name="Enable Low Charge Injection Mode.vi" Type="VI" URL="Public/Configure/Measurements/Enable Low Charge Injection Mode.vi"/>
					</Item>
					<Item Name="Trigger" Type="Folder">
						<Item Name="Trigger.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Configure/Trigger/Trigger.mnu"/>
						<Item Name="Configure Trigger.vi" Type="VI" URL="Public/Configure/Trigger/Configure Trigger.vi"/>
					</Item>
					<Item Name="Configure.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Configure/Configure.mnu"/>
					<Item Name="Configure Buffer.vi" Type="VI" URL="Public/Configure/Configure Buffer.vi"/>
					<Item Name="Configure Scanning.vi" Type="VI" URL="Public/Configure/Configure Scanning.vi"/>
					<Item Name="Configure Analog Output.vi" Type="VI" URL="Public/Configure/Configure Analog Output.vi"/>
					<Item Name="Autozero.vi" Type="VI" URL="Public/Configure/Autozero.vi"/>
					<Item Name="Enable Line Cycle Synchronization.vi" Type="VI" URL="Public/Configure/Enable Line Cycle Synchronization.vi"/>
				</Item>
				<Item Name="Data" Type="Folder">
					<Item Name="Low-level" Type="Folder">
						<Item Name="Low-level.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Data/Low-level/Low-level.mnu"/>
						<Item Name="Abort.vi" Type="VI" URL="Public/Data/Low-level/Abort.vi"/>
						<Item Name="Initiate.vi" Type="VI" URL="Public/Data/Low-level/Initiate.vi"/>
					</Item>
					<Item Name="Data.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Data/Data.mnu"/>
					<Item Name="Read.vi" Type="VI" URL="Public/Data/Read.vi"/>
					<Item Name="Read Latest Measurement.vi" Type="VI" URL="Public/Data/Read Latest Measurement.vi"/>
					<Item Name="Read Math Calculation.vi" Type="VI" URL="Public/Data/Read Math Calculation.vi"/>
					<Item Name="Read Limit Tests.vi" Type="VI" URL="Public/Data/Read Limit Tests.vi"/>
					<Item Name="Read Buffer.vi" Type="VI" URL="Public/Data/Read Buffer.vi"/>
					<Item Name="Read Buffer Statistics.vi" Type="VI" URL="Public/Data/Read Buffer Statistics.vi"/>
				</Item>
				<Item Name="Utility" Type="Folder">
					<Item Name="Utility.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/Utility/Utility.mnu"/>
					<Item Name="Error Query.vi" Type="VI" URL="Public/Utility/Error Query.vi"/>
					<Item Name="Power-on Setup.vi" Type="VI" URL="Public/Utility/Power-on Setup.vi"/>
					<Item Name="Reset.vi" Type="VI" URL="Public/Utility/Reset.vi"/>
					<Item Name="Revision Query.vi" Type="VI" URL="Public/Utility/Revision Query.vi"/>
					<Item Name="Read Internal Temperature.vi" Type="VI" URL="Public/Utility/Read Internal Temperature.vi"/>
					<Item Name="Save Recall Setup.vi" Type="VI" URL="Public/Utility/Save Recall Setup.vi"/>
					<Item Name="Self-Test.vi" Type="VI" URL="Public/Utility/Self-Test.vi"/>
				</Item>
				<Item Name="dir.mnu" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Public/dir.mnu"/>
				<Item Name="Close.vi" Type="VI" URL="Public/Close.vi"/>
				<Item Name="Initialize.vi" Type="VI" URL="Public/Initialize.vi"/>
				<Item Name="VI Tree.vi" Type="VI" URL="Public/VI Tree.vi"/>
			</Item>
			<Item Name="Private" Type="Folder">
				<Item Name="Default Instrument Setup.vi" Type="VI" URL="Private/Default Instrument Setup.vi"/>
				<Item Name="Read Buffer Statistic.vi" Type="VI" URL="Private/Read Buffer Statistic.vi"/>
				<Item Name="Parse Multiple Measurements.vi" Type="VI" URL="Private/Parse Multiple Measurements.vi"/>
				<Item Name="Parse Single Measurement.vi" Type="VI" URL="Private/Parse Single Measurement.vi"/>
			</Item>
			<Item Name="Keithley 2182 Readme.html" Type="Document" URL="/&lt;instrlib&gt;/Keithley 2182/Keithley 2182 Readme.html"/>
		</Item>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="General Error Handler Core CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler Core CORE.vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
