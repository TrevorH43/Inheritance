Public Class PreferredCustomer
    Inherits Customer

    Public Property PurchaseAmount As Decimal
    Public ReadOnly Property DiscountLevel As Single
        Get
            If PurchaseAmount >= 2000 Then
                Return 0.1
            ElseIf PurchaseAmount >= 1500 Then
                Return 0.07
            ElseIf PurchaseAmount >= 1000 Then
                Return 0.06
            ElseIf PurchaseAmount >= 500 Then
                Return 0.05
            Else
                Return 0
            End If
        End Get
    End Property
End Class
