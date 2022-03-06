Public Class SharedVariables
    'jobs
    Public Shared jobsOutput() As Dictionary(Of String, String)

    Public Shared idlepops As Int64 = 0
    Public Shared jobsList As String() = {"Forager", "Hunter", "Gatherer", "Crafter"} 'use this to get job ids, for example forager has id 0 as it is at index 0
    Public Shared jobsQuantity As Int64() = {2, 0, 0, 0}
    Public Shared resourceList As String() = {"Food", "Rocks", "Sticks", "Primitive Tools", "Pelt"}
    Public Shared resourceQuantity As Int64() = {0, 0, 0, 0, 0}
    Public Shared resourcePerSec As Int64() = {0, 0, 0, 0, 0}
    Public Shared declinequotient As Double = 0.5
    Public Shared growthquotient As Double = 1
End Class
