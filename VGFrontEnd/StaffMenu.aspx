<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffMenu.aspx.cs" Inherits="VGFrontEnd.StaffMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff Menu<br />
            <br />
            <asp:Button ID="ButtonStaffEntry" runat="server" Height="60px" OnClick="ButtonStaffEntry_Click" Text="Staff Entry" Width="100px" />
            <br />
            <br />
            <asp:Button ID="ButtonStaffDelete" runat="server" Height="50px" OnClick="ButtonStaffDelete_Click" Text="Staff Delete" Width="100px" />
            <br />
            <br />
            <asp:Button ID="ButtonListStaff" runat="server" Height="50px" OnClick="ButtonListStaff_Click" Text="List Staff" Width="99px" />
            <br />
            <br />
            <asp:Button ID="ButtonUpdateStaff" runat="server" Height="48px" OnClick="ButtonUpdateStaff_Click" Text="Update Staff" Width="100px" />
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
