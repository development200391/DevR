Imports System.ComponentModel.DataAnnotations

Public Class SendEmail
    <Required>
    Public Property Name As String
    <Required>
    Public Property Email As String
    <Required>
    Public Property Subject As String
    <Required>
    Public Property Message As String
End Class
