<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 271px">
    <form id="form1" runat="server">
    <div style="height: 254px">
    
        <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        <asp:TextBox ID="txtId" runat="server" Height="22px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
    
    </div>
    </form>
</body>
</html>
