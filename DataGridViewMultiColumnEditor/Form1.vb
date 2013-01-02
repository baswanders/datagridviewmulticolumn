Public Class Form1

    Private Sub SetupData()

        Dim dt As New DataTable("Companies")
        dt.Columns.Add("CompanyID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Employee", GetType(String))

        dt.Rows.Add(New String() {1, "PB & Sons", "D4"})
        dt.Rows.Add(New String() {2, "Cook ltd.", "D12"})
        dt.Rows.Add(New String() {3, "Wiley & sons", "PM1"})
        dt.Rows.Add(New String() {4, "JB Algor", "T1"})
        dt.Rows.Add(New String() {5, "Barn Co.", "D3"})
        dt.Rows.Add(New String() {6, "Ddd", "D13"})

        DataGridView1.DataSource = dt
        DataGridView1.Columns.RemoveAt(2)

        ' Populate using a DataTable

        Dim dataTable As New DataTable("Employees")

        dataTable.Columns.Add("EmployeeID", GetType([String]))
        dataTable.Columns.Add("Name", GetType([String]))
        dataTable.Columns.Add("Designation", GetType([String]))

        dataTable.Rows.Add(New [String]() {"D1", "Natalia", "Developer"})
        dataTable.Rows.Add(New [String]() {"D2", "Jonathan", "Developer"})
        dataTable.Rows.Add(New [String]() {"D3", "Jake", "Developer"})
        dataTable.Rows.Add(New [String]() {"D4", "Abraham", "Developer"})
        dataTable.Rows.Add(New [String]() {"T1", "Mary", "Team Lead"})
        dataTable.Rows.Add(New [String]() {"PM1", "Calvin", "Project Manager"})
        dataTable.Rows.Add(New [String]() {"T2", "Sarah", "Team Lead"})
        dataTable.Rows.Add(New [String]() {"D12", "Monica", "Developer"})
        dataTable.Rows.Add(New [String]() {"D13", "Donna", "Developer"})

        Dim c As New MultiColumnComboBoxColumn() With {.DataSource = dataTable, .DisplayMember = "Name", .ValueMember = "EmployeeID", .DataPropertyName = "Employee", .DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing}

        c.Columns(0).Visible = False

        DataGridView1.Columns.Add(c)

        '' Populate using a collection

        'Dim studentArray As Student() = New Student() {New Student("Andrew White", 10), New Student("Thomas Smith", 10), New Student("Alice Brown", 11), New Student("Lana Jones", 10), New Student("Jason Smith", 9), New Student("Amamda Williams", 11)}

        'multiColumnComboBox2.DataSource = studentArray
        'multiColumnComboBox2.DisplayMember = InlineAssignHelper(multiColumnComboBox2.ValueMember, "Name")

        '' Drop-down list (non-editable)

        'Dim studentList As New List(Of Student)(studentArray)

        'multiColumnComboBox3.DataSource = studentList

        '' Trying to use as a regular combobox

        'multiColumnComboBox4.Items.Add("Cat")
        'multiColumnComboBox4.Items.Add("Tiger")
        'multiColumnComboBox4.Items.Add("Lion")
        'multiColumnComboBox4.Items.Add("Cheetah")
        'multiColumnComboBox4.SelectedIndex = 0
    End Sub

    Public Class Student
        Public Sub New(name As [String], age As Integer)
            Me.m_name = name
            Me.m_age = age
        End Sub

        Private m_name As [String]

        Public ReadOnly Property Name() As [String]
            Get
                Return m_name
            End Get
        End Property

        Private m_age As Integer

        Public ReadOnly Property Age() As Integer
            Get
                Return m_age
            End Get
        End Property
    End Class

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        SetupData()
    End Sub
End Class
