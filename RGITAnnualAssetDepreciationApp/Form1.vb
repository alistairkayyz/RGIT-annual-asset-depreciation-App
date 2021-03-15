Public Class frmDepreciationApp
    'Declaring variables
    Dim cost As Double
    Dim salvage As Double
    Dim dblDDB As Double
    Dim life As Double
    Dim dblSYD As Double

    Private Sub frmDepreciationApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'declaring and initializing an array
        Dim arrayA As Integer() = New Integer() {3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                                                 13, 14, 15, 16, 17, 18, 19, 20}

        For i = 0 To 17
            'add array values into the combobox 'Useful Life'
            cboUsefulLife.Items.Add(arrayA(i))
        Next
    End Sub

    Private Sub InputAndOutput()

        If (String.IsNullOrEmpty(txtAssetCost.Text) Or
         String.IsNullOrEmpty(txtSalvageValue.Text) Or
         String.IsNullOrEmpty(cboUsefulLife.SelectedItem)) Then
            MsgBox("No input/inputs or selection made.", MsgBoxStyle.Critical)
        Else
            'convert inputs to double
            cost = CDbl(txtAssetCost.Text)
            salvage = CDbl(txtSalvageValue.Text)
            life = CDbl(cboUsefulLife.SelectedItem)

            'Output the depreciations
            FinancialDDB(dblDDB)
            FinancialSYD(dblSYD)
        End If
    End Sub

    Private Function FinancialDDB(ByVal depreciation As Double) As Double
        lstDisplayDDB.Items.Clear() 'remove items
        lstDisplayDDB.Items.Add("Year" & vbTab & "Depreciation") 'add header

        For period As Integer = 1 To life
            'calculate Double-declining balances and display the results
            depreciation = Financial.DDB(cost, salvage, life, period)
            lstDisplayDDB.Items.Add(period & vbTab & depreciation.ToString("C2"))
        Next
        Return depreciation
    End Function

    Private Function FinancialSYD(ByVal depreciation As Double) As Double
        lstDisplaySYD.Items.Clear() 'remove items
        lstDisplaySYD.Items.Add("Year" & vbTab & "Depreciation") 'add header

        For period As Integer = 1 To life
            'calculate Sum-of-year's digits and display the results
            depreciation = Financial.SYD(cost, salvage, life, period)
            lstDisplaySYD.Items.Add(period & vbTab & depreciation.ToString("C2"))
        Next
        Return depreciation
    End Function

    Private Sub btnDDS_Click(sender As Object, e As EventArgs) Handles btnDDS.Click
        InputAndOutput() 'display depreciation schedules when button is clicked
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the windows form using botton exit
        Dim ExitYN As System.Windows.Forms.DialogResult
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)

        If ExitYN = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub frmDepreciationApp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'close the form using (x) button
        Dim dialog As System.Windows.Forms.DialogResult
        dialog = MsgBox("Do you really want to close?", MsgBoxStyle.YesNo)
        If dialog = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class
