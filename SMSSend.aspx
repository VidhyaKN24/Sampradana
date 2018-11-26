<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SMSSend.aspx.cs" Inherits="Sampradana_SMSSending.SMSSend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtMessage" runat="server" >

        </asp:TextBox>
        <asp:Button ID="btnsend" runat="server" Text="Send" OnClick="btnsend_Click" />
    
    </div>
    </form>
</body>
</html>
