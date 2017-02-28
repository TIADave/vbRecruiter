Public Class onPageDLEventArgs
    Inherits EventArgs
    Dim _dttm As Date
    Dim _PageNo As Int16
    Dim _PageText As String

    Public Sub New(_dttm As Date, _PageNo As Short, _PageText As String)
        MyBase.New

        Me._dttm = _dttm
        Me._PageNo = _PageNo
        Me._PageText = _PageText
    End Sub

    Public Property Dttm As Date
        Get
            Return _dttm
        End Get
        Set(value As Date)
            _dttm = value
        End Set
    End Property

    Public Property PageNo As Short
        Get
            Return _PageNo
        End Get
        Set(value As Short)
            _PageNo = value
        End Set
    End Property

    Public Property PageText As String
        Get
            Return _PageText
        End Get
        Set(value As String)
            _PageText = value
        End Set
    End Property

End Class
