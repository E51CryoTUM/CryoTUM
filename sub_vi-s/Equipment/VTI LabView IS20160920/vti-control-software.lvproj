﻿<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="13008000">
	<Property Name="CCSymbols" Type="Str">enable_status,1;</Property>
	<Property Name="NI.LV.All.SourceOnly" Type="Bool">false</Property>
	<Property Name="NI.Project.Description" Type="Str"></Property>
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="app" Type="Folder">
			<Item Name="app append to log.vi" Type="VI" URL="../app/app append to log.vi"/>
			<Item Name="app global state actions.ctl" Type="VI" URL="../app/app global state actions.ctl"/>
			<Item Name="app global state control.ctl" Type="VI" URL="../app/app global state control.ctl"/>
			<Item Name="app global state.vi" Type="VI" URL="../app/app global state.vi"/>
			<Item Name="app initialize.vi" Type="VI" URL="../app/app initialize.vi"/>
		</Item>
		<Item Name="devices" Type="Folder">
			<Item Name="cryocon32B" Type="Folder">
				<Item Name="CC32" Type="Folder">
					<Item Name="CC_Config_Input.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Config_Input.vi"/>
					<Item Name="CC_Config_Setpoint.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32.llb/CC_Config_Setpoint.vi"/>
					<Item Name="CC_CONTROL.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_CONTROL.vi"/>
					<Item Name="CC_DAQ.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_DAQ.vi"/>
					<Item Name="CC_Icon_Tree.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Icon_Tree.vi"/>
					<Item Name="CC_Query_PID.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Query_PID.vi"/>
					<Item Name="CC_Query_Statistics.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Query_Statistics.vi"/>
					<Item Name="CC_QueryInput.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_QueryInput.vi"/>
					<Item Name="CC_Read_Temp.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32.llb/CC_Read_Temp.vi"/>
					<Item Name="CC_Reset.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Reset.vi"/>
					<Item Name="CC_Reset_Statistics.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Reset_Statistics.vi"/>
					<Item Name="CC_Revision_Query.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Revision_Query.vi"/>
					<Item Name="CC_Self-Test.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Self-Test.vi"/>
					<Item Name="CC_Set_Htr_Name.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Set_Htr_Name.vi"/>
					<Item Name="CC_Set_PID.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_Set_PID.vi"/>
					<Item Name="CC_STOP.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CC_STOP.vi"/>
					<Item Name="CurveDownload.vi" Type="VI" URL="../../Cryocon Software/LabView/M32_LV8_2/CC32.llb/CurveDownload.vi"/>
				</Item>
				<Item Name="cryocon ramp to temperature.vi" Type="VI" URL="../devices/cryocon32B/cryocon ramp to temperature.vi"/>
			</Item>
			<Item Name="gaussmeter" Type="Folder">
				<Item Name="gaussmeter channels.ctl" Type="VI" URL="../devices/gaussmeter/gaussmeter channels.ctl"/>
				<Item Name="gaussmeter read channel.vi" Type="VI" URL="../devices/gaussmeter/gaussmeter read channel.vi"/>
				<Item Name="gaussmeter read polar.vi" Type="VI" URL="../devices/gaussmeter/gaussmeter read polar.vi"/>
				<Item Name="gaussmeter read values.vi" Type="VI" URL="../devices/gaussmeter/gaussmeter read values.vi"/>
			</Item>
			<Item Name="magnet" Type="Folder">
				<Item Name="ips120" Type="Folder">
					<Item Name="private" Type="Folder">
						<Item Name="ips120 examine status.vi" Type="VI" URL="../devices/magnet/ips120/private/ips120 examine status.vi"/>
						<Item Name="ips120 query decimal.vi" Type="VI" URL="../devices/magnet/ips120/ips120 query decimal.vi"/>
						<Item Name="ips120 query.vi" Type="VI" URL="../devices/magnet/ips120/private/ips120 query.vi"/>
						<Item Name="ips120 set activity.vi" Type="VI" URL="../devices/magnet/ips120/private/ips120 set activity.vi"/>
						<Item Name="ips120 set target field.vi" Type="VI" URL="../devices/magnet/ips120/private/ips120 set target field.vi"/>
						<Item Name="ips120 switch heater.vi" Type="VI" URL="../devices/magnet/ips120/private/ips120 switch heater.vi"/>
					</Item>
					<Item Name="ips120 get current field.vi" Type="VI" URL="../devices/magnet/ips120/ips120 get current field.vi"/>
					<Item Name="ips120 get target field.vi" Type="VI" URL="../devices/magnet/ips120/ips120 get target field.vi"/>
					<Item Name="ips120 ramp to field.vi" Type="VI" URL="../devices/magnet/ips120/ips120 ramp to field.vi"/>
					<Item Name="ips120 set field sweep rate.vi" Type="VI" URL="../devices/magnet/ips120/ips120 set field sweep rate.vi"/>
					<Item Name="ips120 set remote mode.vi" Type="VI" URL="../devices/magnet/ips120/ips120 set remote mode.vi"/>
				</Item>
				<Item Name="magnet ami connect.vi" Type="VI" URL="../devices/magnet/ami/magnet ami connect.vi"/>
				<Item Name="magnet cartesian field.ctl" Type="VI" URL="../devices/magnet/magnet cartesian field.ctl"/>
				<Item Name="magnet initialize.vi" Type="VI" URL="../devices/magnet/magnet initialize.vi"/>
				<Item Name="magnet polar field.ctl" Type="VI" URL="../devices/magnet/magnet polar field.ctl"/>
				<Item Name="magnet ramp to field vector.vi" Type="VI" URL="../devices/magnet/magnet ramp to field vector.vi"/>
			</Item>
			<Item Name="motor" Type="Folder">
				<Property Name="NI.SortType" Type="Int">3</Property>
				<Item Name="private" Type="Folder">
					<Item Name="motor constants.ctl" Type="VI" URL="../devices/motor/private/motor constants.ctl"/>
					<Item Name="motor enable.vi" Type="VI" URL="../devices/motor/private/motor enable.vi"/>
					<Item Name="motor query switch.vi" Type="VI" URL="../devices/motor/private/motor query switch.vi"/>
					<Item Name="motor set direction.vi" Type="VI" URL="../devices/motor/private/motor set direction.vi"/>
					<Item Name="motor global state.vi" Type="VI" URL="../devices/motor/private/motor global state.vi"/>
					<Item Name="motor global state control.ctl" Type="VI" URL="../devices/motor/private/motor global state control.ctl"/>
					<Item Name="motor step.vi" Type="VI" URL="../devices/motor/private/motor step.vi"/>
					<Item Name="motor goto reference.vi" Type="VI" URL="../devices/motor/private/motor goto reference.vi"/>
					<Item Name="motor directions.ctl" Type="VI" URL="../devices/motor/private/motor directions.ctl"/>
					<Item Name="motor global state actions.ctl" Type="VI" URL="../devices/motor/private/motor global state actions.ctl"/>
					<Item Name="motor initialize.vi" Type="VI" URL="../devices/motor/private/motor initialize.vi"/>
				</Item>
				<Item Name="motor set angle.vi" Type="VI" URL="../devices/motor/motor set angle.vi"/>
				<Item Name="motor goto relative angle.vi" Type="VI" URL="../devices/motor/motor goto relative angle.vi"/>
				<Item Name="motor init connection.vi" Type="VI" URL="../devices/motor/motor init connection.vi"/>
			</Item>
			<Item Name="vna" Type="Folder">
				<Property Name="NI.SortType" Type="Int">3</Property>
				<Item Name="private" Type="Folder">
					<Item Name="vna read block data.vi" Type="VI" URL="../devices/vna/private/vna read block data.vi"/>
					<Item Name="vna query opc.vi" Type="VI" URL="../devices/vna/private/vna query opc.vi"/>
					<Item Name="vna get measurement catalog.vi" Type="VI" URL="../devices/vna/private/vna get measurement catalog.vi"/>
					<Item Name="vna read meas.vi" Type="VI" URL="../devices/vna/private/vna read meas.vi"/>
					<Item Name="vna block data type.ctl" Type="VI" URL="../devices/vna/private/vna block data type.ctl"/>
				</Item>
				<Item Name="vna configure.vi" Type="VI" URL="../devices/vna/vna configure.vi"/>
				<Item Name="vna read settings.vi" Type="VI" URL="../devices/vna/vna read settings.vi"/>
				<Item Name="vna settings.ctl" Type="VI" URL="../devices/vna/vna settings.ctl"/>
				<Item Name="vna perform sweep.vi" Type="VI" URL="../devices/vna/vna perform sweep.vi"/>
				<Item Name="vna data formats.ctl" Type="VI" URL="../devices/vna/vna data formats.ctl"/>
				<Item Name="vna s-parameters.ctl" Type="VI" URL="../devices/vna/vna s-parameters.ctl"/>
				<Item Name="vna preset.vi" Type="VI" URL="../devices/vna/vna preset.vi"/>
			</Item>
			<Item Name="maximize field component.vi" Type="VI" URL="../devices/maximize field component.vi"/>
		</Item>
		<Item Name="functions" Type="Folder">
			<Item Name="str count char.vi" Type="VI" URL="../functions/str count char.vi"/>
		</Item>
		<Item Name="measurement" Type="Folder">
			<Item Name="private" Type="Folder">
				<Item Name="result file write data.vi" Type="VI" URL="../measurement/private/result file write data.vi"/>
				<Item Name="result file write header.vi" Type="VI" URL="../measurement/private/result file write header.vi"/>
				<Item Name="result generate filename.vi" Type="VI" URL="../measurement/private/result generate filename.vi"/>
			</Item>
			<Item Name="measconfig cluster.ctl" Type="VI" URL="../measurement/measconfig cluster.ctl"/>
			<Item Name="measconfig parse section.vi" Type="VI" URL="../measurement/measconfig parse section.vi"/>
			<Item Name="measconfig read file.vi" Type="VI" URL="../measurement/measconfig read file.vi"/>
			<Item Name="measdata cluster.ctl" Type="VI" URL="../measurement/measdata cluster.ctl"/>
			<Item Name="measresult cluster.ctl" Type="VI" URL="../measurement/measresult cluster.ctl"/>
			<Item Name="measresult save.vi" Type="VI" URL="../measurement/measresult save.vi"/>
			<Item Name="measurement perform sweeps.vi" Type="VI" URL="../measurement/measurement perform sweeps.vi"/>
			<Item Name="measurement sweep parameter.ctl" Type="VI" URL="../measurement/measurement sweep parameter.ctl"/>
			<Item Name="measurement sweep.vi" Type="VI" URL="../measurement/measurement sweep.vi"/>
		</Item>
		<Item Name="tests" Type="Folder">
			<Item Name="magnet angle dependency.vi" Type="VI" URL="../tests/magnet angle dependency.vi"/>
		</Item>
		<Item Name="config.vi" Type="VI" URL="../config.vi"/>
		<Item Name="main.vi" Type="VI" URL="../main.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="user.lib" Type="Folder">
				<Item Name="430_GPIB_Command.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_GPIB_Command.vi"/>
				<Item Name="430_GPIB_Query.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_GPIB_Query.vi"/>
				<Item Name="430_RS232_Command.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_RS232_Command.vi"/>
				<Item Name="430_RS232_Query.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_RS232_Query.vi"/>
				<Item Name="430_TCP_Close.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_TCP_Close.vi"/>
				<Item Name="430_TCP_Command.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_TCP_Command.vi"/>
				<Item Name="430_TCP_Open.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_TCP_Open.vi"/>
				<Item Name="430_TCP_Query.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/430_TCP_Query.vi"/>
				<Item Name="CC_Close.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_Close.vi"/>
				<Item Name="CC_Error.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_Error.vi"/>
				<Item Name="CC_Error_Handler.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_Error_Handler.vi"/>
				<Item Name="CC_IO.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_IO.vi"/>
				<Item Name="CC_Read.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_Read.vi"/>
				<Item Name="CC_WriteCmd.vi" Type="VI" URL="/&lt;userlib&gt;/M32_LV8_2/CC32U.llb/CC_WriteCmd.vi"/>
				<Item Name="Check 2D Limits_entwurf.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Check 2D Limits_entwurf.vi"/>
				<Item Name="CheckLimitsBrasse.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/CheckLimitsBrasse.vi"/>
				<Item Name="Decimal Hours.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/Decimal Hours.vi"/>
				<Item Name="Get 2D Field (Cartesian).vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Get 2D Field (Cartesian).vi"/>
				<Item Name="Get Coil Constant.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Coil Constant.vi"/>
				<Item Name="Get Current Limit.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Current Limit.vi"/>
				<Item Name="Get Field Units.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Field Units.vi"/>
				<Item Name="Get Magnet Field.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Magnet Field.vi"/>
				<Item Name="Get Switch Heater Time.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Switch Heater Time.vi"/>
				<Item Name="Get Switch Heater.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Switch Heater.vi"/>
				<Item Name="Get Switch Present.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Get Switch Present.vi"/>
				<Item Name="GPIB Command.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Common VIs/GPIB Command.vi"/>
				<Item Name="Init YZ 2D.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Init YZ 2D.vi"/>
				<Item Name="Set 2D Field (Cartesian)_brasse.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Set 2D Field (Cartesian)_brasse.vi"/>
				<Item Name="Set 2D Field (Polar)_mb.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Set 2D Field (Polar)_mb.vi"/>
				<Item Name="Set 2D Next Vector_entwurf.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Set 2D Next Vector_entwurf.vi"/>
				<Item Name="Set 2D Ramp Rates_entwurf.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/2-Axis Control/Set 2D Ramp Rates_entwurf.vi"/>
				<Item Name="Set Current Ramp Rate.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Current Ramp Rate.vi"/>
				<Item Name="Set Current Ramp Rate_brasse.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Current Ramp Rate_brasse.vi"/>
				<Item Name="Set Field Units.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Field Units.vi"/>
				<Item Name="Set Ramp Rate Segments.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Ramp Rate Segments.vi"/>
				<Item Name="Set Ramp Rate Units.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Ramp Rate Units.vi"/>
				<Item Name="Set Ramping Mode.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Ramping Mode.vi"/>
				<Item Name="Set Ramping Mode_brasse.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Ramping Mode_brasse.vi"/>
				<Item Name="Set Switch Heater.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Switch Heater.vi"/>
				<Item Name="Set Target Field.vi" Type="VI" URL="/&lt;userlib&gt;/AMI/Model 4x0/Set Target Field.vi"/>
			</Item>
			<Item Name="vi.lib" Type="Folder">
				<Item Name="8.6CompatibleGlobalVar.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/config.llb/8.6CompatibleGlobalVar.vi"/>
				<Item Name="Beep.vi" Type="VI" URL="/&lt;vilib&gt;/Platform/system.llb/Beep.vi"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="ex_CorrectErrorChain.vi" Type="VI" URL="/&lt;vilib&gt;/express/express shared/ex_CorrectErrorChain.vi"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="General Error Handler CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler CORE.vi"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="GetDateTimeInSecsCompatVI.vi" Type="VI" URL="/&lt;vilib&gt;/_oldvers/_oldvers.llb/GetDateTimeInSecsCompatVI.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="LJUD_eDI.vi" Type="VI" URL="/&lt;vilib&gt;/addons/LabVIEW_LJUD/LabJackUD DLL Functions/LJUD_eDI.vi"/>
				<Item Name="LJUD_eDO.vi" Type="VI" URL="/&lt;vilib&gt;/addons/LabVIEW_LJUD/LabJackUD DLL Functions/LJUD_eDO.vi"/>
				<Item Name="LJUD_ErrorToString.vi" Type="VI" URL="/&lt;vilib&gt;/addons/LabVIEW_LJUD/LabJackUD DLL Functions/LJUD_ErrorToString.vi"/>
				<Item Name="LJUD_OpenLabJackS.vi" Type="VI" URL="/&lt;vilib&gt;/addons/LabVIEW_LJUD/LabJackUD DLL Functions/LJUD_OpenLabJackS.vi"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LV70U32ToDateRec.vi" Type="VI" URL="/&lt;vilib&gt;/_oldvers/_oldvers.llb/LV70U32ToDateRec.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVNumericRepresentation.ctl" Type="VI" URL="/&lt;vilib&gt;/numeric/LVNumericRepresentation.ctl"/>
				<Item Name="NI_AALBase.lvlib" Type="Library" URL="/&lt;vilib&gt;/Analysis/NI_AALBase.lvlib"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="NI_LVConfig.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/config.llb/NI_LVConfig.lvlib"/>
				<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="subDisplayMessage.vi" Type="VI" URL="/&lt;vilib&gt;/express/express output/DisplayMessageBlock.llb/subDisplayMessage.vi"/>
				<Item Name="subTimeDelay.vi" Type="VI" URL="/&lt;vilib&gt;/express/express execution control/TimeDelayBlock.llb/subTimeDelay.vi"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="VariantType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/VariantDataType/VariantType.lvlib"/>
				<Item Name="VISA Configure Serial Port" Type="VI" URL="/&lt;vilib&gt;/Instr/_visa.llb/VISA Configure Serial Port"/>
				<Item Name="VISA Configure Serial Port (Instr).vi" Type="VI" URL="/&lt;vilib&gt;/Instr/_visa.llb/VISA Configure Serial Port (Instr).vi"/>
				<Item Name="VISA Configure Serial Port (Serial Instr).vi" Type="VI" URL="/&lt;vilib&gt;/Instr/_visa.llb/VISA Configure Serial Port (Serial Instr).vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
			</Item>
			<Item Name="fgv actions.ctl" Type="VI" URL="../fgv actions.ctl"/>
			<Item Name="labjackud.dll" Type="Document" URL="labjackud.dll">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="lvanlys.dll" Type="Document" URL="/&lt;resource&gt;/lvanlys.dll"/>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
