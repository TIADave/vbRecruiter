Public Class needItem

    Dim _Year As Integer
    Dim _Setter As Boolean = False
    Dim _OutsideHitter As Boolean = False
    Dim _PinHitter As Boolean = False
    Dim _MiddleBlocker As Boolean = False
    Dim _Libero As Boolean = False
    Dim _DS As Boolean = False
    Dim _Notes As String = String.Empty
    Dim _Scolarships As String = String.Empty
    Dim _Requirements As String = String.Empty

    Public Sub New(yr As Integer, tx As String)
        _Year = yr
        Parse(tx)
    End Sub

    Private Sub Parse(tx As String)

        tx = tx.ToUpper.Replace("AND", "·").Replace("OR", "·")
        ProcessItems(tx.Split({","c, "@"c, "&"c, "/"c, "\"c, "·"c, ";"c, ":"c}))


    End Sub

    Private Sub ProcessItems(itms() As String)
        For Each itm In itms
            ProcessItem(itm.Trim)
        Next
    End Sub

    Private Sub ProcessItem(itm As String)
        If itm = "ALL" OrElse itm.Contains("EVERYTHING") OrElse itm.Contains("ALL POSITIONS") Then
            _Setter = True
            _MiddleBlocker = True
            _Libero = True
            _OutsideHitter = True
            _DS = True
        ElseIf itm = "S" OrElse itm.Contains("ETTER") Then
            _Setter = True
        ElseIf itm = "M" OrElse itm.Contains("MH") OrElse itm.Contains("MB") OrElse itm.Contains("MIDDLE") OrElse itm.Contains("BLOCKER") OrElse itm = "M1" Then
            _MiddleBlocker = True
        ElseIf itm = "L" OrElse itm.Contains("LB") OrElse itm.Contains("LIBERO") Then
            _Libero = True
        ElseIf itm = "H" OrElse itm.Contains("OH") OrElse itm.Contains("PIN") OrElse itm.Contains("RS") OrElse itm.Contains("LS") OrElse itm.Contains("RH") OrElse itm.Contains("RIGHT") OrElse itm.Contains("LEFT") OrElse itm.Contains("HITTER") OrElse itm.Contains("OUTSIDE") Then
            _OutsideHitter = True
        ElseIf itm = "D" OrElse itm.Contains("DS") OrElse itm.Contains("SPECIALIST") Then
            _DS = True
        ElseIf itm.Contains("COACHES") OrElse itm.Contains("PREPVOLLEYBALL.COM WITH ANY UPDATES.") Then
        Else
            If Not _Notes.Contains(itm) Then
                _Notes += $"{itm}|"
            End If
        End If
    End Sub

    Public Property Year As Integer
        Get
            Return _Year
        End Get
        Set(value As Integer)
            _Year = value
        End Set
    End Property

    Public Property Setter As Boolean
        Get
            Return _Setter
        End Get
        Set(value As Boolean)
            _Setter = value
        End Set
    End Property

    Public Property OutsideHitter As Boolean
        Get
            Return _OutsideHitter
        End Get
        Set(value As Boolean)
            _OutsideHitter = value
        End Set
    End Property

    Public Property PinHitter As Boolean
        Get
            Return _PinHitter
        End Get
        Set(value As Boolean)
            _PinHitter = value
        End Set
    End Property

    Public Property MiddleBlocker As Boolean
        Get
            Return _MiddleBlocker
        End Get
        Set(value As Boolean)
            _MiddleBlocker = value
        End Set
    End Property

    Public Property Libero As Boolean
        Get
            Return _Libero
        End Get
        Set(value As Boolean)
            _Libero = value
        End Set
    End Property

    Public Property DS As Boolean
        Get
            Return _DS
        End Get
        Set(value As Boolean)
            _DS = value
        End Set
    End Property

    Public Property Scolarships As String
        Get
            Return _Scolarships
        End Get
        Set(value As String)
            _Scolarships = value
        End Set
    End Property

    Public Property Requirements As String
        Get
            Return _Requirements
        End Get
        Set(value As String)
            _Requirements = value
        End Set
    End Property

    Public Property Notes As String
        Get
            Return _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

End Class
