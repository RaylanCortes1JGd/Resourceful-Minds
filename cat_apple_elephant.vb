Public Class ResourceCenter
    Dim businessOwner As BusinessOwner
    Dim businessList As List(Of Business)
    Dim businessDirectory As BusinessDirectory
 
    Public Sub New()
        businessOwner = New BusinessOwner()
        businessList = New List(Of Business)
        businessDirectory = New BusinessDirectory()
    End Sub
 
    Public Function GetBusinessOwner() As BusinessOwner
        Return businessOwner
    End Function
 
    Public Sub AddBusiness(ByVal business As Business)
        businessList.Add(business)
    End Sub
 
    Public Sub RemoveBusiness(ByVal businessName As String)
        For Each b As Business In businessList
            If (b.Name = businessName) Then
                businessList.Remove(b)
            End If
        Next
    End Sub
 
    Public Function GetBusinessByNameAndLocation(ByVal businessName As String, ByVal businessLocation As String) As Business
        For Each b As Business In businessList
            If (b.Name = businessName And b.Location = businessLocation) Then
                Return b
            End If
        Next
 
        Return Nothing
    End Function
 
    Public Function GetBusinessDirectory() As BusinessDirectory
        Return businessDirectory
    End Function
 
    Public Sub SetBusinessDirectory(ByVal value As BusinessDirectory)
        businessDirectory = value
    End Sub
 
    Public Function GetBusinessList() As List(Of Business)
        Return businessList
    End Function
 
    Public Sub SetBusinessList(ByVal value As List(Of Business))
        businessList = value
    End Sub
 
    Public Sub UpdateBusinessDirectory()
        For Each b As Business In businessList
            businessDirectory.AddBusiness(b)
        Next
    End Sub
End Class