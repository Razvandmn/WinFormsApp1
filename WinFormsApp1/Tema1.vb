Public Class Tema1

    Dim table As New DataTable


    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        'adauga un rand in table si preia datele din casetele txt
        table.Rows.Add(txtId.Text, txtNume.Text, txtPrenume.Text)

        DataGridView1.DataSource = table

        'sterge datele din casetele text
        txtId.Clear()
        txtNume.Clear()
        txtPrenume.Clear()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'la deschiderea ferestrei creaza si adauga un obiect de tip datacolumns cu nume specific si anumit tip de date, creaza 3 coloane
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("Nume", Type.GetType("System.String"))
        table.Columns.Add("Prenume", Type.GetType("System.String"))


        DataGridView1.DataSource = table


    End Sub
End Class
