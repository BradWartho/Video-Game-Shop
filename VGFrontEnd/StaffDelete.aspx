<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDelete.aspx.cs" Inherits="VGFrontEnd.StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Staff Delete<br />
                <br />
                Staff ID:</div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>
                <asp:Button ID="ButtonDeleteStaffMember" runat="server" Height="34px" OnClick="ButtonDeleteStaffMember_Click" Text="Delete Staff" Width="109px" />
            </p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <p>
                <asp:Button ID="ButtonMainMenu" runat="server" Height="34px" OnClick="ButtonMainMenu_Click" Text="Staff Main Menu" Width="145px" />
            </p>
        </div>
    </form>
</body>
</html>
