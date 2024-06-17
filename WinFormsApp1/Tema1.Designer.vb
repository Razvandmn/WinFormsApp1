<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tema1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        DataGridView1 = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtId = New TextBox()
        txtNume = New TextBox()
        txtPrenume = New TextBox()
        btnAdauga = New Button()
        LblId = New Label()
        LblNume = New Label()
        LblPrenume = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(58, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(531, 86)
        txtId.Name = "txtId"
        txtId.Size = New Size(125, 27)
        txtId.TabIndex = 1
        ' 
        ' txtNume
        ' 
        txtNume.Location = New Point(531, 166)
        txtNume.Name = "txtNume"
        txtNume.Size = New Size(125, 27)
        txtNume.TabIndex = 2
        ' 
        ' txtPrenume
        ' 
        txtPrenume.Location = New Point(531, 245)
        txtPrenume.Name = "txtPrenume"
        txtPrenume.Size = New Size(125, 27)
        txtPrenume.TabIndex = 3
        ' 
        ' btnAdauga
        ' 
        btnAdauga.Location = New Point(775, 156)
        btnAdauga.Name = "btnAdauga"
        btnAdauga.Size = New Size(150, 71)
        btnAdauga.TabIndex = 4
        btnAdauga.Text = "Adauga"
        btnAdauga.UseVisualStyleBackColor = True
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.Location = New Point(458, 92)
        LblId.Name = "LblId"
        LblId.Size = New Size(22, 20)
        LblId.TabIndex = 5
        LblId.Text = "Id"
        ' 
        ' LblNume
        ' 
        LblNume.AutoSize = True
        LblNume.Location = New Point(458, 166)
        LblNume.Name = "LblNume"
        LblNume.Size = New Size(49, 20)
        LblNume.TabIndex = 6
        LblNume.Text = "Nume"
        ' 
        ' LblPrenume
        ' 
        LblPrenume.AutoSize = True
        LblPrenume.Location = New Point(458, 252)
        LblPrenume.Name = "LblPrenume"
        LblPrenume.Size = New Size(67, 20)
        LblPrenume.TabIndex = 7
        LblPrenume.Text = "Prenume"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(997, 525)
        Controls.Add(LblPrenume)
        Controls.Add(LblNume)
        Controls.Add(LblId)
        Controls.Add(btnAdauga)
        Controls.Add(txtPrenume)
        Controls.Add(txtNume)
        Controls.Add(txtId)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNume As TextBox
    Friend WithEvents txtPrenume As TextBox
    Friend WithEvents btnAdauga As Button
    Friend WithEvents LblId As Label
    Friend WithEvents LblNume As Label
    Friend WithEvents LblPrenume As Label
End Class
