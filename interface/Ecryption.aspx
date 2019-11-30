<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ecryption.aspx.cs" Inherits="Ecryption" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Encryption</title>
</head>
<body>
     <div style="background-image: url('images/2.jpg'); background-size:cover; background-attachment:fixed; background-repeat: no-repeat;">
    <form id="form1" runat="server">
            <div>
            <h1 style="text-align:center; color:MidnightBlue;">Data Encryption</h1>
        </div>
    <div style="text-align:center ;margin:30px">
       <asp:Label ID="Label1" runat="server" Text="Select a File" Font-Bold="true" style="padding:30px;"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <!--<input id="File1" type="file" />-->
    </div>
        <div style="text-align:center; margin:30px">
            <asp:Label ID="Label2" runat="server" Text="Data in File"  Font-Bold="true" style="padding:10px;"></asp:Label>
            <asp:TextBox ID="Data" runat="server" Height="327px" Width="496px" style="margin-left:20px"></asp:TextBox>
        </div>
        <div style="text-align:center; margin:30px">
            <asp:Label ID="Label3" runat="server" Text="Enter key to decode" Font-Bold="true" style="padding:30px;"></asp:Label>
            <asp:TextBox ID="Key" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center ;margin:30px">
        <asp:Button ID="Button1" runat="server" Text="Decode" />
            </div>
    </form>
          </div>
</body>
</html>
