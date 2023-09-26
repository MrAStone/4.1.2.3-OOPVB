Module Module1

    Sub Main()

    End Sub

End Module
Class Ball
    Private diameter As Double

    Public Sub SetDiameter(diam As Double)
        diameter = diam
    End Sub
    Public Overridable Function Volume()
        Dim vol As Double = 4.0 / 3.0 * Math.PI * Math.Pow(diameter / 2.0, 3)
        Return vol
    End Function

End Class

Class Football
    Inherits Ball
    Public Overrides Function Volume() As Object
        Dim vol = 5 * MyBase.Volume()
        Return vol
    End Function
End Class
Class Room
    Private width, height, length As Double
    Private type As String

    Public Sub New(w As Double, h As Double, l As Double, rType As String)
        width = w
        height = h
        length = l
        type = rType
    End Sub
    Public Function getArea() As Double
        Return width * length
    End Function

    Public Function getVolume() As Double
        Return height * width * length
    End Function
End Class
Class Resident
    Private ResName As String
    Private ResType As String

    Public Sub New(rName As String, rType As String)
        ResName = rName
        ResType = rType
    End Sub
End Class
Class Building
    Protected rooms As List(Of Room)
    Protected residents As List(Of Resident)

    Public Sub New(numRooms As Integer)
        rooms = New List(Of Room)
        residents = New List(Of Resident)
        For i = 0 To numRooms - 1
            Dim width, length, height As Double
            Dim type As String
            Console.Write("Enter room width: ")
            width = Console.ReadLine
            Console.Write("Enter room height: ")
            height = Console.ReadLine
            Console.Write("Enter room length: ")
            length = Console.ReadLine
            Console.Write("Enter type of room: ")
            type = Console.ReadLine
            Dim room As New Room(width, length, height, type)
            rooms.Add(room)
        Next
    End Sub
    Public Sub addResidents(resident As Resident)
        residents.Add(resident)
    End Sub
    Public Function TotalArea() As Double
        Dim area As Double = 0
        For Each room In rooms
            area += room.getArea
        Next
        Return area
    End Function
End Class
Class Hotel
    Inherits Building
    Private hasPool As Boolean
    Public Sub New(numRooms As Integer, hasAPool As Boolean)
        MyBase.New(numRooms)
        hasPool = hasAPool

    End Sub
End Class
