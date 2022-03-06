Public Class Jobs

    Private Sub cmbJobSelect_DropDown(sender As Object, e As EventArgs) Handles cmbJobSelect.DropDown

        cmbJobSelect.Items.Clear()
        cmbJobSelect.Items.AddRange(SharedVariables.jobsList)
    End Sub

    Private Sub btnComboAdd_Click(sender As Object, e As EventArgs) Handles btnComboAdd.Click
        If SharedVariables.idlepops > 0 Then
            If cmbJobSelect.SelectedItem <> "" Then
                Dim index As Int64 = Array.IndexOf(SharedVariables.jobsList, cmbJobSelect.SelectedItem)
                SharedVariables.jobsQuantity(index) += 1
                RefreshLsv()
            End If
        End If
    End Sub
    Private Sub btnComboSub_Click(sender As Object, e As EventArgs) Handles btnComboSub.Click
        Dim index As Int64 = Array.IndexOf(SharedVariables.jobsList, cmbJobSelect.SelectedItem)
        If cmbJobSelect.SelectedItem <> "" Then
            If SharedVariables.jobsQuantity(index) > 0 Then
                SharedVariables.jobsQuantity(index) -= 1
            Else
                SharedVariables.jobsQuantity(index) = 0
            End If
        End If
        RefreshLsv()
    End Sub
    Public Sub RefreshLsv()
        lsvJobs.Items.Clear()

        For i = 0 To SharedVariables.jobsList.Length() - 1
            Dim arrtoadd(1) As String
            Dim itm As ListViewItem
            arrtoadd(0) = SharedVariables.jobsList(i)
            arrtoadd(1) = SharedVariables.jobsQuantity(i)
            itm = New ListViewItem(arrtoadd)
            lsvJobs.Items.Insert(0, itm)
        Next
    End Sub


    Private Sub Jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshLsv()
    End Sub

    Private Sub tmrrefreshlsv_Tick(sender As Object, e As EventArgs) Handles tmrrefreshlsv.Tick
        RefreshLsv()
    End Sub
End Class