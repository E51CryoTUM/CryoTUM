<?xml version='1.0'?>
<Project Type="Project" LVVersion="8208000">
   <Property Name="CCSymbols" Type="Str"></Property>
   <Property Name="NI.LV.All.SourceOnly" Type="Bool">true</Property>
   <Property Name="NI.Project.Description" Type="Str">Library to communicate with processes by means of stdin and stdout for Windows OS. VIs call external library lv_process.dll to start a process, send and receive data through stdin and stdout and close process. In LabVIEW a pipe is represented by a cluster containing handlers and setting. User can change the cluster values as required (be careful). All traffic can be logged if debug mode is started. Debug console can be shown on the background.</Property>
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
      <Item Name="LV Process library.lvlib" Type="Library" URL="LV Process library.lvlib">
         <Item Name="Private" Type="Folder">
            <Item Name="Check and Generate Path to lv_proc.vi" Type="VI" URL="Private/Check and Generate Path to lv_proc.vi"/>
            <Item Name="Generate Error.vi" Type="VI" URL="Private/Generate Error.vi"/>
         </Item>
         <Item Name="Public" Type="Folder">
            <Item Name="Clean Up.vi" Type="VI" URL="Public/Clean Up.vi"/>
            <Item Name="Create Process.vi" Type="VI" URL="Public/Create Process.vi"/>
            <Item Name="Demo.vi" Type="VI" URL="Public/Demo.vi"/>
            <Item Name="Get Exit Code.vi" Type="VI" URL="Public/Get Exit Code.vi"/>
            <Item Name="Get Version.vi" Type="VI" URL="Public/Get Version.vi"/>
            <Item Name="Kill.vi" Type="VI" URL="Public/Kill.vi"/>
            <Item Name="Pipe Handle.ctl" Type="VI" URL="Public/Pipe Handle.ctl"/>
            <Item Name="Read Stdout.vi" Type="VI" URL="Public/Read Stdout.vi"/>
            <Item Name="Vi Tree.vi" Type="VI" URL="Public/Vi Tree.vi"/>
            <Item Name="Wait For Exit.vi" Type="VI" URL="Public/Wait For Exit.vi"/>
            <Item Name="Write Stdin.vi" Type="VI" URL="Public/Write Stdin.vi"/>
            <Item Name="lv_proc.dll" Type="Document" URL="lv_proc.dll"/>
         </Item>
         <Item Name="license.txt" Type="Document" URL="license.txt"/>
      </Item>
      <Item Name="Dependencies" Type="Dependencies"/>
      <Item Name="Build Specifications" Type="Build">
         <Item Name="source distribution into GOLPI project" Type="Source Distribution">
            <Property Name="Absolute[0]" Type="Bool">false</Property>
            <Property Name="Absolute[1]" Type="Bool">false</Property>
            <Property Name="Absolute[2]" Type="Bool">false</Property>
            <Property Name="BuildName" Type="Str">source distribution into GOLPI project</Property>
            <Property Name="DependencyFolderDestination" Type="Int">0</Property>
            <Property Name="DependencyFolderInclusion" Type="Str">As Needed</Property>
            <Property Name="DestinationItemCount" Type="Int">3</Property>
            <Property Name="DestinationName[0]" Type="Str">Destination Directory</Property>
            <Property Name="DestinationName[1]" Type="Str">Support Directory</Property>
            <Property Name="DestinationName[2]" Type="Str">lv_proc.dll destination</Property>
            <Property Name="DestinationOption" Type="Str">Custom</Property>
            <Property Name="ExcludeInstrLib" Type="Bool">true</Property>
            <Property Name="ExcludeUserLib" Type="Bool">true</Property>
            <Property Name="ExcludeVILIB" Type="Bool">true</Property>
            <Property Name="Path[0]" Type="Path">../../GOLPI/LV Process source distribution</Property>
            <Property Name="Path[1]" Type="Path">../../GOLPI/LV Process source distribution/data</Property>
            <Property Name="Path[2]" Type="Path">../../GOLPI</Property>
            <Property Name="Source[2].destinationIndex" Type="Int">2</Property>
            <Property Name="Source[2].itemID" Type="Ref"></Property>
            <Property Name="SourceInfoItemCount" Type="Int">19</Property>
            <Property Name="SourceItem[0].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[0].IsFolder" Type="Bool">true</Property>
            <Property Name="SourceItem[0].ItemID" Type="Ref">/My Computer/LV Process library.lvlib</Property>
            <Property Name="SourceItem[10].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[10].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[10].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Pipe Handle.ctl</Property>
            <Property Name="SourceItem[11].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[11].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[11].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Read Stdout.vi</Property>
            <Property Name="SourceItem[12].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[12].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[12].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Vi Tree.vi</Property>
            <Property Name="SourceItem[13].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[13].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[13].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Wait For Exit.vi</Property>
            <Property Name="SourceItem[14].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[14].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[14].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Write Stdin.vi</Property>
            <Property Name="SourceItem[15].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[15].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[15].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Write Stdin.vi</Property>
            <Property Name="SourceItem[16].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[16].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[16].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Write Stdin.vi</Property>
            <Property Name="SourceItem[17].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[17].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[17].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Write Stdin.vi</Property>
            <Property Name="SourceItem[18].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[18].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[18].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Write Stdin.vi</Property>
            <Property Name="SourceItem[2].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[2].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[2].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Private</Property>
            <Property Name="SourceItem[3].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[3].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[3].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public</Property>
            <Property Name="SourceItem[4].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[4].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[4].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/license.txt</Property>
            <Property Name="SourceItem[5].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[5].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[5].ItemID" Type="Ref"></Property>
            <Property Name="SourceItem[6].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[6].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[6].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Demo.vi</Property>
            <Property Name="SourceItem[7].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[7].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[7].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Get Exit Code.vi</Property>
            <Property Name="SourceItem[8].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[8].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[8].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Get Version.vi</Property>
            <Property Name="SourceItem[9].FolderTopLevelVI" Type="Str">Never</Property>
            <Property Name="SourceItem[9].Inclusion" Type="Str">As Needed</Property>
            <Property Name="SourceItem[9].ItemID" Type="Ref">/My Computer/LV Process library.lvlib/Public/Kill.vi</Property>
         </Item>
      </Item>
   </Item>
</Project>
