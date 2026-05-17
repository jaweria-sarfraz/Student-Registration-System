<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        RichTextBox1 = New RichTextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        lblEmailError = New Label()
        CheckBox1 = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.SlateGray
        TextBox1.Location = New Point(127, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(457, 26)
        TextBox1.TabIndex = 0
        TextBox1.Text = " Student Registration Form"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(69, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(69, 88)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(305, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(69, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 17)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.ForeColor = Color.Black
        TextBox3.Location = New Point(445, 88)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(305, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(445, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.ForeColor = Color.Black
        TextBox4.Location = New Point(68, 153)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(306, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(445, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 17)
        Label5.TabIndex = 8
        Label5.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.White
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.ForeColor = Color.Black
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1.Location = New Point(445, 153)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(306, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(69, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 17)
        Label6.TabIndex = 10
        Label6.Text = "Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(444, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 17)
        Label7.TabIndex = 11
        Label7.Text = "Phone No"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(445, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 17)
        Label8.TabIndex = 12
        Label8.Text = "Country"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.WhiteSmoke
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(68, 273)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 17)
        Label9.TabIndex = 13
        Label9.Text = "Password"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.Location = New Point(68, 226)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(307, 34)
        RichTextBox1.TabIndex = 14
        RichTextBox1.Text = ""
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.ForeColor = Color.Black
        TextBox5.Location = New Point(445, 298)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(306, 23)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.White
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.ForeColor = Color.Black
        TextBox6.Location = New Point(68, 298)
        TextBox6.Name = "TextBox6"
        TextBox6.PasswordChar = "*"c
        TextBox6.Size = New Size(306, 23)
        TextBox6.TabIndex = 16
        TextBox6.UseSystemPasswordChar = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.White
        ComboBox2.FlatStyle = FlatStyle.Flat
        ComboBox2.ForeColor = Color.Black
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"pakistan ", "india"})
        ComboBox2.Location = New Point(444, 226)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(306, 23)
        ComboBox2.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.CornflowerBlue
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(342, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 29)
        Button1.TabIndex = 18
        Button1.Text = "👤 Registration "
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumSeaGreen
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(455, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 29)
        Button2.TabIndex = 19
        Button2.Text = " ✏️ update"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.IndianRed
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.IndianRed
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(556, 378)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 29)
        Button3.TabIndex = 20
        Button3.Text = " 🗑️ delete"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Gainsboro
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.SlateGray
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.HotTrack
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = SystemColors.ControlDark
        DataGridView1.Location = New Point(0, 413)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.Size = New Size(801, 233)
        DataGridView1.TabIndex = 21
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Silver
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Silver
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(657, 378)
        Button4.Name = "Button4"
        Button4.Size = New Size(95, 29)
        Button4.TabIndex = 22
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblEmailError
        ' 
        lblEmailError.ForeColor = Color.DarkRed
        lblEmailError.Location = New Point(69, 179)
        lblEmailError.Name = "lblEmailError"
        lblEmailError.Size = New Size(103, 15)
        lblEmailError.TabIndex = 23
        lblEmailError.Text = "* Email Required @gmail.com missing" & vbCrLf
        lblEmailError.Visible = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(69, 337)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 24
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 647)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(CheckBox1)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox6)
        Controls.Add(RichTextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(lblEmailError)
        Name = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents lblEmailError As Label
    Friend WithEvents CheckBox1 As CheckBox

End Class
