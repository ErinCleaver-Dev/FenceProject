' Name:         Rectangle.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Rectangle
    Private dbLength As Double
    Private dbWidth As Double

    Public Property Length As Double
        Get
            Return dbLength
        End Get
        Set(value As Double)
            If value > 0 Then
                dbLength = value
            Else
                dbWidth = 0
            End If
        End Set
    End Property

    Public Property Width As Double
        Get
            Return dbWidth
        End Get
        Set(value As Double)
            If value > 0 Then
                dbWidth = value
            Else
                dbWidth = 0
            End If
        End Set
    End Property

    Public Sub New()
        dbLength = 0
        dbWidth = 0
    End Sub

    Public Sub New(ByVal dbL As Double, ByVal dbW As Double)
        Length = dbL
        Width = dbW
    End Sub

    Public Function GetArea() As Double
        Return dbLength * dbWidth
    End Function

    Public Function GetPerimeter() As Double
        Return (dbLength + dbWidth) * 2
    End Function
End Class
