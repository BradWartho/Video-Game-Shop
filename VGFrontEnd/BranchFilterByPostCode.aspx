<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BranchFilterByPostCode.aspx.cs" Inherits="VGFrontEnd.BranchFilterByPostCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FilterByPostCode<br />
            <br />
            Branch Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Branch PostCode:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnFilter" runat="server" Text="Filter " Width="44px" />
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnBackFilter" runat="server" OnClick="BtnBackFilter_Click1" Text="Back" />
            <br />
            <br />
            <asp:Label ID="LblFilter" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
