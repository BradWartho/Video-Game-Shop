<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffEntry.aspx.cs" Inherits="VGFrontEnd.StaffEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body style="height: 310px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Staff Entry"></asp:Label>
            <br />
            <br />
            <br />
            First Name:<br />
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:<br />
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            Address:<br />
            <asp:TextBox ID="TextBoxAddress" runat="server" Height="22px" Width="365px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonAddStaff" runat="server" Height="40px" OnClick="ButtonAddStaff_Click" Text="Add Staff" Width="130px" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonMainMenu" runat="server" Height="32px" OnClick="ButtonMainMenu_Click" Text="Staff Main Menu" Width="155px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
