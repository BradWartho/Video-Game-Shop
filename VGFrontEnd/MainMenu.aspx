<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="VGFrontEnd.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Main Menu<br />
            <br />
            <br />
            <asp:Button ID="ButtonStaff" runat="server" Height="50px" OnClick="ButtonStaff_Click" Text="Staff" Width="99px" />
            <br />
            <br />
            <asp:Button ID="ButtonBranches" runat="server" Height="50px" OnClick="ButtonBranches_Click" Text="Branches" Width="98px" />
            <br />
            <br />
            <br />
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
