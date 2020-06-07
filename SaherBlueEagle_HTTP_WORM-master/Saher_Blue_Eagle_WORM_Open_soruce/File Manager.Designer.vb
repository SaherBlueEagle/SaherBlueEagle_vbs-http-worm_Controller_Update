<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class File_Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(File_Manager))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BOXT1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDowloadsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMGList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BOXT1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Lime
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 79)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BOXT1
        '
        Me.BOXT1.BackColor = System.Drawing.Color.White
        Me.BOXT1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BOXT1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOXT1.Location = New System.Drawing.Point(0, 19)
        Me.BOXT1.Name = "BOXT1"
        Me.BOXT1.ReadOnly = True
        Me.BOXT1.Size = New System.Drawing.Size(612, 26)
        Me.BOXT1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Local Path"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Consolas", 11.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ExecuteFileToolStripMenuItem, Me.UploadFileToolStripMenuItem, Me.DownloadFileToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.RenameFileToolStripMenuItem, Me.AddNewFolderToolStripMenuItem, Me.OpenDowloadsFolderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(237, 180)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RefreshToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ExecuteFileToolStripMenuItem
        '
        Me.ExecuteFileToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ExecuteFileToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ExecuteFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExecuteFileToolStripMenuItem.Image = CType(resources.GetObject("ExecuteFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExecuteFileToolStripMenuItem.Name = "ExecuteFileToolStripMenuItem"
        Me.ExecuteFileToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ExecuteFileToolStripMenuItem.Text = "Execute File"
        '
        'UploadFileToolStripMenuItem
        '
        Me.UploadFileToolStripMenuItem.BackgroundImage = CType(resources.GetObject("UploadFileToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.UploadFileToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadFileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UploadFileToolStripMenuItem.Image = CType(resources.GetObject("UploadFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem"
        Me.UploadFileToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.UploadFileToolStripMenuItem.Text = "Upload File"
        '
        'DownloadFileToolStripMenuItem
        '
        Me.DownloadFileToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DownloadFileToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DownloadFileToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadFileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DownloadFileToolStripMenuItem.Image = CType(resources.GetObject("DownloadFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadFileToolStripMenuItem.Name = "DownloadFileToolStripMenuItem"
        Me.DownloadFileToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DownloadFileToolStripMenuItem.Text = "Download File"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DeleteFileToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DeleteFileToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteFileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteFileToolStripMenuItem.Image = CType(resources.GetObject("DeleteFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File"
        '
        'RenameFileToolStripMenuItem
        '
        Me.RenameFileToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RenameFileToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.RenameFileToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenameFileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RenameFileToolStripMenuItem.Image = CType(resources.GetObject("RenameFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem"
        Me.RenameFileToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RenameFileToolStripMenuItem.Text = "Rename Folder / File"
        '
        'AddNewFolderToolStripMenuItem
        '
        Me.AddNewFolderToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AddNewFolderToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AddNewFolderToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddNewFolderToolStripMenuItem.Image = CType(resources.GetObject("AddNewFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewFolderToolStripMenuItem.Name = "AddNewFolderToolStripMenuItem"
        Me.AddNewFolderToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AddNewFolderToolStripMenuItem.Text = "Add New Folder"
        '
        'OpenDowloadsFolderToolStripMenuItem
        '
        Me.OpenDowloadsFolderToolStripMenuItem.BackgroundImage = CType(resources.GetObject("OpenDowloadsFolderToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.OpenDowloadsFolderToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenDowloadsFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenDowloadsFolderToolStripMenuItem.Image = CType(resources.GetObject("OpenDowloadsFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenDowloadsFolderToolStripMenuItem.Name = "OpenDowloadsFolderToolStripMenuItem"
        Me.OpenDowloadsFolderToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OpenDowloadsFolderToolStripMenuItem.Text = "Open Dowloads Folder"
        '
        'IMGList1
        '
        Me.IMGList1.ImageStream = CType(resources.GetObject("IMGList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMGList1.TransparentColor = System.Drawing.Color.Transparent
        Me.IMGList1.Images.SetKeyName(0, "shell32_1.ico")
        Me.IMGList1.Images.SetKeyName(1, "shell32_5.ico")
        Me.IMGList1.Images.SetKeyName(2, "shell32_9.ico")
        Me.IMGList1.Images.SetKeyName(3, "shell32_10.ico")
        Me.IMGList1.Images.SetKeyName(4, "shell32_12.ico")
        Me.IMGList1.Images.SetKeyName(5, "shell32_27.ico")
        Me.IMGList1.Images.SetKeyName(6, "shell32_43.ico")
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Teal
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView1.FullRowSelect = True
        Me.ListView1.LargeImageList = Me.IMGList1
        Me.ListView1.Location = New System.Drawing.Point(0, 79)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(616, 383)
        Me.ListView1.SmallImageList = Me.IMGList1
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ext Type"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.Width = 100
        '
        'File_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 462)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "File_Manager"
        Me.Text = "File Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BOXT1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDowloadsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMGList1 As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
