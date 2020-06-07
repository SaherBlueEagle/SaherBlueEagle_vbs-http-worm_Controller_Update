Public Class SQLform

    Public key As String
    Friend SQL_CONN_STR As String = ""
    Friend Servername As String = ""
    Dim tabSQL_Query As String = "" '    TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").TreeView.Sort()
    Protected Friend issort_now As Boolean = False
    Private Sub RefreshDatabases()
        On Error Resume Next
        TreeView1.Nodes(0).Nodes(0).Nodes.Clear()
        GetDatabases()
    End Sub
    Private Sub RefreshTables()
        On Error Resume Next

        If TreeView1.SelectedNode.Text.Equals("Tables") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Text
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").Nodes.Clear()
            GetTables(databasename)
            Exit Sub

        End If

    End Sub
    Private Sub Refreshviews()
        On Error Resume Next

        If TreeView1.SelectedNode.Text.Equals("Views") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Text
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").Nodes.Clear()
            GetViews(databasename)
            Exit Sub

        End If

    End Sub
    Private Sub RefreshLinked()
        On Error Resume Next

        If TreeView1.SelectedNode.Text.Equals("Linked Servers") Then

            TreeView1.Nodes(0).Nodes(0).Nodes("Linked Servers").Nodes.Clear()
            get_linked()
            Exit Sub

        End If

    End Sub
    Private Sub get_linked()
        Dim SQLQuery As String = "SELECT  name  from sys.servers "
        ' Add_view("bases111", "views111")
        ' Add_view("bases111", "views1110")

        Run_Query("linked_svrs", SQLQuery, "")
    End Sub

    Delegate Sub ADDREF(data As DataGridView)
    Protected Friend Sub ADD_rEF(data As DataGridView)
        If (data.InvokeRequired) Then
            Dim d As ADDREF = New ADDREF(AddressOf ADD_rEF)
            Me.Invoke(d, New Object() {data})
        Else
            data.Columns.Clear()
            Try
                Dim tabpagename As String = TabControl1.SelectedTab.Text
                tabpagename = tabpagename.Replace(" ", "")
                Dim tatemp As TabPage = TabControl1.SelectedTab
                'RichTextBox1

                For Each C As Control In tatemp.Controls
                    If C.Name.Equals("RichTextBox1") Then
                        Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                        Run_Query("ordselect", tabpage_RichTextBox1a.Text, "")
                        Exit For
                    End If
                Next


            Catch ex As Exception

            End Try
        End If
    End Sub

    Delegate Sub ADDSORT(data As DataGridView)
    Protected Friend Sub ADD_SORT(data As DataGridView)
        If (data.InvokeRequired) Then
            Dim d As ADDSORT = New ADDSORT(AddressOf ADD_SORT)
            Me.Invoke(d, New Object() {data})
        Else
            TreeView1.Nodes(0).Nodes(0).TreeView.Sort()
            SplitContainer1.Panel1.Enabled = True
        End If
    End Sub

    Delegate Sub ADDDataGridrw(resvalue As Integer, data As DataGridView)
    Protected Friend Sub ADD_DataGridrw(resvalue As Integer, data As DataGridView)
        If (data.InvokeRequired) Then
            Dim d As ADDDataGridrw = New ADDDataGridrw(AddressOf ADD_DataGridrw)
            Me.Invoke(d, New Object() {resvalue, data})
        Else
            For i As Integer = 0 To resvalue
                DataGridView1.Rows.Add("")
            Next
            If is_select200 = True Then
                Dim colline As String = ""
                For Each sac As DataGridViewColumn In data.Columns
                    colline &= sac.HeaderText & ","
                Next

                colline = colline.TrimEnd(CType(",", Char))
                is_select200_qu = is_select200_qu.Replace("*", colline)

                tabkey += 1
                inint(is_select200_qu)

                '
                is_select200_qu = ""
                is_select200 = False
            End If
        End If
    End Sub

    Delegate Sub ADDDataGridColumn(resvalue As String, data As DataGridView)
    Protected Friend Sub ADD_DataGridColumn(resvalue As String, data As DataGridView)
        If (data.InvokeRequired) Then
            Dim d As ADDDataGridColumn = New ADDDataGridColumn(AddressOf ADD_DataGridColumn)
            Me.Invoke(d, New Object() {resvalue, data})
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = resvalue
            DataGridView1.Columns.Add(col)
        End If
    End Sub

    Delegate Sub ADDDataGridCEll_VALUE(resvalue As DataGridViewRow, data As DataGridView)
    Protected Friend Sub ADD_DataGridCEllvalue(resvalue As DataGridViewRow, data As DataGridView)
        If (data.InvokeRequired) Then
            Dim d As ADDDataGridCEll_VALUE = New ADDDataGridCEll_VALUE(AddressOf ADD_DataGridCEllvalue)
            Me.Invoke(d, New Object() {resvalue, data})
        Else
            '  data.Rows(i).Cells(j).Value = resvalue
            data.Rows.Add(resvalue)
        End If
    End Sub

    Delegate Sub ADDDataGridCEll(resvalue As String, data As DataGridView, i As Integer, j As Integer)
    Protected Friend Sub ADD_DataGridCEll(resvalue As String, data As DataGridView, i As Integer, j As Integer)
        If (data.InvokeRequired) Then
            Dim d As ADDDataGridCEll = New ADDDataGridCEll(AddressOf ADD_DataGridCEll)
            Me.Invoke(d, New Object() {resvalue, data, i, j})
        Else
            data.Rows(i).Cells(j).Value = resvalue

        End If
    End Sub


    Delegate Sub DUpdateTreeView(resvalue As String, tree As TreeView, clear As Boolean, ByVal operation As String, ByVal databasename As String)
    Protected Friend Sub UpdataTreeView(resvalue As String, tree As TreeView, clear As Boolean, ByVal operation As String, ByVal databasename As String)
        If (tree.InvokeRequired) Then
            Dim d As DUpdateTreeView = New DUpdateTreeView(AddressOf UpdataTreeView)
            Me.Invoke(d, New Object() {resvalue, tree, clear, operation, databasename})
        Else
            If (clear) Then
                tree.Nodes.Clear()
            Else
                If operation.Equals("getdatabases") Then

                    Add_database(resvalue)
                End If
                If operation.Equals("getviews") Then

                    Add_view(databasename, resvalue)
                End If
                If operation.Equals("gettables") Then
                    Add_table(databasename, resvalue)
                End If
                If operation.Equals("linked_svrs") Then
                    Add_llinked(resvalue)
                End If


                '   tree.SelectedNode.Nodes.Add(keyname)
            End If
        End If
    End Sub

    Protected Friend Sub Add_database(ByVal basename As String)

        If TreeView1.Nodes(0).Nodes(0).Nodes.Contains(TreeView1.Nodes(0).Nodes(0).Nodes(basename)) Then
            TreeView1.Nodes(0).Nodes(0).Expand()
            Exit Sub
        Else
            TreeView1.Nodes(0).Nodes(0).Nodes.Add(basename, basename, 7).SelectedImageIndex = 7


            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes.Add("Tables", "Tables", 0)
            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes.Add("Views", "Views", 0)
            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes("Tables").SelectedImageIndex = 0
            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes("Views").SelectedImageIndex = 0
            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes("Tables").ContextMenuStrip = Me.ContextMenuStrip2
            TreeView1.Nodes(0).Nodes(0).Nodes(basename).Nodes("Views").ContextMenuStrip = Me.ContextMenuStrip2

            TreeView1.Nodes(0).Nodes(0).Expand()

            '    ChangeServer(Servername)
        End If

    End Sub

    Protected Friend Sub Add_table(ByVal databasename As String, ByVal tablename As String)
        If TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").Nodes.Contains(TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes(tablename)) Then

            Exit Sub
        Else
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").Nodes.Add(tablename, tablename, 5)
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").Nodes(tablename).SelectedImageIndex = 5
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").TreeView.ContextMenuStrip = Me.ContextMenuStrip2
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Tables").Expand()
            SplitContainer1.Panel1.Enabled = False

        End If

    End Sub
    
    Protected Friend Sub Add_view(ByVal databasename As String, ByVal viewname As String)
        If TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").Nodes.Contains(TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes(viewname)) Then

            Exit Sub
        Else
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").Nodes.Add(viewname, viewname, 13)
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").Nodes(viewname).SelectedImageIndex = 13
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").TreeView.ContextMenuStrip = Me.ContextMenuStrip2
            TreeView1.Nodes(0).Nodes(0).Nodes(databasename).Nodes("Views").Expand()
            SplitContainer1.Panel1.Enabled = False
        End If

    End Sub
    Protected Friend Sub ChangeServer(ByVal servername As String)
        If TreeView1.Nodes(0).Text.Equals(servername) = False Then
            TreeView1.Nodes(0).Text = servername
        End If
    End Sub
    Private Sub RefreshDatabasesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshDatabasesToolStripMenuItem.Click
        If TreeView1.SelectedNode.Text.Equals("Databases") Then
            If TreeView1.SelectedNode.Name.Equals("Databases") Then
                RefreshDatabases()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TreeView1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDoubleClick
        If TreeView1.SelectedNode.Text.Equals("Databases") Then
            If TreeView1.SelectedNode.Name.Equals("Databases") Then
                RefreshDatabases()
                Exit Sub
            End If
        End If
        If TreeView1.SelectedNode.Text.Equals("Tables") Then
            RefreshTables()
            Exit Sub
        End If
        If TreeView1.SelectedNode.Text.Equals("Views") Then
            Refreshviews()
            Exit Sub
        End If
        If TreeView1.SelectedNode.Text.Equals("Triggers") Then
            Dim databasename As String = InputBox("Enter Database name to get Triggers from it", "Database name entry", "master")
            If TreeView1.Nodes(0).Nodes(0).Nodes.Contains(TreeView1.Nodes(0).Nodes(0).Nodes(databasename)) Then
                tabkey += 1
                inint("SELECT Top 20 name , create_date , is_disabled FROM [" & databasename & "].sys.triggers")
                Run_Query("ordselect", "SELECT Top 20 name , create_date , is_disabled FROM [" & databasename & "].sys.triggers", "")
                Exit Sub
            Else
                MsgBox("Database name is not exist in the following databases", MsgBoxStyle.Critical)
            End If
        End If
        If TreeView1.SelectedNode.Text.Equals("Linked Servers") Then
            '"linked_svrs"
            RefreshLinked()
            Exit Sub
        End If
    End Sub
    Private Sub Add_llinked(ByVal lname As String)
        If TreeView1.Nodes(0).Nodes(1).Nodes.Contains(TreeView1.Nodes(0).Nodes(1).Nodes(lname)) = False Then
            TreeView1.Nodes(0).Nodes(1).Nodes.Add(lname, lname, 14)
            TreeView1.Nodes(0).Nodes(1).Expand()
        End If
    End Sub
    
    Private Sub GetTables(ByVal databasename As String)
        Dim SQLQuery As String = "SELECT name FROM " & "[" & databasename & "].sys.tables"
        'Add_table("bases111", "tabless11")
        'Add_table("bases111", "tabless110")
        'Add_table("bases111", "tabless1101")
        Run_Query("gettables", SQLQuery, databasename)
    End Sub
    Private Sub GetViews(ByVal databasename As String)
        Dim SQLQuery As String = "SELECT name FROM " & "[" & databasename & "].sys.views"
        ' Add_view("bases111", "views111")
        ' Add_view("bases111", "views1110")
        Run_Query("getviews", SQLQuery, databasename)
    End Sub
    Private Sub GetDatabases()
        Dim SQLQuery As String = "SELECT name FROM sys.databases"
        '  Add_database("bases111")
        Run_Query("getdatabases", SQLQuery, "")

    End Sub
    Friend is_select200 As Boolean = False
    Friend is_select200_qu As String = ""
    Private Sub SelectTop200RowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectTop200RowsToolStripMenuItem.Click
        On Error Resume Next
        Dim SQLQuery As String = ""
        If TreeView1.SelectedNode.Parent.Text.Equals("Tables") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Parent.Text
            Dim tablename As String = TreeView1.SelectedNode.Text
            SQLQuery = "SELECT TOP 20 *  FROM [" & databasename & "].[dbo].[" & tablename & "]"
            is_select200 = True
            is_select200_qu = SQLQuery
        ElseIf TreeView1.SelectedNode.Parent.Text.Equals("Views") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Parent.Text
            Dim tablename As String = TreeView1.SelectedNode.Text
            SQLQuery = "SELECT TOP 20 *  FROM [" & databasename & "].[dbo].[" & tablename & "]"
            is_select200 = True
            is_select200_qu = SQLQuery
        End If
        If SQLQuery.Length > 5 Then
            Run_Query("ordselect", SQLQuery, "")
        End If

    End Sub
    Private Sub Run_Query(ByVal querytype As String, ByVal SQLQuery As String, dbname As String)
        Label2.Text = ""
        If SQL_CONN_STR.Length < 5 Then
            MsgBox("Invalid Connection String", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If querytype.Equals("ordselect") Then
            DataGridView1.Columns.Clear()

            Form1.Send_to_Client("dosqlqueryordselect" & FUNC.SPL & SQLQuery & FUNC.SPL & SQL_CONN_STR & FUNC.SPL & dbname & FUNC.SPL, key)

        ElseIf querytype.Equals("getdatabases") Then

            Form1.Send_to_Client("dosqlquerygetdatabases" & FUNC.SPL & SQLQuery & FUNC.SPL & SQL_CONN_STR & FUNC.SPL & dbname & FUNC.SPL, key)

        ElseIf querytype.Equals("getviews") Then
            Form1.Send_to_Client("dosqlquerygetviews" & FUNC.SPL & SQLQuery & FUNC.SPL & SQL_CONN_STR & FUNC.SPL & dbname & FUNC.SPL, key)

        ElseIf querytype.Equals("gettables") Then

            Form1.Send_to_Client("dosqlquerygettables" & FUNC.SPL & SQLQuery & FUNC.SPL & SQL_CONN_STR & FUNC.SPL & dbname & FUNC.SPL, key)
        End If




    End Sub

    Private Sub DeleteTableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteTableToolStripMenuItem.Click
        'DROP TABLE  tablename;
        Dim SQLQuery As String = ""
        If TreeView1.SelectedNode.Parent.Text.Equals("Tables") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Parent.Text
            Dim tablename As String = TreeView1.SelectedNode.Text
            SQLQuery = "DROP TABLE [" & databasename & "].[dbo].[" & tablename & "]"

        End If
        If SQLQuery.Length > 5 Then
            Run_Query("droptables", SQLQuery, "")
        End If
    End Sub

    Private Sub DeleteViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteViewToolStripMenuItem.Click
        'VIEW
        Dim SQLQuery As String = ""
        If TreeView1.SelectedNode.Parent.Text.Equals("Views") Then
            Dim databasename As String = TreeView1.SelectedNode.Parent.Parent.Text
            Dim tablename As String = TreeView1.SelectedNode.Text
            SQLQuery = "DROP VIEW [" & databasename & "].[dbo].[" & tablename & "]"
        End If
        If SQLQuery.Length > 5 Then
            Run_Query("dropviews", SQLQuery, "")
        End If
    End Sub
    Dim tabkey As Integer = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'TabControl1.TabPages.Add("NewQuery" & tabkey, "New Query" & " " & tabkey, 23)
        'tabp = New Tabpage
        'tabp.TopLevel = False
        'tabp.Show()
        'tabp.Parent = TabControl1.TabPages("NewQuery" & tabkey)
        'tabp.Name = "NewQuery" & tabkey

        inint("")

        tabkey += 1
    End Sub



    Delegate Sub dell_tab(tab_name As String, data As TabControl)
    Protected Friend Sub Delltab(tab_name As String, TabControl As TabControl)


     



        For ix As Integer = 0 To TabControl1.TabPages.Count - 1
            MsgBox(TabControl1.TabPages(ix).Text)
        Next

        If (TabControl.InvokeRequired) Then
            Dim d As dell_tab = New dell_tab(AddressOf Delltab)
            Me.Invoke(d, New Object() {tab_name, TabControl})
        Else
            TabControl.TabPages.RemoveByKey(tab_name)
            tabkey -= 1
        End If
    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("The Select Query Shouldn`t Increase more than 20 Rows / By adding your Where condition , " & vbNewLine & "Because this will slow operation " & vbNewLine & "If selected more than 20 Row , the query will be done , but will take larger time to send you the out data" & vbNewLine & "By pressing Ok , you have read the above statments", "Select Query Warning", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Try
                Dim tabpagename As String = TabControl1.SelectedTab.Text
                tabpagename = tabpagename.Replace(" ", "")
                Dim tatemp As TabPage = TabControl1.SelectedTab
                'RichTextBox1

                For Each C As Control In tatemp.Controls
                    If C.Name.Equals("RichTextBox1") Then
                        Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                        Run_Query("ordselect", tabpage_RichTextBox1a.Text, "")
                        Exit For
                    End If
                Next


            Catch ex As Exception

            End Try
        End If

       
    End Sub

    Private Sub SQLform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim sername As String = ""
        'sername = InputBox("Enter SQL Server name (DSN) / Sql server ip", "SQL Server Entry", "192.168.1.9")
        'If sername.Length > 4 Then
        '    Servername = sername
        '    Button3.PerformClick()
        'Else
        '    MsgBox("Invalid Server name / DSN ", MsgBoxStyle.Critical)
        '    Me.Close()
        'End If
    End Sub

 

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
      
    End Sub


    Private Sub TabControl1_Resize() Handles TabControl1.Resize, TabControl1.MouseMove, TabControl1.MouseHover
        On Error Resume Next
        Dim tabpagename As String = TabControl1.SelectedTab.Text
        tabpagename = tabpagename.Replace(" ", "")
   
        ' tabp.Size = New Size(Me.TabControl1.TabPages(tabp.Name).Size)


    End Sub
    '$$$$$$$$$$$$$$$$$$$$$$$$$$$ tab page 
    Friend WithEvents tabpage_Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tabpage_Label1 As System.Windows.Forms.Label
    Friend WithEvents tabpage_RichTextBox1 As System.Windows.Forms.RichTextBox
    Sub inint(ByVal q As String)
        
        Me.tabpage_Panel2 = New System.Windows.Forms.Panel()
        Me.tabpage_Label1 = New System.Windows.Forms.Label()
        Me.tabpage_RichTextBox1 = New System.Windows.Forms.RichTextBox()


        '
        'Panel2
        '
        Me.tabpage_Panel2.BackColor = System.Drawing.Color.Transparent
        Me.tabpage_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpage_Panel2.Controls.Add(Me.tabpage_Label1)
        Me.tabpage_Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabpage_Panel2.Location = New System.Drawing.Point(0, 0)
        Me.tabpage_Panel2.Name = "Panel2"
        Me.tabpage_Panel2.Size = New System.Drawing.Size(284, 18)
        Me.tabpage_Panel2.TabIndex = 2

        Me.tabpage_Label1.AutoSize = True
        Me.tabpage_Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.tabpage_Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpage_Label1.Location = New System.Drawing.Point(265, 0)
        Me.tabpage_Label1.Name = "Label1"
        Me.tabpage_Label1.Size = New System.Drawing.Size(17, 16)
        Me.tabpage_Label1.TabIndex = 3
        Me.tabpage_Label1.Text = "X"

        Me.tabpage_RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabpage_RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpage_RichTextBox1.Location = New System.Drawing.Point(0, 18)
        Me.tabpage_RichTextBox1.Name = "RichTextBox1"
        Me.tabpage_RichTextBox1.Size = New System.Drawing.Size(284, 243)
        Me.tabpage_RichTextBox1.TabIndex = 3
        Me.tabpage_RichTextBox1.Text = ""


        Dim tabpagec As New TabPage
        tabpagec.Name = "NewQuery" & tabkey
        tabpagec.ImageIndex = 23
        tabpagec.Text = "New Query" & " " & tabkey
        tabpagec.Controls.Add(Me.tabpage_RichTextBox1)
        tabpagec.Controls.Add(Me.tabpage_Panel2)
        TabControl1.TabPages.Add(tabpagec)
        TabControl1.SelectTab(tabpagec)

        If q.Length > 5 Then

            tabpage_RichTextBox1.Text = q
            tabpage_RichTextBox1.Text = tabpage_RichTextBox1.Text.Replace("FROM", vbNewLine & "FROM")
            tabpage_RichTextBox1.Text = tabpage_RichTextBox1.Text.Replace("TOP", vbNewLine & "TOP" & vbNewLine)
            tabpage_RichTextBox1.Text &= vbNewLine
        End If




    End Sub
    Private Sub Label1_Click() Handles tabpage_Label1.Click
        On Error Resume Next
        DataGridView1.Columns.Clear()
        TabControl1.TabPages.RemoveByKey(TabControl1.SelectedTab.Name)
        If tabkey > 0 Then
            tabkey -= 1
        End If
        If tabkey = 0 Then
            tabkey = 0
        End If

    End Sub
    Private Sub RichTextBox1_TextChanged() Handles tabpage_RichTextBox1.TextChanged
        If tabpage_RichTextBox1.Text.Length > 5 Then
            Me.Button2.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        tabkey = 0
        TabControl1.TabPages.Clear()
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub EditValueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditValueToolStripMenuItem.Click
        If DataGridView1.SelectedCells.Count > 1 Then
            MsgBox("Only Select one Cell to Edit", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If DataGridView1.SelectedCells.Count = 1 Then
            Dim value_cell As String = CType(DataGridView1.SelectedCells(0).FormattedValue, String)
            Dim input_value As String = InputBox("Edit " & value_cell & vbNewLine & "Enter new value", "Edit value", value_cell)
            If input_value.Length > 0 Then

                If value_cell.Equals(input_value) Then
                    MsgBox("Enter another Diffrent Value " & vbNewLine & "The new value Already Exists", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                Try
                    Dim tabpagename As String = TabControl1.SelectedTab.Text
                    tabpagename = tabpagename.Replace(" ", "")
                    Dim tatemp As TabPage = TabControl1.SelectedTab
                    'RichTextBox1
                    Dim SQL_Query As String = ""
                    For Each C As Control In tatemp.Controls
                        If C.Name.Equals("RichTextBox1") Then
                            Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                            SQL_Query = tabpage_RichTextBox1a.Text
                            Exit For
                        End If
                    Next
                    Dim from_statment As String = ""
                    Dim temp_start_index As Integer = 0
                    For x As Integer = 0 To SQL_Query.Length - 1

                        If SQL_Query(x).ToString.ToUpper.Equals("F") Then
                            If SQL_Query(x + 1).ToString.ToUpper.Equals("R") Then
                                If SQL_Query(x + 2).ToString.ToUpper.Equals("O") Then
                                    If SQL_Query(x + 3).ToString.ToUpper.Equals("M") Then

                                        temp_start_index = x
                                        Exit For
                                    End If
                                End If
                            End If
                        End If

                    Next
                    from_statment = SQL_Query.Replace(SQL_Query.Substring(0, temp_start_index), "")
                    Dim colname As String = DataGridView1.SelectedCells(0).OwningColumn.HeaderText
                    Dim colname_firstone As String = DataGridView1.SelectedCells(0).OwningRow.Cells(0).OwningColumn.HeaderText
                    Dim value_firstine As String = DataGridView1.SelectedCells(0).OwningRow.Cells(0).Value
                   
                    from_statment = from_statment.ToUpper
                    from_statment = from_statment.Replace("WHERE", " Set " & colname & " = '" & input_value & "' WHERE " & colname & " = '" & value_cell & "' And " & colname_firstone & " = '" & value_firstine & "' And ")
                    SQL_Query = "Update " & from_statment
                    from_statment = ""
                    SQL_Query = SQL_Query.Replace("FROM", "")
                    
                    Run_Query("ordselect", SQL_Query, "")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try






            End If
        End If
    End Sub

 

    Private Sub DeleteRowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteRowToolStripMenuItem.Click

        If DataGridView1.SelectedRows.Count = 1 Then
            Dim value_cell As String = CType(DataGridView1.SelectedRows(0).Cells(0).FormattedValue, String)

            Try
                Dim tabpagename As String = TabControl1.SelectedTab.Text
                tabpagename = tabpagename.Replace(" ", "")
                Dim tatemp As TabPage = TabControl1.SelectedTab
                'RichTextBox1
                Dim SQL_Query As String = ""
                For Each C As Control In tatemp.Controls
                    If C.Name.Equals("RichTextBox1") Then
                        Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                        SQL_Query = tabpage_RichTextBox1a.Text
                        Exit For
                    End If
                Next
                Dim from_statment As String = ""
                Dim temp_start_index As Integer = 0
                For x As Integer = 0 To SQL_Query.Length - 1

                    If SQL_Query(x).ToString.ToUpper.Equals("F") Then
                        If SQL_Query(x + 1).ToString.ToUpper.Equals("R") Then
                            If SQL_Query(x + 2).ToString.ToUpper.Equals("O") Then
                                If SQL_Query(x + 3).ToString.ToUpper.Equals("M") Then

                                    temp_start_index = x
                                    Exit For
                                End If
                            End If
                        End If
                    End If

                Next
                from_statment = SQL_Query.Replace(SQL_Query.Substring(0, temp_start_index), "")
                Dim colname As String = DataGridView1.SelectedCells(0).OwningColumn.HeaderText

                from_statment = from_statment.ToUpper
                from_statment = from_statment.Replace("WHERE", " WHERE " & colname & " = '" & value_cell & "' And ")
                SQL_Query = "Delete " & from_statment
                from_statment = ""
                Run_Query("ordselect", SQL_Query, "")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Exit Sub

        Else
            MsgBox("Only Select one Cell from the Row you want to Delete  /  Or  the Entire ROW ", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If DataGridView1.SelectedCells.Count = 1 Then
            Dim value_cell As String = CType(DataGridView1.SelectedCells(0).FormattedValue, String)

            Try
                Dim tabpagename As String = TabControl1.SelectedTab.Text
                tabpagename = tabpagename.Replace(" ", "")
                Dim tatemp As TabPage = TabControl1.SelectedTab
                'RichTextBox1
                Dim SQL_Query As String = ""
                For Each C As Control In tatemp.Controls
                    If C.Name.Equals("RichTextBox1") Then
                        Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                        SQL_Query = tabpage_RichTextBox1a.Text
                        Exit For
                    End If
                Next
                Dim from_statment As String = ""
                Dim temp_start_index As Integer = 0
                For x As Integer = 0 To SQL_Query.Length - 1

                    If SQL_Query(x).ToString.ToUpper.Equals("F") Then
                        If SQL_Query(x + 1).ToString.ToUpper.Equals("R") Then
                            If SQL_Query(x + 2).ToString.ToUpper.Equals("O") Then
                                If SQL_Query(x + 3).ToString.ToUpper.Equals("M") Then

                                    temp_start_index = x
                                    Exit For
                                End If
                            End If
                        End If
                    End If

                Next
                from_statment = SQL_Query.Replace(SQL_Query.Substring(0, temp_start_index), "")
                Dim colname As String = DataGridView1.SelectedCells(0).OwningColumn.HeaderText

                from_statment = from_statment.ToUpper
                from_statment = from_statment.Replace("WHERE", "' WHERE " & colname & " = '" & value_cell & "' And ")
                SQL_Query = "Delete " & from_statment
                from_statment = ""
				Run_Query("ordselect", SQL_Query, "")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




        Else
            MsgBox("Only Select one Cell from the Row you want to Delete", MsgBoxStyle.Critical)

        End If

    End Sub
    Private theifrstis_lod_id As Boolean = False
    Private Sub InsertRowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InsertRowToolStripMenuItem.Click
        Dim colline As String = "("
        Dim collline2 As String = ""
        Dim valuesline As String = "VALUES ("
        For Each sac As DataGridViewColumn In DataGridView1.Columns
            colline &= "[" & sac.HeaderText & "]" & ","
            collline2 &= sac.HeaderText & ","
        Next
        colline = colline.TrimEnd(CType(",", Char))
        colline &= ")"
        collline2 = collline2.TrimEnd(CType(",", Char))
        Dim aSl As String() = Split(collline2, ",")
        Dim itsidco As Integer = 0
        For Each Stringv As String In aSl
            Dim newvalue As String = ""
            If itsidco = 0 Then
                newvalue = InputBox("Enter the new Value for : " & Stringv, "New Row Values", "it`sid")
            Else
                newvalue = InputBox("Enter the new Value for : " & Stringv, "New Row Values", "NULL")
            End If

            If newvalue.Length >= 1 Then
            Else
                newvalue = "NULL"
            End If
            newvalue = "it`sid"

            If newvalue.Equals("it`sid") Then
                If theifrstis_lod_id = True Then
                    newvalue = "NULL"
                Else
                    theifrstis_lod_id = True
                End If

            Else
                valuesline &= "'" & newvalue & "'" & ","
            End If
            itsidco += 1
        Next

        If theifrstis_lod_id Then
            valuesline = valuesline.Replace("'it`sid',", "")
            colline = "("
            For Each sac As DataGridViewColumn In DataGridView1.Columns
                If theifrstis_lod_id = True Then
                    colline &= ""
                    theifrstis_lod_id = False
                Else
                    colline &= "[" & sac.HeaderText & "]" & ","
                End If



            Next
            colline = colline.TrimEnd(CType(",", Char))
            colline &= ")"

        End If

        valuesline = valuesline.TrimEnd(CType(",", Char))
        valuesline &= ")"
        Try
            Dim tabpagename As String = TabControl1.SelectedTab.Text
            tabpagename = tabpagename.Replace(" ", "")
            Dim tatemp As TabPage = TabControl1.SelectedTab
            'RichTextBox1
            Dim SQL_Query As String = ""
            For Each C As Control In tatemp.Controls
                If C.Name.Equals("RichTextBox1") Then
                    Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                    SQL_Query = tabpage_RichTextBox1a.Text
                    Exit For
                End If
            Next
            Dim from_statment As String = ""
            Dim temp_start_index As Integer = 0
            For x As Integer = 0 To SQL_Query.Length - 1
                If SQL_Query(x).ToString.ToUpper.Equals("F") Then
                    If SQL_Query(x + 1).ToString.ToUpper.Equals("R") Then
                        If SQL_Query(x + 2).ToString.ToUpper.Equals("O") Then
                            If SQL_Query(x + 3).ToString.ToUpper.Equals("M") Then
                                temp_start_index = x
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next
            from_statment = SQL_Query.Replace(SQL_Query.Substring(0, temp_start_index), "")
            Dim colname As String = DataGridView1.SelectedCells(0).OwningColumn.HeaderText
            from_statment = from_statment.ToUpper
            from_statment = from_statment.Replace("FROM", "")
            SQL_Query = "Insert INTO " & from_statment
            from_statment = SQL_Query
            For x As Integer = 0 To SQL_Query.Length - 1

                If SQL_Query(x).ToString.ToUpper.Equals("W") Then
                    If SQL_Query(x + 1).ToString.ToUpper.Equals("H") Then
                        If SQL_Query(x + 2).ToString.ToUpper.Equals("E") Then
                            If SQL_Query(x + 3).ToString.ToUpper.Equals("R") Then
                                If SQL_Query(x + 4).ToString.ToUpper.Equals("E") Then

                                    temp_start_index = x
                                    Exit For
                                End If
                            End If
                        End If
                    End If
                End If

            Next
            from_statment = SQL_Query.Replace(SQL_Query.Substring(0, temp_start_index), "")
            SQL_Query = SQL_Query.Replace(from_statment, "")
            SQL_Query &= colline & valuesline
            MsgBox(SQL_Query)
            Run_Query("ordselect", SQL_Query, "")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try















    End Sub
 
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim tabpagename As String = TabControl1.SelectedTab.Text
            tabpagename = tabpagename.Replace(" ", "")
            Dim tatemp As TabPage = TabControl1.SelectedTab
            'RichTextBox1

            For Each C As Control In tatemp.Controls
                If C.Name.Equals("RichTextBox1") Then
                    Dim tabpage_RichTextBox1a As RichTextBox = CType(C, RichTextBox)
                    Run_Query("ordselect", tabpage_RichTextBox1a.Text, "")
                    Exit For
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Timer1.Stop()
        Exit Sub
    End Sub

     
End Class