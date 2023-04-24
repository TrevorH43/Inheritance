Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices

Public Class Form1

    Private _customer As Customer

    Private preferredCustomers As New Dictionary(Of Integer, PreferredCustomer)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _customer = New Customer()
        custNumberTxt.Text = _customer.CustomerNumber.ToString()
        mailList.Checked = _customer.MailingList
        commentsTxt.Text = _customer.Comments
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim customer As New PreferredCustomer() With {
            .CustomerNumber = Integer.Parse(custNumberTxt.Text),
            .FirstName = firstNameTxt.Text,
            .Address = addrTxt.Text,
            .LastName = lastNameTxt.Text,
            .City = cityTxt.Text,
            .State = stateTxt.Text,
            .Zip = zipTxt.Text,
            .Phone = custNumberTxt.Text,
            .PurchaseAmount = Decimal.Parse(purchaseAmtTxt.Text)
        }
        preferredCustomers.Add(customer.CustomerNumber, customer)

        MessageBox.Show("Customer information saved successfully.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        firstNameTxt.Clear()
        lastNameTxt.Clear()
        addrTxt.Clear()
        stateTxt.Clear()
        zipTxt.Clear()
        custNumbTxt.Clear()
        custNumberTxt.Clear()
        cityTxt.Clear()
        purchaseAmtTxt.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim customerNumber As Integer = Integer.Parse(custNumbTxt.Text)
        If preferredCustomers.ContainsKey(customerNumber) Then
            Dim customer As PreferredCustomer = preferredCustomers(customerNumber)

            mailList.Checked = customer.MailingList
            commentsTxt.Text = customer.Comments
            purchaseAmtTxt.Text = customer.PurchaseAmount.ToString()
            discountLvl.Text = customer.DiscountLevel.ToString()
        Else
            MessageBox.Show("Customer Not Found.")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim customerNumber As Integer = CInt(custNumbTxt.Text)

        If preferredCustomers.ContainsKey(customerNumber) Then
            preferredCustomers.Remove(customerNumber)
            MessageBox.Show("Customer Deleted")
        End If
        MessageBox.Show("Customer Not Found.")
    End Sub
End Class
