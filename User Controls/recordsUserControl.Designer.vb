﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recordsUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.borrowListTabPage = New System.Windows.Forms.TabPage()
        Me.borrowListDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchBorrowBtn = New System.Windows.Forms.Button()
        Me.searchBorrowTxtBx = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.returnListDataGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.searchReturnBtn = New System.Windows.Forms.Button()
        Me.searchReturnTxtBx = New System.Windows.Forms.TextBox()
        Me.reserveListTabPage = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.reservationListDataGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reservationId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchReservationBtn = New System.Windows.Forms.Button()
        Me.searchReservationTxtBx = New System.Windows.Forms.TextBox()
        Me.Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelDataGridViewBorrowList = New System.Windows.Forms.Panel()
        Me.TabControl.SuspendLayout()
        Me.borrowListTabPage.SuspendLayout()
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.returnListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.reserveListTabPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelDataGridViewBorrowList.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.borrowListTabPage)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.reserveListTabPage)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(10, 5)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1700, 760)
        Me.TabControl.TabIndex = 1
        '
        'borrowListTabPage
        '
        Me.borrowListTabPage.BackColor = System.Drawing.Color.White
        Me.borrowListTabPage.Controls.Add(Me.PanelDataGridViewBorrowList)
        Me.borrowListTabPage.Controls.Add(Me.Panel1)
        Me.borrowListTabPage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowListTabPage.Location = New System.Drawing.Point(4, 36)
        Me.borrowListTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListTabPage.Name = "borrowListTabPage"
        Me.borrowListTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListTabPage.Size = New System.Drawing.Size(1692, 720)
        Me.borrowListTabPage.TabIndex = 0
        Me.borrowListTabPage.Text = "Borrow List"
        '
        'borrowListDataGrid
        '
        Me.borrowListDataGrid.AllowUserToAddRows = False
        Me.borrowListDataGrid.AllowUserToDeleteRows = False
        Me.borrowListDataGrid.AllowUserToResizeColumns = False
        Me.borrowListDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.borrowListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.borrowListDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.borrowListDataGrid.ColumnHeadersHeight = 29
        Me.borrowListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.borrowListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cover_Column, Me.Status_Column, Me.BorrowDate_Column, Me.DueDate_Column, Me.Title_Column, Me.ShelfID_Column, Me.ID_Column, Me.borrowId, Me.Button_Column})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.borrowListDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.borrowListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.borrowListDataGrid.EnableHeadersVisualStyles = False
        Me.borrowListDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.borrowListDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListDataGrid.Name = "borrowListDataGrid"
        Me.borrowListDataGrid.ReadOnly = True
        Me.borrowListDataGrid.RowHeadersVisible = False
        Me.borrowListDataGrid.RowHeadersWidth = 51
        Me.borrowListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.borrowListDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.borrowListDataGrid.RowTemplate.Height = 24
        Me.borrowListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.borrowListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.borrowListDataGrid.Size = New System.Drawing.Size(1686, 626)
        Me.borrowListDataGrid.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.searchBorrowBtn)
        Me.Panel1.Controls.Add(Me.searchBorrowTxtBx)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1686, 90)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1686, 6)
        Me.Panel2.TabIndex = 21
        '
        'searchBorrowBtn
        '
        Me.searchBorrowBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.searchBorrowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowBtn.Location = New System.Drawing.Point(1584, 32)
        Me.searchBorrowBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchBorrowBtn.Name = "searchBorrowBtn"
        Me.searchBorrowBtn.Size = New System.Drawing.Size(93, 34)
        Me.searchBorrowBtn.TabIndex = 20
        Me.searchBorrowBtn.Text = "Search"
        Me.searchBorrowBtn.UseVisualStyleBackColor = True
        '
        'searchBorrowTxtBx
        '
        Me.searchBorrowTxtBx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.searchBorrowTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchBorrowTxtBx.Location = New System.Drawing.Point(1286, 34)
        Me.searchBorrowTxtBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchBorrowTxtBx.Name = "searchBorrowTxtBx"
        Me.searchBorrowTxtBx.Size = New System.Drawing.Size(292, 30)
        Me.searchBorrowTxtBx.TabIndex = 19
        Me.searchBorrowTxtBx.Text = "Search ID number..."
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage4.Controls.Add(Me.returnListDataGrid)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Size = New System.Drawing.Size(1550, 520)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Return List"
        '
        'returnListDataGrid
        '
        Me.returnListDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.returnListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.returnListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewButtonColumn1})
        Me.returnListDataGrid.Location = New System.Drawing.Point(0, 89)
        Me.returnListDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.returnListDataGrid.Name = "returnListDataGrid"
        Me.returnListDataGrid.RowHeadersWidth = 51
        Me.returnListDataGrid.RowTemplate.Height = 24
        Me.returnListDataGrid.Size = New System.Drawing.Size(1550, 1310)
        Me.returnListDataGrid.TabIndex = 3
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Cover"
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Borrow Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Copy #"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID No."
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "BorrowID"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Check In"
        Me.DataGridViewButtonColumn1.MinimumWidth = 6
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Check In"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 125
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.searchReturnBtn)
        Me.Panel5.Controls.Add(Me.searchReturnTxtBx)
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(749, 69)
        Me.Panel5.TabIndex = 2
        '
        'searchReturnBtn
        '
        Me.searchReturnBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.searchReturnBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReturnBtn.Location = New System.Drawing.Point(317, 18)
        Me.searchReturnBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReturnBtn.Name = "searchReturnBtn"
        Me.searchReturnBtn.Size = New System.Drawing.Size(93, 38)
        Me.searchReturnBtn.TabIndex = 18
        Me.searchReturnBtn.Text = "Search"
        Me.searchReturnBtn.UseVisualStyleBackColor = True
        '
        'searchReturnTxtBx
        '
        Me.searchReturnTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchReturnTxtBx.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReturnTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchReturnTxtBx.Location = New System.Drawing.Point(43, 20)
        Me.searchReturnTxtBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReturnTxtBx.Multiline = True
        Me.searchReturnTxtBx.Name = "searchReturnTxtBx"
        Me.searchReturnTxtBx.Size = New System.Drawing.Size(273, 37)
        Me.searchReturnTxtBx.TabIndex = 17
        Me.searchReturnTxtBx.Text = "Search ID number..."
        '
        'reserveListTabPage
        '
        Me.reserveListTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.reserveListTabPage.Controls.Add(Me.Panel4)
        Me.reserveListTabPage.Controls.Add(Me.Panel3)
        Me.reserveListTabPage.Location = New System.Drawing.Point(4, 36)
        Me.reserveListTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reserveListTabPage.Name = "reserveListTabPage"
        Me.reserveListTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reserveListTabPage.Size = New System.Drawing.Size(1692, 720)
        Me.reserveListTabPage.TabIndex = 2
        Me.reserveListTabPage.Text = "Reserve List"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.reservationListDataGrid)
        Me.Panel4.Location = New System.Drawing.Point(134, 143)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 670)
        Me.Panel4.TabIndex = 2
        '
        'reservationListDataGrid
        '
        Me.reservationListDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reservationListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reservationListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1, Me.ReserveDate_Column, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.reservationId, Me.Complete_Column})
        Me.reservationListDataGrid.Location = New System.Drawing.Point(257, 110)
        Me.reservationListDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reservationListDataGrid.Name = "reservationListDataGrid"
        Me.reservationListDataGrid.RowHeadersWidth = 51
        Me.reservationListDataGrid.RowTemplate.Height = 24
        Me.reservationListDataGrid.Size = New System.Drawing.Size(928, 646)
        Me.reservationListDataGrid.TabIndex = 0
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Cover"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'ReserveDate_Column
        '
        Me.ReserveDate_Column.HeaderText = "Reserve Date"
        Me.ReserveDate_Column.MinimumWidth = 6
        Me.ReserveDate_Column.Name = "ReserveDate_Column"
        Me.ReserveDate_Column.ReadOnly = True
        Me.ReserveDate_Column.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Copy #"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID No."
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'reservationId
        '
        Me.reservationId.HeaderText = "ReservationID"
        Me.reservationId.MinimumWidth = 6
        Me.reservationId.Name = "reservationId"
        Me.reservationId.ReadOnly = True
        Me.reservationId.Visible = False
        Me.reservationId.Width = 125
        '
        'Complete_Column
        '
        Me.Complete_Column.HeaderText = "Complete"
        Me.Complete_Column.MinimumWidth = 6
        Me.Complete_Column.Name = "Complete_Column"
        Me.Complete_Column.Text = "Complete"
        Me.Complete_Column.UseColumnTextForButtonValue = True
        Me.Complete_Column.Width = 125
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.searchReservationBtn)
        Me.Panel3.Controls.Add(Me.searchReservationTxtBx)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 69)
        Me.Panel3.TabIndex = 1
        '
        'searchReservationBtn
        '
        Me.searchReservationBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.searchReservationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationBtn.Location = New System.Drawing.Point(317, 18)
        Me.searchReservationBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReservationBtn.Name = "searchReservationBtn"
        Me.searchReservationBtn.Size = New System.Drawing.Size(93, 38)
        Me.searchReservationBtn.TabIndex = 18
        Me.searchReservationBtn.Text = "Search"
        Me.searchReservationBtn.UseVisualStyleBackColor = True
        '
        'searchReservationTxtBx
        '
        Me.searchReservationTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchReservationTxtBx.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchReservationTxtBx.Location = New System.Drawing.Point(43, 20)
        Me.searchReservationTxtBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReservationTxtBx.Multiline = True
        Me.searchReservationTxtBx.Name = "searchReservationTxtBx"
        Me.searchReservationTxtBx.Size = New System.Drawing.Size(273, 37)
        Me.searchReservationTxtBx.TabIndex = 17
        Me.searchReservationTxtBx.Text = "Search ID number..."
        '
        'Cover_Column
        '
        Me.Cover_Column.HeaderText = "Cover"
        Me.Cover_Column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Cover_Column.MinimumWidth = 6
        Me.Cover_Column.Name = "Cover_Column"
        Me.Cover_Column.ReadOnly = True
        Me.Cover_Column.Width = 67
        '
        'Status_Column
        '
        Me.Status_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Status_Column.HeaderText = "Status"
        Me.Status_Column.MinimumWidth = 6
        Me.Status_Column.Name = "Status_Column"
        Me.Status_Column.ReadOnly = True
        Me.Status_Column.Width = 108
        '
        'BorrowDate_Column
        '
        Me.BorrowDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BorrowDate_Column.HeaderText = "Borrow Date"
        Me.BorrowDate_Column.MinimumWidth = 6
        Me.BorrowDate_Column.Name = "BorrowDate_Column"
        Me.BorrowDate_Column.ReadOnly = True
        Me.BorrowDate_Column.Width = 174
        '
        'DueDate_Column
        '
        Me.DueDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DueDate_Column.HeaderText = "Due Date"
        Me.DueDate_Column.MinimumWidth = 6
        Me.DueDate_Column.Name = "DueDate_Column"
        Me.DueDate_Column.ReadOnly = True
        Me.DueDate_Column.Width = 138
        '
        'Title_Column
        '
        Me.Title_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Title_Column.HeaderText = "Title"
        Me.Title_Column.MinimumWidth = 6
        Me.Title_Column.Name = "Title_Column"
        Me.Title_Column.ReadOnly = True
        '
        'ShelfID_Column
        '
        Me.ShelfID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShelfID_Column.HeaderText = "Copy #"
        Me.ShelfID_Column.MinimumWidth = 6
        Me.ShelfID_Column.Name = "ShelfID_Column"
        Me.ShelfID_Column.ReadOnly = True
        Me.ShelfID_Column.Width = 111
        '
        'ID_Column
        '
        Me.ID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID_Column.HeaderText = "ID No."
        Me.ID_Column.MinimumWidth = 6
        Me.ID_Column.Name = "ID_Column"
        Me.ID_Column.ReadOnly = True
        Me.ID_Column.Width = 108
        '
        'borrowId
        '
        Me.borrowId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.borrowId.HeaderText = "BorrowID"
        Me.borrowId.MinimumWidth = 6
        Me.borrowId.Name = "borrowId"
        Me.borrowId.ReadOnly = True
        Me.borrowId.Visible = False
        Me.borrowId.Width = 131
        '
        'Button_Column
        '
        Me.Button_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Button_Column.HeaderText = "Check In"
        Me.Button_Column.MinimumWidth = 6
        Me.Button_Column.Name = "Button_Column"
        Me.Button_Column.ReadOnly = True
        Me.Button_Column.Text = "Check In"
        Me.Button_Column.UseColumnTextForButtonValue = True
        Me.Button_Column.Width = 112
        '
        'PanelDataGridViewBorrowList
        '
        Me.PanelDataGridViewBorrowList.AutoScroll = True
        Me.PanelDataGridViewBorrowList.Controls.Add(Me.borrowListDataGrid)
        Me.PanelDataGridViewBorrowList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDataGridViewBorrowList.Location = New System.Drawing.Point(3, 92)
        Me.PanelDataGridViewBorrowList.Name = "PanelDataGridViewBorrowList"
        Me.PanelDataGridViewBorrowList.Size = New System.Drawing.Size(1686, 626)
        Me.PanelDataGridViewBorrowList.TabIndex = 1
        '
        'recordsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "recordsUserControl"
        Me.Size = New System.Drawing.Size(1700, 760)
        Me.TabControl.ResumeLayout(False)
        Me.borrowListTabPage.ResumeLayout(False)
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.returnListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.reserveListTabPage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelDataGridViewBorrowList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents borrowListTabPage As TabPage
    Friend WithEvents borrowListDataGrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchBorrowBtn As Button
    Friend WithEvents searchBorrowTxtBx As TextBox
    Friend WithEvents reserveListTabPage As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents reservationListDataGrid As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents reservationId As DataGridViewTextBoxColumn
    Friend WithEvents Complete_Column As DataGridViewButtonColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents searchReturnBtn As Button
    Friend WithEvents searchReturnTxtBx As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents searchReservationBtn As Button
    Friend WithEvents searchReservationTxtBx As TextBox
    Friend WithEvents returnListDataGrid As DataGridView
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cover_Column As DataGridViewImageColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents ID_Column As DataGridViewTextBoxColumn
    Friend WithEvents borrowId As DataGridViewTextBoxColumn
    Friend WithEvents Button_Column As DataGridViewButtonColumn
    Friend WithEvents PanelDataGridViewBorrowList As Panel
End Class
