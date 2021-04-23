<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recordsUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.borrowListTabPage = New System.Windows.Forms.TabPage()
        Me.PanelDataGridViewBorrowList = New System.Windows.Forms.Panel()
        Me.borrowListDataGrid = New System.Windows.Forms.DataGridView()
        Me.B_Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.B_BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_ISBN_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_Edition_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_BowID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckIn_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxBookDetailBorrowList = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBookDetailFilterBorrowList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerBorrowListTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerBorrowListFrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchBorrowBtn = New System.Windows.Forms.Button()
        Me.searchBorrowTxtBx1 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.returnListDataGrid = New System.Windows.Forms.DataGridView()
        Me.Ret_Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ret_PaymentStatus_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_DateReturned_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_Penalty_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_ISBN_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_Edition_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_BowID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ret_UpdatePStatus_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxReturnListDate = New System.Windows.Forms.ComboBox()
        Me.TextBoxBookDetailReturnList = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxBookDetailFilterReturnList = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePickeReturnListTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerReturnListFrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.searchReturnBtn = New System.Windows.Forms.Button()
        Me.searchReturnTxtBx = New System.Windows.Forms.TextBox()
        Me.reserveListTabPage = New System.Windows.Forms.TabPage()
        Me.PanelDataGridViewReserveList = New System.Windows.Forms.Panel()
        Me.reservationListDataGrid = New System.Windows.Forms.DataGridView()
        Me.Res_Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Res_Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_ReserveDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_ISBN_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_Edition_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_BowID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Res_ReservationID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxBookDetailReserveList = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxBookDetailFilterReserveList = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePickerReserveListTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerReserveListFrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.searchReservationBtn = New System.Windows.Forms.Button()
        Me.searchReservationTxtBx = New System.Windows.Forms.TextBox()
        Me.LinkLabelReturnedBooks = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelBorrowedBooks = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelReservedBooks = New System.Windows.Forms.LinkLabel()
        Me.TabControl.SuspendLayout()
        Me.borrowListTabPage.SuspendLayout()
        Me.PanelDataGridViewBorrowList.SuspendLayout()
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.returnListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.reserveListTabPage.SuspendLayout()
        Me.PanelDataGridViewReserveList.SuspendLayout()
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.borrowListTabPage)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.reserveListTabPage)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(10, 5)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1750, 795)
        Me.TabControl.TabIndex = 1
        '
        'borrowListTabPage
        '
        Me.borrowListTabPage.BackColor = System.Drawing.Color.White
        Me.borrowListTabPage.Controls.Add(Me.PanelDataGridViewBorrowList)
        Me.borrowListTabPage.Controls.Add(Me.Panel1)
        Me.borrowListTabPage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowListTabPage.Location = New System.Drawing.Point(4, 34)
        Me.borrowListTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListTabPage.Name = "borrowListTabPage"
        Me.borrowListTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListTabPage.Size = New System.Drawing.Size(1742, 757)
        Me.borrowListTabPage.TabIndex = 0
        Me.borrowListTabPage.Text = "Borrow List"
        '
        'PanelDataGridViewBorrowList
        '
        Me.PanelDataGridViewBorrowList.AutoScroll = True
        Me.PanelDataGridViewBorrowList.Controls.Add(Me.borrowListDataGrid)
        Me.PanelDataGridViewBorrowList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDataGridViewBorrowList.Location = New System.Drawing.Point(3, 116)
        Me.PanelDataGridViewBorrowList.Name = "PanelDataGridViewBorrowList"
        Me.PanelDataGridViewBorrowList.Size = New System.Drawing.Size(1736, 639)
        Me.PanelDataGridViewBorrowList.TabIndex = 1
        '
        'borrowListDataGrid
        '
        Me.borrowListDataGrid.AllowUserToAddRows = False
        Me.borrowListDataGrid.AllowUserToDeleteRows = False
        Me.borrowListDataGrid.AllowUserToResizeColumns = False
        Me.borrowListDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.borrowListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.borrowListDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.borrowListDataGrid.ColumnHeadersHeight = 29
        Me.borrowListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.borrowListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.B_Cover_Column, Me.B_BorrowDate_Column, Me.B_DueDate_Column, Me.B_ISBN_Column, Me.B_Title_Column, Me.B_Edition_Column, Me.B_ShelfID_Column, Me.B_BowID_Column, Me.CheckIn_Column})
        Me.borrowListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.borrowListDataGrid.EnableHeadersVisualStyles = False
        Me.borrowListDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.borrowListDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrowListDataGrid.Name = "borrowListDataGrid"
        Me.borrowListDataGrid.ReadOnly = True
        Me.borrowListDataGrid.RowHeadersVisible = False
        Me.borrowListDataGrid.RowHeadersWidth = 51
        Me.borrowListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.borrowListDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.borrowListDataGrid.RowTemplate.Height = 30
        Me.borrowListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.borrowListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.borrowListDataGrid.Size = New System.Drawing.Size(1736, 639)
        Me.borrowListDataGrid.TabIndex = 0
        '
        'B_Cover_Column
        '
        Me.B_Cover_Column.HeaderText = "Cover"
        Me.B_Cover_Column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.B_Cover_Column.MinimumWidth = 6
        Me.B_Cover_Column.Name = "B_Cover_Column"
        Me.B_Cover_Column.ReadOnly = True
        Me.B_Cover_Column.Width = 67
        '
        'B_BorrowDate_Column
        '
        Me.B_BorrowDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_BorrowDate_Column.HeaderText = "Borrow Date"
        Me.B_BorrowDate_Column.MinimumWidth = 6
        Me.B_BorrowDate_Column.Name = "B_BorrowDate_Column"
        Me.B_BorrowDate_Column.ReadOnly = True
        Me.B_BorrowDate_Column.Width = 149
        '
        'B_DueDate_Column
        '
        Me.B_DueDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_DueDate_Column.HeaderText = "Due Date"
        Me.B_DueDate_Column.MinimumWidth = 6
        Me.B_DueDate_Column.Name = "B_DueDate_Column"
        Me.B_DueDate_Column.ReadOnly = True
        Me.B_DueDate_Column.Width = 119
        '
        'B_ISBN_Column
        '
        Me.B_ISBN_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_ISBN_Column.HeaderText = "ISBN"
        Me.B_ISBN_Column.MinimumWidth = 6
        Me.B_ISBN_Column.Name = "B_ISBN_Column"
        Me.B_ISBN_Column.ReadOnly = True
        Me.B_ISBN_Column.Width = 86
        '
        'B_Title_Column
        '
        Me.B_Title_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_Title_Column.HeaderText = "Title"
        Me.B_Title_Column.MinimumWidth = 6
        Me.B_Title_Column.Name = "B_Title_Column"
        Me.B_Title_Column.ReadOnly = True
        Me.B_Title_Column.Width = 82
        '
        'B_Edition_Column
        '
        Me.B_Edition_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_Edition_Column.HeaderText = "Edition"
        Me.B_Edition_Column.MinimumWidth = 6
        Me.B_Edition_Column.Name = "B_Edition_Column"
        Me.B_Edition_Column.ReadOnly = True
        Me.B_Edition_Column.Width = 105
        '
        'B_ShelfID_Column
        '
        Me.B_ShelfID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_ShelfID_Column.HeaderText = "Copy #"
        Me.B_ShelfID_Column.MinimumWidth = 6
        Me.B_ShelfID_Column.Name = "B_ShelfID_Column"
        Me.B_ShelfID_Column.ReadOnly = True
        Me.B_ShelfID_Column.Width = 101
        '
        'B_BowID_Column
        '
        Me.B_BowID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.B_BowID_Column.HeaderText = "Borrower ID"
        Me.B_BowID_Column.MinimumWidth = 6
        Me.B_BowID_Column.Name = "B_BowID_Column"
        Me.B_BowID_Column.ReadOnly = True
        Me.B_BowID_Column.Width = 147
        '
        'CheckIn_Column
        '
        Me.CheckIn_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CheckIn_Column.HeaderText = ""
        Me.CheckIn_Column.MinimumWidth = 6
        Me.CheckIn_Column.Name = "CheckIn_Column"
        Me.CheckIn_Column.ReadOnly = True
        Me.CheckIn_Column.Text = "Check In"
        Me.CheckIn_Column.UseColumnTextForButtonValue = True
        Me.CheckIn_Column.Width = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabelBorrowedBooks)
        Me.Panel1.Controls.Add(Me.TextBoxBookDetailBorrowList)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxBookDetailFilterBorrowList)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePickerBorrowListTo)
        Me.Panel1.Controls.Add(Me.DateTimePickerBorrowListFrom)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.searchBorrowBtn)
        Me.Panel1.Controls.Add(Me.searchBorrowTxtBx1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1736, 114)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxBookDetailBorrowList
        '
        Me.TextBoxBookDetailBorrowList.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookDetailBorrowList.Location = New System.Drawing.Point(944, 72)
        Me.TextBoxBookDetailBorrowList.MaxLength = 200
        Me.TextBoxBookDetailBorrowList.Name = "TextBoxBookDetailBorrowList"
        Me.TextBoxBookDetailBorrowList.Size = New System.Drawing.Size(236, 33)
        Me.TextBoxBookDetailBorrowList.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 21)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Borrow Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1249, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Borrower ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Book Detail:"
        '
        'ComboBoxBookDetailFilterBorrowList
        '
        Me.ComboBoxBookDetailFilterBorrowList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBookDetailFilterBorrowList.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBookDetailFilterBorrowList.FormattingEnabled = True
        Me.ComboBoxBookDetailFilterBorrowList.Items.AddRange(New Object() {"Title", "ISBN", "Edition", "Copy#"})
        Me.ComboBoxBookDetailFilterBorrowList.Location = New System.Drawing.Point(702, 72)
        Me.ComboBoxBookDetailFilterBorrowList.Name = "ComboBoxBookDetailFilterBorrowList"
        Me.ComboBoxBookDetailFilterBorrowList.Size = New System.Drawing.Size(236, 36)
        Me.ComboBoxBookDetailFilterBorrowList.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "From:"
        '
        'DateTimePickerBorrowListTo
        '
        Me.DateTimePickerBorrowListTo.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBorrowListTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBorrowListTo.Location = New System.Drawing.Point(338, 75)
        Me.DateTimePickerBorrowListTo.Name = "DateTimePickerBorrowListTo"
        Me.DateTimePickerBorrowListTo.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickerBorrowListTo.TabIndex = 23
        '
        'DateTimePickerBorrowListFrom
        '
        Me.DateTimePickerBorrowListFrom.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBorrowListFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBorrowListFrom.Location = New System.Drawing.Point(156, 75)
        Me.DateTimePickerBorrowListFrom.Name = "DateTimePickerBorrowListFrom"
        Me.DateTimePickerBorrowListFrom.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickerBorrowListFrom.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1736, 6)
        Me.Panel2.TabIndex = 21
        '
        'searchBorrowBtn
        '
        Me.searchBorrowBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.searchBorrowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowBtn.Location = New System.Drawing.Point(1572, 37)
        Me.searchBorrowBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchBorrowBtn.Name = "searchBorrowBtn"
        Me.searchBorrowBtn.Size = New System.Drawing.Size(150, 68)
        Me.searchBorrowBtn.TabIndex = 20
        Me.searchBorrowBtn.Text = "Search"
        Me.searchBorrowBtn.UseVisualStyleBackColor = False
        '
        'searchBorrowTxtBx1
        '
        Me.searchBorrowTxtBx1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowTxtBx1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchBorrowTxtBx1.Location = New System.Drawing.Point(1253, 71)
        Me.searchBorrowTxtBx1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchBorrowTxtBx1.MaxLength = 20
        Me.searchBorrowTxtBx1.Name = "searchBorrowTxtBx1"
        Me.searchBorrowTxtBx1.Size = New System.Drawing.Size(238, 33)
        Me.searchBorrowTxtBx1.TabIndex = 19
        Me.searchBorrowTxtBx1.Text = "Search ID number..."
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage4.Size = New System.Drawing.Size(1742, 757)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Return List"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.returnListDataGrid)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 116)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1736, 639)
        Me.Panel4.TabIndex = 4
        '
        'returnListDataGrid
        '
        Me.returnListDataGrid.AllowUserToAddRows = False
        Me.returnListDataGrid.AllowUserToDeleteRows = False
        Me.returnListDataGrid.AllowUserToResizeColumns = False
        Me.returnListDataGrid.AllowUserToResizeRows = False
        Me.returnListDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.returnListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.returnListDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.returnListDataGrid.ColumnHeadersHeight = 29
        Me.returnListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.returnListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ret_Cover_Column, Me.Ret_PaymentStatus_Column, Me.Ret_BorrowDate_Column, Me.Ret_DueDate_Column, Me.Ret_DateReturned_Column, Me.Ret_Penalty_Column, Me.Ret_ISBN_Column, Me.Ret_Title_Column, Me.Ret_Edition_Column, Me.Ret_ShelfID_Column, Me.Ret_BowID_Column, Me.Ret_UpdatePStatus_Column})
        Me.returnListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.returnListDataGrid.EnableHeadersVisualStyles = False
        Me.returnListDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.returnListDataGrid.Name = "returnListDataGrid"
        Me.returnListDataGrid.ReadOnly = True
        Me.returnListDataGrid.RowHeadersVisible = False
        Me.returnListDataGrid.RowHeadersWidth = 51
        Me.returnListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.returnListDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.returnListDataGrid.RowTemplate.Height = 30
        Me.returnListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.returnListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.returnListDataGrid.Size = New System.Drawing.Size(1736, 639)
        Me.returnListDataGrid.TabIndex = 0
        '
        'Ret_Cover_Column
        '
        Me.Ret_Cover_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_Cover_Column.HeaderText = "Cover"
        Me.Ret_Cover_Column.Image = Global.LibraryManagementSystem.My.Resources.Resources.default_book
        Me.Ret_Cover_Column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Ret_Cover_Column.MinimumWidth = 6
        Me.Ret_Cover_Column.Name = "Ret_Cover_Column"
        Me.Ret_Cover_Column.ReadOnly = True
        Me.Ret_Cover_Column.Width = 68
        '
        'Ret_PaymentStatus_Column
        '
        Me.Ret_PaymentStatus_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_PaymentStatus_Column.HeaderText = "Payment Status"
        Me.Ret_PaymentStatus_Column.MinimumWidth = 6
        Me.Ret_PaymentStatus_Column.Name = "Ret_PaymentStatus_Column"
        Me.Ret_PaymentStatus_Column.ReadOnly = True
        Me.Ret_PaymentStatus_Column.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ret_PaymentStatus_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ret_PaymentStatus_Column.Width = 155
        '
        'Ret_BorrowDate_Column
        '
        Me.Ret_BorrowDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_BorrowDate_Column.HeaderText = "Borrow Date"
        Me.Ret_BorrowDate_Column.MinimumWidth = 6
        Me.Ret_BorrowDate_Column.Name = "Ret_BorrowDate_Column"
        Me.Ret_BorrowDate_Column.ReadOnly = True
        Me.Ret_BorrowDate_Column.Width = 151
        '
        'Ret_DueDate_Column
        '
        Me.Ret_DueDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_DueDate_Column.HeaderText = "Due Date"
        Me.Ret_DueDate_Column.MinimumWidth = 6
        Me.Ret_DueDate_Column.Name = "Ret_DueDate_Column"
        Me.Ret_DueDate_Column.ReadOnly = True
        Me.Ret_DueDate_Column.Width = 121
        '
        'Ret_DateReturned_Column
        '
        Me.Ret_DateReturned_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_DateReturned_Column.HeaderText = "Date Returned"
        Me.Ret_DateReturned_Column.MinimumWidth = 6
        Me.Ret_DateReturned_Column.Name = "Ret_DateReturned_Column"
        Me.Ret_DateReturned_Column.ReadOnly = True
        Me.Ret_DateReturned_Column.Width = 170
        '
        'Ret_Penalty_Column
        '
        Me.Ret_Penalty_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_Penalty_Column.HeaderText = "Penalty(Php)"
        Me.Ret_Penalty_Column.MinimumWidth = 6
        Me.Ret_Penalty_Column.Name = "Ret_Penalty_Column"
        Me.Ret_Penalty_Column.ReadOnly = True
        Me.Ret_Penalty_Column.Width = 156
        '
        'Ret_ISBN_Column
        '
        Me.Ret_ISBN_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_ISBN_Column.HeaderText = "ISBN"
        Me.Ret_ISBN_Column.MinimumWidth = 6
        Me.Ret_ISBN_Column.Name = "Ret_ISBN_Column"
        Me.Ret_ISBN_Column.ReadOnly = True
        Me.Ret_ISBN_Column.Width = 85
        '
        'Ret_Title_Column
        '
        Me.Ret_Title_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_Title_Column.HeaderText = "Title"
        Me.Ret_Title_Column.MinimumWidth = 6
        Me.Ret_Title_Column.Name = "Ret_Title_Column"
        Me.Ret_Title_Column.ReadOnly = True
        Me.Ret_Title_Column.Width = 80
        '
        'Ret_Edition_Column
        '
        Me.Ret_Edition_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_Edition_Column.HeaderText = "Edition"
        Me.Ret_Edition_Column.MinimumWidth = 6
        Me.Ret_Edition_Column.Name = "Ret_Edition_Column"
        Me.Ret_Edition_Column.ReadOnly = True
        Me.Ret_Edition_Column.Width = 104
        '
        'Ret_ShelfID_Column
        '
        Me.Ret_ShelfID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_ShelfID_Column.HeaderText = "Copy #"
        Me.Ret_ShelfID_Column.MinimumWidth = 6
        Me.Ret_ShelfID_Column.Name = "Ret_ShelfID_Column"
        Me.Ret_ShelfID_Column.ReadOnly = True
        Me.Ret_ShelfID_Column.Width = 97
        '
        'Ret_BowID_Column
        '
        Me.Ret_BowID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_BowID_Column.HeaderText = "Borrower ID"
        Me.Ret_BowID_Column.MinimumWidth = 6
        Me.Ret_BowID_Column.Name = "Ret_BowID_Column"
        Me.Ret_BowID_Column.ReadOnly = True
        Me.Ret_BowID_Column.Width = 151
        '
        'Ret_UpdatePStatus_Column
        '
        Me.Ret_UpdatePStatus_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Ret_UpdatePStatus_Column.HeaderText = ""
        Me.Ret_UpdatePStatus_Column.MinimumWidth = 6
        Me.Ret_UpdatePStatus_Column.Name = "Ret_UpdatePStatus_Column"
        Me.Ret_UpdatePStatus_Column.ReadOnly = True
        Me.Ret_UpdatePStatus_Column.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ret_UpdatePStatus_Column.Text = "Update Payment Status"
        Me.Ret_UpdatePStatus_Column.Width = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LinkLabelReturnedBooks)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.CheckBox2)
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.ComboBoxReturnListDate)
        Me.Panel5.Controls.Add(Me.TextBoxBookDetailReturnList)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.ComboBoxBookDetailFilterReturnList)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.DateTimePickeReturnListTo)
        Me.Panel5.Controls.Add(Me.DateTimePickerReturnListFrom)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.searchReturnBtn)
        Me.Panel5.Controls.Add(Me.searchReturnTxtBx)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1736, 114)
        Me.Panel5.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(614, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 21)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Payment Status:"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(883, 27)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(90, 25)
        Me.CheckBox2.TabIndex = 43
        Me.CheckBox2.Text = "Unpaid"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(794, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 25)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.Text = "Paid"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1289, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 21)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Borrower ID:"
        '
        'ComboBoxReturnListDate
        '
        Me.ComboBoxReturnListDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReturnListDate.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxReturnListDate.FormattingEnabled = True
        Me.ComboBoxReturnListDate.Items.AddRange(New Object() {"Date Returned:", "Borrow Date:", "Due Date:"})
        Me.ComboBoxReturnListDate.Location = New System.Drawing.Point(4, 75)
        Me.ComboBoxReturnListDate.Name = "ComboBoxReturnListDate"
        Me.ComboBoxReturnListDate.Size = New System.Drawing.Size(199, 36)
        Me.ComboBoxReturnListDate.TabIndex = 40
        '
        'TextBoxBookDetailReturnList
        '
        Me.TextBoxBookDetailReturnList.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookDetailReturnList.Location = New System.Drawing.Point(997, 72)
        Me.TextBoxBookDetailReturnList.MaxLength = 200
        Me.TextBoxBookDetailReturnList.Name = "TextBoxBookDetailReturnList"
        Me.TextBoxBookDetailReturnList.Size = New System.Drawing.Size(236, 33)
        Me.TextBoxBookDetailReturnList.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(614, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 21)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Book Detail:"
        '
        'ComboBoxBookDetailFilterReturnList
        '
        Me.ComboBoxBookDetailFilterReturnList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBookDetailFilterReturnList.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBookDetailFilterReturnList.FormattingEnabled = True
        Me.ComboBoxBookDetailFilterReturnList.Items.AddRange(New Object() {"Title", "ISBN", "Edition", "Copy#"})
        Me.ComboBoxBookDetailFilterReturnList.Location = New System.Drawing.Point(755, 72)
        Me.ComboBoxBookDetailFilterReturnList.Name = "ComboBoxBookDetailFilterReturnList"
        Me.ComboBoxBookDetailFilterReturnList.Size = New System.Drawing.Size(236, 36)
        Me.ComboBoxBookDetailFilterReturnList.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(387, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 21)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "To:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(210, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 21)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "From:"
        '
        'DateTimePickeReturnListTo
        '
        Me.DateTimePickeReturnListTo.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickeReturnListTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickeReturnListTo.Location = New System.Drawing.Point(391, 75)
        Me.DateTimePickeReturnListTo.Name = "DateTimePickeReturnListTo"
        Me.DateTimePickeReturnListTo.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickeReturnListTo.TabIndex = 33
        '
        'DateTimePickerReturnListFrom
        '
        Me.DateTimePickerReturnListFrom.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReturnListFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerReturnListFrom.Location = New System.Drawing.Point(209, 75)
        Me.DateTimePickerReturnListFrom.Name = "DateTimePickerReturnListFrom"
        Me.DateTimePickerReturnListFrom.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickerReturnListFrom.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1736, 6)
        Me.Panel7.TabIndex = 22
        '
        'searchReturnBtn
        '
        Me.searchReturnBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.searchReturnBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReturnBtn.Location = New System.Drawing.Point(1573, 36)
        Me.searchReturnBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReturnBtn.Name = "searchReturnBtn"
        Me.searchReturnBtn.Size = New System.Drawing.Size(150, 68)
        Me.searchReturnBtn.TabIndex = 18
        Me.searchReturnBtn.Text = "Search"
        Me.searchReturnBtn.UseVisualStyleBackColor = False
        '
        'searchReturnTxtBx
        '
        Me.searchReturnTxtBx.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReturnTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchReturnTxtBx.Location = New System.Drawing.Point(1293, 71)
        Me.searchReturnTxtBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReturnTxtBx.MaxLength = 20
        Me.searchReturnTxtBx.Name = "searchReturnTxtBx"
        Me.searchReturnTxtBx.Size = New System.Drawing.Size(238, 33)
        Me.searchReturnTxtBx.TabIndex = 17
        Me.searchReturnTxtBx.Text = "Search ID number..."
        '
        'reserveListTabPage
        '
        Me.reserveListTabPage.BackColor = System.Drawing.Color.White
        Me.reserveListTabPage.Controls.Add(Me.PanelDataGridViewReserveList)
        Me.reserveListTabPage.Controls.Add(Me.Panel3)
        Me.reserveListTabPage.Location = New System.Drawing.Point(4, 34)
        Me.reserveListTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reserveListTabPage.Name = "reserveListTabPage"
        Me.reserveListTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reserveListTabPage.Size = New System.Drawing.Size(1742, 757)
        Me.reserveListTabPage.TabIndex = 2
        Me.reserveListTabPage.Text = "Reserve List"
        '
        'PanelDataGridViewReserveList
        '
        Me.PanelDataGridViewReserveList.AutoScroll = True
        Me.PanelDataGridViewReserveList.Controls.Add(Me.reservationListDataGrid)
        Me.PanelDataGridViewReserveList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDataGridViewReserveList.Location = New System.Drawing.Point(3, 116)
        Me.PanelDataGridViewReserveList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDataGridViewReserveList.Name = "PanelDataGridViewReserveList"
        Me.PanelDataGridViewReserveList.Size = New System.Drawing.Size(1736, 639)
        Me.PanelDataGridViewReserveList.TabIndex = 2
        '
        'reservationListDataGrid
        '
        Me.reservationListDataGrid.AllowUserToAddRows = False
        Me.reservationListDataGrid.AllowUserToDeleteRows = False
        Me.reservationListDataGrid.AllowUserToResizeColumns = False
        Me.reservationListDataGrid.AllowUserToResizeRows = False
        Me.reservationListDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.reservationListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reservationListDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.reservationListDataGrid.ColumnHeadersHeight = 29
        Me.reservationListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.reservationListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Res_Cover_Column, Me.Res_Status_Column, Me.Res_ReserveDate_Column, Me.Res_ISBN_Column, Me.Res_Title_Column, Me.Res_Edition_Column, Me.Res_ShelfID_Column, Me.Res_BowID_Column, Me.Res_ReservationID_Column, Me.Complete_Column})
        Me.reservationListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reservationListDataGrid.EnableHeadersVisualStyles = False
        Me.reservationListDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.reservationListDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reservationListDataGrid.Name = "reservationListDataGrid"
        Me.reservationListDataGrid.ReadOnly = True
        Me.reservationListDataGrid.RowHeadersVisible = False
        Me.reservationListDataGrid.RowHeadersWidth = 51
        Me.reservationListDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.reservationListDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.reservationListDataGrid.RowTemplate.Height = 30
        Me.reservationListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reservationListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reservationListDataGrid.Size = New System.Drawing.Size(1736, 639)
        Me.reservationListDataGrid.TabIndex = 0
        '
        'Res_Cover_Column
        '
        Me.Res_Cover_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_Cover_Column.HeaderText = "Cover"
        Me.Res_Cover_Column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Res_Cover_Column.MinimumWidth = 6
        Me.Res_Cover_Column.Name = "Res_Cover_Column"
        Me.Res_Cover_Column.ReadOnly = True
        Me.Res_Cover_Column.Width = 68
        '
        'Res_Status_Column
        '
        Me.Res_Status_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_Status_Column.HeaderText = "Status"
        Me.Res_Status_Column.MinimumWidth = 6
        Me.Res_Status_Column.Name = "Res_Status_Column"
        Me.Res_Status_Column.ReadOnly = True
        Me.Res_Status_Column.Width = 95
        '
        'Res_ReserveDate_Column
        '
        Me.Res_ReserveDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_ReserveDate_Column.HeaderText = "Reserve Date"
        Me.Res_ReserveDate_Column.MinimumWidth = 6
        Me.Res_ReserveDate_Column.Name = "Res_ReserveDate_Column"
        Me.Res_ReserveDate_Column.ReadOnly = True
        Me.Res_ReserveDate_Column.Width = 157
        '
        'Res_ISBN_Column
        '
        Me.Res_ISBN_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_ISBN_Column.HeaderText = "ISBN"
        Me.Res_ISBN_Column.MinimumWidth = 6
        Me.Res_ISBN_Column.Name = "Res_ISBN_Column"
        Me.Res_ISBN_Column.ReadOnly = True
        Me.Res_ISBN_Column.Width = 85
        '
        'Res_Title_Column
        '
        Me.Res_Title_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_Title_Column.HeaderText = "Title"
        Me.Res_Title_Column.MinimumWidth = 6
        Me.Res_Title_Column.Name = "Res_Title_Column"
        Me.Res_Title_Column.ReadOnly = True
        Me.Res_Title_Column.Width = 80
        '
        'Res_Edition_Column
        '
        Me.Res_Edition_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_Edition_Column.HeaderText = "Edition"
        Me.Res_Edition_Column.MinimumWidth = 6
        Me.Res_Edition_Column.Name = "Res_Edition_Column"
        Me.Res_Edition_Column.ReadOnly = True
        Me.Res_Edition_Column.Width = 104
        '
        'Res_ShelfID_Column
        '
        Me.Res_ShelfID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_ShelfID_Column.HeaderText = "Copy #"
        Me.Res_ShelfID_Column.MinimumWidth = 6
        Me.Res_ShelfID_Column.Name = "Res_ShelfID_Column"
        Me.Res_ShelfID_Column.ReadOnly = True
        Me.Res_ShelfID_Column.Width = 97
        '
        'Res_BowID_Column
        '
        Me.Res_BowID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_BowID_Column.HeaderText = "Borrower ID"
        Me.Res_BowID_Column.MinimumWidth = 6
        Me.Res_BowID_Column.Name = "Res_BowID_Column"
        Me.Res_BowID_Column.ReadOnly = True
        Me.Res_BowID_Column.Width = 151
        '
        'Res_ReservationID_Column
        '
        Me.Res_ReservationID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Res_ReservationID_Column.HeaderText = "Reservation ID"
        Me.Res_ReservationID_Column.MinimumWidth = 6
        Me.Res_ReservationID_Column.Name = "Res_ReservationID_Column"
        Me.Res_ReservationID_Column.ReadOnly = True
        Me.Res_ReservationID_Column.Width = 173
        '
        'Complete_Column
        '
        Me.Complete_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Complete_Column.HeaderText = ""
        Me.Complete_Column.MinimumWidth = 6
        Me.Complete_Column.Name = "Complete_Column"
        Me.Complete_Column.ReadOnly = True
        Me.Complete_Column.Text = "Complete"
        Me.Complete_Column.UseColumnTextForButtonValue = True
        Me.Complete_Column.Width = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinkLabelReservedBooks)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TextBoxBookDetailReserveList)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ComboBoxBookDetailFilterReserveList)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.DateTimePickerReserveListTo)
        Me.Panel3.Controls.Add(Me.DateTimePickerReserveListFrom)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.searchReservationBtn)
        Me.Panel3.Controls.Add(Me.searchReservationTxtBx)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1736, 114)
        Me.Panel3.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1249, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 21)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Borrower ID:"
        '
        'TextBoxBookDetailReserveList
        '
        Me.TextBoxBookDetailReserveList.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookDetailReserveList.Location = New System.Drawing.Point(940, 72)
        Me.TextBoxBookDetailReserveList.MaxLength = 200
        Me.TextBoxBookDetailReserveList.Name = "TextBoxBookDetailReserveList"
        Me.TextBoxBookDetailReserveList.Size = New System.Drawing.Size(236, 33)
        Me.TextBoxBookDetailReserveList.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Reserve Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Book Detail:"
        '
        'ComboBoxBookDetailFilterReserveList
        '
        Me.ComboBoxBookDetailFilterReserveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBookDetailFilterReserveList.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBookDetailFilterReserveList.FormattingEnabled = True
        Me.ComboBoxBookDetailFilterReserveList.Items.AddRange(New Object() {"Title", "ISBN", "Edition", "Copy#"})
        Me.ComboBoxBookDetailFilterReserveList.Location = New System.Drawing.Point(698, 72)
        Me.ComboBoxBookDetailFilterReserveList.Name = "ComboBoxBookDetailFilterReserveList"
        Me.ComboBoxBookDetailFilterReserveList.Size = New System.Drawing.Size(236, 36)
        Me.ComboBoxBookDetailFilterReserveList.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 21)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "To:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(153, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "From:"
        '
        'DateTimePickerReserveListTo
        '
        Me.DateTimePickerReserveListTo.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReserveListTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerReserveListTo.Location = New System.Drawing.Point(334, 75)
        Me.DateTimePickerReserveListTo.Name = "DateTimePickerReserveListTo"
        Me.DateTimePickerReserveListTo.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickerReserveListTo.TabIndex = 33
        '
        'DateTimePickerReserveListFrom
        '
        Me.DateTimePickerReserveListFrom.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReserveListFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerReserveListFrom.Location = New System.Drawing.Point(152, 75)
        Me.DateTimePickerReserveListFrom.Name = "DateTimePickerReserveListFrom"
        Me.DateTimePickerReserveListFrom.Size = New System.Drawing.Size(176, 34)
        Me.DateTimePickerReserveListFrom.TabIndex = 32
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1736, 6)
        Me.Panel6.TabIndex = 22
        '
        'searchReservationBtn
        '
        Me.searchReservationBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.searchReservationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationBtn.Location = New System.Drawing.Point(1572, 37)
        Me.searchReservationBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReservationBtn.Name = "searchReservationBtn"
        Me.searchReservationBtn.Size = New System.Drawing.Size(150, 68)
        Me.searchReservationBtn.TabIndex = 18
        Me.searchReservationBtn.Text = "Search"
        Me.searchReservationBtn.UseVisualStyleBackColor = False
        '
        'searchReservationTxtBx
        '
        Me.searchReservationTxtBx.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchReservationTxtBx.Location = New System.Drawing.Point(1253, 71)
        Me.searchReservationTxtBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchReservationTxtBx.MaxLength = 20
        Me.searchReservationTxtBx.Name = "searchReservationTxtBx"
        Me.searchReservationTxtBx.Size = New System.Drawing.Size(238, 33)
        Me.searchReservationTxtBx.TabIndex = 17
        Me.searchReservationTxtBx.Text = "Search ID number..."
        '
        'LinkLabelReturnedBooks
        '
        Me.LinkLabelReturnedBooks.AutoSize = True
        Me.LinkLabelReturnedBooks.Font = New System.Drawing.Font("Century Schoolbook", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelReturnedBooks.Location = New System.Drawing.Point(1533, 11)
        Me.LinkLabelReturnedBooks.Name = "LinkLabelReturnedBooks"
        Me.LinkLabelReturnedBooks.Size = New System.Drawing.Size(190, 17)
        Me.LinkLabelReturnedBooks.TabIndex = 45
        Me.LinkLabelReturnedBooks.TabStop = True
        Me.LinkLabelReturnedBooks.Text = "View All Returned Books"
        '
        'LinkLabelBorrowedBooks
        '
        Me.LinkLabelBorrowedBooks.AutoSize = True
        Me.LinkLabelBorrowedBooks.Font = New System.Drawing.Font("Century Schoolbook", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelBorrowedBooks.Location = New System.Drawing.Point(1529, 11)
        Me.LinkLabelBorrowedBooks.Name = "LinkLabelBorrowedBooks"
        Me.LinkLabelBorrowedBooks.Size = New System.Drawing.Size(193, 17)
        Me.LinkLabelBorrowedBooks.TabIndex = 46
        Me.LinkLabelBorrowedBooks.TabStop = True
        Me.LinkLabelBorrowedBooks.Text = "View All Borrowed Books"
        '
        'LinkLabelReservedBooks
        '
        Me.LinkLabelReservedBooks.AutoSize = True
        Me.LinkLabelReservedBooks.Font = New System.Drawing.Font("Century Schoolbook", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelReservedBooks.Location = New System.Drawing.Point(1534, 11)
        Me.LinkLabelReservedBooks.Name = "LinkLabelReservedBooks"
        Me.LinkLabelReservedBooks.Size = New System.Drawing.Size(188, 17)
        Me.LinkLabelReservedBooks.TabIndex = 46
        Me.LinkLabelReservedBooks.TabStop = True
        Me.LinkLabelReservedBooks.Text = "View All Reserved Books"
        '
        'recordsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "recordsUserControl"
        Me.Size = New System.Drawing.Size(1750, 795)
        Me.TabControl.ResumeLayout(False)
        Me.borrowListTabPage.ResumeLayout(False)
        Me.PanelDataGridViewBorrowList.ResumeLayout(False)
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.returnListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.reserveListTabPage.ResumeLayout(False)
        Me.PanelDataGridViewReserveList.ResumeLayout(False)
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents borrowListTabPage As TabPage
    Friend WithEvents borrowListDataGrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchBorrowBtn As Button
    Friend WithEvents reserveListTabPage As TabPage
    Friend WithEvents PanelDataGridViewReserveList As Panel
    Friend WithEvents reservationListDataGrid As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents searchReservationBtn As Button
    Friend WithEvents searchReservationTxtBx As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelDataGridViewBorrowList As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents returnListDataGrid As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents B_Cover_Column As DataGridViewImageColumn
    Friend WithEvents B_BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_ISBN_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_Edition_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents B_BowID_Column As DataGridViewTextBoxColumn
    Friend WithEvents CheckIn_Column As DataGridViewButtonColumn
    Friend WithEvents Ret_Cover_Column As DataGridViewImageColumn
    Friend WithEvents Ret_PaymentStatus_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_DateReturned_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_Penalty_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_ISBN_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_Edition_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_BowID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Ret_UpdatePStatus_Column As DataGridViewButtonColumn
    Friend WithEvents Res_Cover_Column As DataGridViewImageColumn
    Friend WithEvents Res_Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_ReserveDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_ISBN_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_Edition_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_BowID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Res_ReservationID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Complete_Column As DataGridViewButtonColumn
    Friend WithEvents DateTimePickerBorrowListFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxBookDetailFilterBorrowList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents searchBorrowTxtBx1 As TextBox
    Friend WithEvents searchReturnBtn As Button
    Friend WithEvents searchReturnTxtBx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerBorrowListTo As DateTimePicker
    Friend WithEvents TextBoxBookDetailBorrowList As TextBox
    Friend WithEvents TextBoxBookDetailReserveList As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxBookDetailFilterReserveList As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerReserveListTo As DateTimePicker
    Friend WithEvents DateTimePickerReserveListFrom As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxBookDetailReturnList As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxBookDetailFilterReturnList As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePickeReturnListTo As DateTimePicker
    Friend WithEvents DateTimePickerReturnListFrom As DateTimePicker
    Friend WithEvents ComboBoxReturnListDate As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabelReturnedBooks As LinkLabel
    Friend WithEvents LinkLabelBorrowedBooks As LinkLabel
    Friend WithEvents LinkLabelReservedBooks As LinkLabel
End Class
