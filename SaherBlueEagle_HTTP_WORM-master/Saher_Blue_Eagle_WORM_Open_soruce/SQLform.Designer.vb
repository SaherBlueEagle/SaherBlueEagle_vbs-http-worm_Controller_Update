<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Databases", 0, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Linked Servers", 0, 0)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Triggers", 0, 0)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Security", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("server", 16, 16, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode4})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLform))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Results = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Messages = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RefreshDatabasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshViewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectTop200RowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Results.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Messages.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(757, 505)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 16
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "Databases"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Text = "Databases"
        TreeNode2.ImageIndex = 0
        TreeNode2.Name = "Linkedservers"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Text = "Linked Servers"
        TreeNode3.ImageIndex = 0
        TreeNode3.Name = "Triggers"
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Text = "Triggers"
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = "Security"
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Text = "Security"
        TreeNode5.ImageIndex = 16
        TreeNode5.Name = "server"
        TreeNode5.SelectedImageIndex = 16
        TreeNode5.Text = "server"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.TreeView1.SelectedImageIndex = 21
        Me.TreeView1.Size = New System.Drawing.Size(215, 503)
        Me.TreeView1.StateImageList = Me.ImageList1
        Me.TreeView1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "dpedtui_207.ico")
        Me.ImageList1.Images.SetKeyName(1, "dpprjui_207.ico")
        Me.ImageList1.Images.SetKeyName(2, "dpprjui_4010.ico")
        Me.ImageList1.Images.SetKeyName(3, "Microsoft_1_398.ico")
        Me.ImageList1.Images.SetKeyName(4, "Microsoft_1_1444.ico")
        Me.ImageList1.Images.SetKeyName(5, "Microsoft_613.ico")
        Me.ImageList1.Images.SetKeyName(6, "Microsoft_653.ico")
        Me.ImageList1.Images.SetKeyName(7, "Microsoft_663.ico")
        Me.ImageList1.Images.SetKeyName(8, "Microsoft_753.ico")
        Me.ImageList1.Images.SetKeyName(9, "Microsoft_773.ico")
        Me.ImageList1.Images.SetKeyName(10, "Microsoft_863.ico")
        Me.ImageList1.Images.SetKeyName(11, "Microsoft_943.ico")
        Me.ImageList1.Images.SetKeyName(12, "Microsoft_1013.ico")
        Me.ImageList1.Images.SetKeyName(13, "Microsoft_1193.ico")
        Me.ImageList1.Images.SetKeyName(14, "Microsoft_1273.ico")
        Me.ImageList1.Images.SetKeyName(15, "Microsoft_1333.ico")
        Me.ImageList1.Images.SetKeyName(16, "Microsoft_1445.ico")
        Me.ImageList1.Images.SetKeyName(17, "Microsoft_1513.ico")
        Me.ImageList1.Images.SetKeyName(18, "Microsoft_1533.ico")
        Me.ImageList1.Images.SetKeyName(19, "Microsoft_1553.ico")
        Me.ImageList1.Images.SetKeyName(20, "Microsoft_1603.ico")
        Me.ImageList1.Images.SetKeyName(21, "docprop_1998.ico")
        Me.ImageList1.Images.SetKeyName(22, "Microsoft_1_753.ico")
        Me.ImageList1.Images.SetKeyName(23, "Microsoft_653.ico")
        Me.ImageList1.Images.SetKeyName(24, "Microsoft_9017.ico")
        Me.ImageList1.Images.SetKeyName(25, "Microsoft_1_753.ico")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 167)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(536, 338)
        Me.SplitContainer2.SplitterDistance = 177
        Me.SplitContainer2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(534, 175)
        Me.TabControl1.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.Results)
        Me.TabControl2.Controls.Add(Me.Messages)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ImageList = Me.ImageList1
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(534, 155)
        Me.TabControl2.TabIndex = 0
        '
        'Results
        '
        Me.Results.Controls.Add(Me.DataGridView1)
        Me.Results.Controls.Add(Me.Panel2)
        Me.Results.ImageKey = "Microsoft_753.ico"
        Me.Results.Location = New System.Drawing.Point(4, 23)
        Me.Results.Name = "Results"
        Me.Results.Padding = New System.Windows.Forms.Padding(3)
        Me.Results.Size = New System.Drawing.Size(526, 128)
        Me.Results.TabIndex = 0
        Me.Results.Text = "Selected Query Results"
        Me.Results.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(520, 122)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertRowToolStripMenuItem, Me.DeleteRowToolStripMenuItem, Me.EditValueToolStripMenuItem, Me.SaveAllToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(134, 92)
        '
        'InsertRowToolStripMenuItem
        '
        Me.InsertRowToolStripMenuItem.Name = "InsertRowToolStripMenuItem"
        Me.InsertRowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.InsertRowToolStripMenuItem.Text = "Insert Row"
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete Row"
        '
        'EditValueToolStripMenuItem
        '
        Me.EditValueToolStripMenuItem.Name = "EditValueToolStripMenuItem"
        Me.EditValueToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EditValueToolStripMenuItem.Text = "Edit Value"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.RichTextBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(131, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 10)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(201, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 0)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "SQL Server Authentication"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 0)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Windows Authentication"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RichTextBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 18)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(256, 30)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = Global.Saher_Blue_Eagle_WORM.My.Resources.Resources.Dl_HELLOVIR
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Connection String"
        '
        'Messages
        '
        Me.Messages.Controls.Add(Me.RichTextBox1)
        Me.Messages.ImageKey = "Microsoft_9017.ico"
        Me.Messages.Location = New System.Drawing.Point(4, 23)
        Me.Messages.Name = "Messages"
        Me.Messages.Padding = New System.Windows.Forms.Padding(3)
        Me.Messages.Size = New System.Drawing.Size(524, 128)
        Me.Messages.TabIndex = 1
        Me.Messages.Text = "Messages"
        Me.Messages.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(518, 122)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = Global.Saher_Blue_Eagle_WORM.My.Resources.Resources.Dl_HELLOVIR
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 167)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(532, 27)
        Me.Panel3.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(258, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 25)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Clear Queries"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(248, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 25)
        Me.Panel5.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(129, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Execute"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(119, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 25)
        Me.Panel4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Query"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RefreshDatabasesToolStripMenuItem
        '
        Me.RefreshDatabasesToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshDatabasesToolStripMenuItem.Name = "RefreshDatabasesToolStripMenuItem"
        Me.RefreshDatabasesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RefreshDatabasesToolStripMenuItem.Text = "Refresh Databases"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDatabasesToolStripMenuItem, Me.RefreshTablesToolStripMenuItem, Me.RefreshViewsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(194, 70)
        '
        'RefreshTablesToolStripMenuItem
        '
        Me.RefreshTablesToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshTablesToolStripMenuItem.Name = "RefreshTablesToolStripMenuItem"
        Me.RefreshTablesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RefreshTablesToolStripMenuItem.Text = "Refresh Tables"
        '
        'RefreshViewsToolStripMenuItem
        '
        Me.RefreshViewsToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RefreshViewsToolStripMenuItem.Name = "RefreshViewsToolStripMenuItem"
        Me.RefreshViewsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RefreshViewsToolStripMenuItem.Text = "Refresh Views"
        '
        'DeleteTableToolStripMenuItem
        '
        Me.DeleteTableToolStripMenuItem.Name = "DeleteTableToolStripMenuItem"
        Me.DeleteTableToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteTableToolStripMenuItem.Text = "Delete Table"
        '
        'SelectTop200RowsToolStripMenuItem
        '
        Me.SelectTop200RowsToolStripMenuItem.Name = "SelectTop200RowsToolStripMenuItem"
        Me.SelectTop200RowsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SelectTop200RowsToolStripMenuItem.Text = "Select Top 20 Rows"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectTop200RowsToolStripMenuItem, Me.DeleteTableToolStripMenuItem, Me.DeleteViewToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(176, 70)
        '
        'DeleteViewToolStripMenuItem
        '
        Me.DeleteViewToolStripMenuItem.Name = "DeleteViewToolStripMenuItem"
        Me.DeleteViewToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteViewToolStripMenuItem.Text = "Delete View"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'SQLform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 505)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SQLform"
        Me.Text = "SQLform"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.Results.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Messages.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents Results As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Messages As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RefreshDatabasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshViewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectTop200RowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
