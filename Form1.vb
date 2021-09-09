Public Class Form1
    Dim Gearing_Ratio As Double = 0
    Dim Speed_kph As Double = 0
    Dim Speed_mph As Double = 0
    Dim Wheel_Circumference As Double = 0

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click
        Calculate()
    End Sub

    Public Sub UpdateUI()
        TextBox_Gearing_Ratio.Text = Gearing_Ratio.ToString("0.##")
        TextBox_Speed.Text = Speed_kph.ToString("0.#") + " (" + Speed_mph.ToString("0.#") + ")"
    End Sub

    Public Sub Calculate()
        'Cadence in 1/min
        'Wheel size in mm
        Gearing_Ratio = NumericUpDown_FrontRing.Value / NumericUpDown_RearRing.Value
        Wheel_Circumference = NumericUpDown_RearWheelSize.Value * Math.PI / 1000000 'circumference in kilometers

        Speed_kph = NumericUpDown_Cadence.Value * Gearing_Ratio * Wheel_Circumference * 60 'km/min, so multiply by 60 to get km/h
        Speed_mph = Speed_kph * 0.62137

        Dim row As String() = {NumericUpDown_FrontRing.Value.ToString, NumericUpDown_RearRing.Value.ToString, Gearing_Ratio.ToString("0.##"), NumericUpDown_RearWheelSize.Value.ToString, NumericUpDown_Cadence.Value.ToString, Speed_kph.ToString("0.#") + " (" + Speed_mph.ToString("0.#") + ")"}
        Grid.Rows.Add(row)
        UpdateUI()
    End Sub

    Private Sub Button_Export_Click(sender As Object, e As EventArgs) Handles Button_Export.Click
        Dim GridData As String = ""
        Dim FileName As String = ""
        Dim Path As String = ""

        If TextBox_FileName.Text.Length > 0 Then
            FileName = TextBox_FileName.Text
            Path = My.Application.Info.DirectoryPath + "\" + FileName + ".txt"

            For j As Integer = 0 To Grid.Columns.Count - 1
                GridData += Grid.Columns.Item(j).Name + vbTab
            Next
            GridData += vbCrLf

            For i As Integer = 0 To Grid.Rows.Count - 2
                For j As Integer = 0 To Grid.Columns.Count - 1
                    GridData += Grid.Rows.Item(i).Cells.Item(j).Value.ToString + vbTab
                Next
                GridData += vbCrLf
            Next
            If Not IO.File.Exists(Path) Then
                IO.File.WriteAllText(Path, GridData)
            Else
                MsgBox("FileName: " + FileName + " already exists in the folder!")
            End If
        Else
            MsgBox("FileName is empty!")
        End If

    End Sub
End Class
