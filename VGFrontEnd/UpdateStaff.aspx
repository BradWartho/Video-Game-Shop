<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStaff.aspx.cs" Inherits="VGFrontEnd.UpdateStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update Staff<br />
            <br />
            Find Staff Member:<br />
            <br />
            Staff ID:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonFindStaffMember" runat="server" OnClick="ButtonFindStaffMember_Click" Text="Find Staff Member" Width="187px" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            Update Details:<br />
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
            <asp:TextBox ID="TextBoxAddress" runat="server" Width="470px"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonUpdateStaffDetails" runat="server" Height="39px" OnClick="ButtonUpdateStaffDetails_Click" Text="Update Details " Width="121px" />
            <asp:Label ID="lblUpdateDetails" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonMainMenu" runat="server" OnClick="ButtonMainMenu_Click" Text="Main Menu" />
        </div>
    </form>
</body>
</html>
