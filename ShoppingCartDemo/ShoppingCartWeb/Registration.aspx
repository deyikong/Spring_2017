<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 326px">
    <form id="form1" runat="server">
   <div style="height: 311px">
    
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
        <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
    
    </div>
    </form>
</body>
</html>
