Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System
Public Class Form1
    Dim oldUser As String = ""
    <Obsolete>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    <Obsolete>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Connection String
        Dim con As New SqlConnection("Data Source=DESKTOP-APADBTF\SQLEXPRESS;Initial Catalog=login;User ID=sa;TrustServerCertificate=True")

        ' 2. Validation (Sab se pehle check karein)
        If TextBox4.Text = "" Or Not TextBox4.Text.Contains("@") Then
            lblEmailError.Visible = True
            TextBox4.Focus()
            Exit Sub
        Else
            lblEmailError.Visible = False
        End If

        ' Phone number check (Ye zaroori hai error se bachne ke liye)
        If TextBox5.Text = "" Or Not IsNumeric(TextBox5.Text) Then
            MessageBox.Show("Please enter a valid Phone Number first!")
            TextBox5.Focus()
            Exit Sub
        End If

        ' 3. Query (Ab jab data sahi hai, tab query banayein)
        Dim query As String = "INSERT INTO [dbo].[student registration form]
([name],[username],[gender],[email],[address],[phone],[password],[country]) " &
                             "VALUES ('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "', '" & TextBox4.Text & "', '" & RichTextBox1.Text & "', " & Val(TextBox5.Text) & ", '" & TextBox6.Text & "', '" & ComboBox2.Text & "')"

        ' 4. Execution
        Try
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record successfully saved!")
            ShowData()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    <Obsolete>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection("Data Source=DESKTOP-APADBTF\SQLEXPRESS;Initial Catalog=login;User ID=sa;TrustServerCertificate=True;")
        If TextBox4.Text = "" Or Not TextBox4.Text.ToLower().EndsWith("@gmail.com") Then
            lblEmailError.Visible = True
            TextBox4.Focus()
            Exit Sub
        Else
            lblEmailError.Visible = False
        End If
        Dim query As String = "UPDATE [dbo].[student registration form] SET " &
          "[Name] = @name, [Username] = @newUsername, [Gender] = @gender, [Email] = @email, " &
          "[Address] = @address, [Phone] = @phone, [Country] = @country, " &
          "[Password] = @pass WHERE [Username] = @oldUsername"

        Try
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@newUsername", TextBox3.Text)
            cmd.Parameters.AddWithValue("@gender", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@email", TextBox4.Text)
            cmd.Parameters.AddWithValue("@address", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@phone", TextBox5.Text)
            cmd.Parameters.AddWithValue("@country", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox6.Text)

            cmd.Parameters.AddWithValue("@oldUsername", oldUser)

            con.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            con.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Record successfully updated!")
                oldUser = TextBox3.Text
                ShowData()
            Else
                MessageBox.Show("Record not found!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try


    End Sub

    <Obsolete>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-APADBTF\SQLEXPRESS;Initial Catalog=login;User ID=sa;TrustServerCertificate=True;")

        Try
            If String.IsNullOrEmpty(TextBox3.Text) Then
                MessageBox.Show("Please select a student from the list first")
                Exit Sub
            End If

            Dim query As String = "DELETE FROM [student registration form] WHERE [Username] = @user"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@user", TextBox3.Text)

            con.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Record successfully deleted")
                ShowData()
            Else
                MessageBox.Show("Record not found")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con IsNot Nothing Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End If
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            oldUser = row.Cells("username").Value.ToString()

            TextBox2.Text = row.Cells("name").Value.ToString()
            TextBox3.Text = row.Cells("username").Value.ToString()

            ComboBox1.Text = row.Cells("gender").Value.ToString()

            TextBox4.Text = row.Cells("email").Value.ToString()
            RichTextBox1.Text = row.Cells("address").Value.ToString()
            TextBox5.Text = row.Cells("phone").Value.ToString()

            ComboBox2.Text = row.Cells("country").Value.ToString()

            TextBox6.Text = row.Cells("password").Value.ToString()
        End If
    End Sub

    <Obsolete>
    Public Sub ShowData()
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-APADBTF\SQLEXPRESS;Initial Catalog=login;User ID=sa;TrustServerCertificate=True;")
            Dim cmd As New SqlCommand("SELECT * FROM [student registration form]", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            da.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RichTextBox1.Clear()


        ComboBox1.SelectedIndex = -1
        ComboBox1.Text = ""

        ComboBox2.SelectedIndex = -1
        ComboBox2.Text = ""

        TextBox2.Focus()
    End Sub

    Private Sub lblEmailError_Click(sender As Object, e As EventArgs) Handles lblEmailError.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

        If String.IsNullOrEmpty(TextBox4.Text) OrElse Not TextBox4.Text.ToLower().EndsWith("@gmail.com") Then
            ' Email error dikhane ke liye
            lblEmailError.Text = "Invalid Email Format!"
            lblEmailError.ForeColor = Color.Red
            lblEmailError.Visible = True

            ' Phone label ko hamesha nazar aane ke liye (Aapka Label7)
            Label7.Visible = True
        Else
            lblEmailError.Visible = False
        End If
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox4.Validating

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
            TextBox6.PasswordChar = ControlChars.NullChar
        Else

            TextBox6.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class


