Public Class MainView

    Dim tickcounter As Int64 = 0
    Dim population As Int64 = 2
    Dim deaths As Int64 = 0
    Dim popgrowthprogess As Int64 = 0
    Dim JobForm As New Jobs
    Public Function findJobQuantity(jobTitle)
        Dim index As Int64 = Array.IndexOf(SharedVariables.jobsList, jobTitle)
        Return (SharedVariables.jobsQuantity(index))
    End Function

    Public Function findJobIndex(jobTitle)
        Return Array.IndexOf(SharedVariables.jobsList, jobTitle)
    End Function

    Public Function findResoucesQuantity(resourceTitle)
        Dim index As Int64 = Array.IndexOf(SharedVariables.resourceList, resourceTitle)
        Return (SharedVariables.resourceQuantity(index))
    End Function

    Public Function findResourceIndex(resourceTitle)
        Return Array.IndexOf(SharedVariables.resourceList, resourceTitle)
    End Function
    Private Sub tmrparsetick_Tick(sender As Object, e As EventArgs) Handles tmrparsetick.Tick

        lblIdlePops.Text = ("Idle Pops:" + Str(SharedVariables.idlepops))
        lblpopulation.Text = ("Population: " + Str(population))
        lbldeaths.Text = ("Deaths: " + Str(deaths))

        SharedVariables.idlepops = population - SharedVariables.jobsQuantity.Sum
    End Sub
    Private Sub tmrgametick_Tick(sender As Object, e As EventArgs) Handles tmrgametick.Tick

        lblgametick.Text = tickcounter
        tickcounter += 1

        If tickcounter Mod 100 = 0 Then

            refreshResourceLsv()

            If SharedVariables.resourceQuantity(findResourceIndex("Food")) <= 0 Then

                If population <> 0 And SharedVariables.resourcePerSec(findResourceIndex("Food")) < 0 Then
                    population -= Int(SharedVariables.declinequotient * -1 * SharedVariables.resourcePerSec(findResourceIndex("Food")))
                    deaths += Int(SharedVariables.declinequotient * -1 * SharedVariables.resourcePerSec(findResourceIndex("Food")))
                End If

            Else
                popgrowthprogess += 1 + (SharedVariables.growthquotient * SharedVariables.resourceQuantity(findResourceIndex("Food")))

            End If



        End If

        If popgrowthprogess >= population Then
            population += Int(popgrowthprogess / (population + 1))
            popgrowthprogess = 0
        End If

        If SharedVariables.idlepops < 0 Then
            Dim rnd = New Random()
            Dim rndindex As Int64 = rnd.Next(0, SharedVariables.jobsQuantity.Count)
            If SharedVariables.jobsQuantity(rndindex) > 0 Then
                SharedVariables.jobsQuantity(rndindex) -= 1
            End If
        End If

        If SharedVariables.resourceQuantity(findResourceIndex("Food")) >= 0 Then
            population -= 0
        End If
    End Sub

    Private Sub btnbreedlol_Click(sender As Object, e As EventArgs) Handles btnbreedlol.Click
        population += 1
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        If tmrgametick.Enabled = False Then
            tmrgametick.Enabled = True
            btnpause.Text = "PAUSE"
        Else
            tmrgametick.Enabled = False
            btnpause.Text = "RESUME"
        End If
    End Sub

    Private Sub btnjobwindow_Click(sender As Object, e As EventArgs) Handles btnjobwindow.Click
        If JobForm.IsHandleCreated Then
            JobForm.Show()
        Else
            Dim JobForm As New Jobs
            JobForm.Show()
        End If
    End Sub
    Public Sub refreshResourceLsv()
        ParseJobs()

        lsvResources.Clear()

        lsvResources.Columns.Add("Resource", 100)
        lsvResources.Columns.Add("Quantity", 100)
        lsvResources.Columns.Add("Per Second", 50)

        For index As Integer = 0 To SharedVariables.resourceQuantity.Length - 1
            Dim arrtoadd(3) As String
            Dim itm As ListViewItem
            arrtoadd(0) = SharedVariables.resourceList(index)
            arrtoadd(1) = Str(SharedVariables.resourceQuantity(index))
            arrtoadd(2) = Str(SharedVariables.resourcePerSec(index))
            itm = New ListViewItem(arrtoadd)
            lsvResources.Items.Insert(0, itm)
        Next index
    End Sub
    Public Sub resetRPS()
        For index As Integer = 0 To SharedVariables.resourcePerSec.Length - 1
            SharedVariables.resourcePerSec(index) = 0
        Next index
    End Sub
    Public Sub ParseFoodJobs()
        SharedVariables.resourcePerSec(findResourceIndex("Food")) = 0
        For index As Integer = 0 To SharedVariables.foodjobs.Length - 1
            SharedVariables.resourcePerSec(findResourceIndex("Food")) += findJobQuantity(SharedVariables.foodjobs(index)) * SharedVariables.foodjobsQuantity(index)
        Next index

        SharedVariables.resourcePerSec(findResourceIndex("Food")) -= population

        SharedVariables.resourceQuantity(findResourceIndex("Food")) += SharedVariables.resourcePerSec(findResourceIndex("Food"))

        If SharedVariables.resourceQuantity(findResourceIndex("Food")) < 0 Then
            SharedVariables.resourceQuantity(findResourceIndex("Food")) = 0
        End If

    End Sub

    Public Sub parseSingularBasicJob(jobTitle, jobResource, jobQuantity)
        SharedVariables.resourcePerSec(findResourceIndex(jobResource)) += findJobQuantity(jobTitle) * jobQuantity
        SharedVariables.resourceQuantity(findResourceIndex(jobResource)) += SharedVariables.resourcePerSec(findResourceIndex(jobResource))
    End Sub

    Public Sub parseSingularBasicJobSub(jobTitle, jobResource, jobQuantity, subResource, subQuantity)
        If SharedVariables.resourceQuantity(findResourceIndex(subResource)) > 0 Then
            SharedVariables.resourcePerSec(findResourceIndex(jobResource)) += findJobQuantity(jobTitle) * jobQuantity
            SharedVariables.resourceQuantity(findResourceIndex(jobResource)) += SharedVariables.resourcePerSec(findResourceIndex(jobResource)) * jobQuantity
            SharedVariables.resourcePerSec(findResourceIndex(subResource)) -= findJobQuantity(jobTitle) * subQuantity
        End If
    End Sub
    Public Sub ParseBasicJobs()

        parseSingularBasicJobSub("Hunter", "Pelt", 1, "Primitive Tools", 1)
        parseSingularBasicJobSub("Crafter", "Primitive Tools", 1, "Rocks", 1)
        parseSingularBasicJobSub("Crafter", "Primitive Tools", 0, "Sticks", 1)
        parseSingularBasicJob("Gatherer", "Sticks", 2)
        parseSingularBasicJob("Gatherer", "Rocks", 1)

    End Sub

    Public Sub ParseJobs()
        resetRPS()
        ParseBasicJobs()
        ParseFoodJobs()
    End Sub


End Class