<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListStaff.aspx.cs" Inherits="VGFrontEnd.ListStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                List Of Staff&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            <asp:TextBox ID="TextBoxListOfStaff" runat="server" Height="300px" Width="199px"></asp:TextBox>
            <br />
            <br />
            Filter By:<br />
            <br />
            First Name:<br />
            <asp:TextBox ID="TextBoxFilterFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:<br />
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            Staff ID:<br />
            <asp:TextBox ID="TextBoxFilterStaffID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonFilterStaff" runat="server" Height="30px" OnClick="ButtonFilterStaff_Click" Text="Filter Staff" Width="114px" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonMainMenu" runat="server" Height="30px" OnClick="ButtonMainMenu_Click" Text="Main Menu" Width="114px" />
        </div>
    </form>
</body>
</html>
