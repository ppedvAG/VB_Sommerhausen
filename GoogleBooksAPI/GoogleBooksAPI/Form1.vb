Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        booksDataGridView.AutoGenerateColumns = False
        dragDataGridView.AutoGenerateColumns = False
        dropDataGridView.AutoGenerateColumns = False


        TextBox4.DataBindings.Add("Text", TextBox3, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox4.DataBindings.Add("BackColor", TextBox3, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox4.DataBindings.Add(NameOf(TextBox.Width), TrackBar1, "Value", True, DataSourceUpdateMode.OnPropertyChanged)

        BindingSource1.DataSource = New List(Of Volumeinfo) 'für binding init
        BindingSource2.DataSource = New List(Of Volumeinfo) 'für binding init
        BindingSource3.DataSource = New List(Of Volumeinfo) 'für binding init

        TextBox1.DataBindings.Add(NameOf(TextBox.Text), BindingSource1, NameOf(Volumeinfo.title), True, DataSourceUpdateMode.OnPropertyChanged)
        booksDataGridView.DataSource = BindingSource1
        dragDataGridView.DataSource = BindingSource2
        dropDataGridView.DataSource = BindingSource3

        ListBox1.DisplayMember = "title"
        ListBox1.DataSource = BindingSource1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url = $"https://www.googleapis.com/books/v1/volumes?q={suchTextBox.Text}"

        Dim http = New WebClient()
        http.Encoding = Encoding.UTF8
        Dim json = http.DownloadString(url)
        jsonTextbox.Text = json

        Dim books = JsonConvert.DeserializeObject(Of BookResults)(json)

        'booksDataGridView.DataSource = books.items.Select(Function(x) x.volumeInfo).OrderBy(Function(x) x.title).ToList()
        'dragDataGridView.DataSource = books.items.Select(Function(x) x.volumeInfo).OrderBy(Function(x) x.title).ToList()

        BindingSource1.DataSource = books.items.Select(Function(x) x.volumeInfo).OrderBy(Function(x) x.title).ToList()
        BindingSource2.DataSource = books.items.Select(Function(x) x.volumeInfo).OrderBy(Function(x) x.title).ToList()



    End Sub

    Private Sub DataGridView2_MouseMove(sender As Object, e As MouseEventArgs) Handles dragDataGridView.MouseMove

        If e.Button = MouseButtons.Left Then
            dragDataGridView.DoDragDrop(dragDataGridView.CurrentRow.DataBoundItem, DragDropEffects.Move)
        End If
    End Sub


    Private Sub DataGridView3_DragOver(sender As Object, e As DragEventArgs) Handles dropDataGridView.DragOver

        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub DataGridView3_DragDrop(sender As Object, e As DragEventArgs) Handles dropDataGridView.DragDrop

        If e.Data.GetDataPresent(GetType(Volumeinfo)) Then
            Dim vi = TryCast(e.Data.GetData(GetType(Volumeinfo)), Volumeinfo)
            'Dim liste = New List(Of Volumeinfo)()
            'liste.Add(vi)
            'dropDataGridView.DataSource = liste
            BindingSource3.Add(vi)
            BindingSource2.Remove(vi)
        End If

    End Sub
End Class
