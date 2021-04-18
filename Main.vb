﻿Imports System.Globalization
Public Class Main
    Public bookDP As New List(Of bookDisplay)
    Private newTitle_click As Integer = 0
    Private auth_click As Integer = 0
    Private pb_click As Integer = 0
    Private pub_click As Integer = 0
    Private radio_click As Integer = 0

    Private sortBy As String = "DateAdded"  ' defeault is date added
    Private provider As CultureInfo = CultureInfo.InvariantCulture
    Private numPage As Integer = 1
    Private totalResult As Integer = 0
    Private searchKey As String = String.Empty

    Private PageIndex As Integer = 0
    Private BooksPerPage As Integer = 5 'number of books shown on each page

    Private viewBook As New viewBook

    Public Sub New()
        ' wassup mananap was here
        InitializeComponent()
        searchTextBox.SelectionStart = 0
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.WrapContents = False

        For x As Integer = 1 To BooksPerPage
            bookDP.Add(New bookDisplay(viewBook))
        Next

        'Year
        For year As Integer = 1900 To DateAndTime.Today.Year Step 5
            beforeYear.Items.Add(year)
            afterYear.Items.Add(year)
        Next
        setResult()
        initializeResult()
    End Sub

    Private Sub prevLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles prevLnkLbl.LinkClicked
        ' LoadPage(False) 'false indicates to go back a page
        If PageIndex > 0 Then
            PageIndex -= 1
            initializeResult()
        End If
    End Sub

    Private Sub nextLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles nextLnkLbl.LinkClicked
        ' LoadPage(True) 'true indicates to go forward a page
        If PageIndex + 1 < numPage Then
            PageIndex += 1
            initializeResult()
        End If
    End Sub
    Private Sub LoadPage(ByVal pgNext As Boolean)

        'make sure there is another page before adding 1 to the PageIndex
        If pgNext And (PageIndex + 1) * BooksPerPage < bookDP.Count - 1 Then
            PageIndex += 1
        ElseIf Not pgNext And PageIndex - 1 >= 0 Then 'make sure it is not on PageIndex 0 before going back a Page
            PageIndex -= 1
        Else
            Exit Sub 'exit the sub if already on Page1 or on the Last Page
        End If

        ' remove all the books from the this page
        For i As Integer = FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
            FlowLayoutPanel1.Controls.RemoveAt(i)
        Next

        'when going forward, make sure there Is 6 more books in the list. If Not then get the number of books left in the list.
        Dim endpage As Integer = Math.Min(((PageIndex * BooksPerPage) + BooksPerPage) - 1, bookDP.Count - 1)

        'add the books for the Page to the FlowLayoutPanel
        For i As Integer = (PageIndex * BooksPerPage) To endpage
            'bookDP(i).Label2.Text = i.ToString
            FlowLayoutPanel1.Controls.Add(bookDP(i))

        Next

        PageNumLabel.Text = "Page " & (PageIndex + 1).ToString 'set the text to the Page Number
    End Sub




    Private Sub searchTextBox_mouseEnter(sender As Object, e As EventArgs)
        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        ' sample search
        ' For Each book In bookDP
        ' book.Anchor = Anchor.Left
        ' book.Anchor = Anchor.Right
        'FlowLayoutPanel1.Controls.Add(book)
        '  Next

    End Sub

    Private Sub searchTextBox_mouseLeave(sender As Object, e As EventArgs)
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
            searchTextBox.ForeColor = Color.FromArgb(119, 117, 117)
            searchKey = String.Empty
        End If
    End Sub


    Private Sub newTitleBtn_Click_1(sender As Object, e As EventArgs) Handles newTitleBtn.Click
        newTitle_click += 1
        utils.clickAnimation(newTitleBtn, newTitle_click)
        utils.dropDownAnimationNewTitle(newTitlePanel, authBtn, pbBtn, publisherBtn)
    End Sub

    Private Sub authBtn_Click_1(sender As Object, e As EventArgs) Handles authBtn.Click
        auth_click += 1
        utils.clickAnimation(authBtn, auth_click)
        utils.dropDownAnimationauthBtn(authPanel, pbBtn, publisherBtn)
    End Sub

    Private Sub pbBtn_Click_1(sender As Object, e As EventArgs) Handles pbBtn.Click
        pb_click += 1
        utils.clickAnimation(pbBtn, pb_click)
        utils.dropDownAnimationpy(pbPanel, publisherBtn)
    End Sub

    Private Sub publisherBtn_Click_1(sender As Object, e As EventArgs) Handles publisherBtn.Click
        pub_click += 1
        utils.clickAnimation(publisherBtn, pub_click)
        utils.dropDownAnimationpub(classPanel)
    End Sub


    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.ForeColor = Color.FromArgb(0, 54, 99)
        'login.ShowDialog()
        Dim lgIn As New login
        lgIn.ShowDialog()
    End Sub

    Private Sub advanceSearchLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles advanceSearchLinkLbl.LinkClicked
        'advanceSearch.Show()
        Dim advSearch = New advanceSearch
        advSearch.ShowDialog()
    End Sub

    Private Sub loginBtn_mouseLeave(sender As Object, e As EventArgs)
        loginBtn.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        newTitlePanel.Height = 127

        authBtn.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 127)
        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)

        authPanel.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 45)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        classPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        authPanel.Height = 127

        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        classPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pbPanel.Height = 127

        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        classPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        classPanel.Height = 127
        Timer4.Stop()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' RadioButton Event Handlers
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNewlyAdded.CheckedChanged, RadioButtonPublicationDate.CheckedChanged, RadioButtonTitle.CheckedChanged
        radio_click += 1
        If sender.Equals(RadioButtonNewlyAdded) Then
            sortBy = "DateAdded"
        ElseIf sender.Equals(RadioButtonPublicationDate) Then
            sortBy = "PublishedDate"
        ElseIf sender.Equals(RadioButtonTitle) Then
            sortBy = "Title"
        End If

        If radio_click = 2 Then
            radio_click = 0
            ' execute sort
            initializeResult()
        End If
    End Sub

    Public Sub serchPcBx_Clicked(sender As Object, e As EventArgs) Handles searchPcBx.Click
        setResult()
        initializeResult()
    End Sub

    ' results
    Private Sub setResult()
        If Not searchTextBox.Text.Equals("Search...") Then
            searchKey = searchTextBox.Text.Replace(" ", "+")
        End If
        totalResult = BookController.getNumBkResult(searchKey)
        Debug.WriteLine(totalResult.ToString)
        numPage = totalResult / BooksPerPage
        Debug.WriteLine(numPage.ToString)
        PageIndex = 0
    End Sub
    Public Sub initializeResult()
        FlowLayoutPanel1.Controls.Clear()
        Select Case sortBy
            Case "DateAdded"
                RadioButtonNewlyAdded.Checked = True
            Case "PublishedDate"
                RadioButtonPublicationDate.Checked = True
            Case "Title"
                RadioButtonTitle.Checked = True
        End Select
        radio_click = 0

        setBookDisplayResults()
        loadImage()
        setPaginationControls()
    End Sub

    Private Sub setBookDisplayResults()
        Dim bkDTOs As List(Of BookDetailsDTO) = BookController.getBooksPaginationSortBy(PageIndex, BooksPerPage, sortBy, searchKey)
        For idx As Integer = 0 To bkDTOs.Count - 1
            bookDP.Item(idx).setBkDTO(bkDTOs.Item(idx))
            FlowLayoutPanel1.Controls.Add(bookDP.Item(idx))
        Next
    End Sub

    Private Sub loadImage()
        For Each bkDisplay As bookDisplay In FlowLayoutPanel1.Controls
            If String.Compare(bkDisplay.imageName, "empty") <> 0 Then
                bkDisplay.coverPcBx.Image = getImage(bkDisplay.imageName)
            Else
                bkDisplay.coverPcBx.Image = My.Resources.default_book
            End If
        Next
    End Sub

    Private Sub setPaginationControls()
        If PageIndex + 1 >= numPage Then
            nextLnkLbl.Visible = False
        Else
            nextLnkLbl.Visible = True
        End If

        If PageIndex <= 0 Then
            prevLnkLbl.Visible = False
        Else
            prevLnkLbl.Visible = True
        End If
        PageNumLabel.Text = "Page " & (1 + PageIndex).ToString 'set the text to the Page Number
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub
End Class
