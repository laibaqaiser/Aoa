<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Encryption</title>
</head>
<body>
     <div style="background-image: url('images/encode.png'); margin: 0; padding: 0;position:absolute; z-index:-1; width:100%;height:100% ;background-size:cover; background-attachment:fixed; background-repeat: no-repeat;">
    <form id="form1" runat="server">
            <div>
            <h1 style="text-align:center; color:MidnightBlue;">Data Encryption</h1>
        </div>
    <div style="text-align:center ;margin:30px">
       <asp:Label ID="Label1" runat="server" Text="Select a File" Font-Bold="true" style="padding:30px;"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <!--<input id="File1" type="file" />-->
        <asp:Button ID="Upload" runat="server" Text="Upload" OnClick="Upload_Click" />
    </div>
        <div style="text-align:center; margin:30px">
            <asp:Label ID="Label2" runat="server" Text="Data in File"  Font-Bold="true" style="padding:10px"></asp:Label>
            <textarea id="data" runat="server" cols="50" rows="20" style="margin-left:30px"></textarea>
        </div>
        <div style="text-align:center; margin:30px">
            <asp:Label ID="Label3" runat="server" Text="Enter key to decode" Font-Bold="true" style="padding:30px;"></asp:Label>
            <asp:TextBox ID="Key" type="password" runat="server"></asp:TextBox>
        </div>
        <div style="text-align:center ;margin:30px">
            <asp:Button ID="Decode" runat="server" Text="Decode" OnClick="Decode_Click"  /> 

        </div>
    </form>
          </div>
</body>
</html>
