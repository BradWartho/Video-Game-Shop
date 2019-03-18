<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateBranch.aspx.cs" Inherits="VGFrontEnd.UpdateBranch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Update Branch<br />
    <br />
    <form id="form1" runat="server">
        Branch Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        Address Line 1:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Address Line 2:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        City:<asp:TextBox ID="TextBox5" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        Postcode:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="BntUpdateButton" runat="server" Text="Update Button" />
        <br />
        <br />
        <asp:Button ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
        <div>
        </div>
    </form>
</body>
</html>
