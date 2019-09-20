Imports System.ComponentModel.DataAnnotations

Public Class ListPortofolio
    Private _no As Integer
    Public Property No() As Integer
        Get
            Return _no
        End Get
        Set(ByVal value As Integer)
            _no = value
        End Set
    End Property
    Private _nameProject As String
    <Display(Name:="Name Project")>
    Public Property NameProject() As String
        Get
            Return _nameProject
        End Get
        Set(ByVal value As String)
            _nameProject = value
        End Set
    End Property
    Private _program As String
    Public Property Program() As String
        Get
            Return _program
        End Get
        Set(ByVal value As String)
            _program = value
        End Set
    End Property
    Private _view As String
    Public Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            _view = value
        End Set
    End Property
End Class
