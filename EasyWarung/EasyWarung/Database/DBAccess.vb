Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DBAccess
    Private SQLConn As SqlConnection
    Private ServerAddress As String
    Private DBInstance As String
    Private DBName As String
    Private UserDB As String
    Private PassDB As String

    Public Sub New(serverAddress As String, dBInstance As String, dBName As String, userDB As String, passDB As String)
        Me.ServerAddress = serverAddress
        Me.DBInstance = dBInstance
        Me.DBName = dBName
        Me.UserDB = userDB
        Me.PassDB = passDB
    End Sub

    Public Sub OpenSqlConn()
        SQLConn = New SqlConnection(
            "Data Source=" & ServerAddress & "\" & DBInstance & "; 
            Database=" & DBName & "; 
            User Id=" & UserDB & "; 
            Password=" & PassDB & ";"
        )
        If SQLConn.State = ConnectionState.Closed Then
            SQLConn.Open()
        ElseIf SQLConn.State = ConnectionState.Broken Then
            SQLConn.Close()
            SQLConn.Open()
        End If
    End Sub

    Public Sub CloseSqlConn()
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        ElseIf SQLConn.State = ConnectionState.Connecting Then
            SQLConn.Close()
        ElseIf SQLConn.State = ConnectionState.Broken Then
            SQLConn.Close()
        End If
    End Sub

    Public Function CheckDBConn() As Boolean
        Try
            OpenSqlConn()
            If SQLConn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Indextation Domain
    '
    Public Function IndextationIDGetter(index As Integer, identity As Integer, order As DateTime) As String
        Dim IDTable As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_IndextationIDGetter", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@id_index", SqlDbType.Int)
            SQLCmd.Parameters("@id_index").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@id_index").Value = index

            SQLCmd.Parameters.Add("@id_identity", SqlDbType.Int)
            SQLCmd.Parameters("@id_identity").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@id_identity").Value = identity

            SQLCmd.Parameters.Add("@order_date", SqlDbType.DateTime)
            SQLCmd.Parameters("@order_date").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_date").Value = order

            SQLCmd.Parameters.Add("@id_table", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@id_table").Direction = ParameterDirection.Output

            SQLCmd.ExecuteNonQuery()
            IDTable = SQLCmd.Parameters("@id_table").Value.ToString()
            Return IDTable
        Catch ex As Exception
            Return "Error retrieving the indextation ID: " & ex.Message & "ERROR DBA.IndextationIDGetter()"
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Categories Domain
    '
    Public Function CategoriesList() As DataTable
        Dim DTCategory As New DataTable
        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_CategoriesList", SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTCategory)
            Return DTCategory
        Catch ex As Exception
            MessageBox.Show("Error retrieving the category list: " & ex.Message, "ERROR DBA.CategoriesList()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTCategory
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function CategoriesInsert(category As Category) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_CategoriesInsert", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@category_name", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@category_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_name").Value = category.CategoryName

            SQLCmd.ExecuteNonQuery()
            Return "Category data has been successfully added to the database."
        Catch ex As Exception
            Return "Error adding category data to the database: " & ex.Message & "ERROR DBA.BukuInsert()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function CategoriesUpdate(category As Category) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_CategoriesUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@category_id", SqlDbType.Int)
            SQLCmd.Parameters("@category_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_id").Value = category.CategoryID

            SQLCmd.Parameters.Add("@category_name", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@category_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_name").Value = category.CategoryName

            SQLCmd.ExecuteNonQuery()
            Return "Category data has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating category data to the database: " & ex.Message & "ERROR DBA.CategoriesUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function CategoriesDelete(category As Category) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_CategoriesDelete", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@category_id", SqlDbType.Int)
            SQLCmd.Parameters("@category_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_id").Value = category.CategoryID

            SQLCmd.ExecuteNonQuery()
            Return "Category data has been successfully deleted to the database."
        Catch ex As Exception
            Return "Error deleting category data to the database: " & ex.Message & "ERROR DBA.CategoriesDelete()"
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Products Domain
    '
    Public Function ProductsList() As DataTable
        Dim DTProduct As New DataTable
        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_ProductsList", SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTProduct)
            Return DTProduct
        Catch ex As Exception
            MessageBox.Show("Error retrieving the product list: " & ex.Message, "ERROR DBA.ProductsList()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTProduct
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function ProductsInsert(product As Product) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_ProductsInsert", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@product_name", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@product_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_name").Value = product.ProductName

            SQLCmd.Parameters.Add("@product_price", SqlDbType.Float)
            SQLCmd.Parameters("@product_price").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_price").Value = product.ProductPrice

            SQLCmd.Parameters.Add("@category_id", SqlDbType.Int)
            SQLCmd.Parameters("@category_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_id").Value = product.CategoryID

            SQLCmd.Parameters.Add("@product_image", SqlDbType.Image)
            SQLCmd.Parameters("@product_image").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_image").Value = product.ProductImage

            SQLCmd.ExecuteNonQuery()
            Return "Product data has been successfully added to the database."
        Catch ex As Exception
            Return "Error adding product data to the database: " & ex.Message & "ERROR DBA.ProductsInsert()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function ProductsUpdate(product As Product) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_ProductsUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@product_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@product_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_id").Value = product.ProductID

            SQLCmd.Parameters.Add("@product_name", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@product_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_name").Value = product.ProductName

            SQLCmd.Parameters.Add("@product_price", SqlDbType.Float)
            SQLCmd.Parameters("@product_price").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_price").Value = product.ProductPrice

            SQLCmd.Parameters.Add("@category_id", SqlDbType.Int)
            SQLCmd.Parameters("@category_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@category_id").Value = product.CategoryID

            SQLCmd.Parameters.Add("@product_image", SqlDbType.Image)
            SQLCmd.Parameters("@product_image").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_image").Value = product.ProductImage

            SQLCmd.ExecuteNonQuery()
            Return "Product data has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating product data to the database: " & ex.Message & "ERROR DBA.ProductsUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function ProductsDelete(product As Product) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_ProductsDelete", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@product_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@product_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_id").Value = product.ProductID

            SQLCmd.ExecuteNonQuery()
            Return "Product data has been successfully deleted to the database."
        Catch ex As Exception
            Return "Error deleting product data to the database: " & ex.Message & "ERROR DBA.ProductsDelete()"
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Payments Domain
    '
    Public Function PaymentsList() As DataTable
        Dim DTPayment As New DataTable
        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_PaymentsList", SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTPayment)
            Return DTPayment
        Catch ex As Exception
            MessageBox.Show("Error retrieving the payment list: " & ex.Message, "ERROR DBA.PaymentsList()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTPayment
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Orders Domain
    '
    Public Function OrdersList() As DataTable
        Dim DTOrder As New DataTable
        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_OrdersList", SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTOrder)
            Return DTOrder
        Catch ex As Exception
            MessageBox.Show("Error retrieving the order list: " & ex.Message, "ERROR DBA.OrdersList()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTOrder
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrdersInsert(order As Order) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrdersInsert", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@user_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_id").Value = My.Application.User.UserID

            SQLCmd.Parameters.Add("@payment_id", SqlDbType.Int)
            SQLCmd.Parameters("@payment_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@payment_id").Value = order.PaymentID

            SQLCmd.Parameters.Add("@order_date", SqlDbType.DateTime)
            SQLCmd.Parameters("@order_date").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_date").Value = order.OrderDateTime

            SQLCmd.ExecuteNonQuery()
            Return "Order data has been successfully added to the database."
        Catch ex As Exception
            Return "Error adding order data to the database: " & ex.Message & "ERROR DBA.OrdersInsert()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrdersUpdate(order As Order) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrdersUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            SQLCmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@user_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_id").Value = My.Application.User.UserID

            SQLCmd.Parameters.Add("@payment_id", SqlDbType.Int)
            SQLCmd.Parameters("@payment_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@payment_id").Value = order.PaymentID

            SQLCmd.Parameters.Add("@order_date", SqlDbType.DateTime)
            SQLCmd.Parameters("@order_date").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_date").Value = order.OrderDateTime

            SQLCmd.ExecuteNonQuery()
            Return "Order data has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating order data to the database: " & ex.Message & "ERROR DBA.OrdersUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrdersDelete(order As Order) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrdersDelete", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            SQLCmd.ExecuteNonQuery()
            Return "Order data has been successfully deleted to the database."
        Catch ex As Exception
            Return "Error deleting order data to the database: " & ex.Message & "ERROR DBA.OrdersDelete()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrderStatusUpdate(order As Order, status As Integer) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrderStatusUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            SQLCmd.Parameters.Add("@order_status", SqlDbType.Int)
            SQLCmd.Parameters("@order_status").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_status").Value = status

            SQLCmd.ExecuteNonQuery()
            Return "Order status has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating order status to the database: " & ex.Message & "ERROR DBA.OrderStatusUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function
    '
    ' Order Detail Domain
    '
    Public Function OrderDetailListByID(order As Order) As DataTable
        Dim DTOrderDetail As New DataTable
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrderDetailListByID", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            Dim adapter As New SqlDataAdapter(SQLCmd)
            adapter.Fill(DTOrderDetail)
            Return DTOrderDetail
        Catch ex As Exception
            MessageBox.Show("Error retrieving the order detail list: " & ex.Message, "ERROR DBA.OrderDetailListByID()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTOrderDetail
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrderDetailInsert(order As Order, orderDetail As OrderDetail) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrderDetailInsert", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            SQLCmd.Parameters.Add("@product_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@product_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_id").Value = orderDetail.ProductID

            SQLCmd.Parameters.Add("@product_price", SqlDbType.Float)
            SQLCmd.Parameters("@product_price").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_price").Value = orderDetail.ProductPrice

            SQLCmd.Parameters.Add("@order_amount", SqlDbType.Int)
            SQLCmd.Parameters("@order_amount").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_amount").Value = orderDetail.OrderAmount

            SQLCmd.ExecuteNonQuery()
            Return "Order Detail data has been successfully added to the database."
        Catch ex As Exception
            Return "Error adding order detail data to the database: " & ex.Message & "ERROR DBA.OrderDetailInsert()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrderDetailUpdate(order As Order, orderDetail As OrderDetail) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrderDetailUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@detail_id", SqlDbType.Int)
            SQLCmd.Parameters("@detail_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@detail_id").Value = orderDetail.DetailID

            SQLCmd.Parameters.Add("@order_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@order_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_id").Value = order.OrderID

            SQLCmd.Parameters.Add("@product_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@product_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_id").Value = orderDetail.ProductID

            SQLCmd.Parameters.Add("@product_price", SqlDbType.Float)
            SQLCmd.Parameters("@product_price").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@product_price").Value = orderDetail.ProductPrice

            SQLCmd.Parameters.Add("@order_amount", SqlDbType.Int)
            SQLCmd.Parameters("@order_amount").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@order_amount").Value = orderDetail.OrderAmount

            SQLCmd.ExecuteNonQuery()
            Return "Order Detail data has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating order detail data to the database: " & ex.Message & "ERROR DBA.OrderDetailUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function OrderDetailDelete(orderDetail As OrderDetail) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_OrderDetailDelete", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@detail_id", SqlDbType.Int)
            SQLCmd.Parameters("@detail_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@detail_id").Value = orderDetail.DetailID

            SQLCmd.ExecuteNonQuery()
            Return "Order Detail data has been successfully deleted to the database."
        Catch ex As Exception
            Return "Error deleting order detail data to the database: " & ex.Message & "ERROR DBA.OrderDetailDelete()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    '
    ' Users Domain
    '
    Public Function UsersList() As DataTable
        Dim DTUser As New DataTable
        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_UsersList", SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTUser)
            Return DTUser
        Catch ex As Exception
            MessageBox.Show("Error retrieving the user list: " & ex.Message, "ERROR DBA.UsersList()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DTUser
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UserLogin(username As String, passwordChipper As String) As User
        Dim user As User
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UserLogin", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@user_username", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@user_username").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_username").Value = username

            SQLCmd.Parameters.Add("@user_password", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@user_password").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_password").Value = passwordChipper

            Dim reader As SqlDataReader
            reader = SQLCmd.ExecuteReader()

            While reader.Read
                If reader.HasRows() Then
                    user = New User(reader.Item("UserID"), reader.Item("UserName"), reader.Item("UserAddress"), reader.Item("UserEmail"), reader.Item("UserPhone"), reader.Item("UserRoleStr"), reader.Item("Username"), passwordChipper, reader.Item("UserImage"), reader.Item("UserStatusStr"), reader.Item("UserRoleInt"), reader.Item("UserStatusInt"))
                    Return user
                Else
                    user = Nothing
                End If
            End While

            reader.Close()
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("Error retrieving the user data: " & ex.Message, "ERROR DBA.UserLogin()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UsersInsert(user As User) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UsersInsert", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_name").Value = user.UserNames

            SQLCmd.Parameters.Add("@user_address", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_address").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_address").Value = user.UserAddress

            SQLCmd.Parameters.Add("@user_email", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_email").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_email").Value = user.UserEmail

            SQLCmd.Parameters.Add("@user_phone", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_phone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_phone").Value = user.UserPhone

            SQLCmd.Parameters.Add("@user_role", SqlDbType.Int)
            SQLCmd.Parameters("@user_role").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_role").Value = user.UserRoleInt

            SQLCmd.Parameters.Add("@user_username", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@user_username").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_username").Value = user.Username

            SQLCmd.Parameters.Add("@user_password", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@user_password").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_password").Value = user.Password

            SQLCmd.Parameters.Add("@user_image", SqlDbType.Image)
            SQLCmd.Parameters("@user_image").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_image").Value = user.UserImage

            SQLCmd.ExecuteNonQuery()
            Return "User data has been successfully added to the database."
        Catch ex As Exception
            Return "Error adding user data to the database: " & ex.Message & "ERROR DBA.UsersInsert()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UsersUpdate(user As User) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UsersUpdate", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@user_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_id").Value = user.UserID

            SQLCmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_name").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_name").Value = user.UserNames

            SQLCmd.Parameters.Add("@user_address", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_address").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_address").Value = user.UserAddress

            SQLCmd.Parameters.Add("@user_email", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_email").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_email").Value = user.UserEmail

            SQLCmd.Parameters.Add("@user_phone", SqlDbType.NVarChar, 250)
            SQLCmd.Parameters("@user_phone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_phone").Value = user.UserPhone

            SQLCmd.Parameters.Add("@user_role", SqlDbType.Int)
            SQLCmd.Parameters("@user_role").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_role").Value = user.UserRoleInt

            SQLCmd.Parameters.Add("@user_username", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@user_username").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_username").Value = user.Username

            SQLCmd.Parameters.Add("@user_password", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@user_password").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_password").Value = user.Password

            SQLCmd.Parameters.Add("@user_image", SqlDbType.Image)
            SQLCmd.Parameters("@user_image").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_image").Value = user.UserImage

            SQLCmd.ExecuteNonQuery()
            Return "User data has been successfully updated to the database."
        Catch ex As Exception
            Return "Error updating user data to the database: " & ex.Message & "ERROR DBA.UsersUpdate()"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UsersDelete(user As User) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UsersDelete", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 25)
            SQLCmd.Parameters("@user_id").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@user_id").Value = user.UserID

            SQLCmd.ExecuteNonQuery()
            Return "User data has been successfully deleted to the database."
        Catch ex As Exception
            Return "Error deleting user data to the database: " & ex.Message & "ERROR DBA.UsersDelete()"
        Finally
            CloseSqlConn()
        End Try
    End Function
End Class