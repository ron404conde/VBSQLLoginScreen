'RON
'Created by: RON CONDE

Option Strict Off
Option Explicit On

Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class AppConfiguration
    Public cnstring As String
    Public sqlconn As New SqlConnection

    'database string
    Public Server As String
    Public Database As String
    Public Username As String
    Public Password As String

    Public Sub New()
        Dim appRdr As New System.Configuration.AppSettingsReader

        Server = appRdr.GetValue("Server", GetType(String))
        Database = appRdr.GetValue("Database", GetType(String))
        Username = appRdr.GetValue("Username", GetType(String))
        Password = appRdr.GetValue("Password", GetType(String))

        Dim str_DEncrypted As String
        str_DEncrypted = GetDecryptedData(Password)

        cnstring = "Data Source= '" & Server & "' ;Initial Catalog= '" & Database & "' ;User Id= '" & Username & "';Password='" & str_DEncrypted & "' ; Connection Timeout=900;"
        sqlconn = New SqlConnection(cnstring)
    End Sub

    'Encrypt the Data
    Public Shared Function GetEncryptedData(ByVal Data As String) As String
        Dim shaM As New SHA1Managed
        Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Data)))
        Dim eNC_data() As Byte = ASCIIEncoding.ASCII.GetBytes(Data)
        Dim eNC_str As String = Convert.ToBase64String(eNC_data)
        GetEncryptedData = eNC_str
    End Function

    'Decrypt the Data
    Public Shared Function GetDecryptedData(ByVal Data As String) As String
        Dim dEC_data() As Byte = Convert.FromBase64String(Data)
        Dim dEC_Str As String = ASCIIEncoding.ASCII.GetString(dEC_data)
        GetDecryptedData = dEC_Str
    End Function

End Class
