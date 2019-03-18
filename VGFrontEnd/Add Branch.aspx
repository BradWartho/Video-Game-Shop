<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add Branch.aspx.cs" Inherits="VGFrontEnd.Add_Branch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Branch<br />
            <br />
            <br />
            <br />
            <br />
            Branch Name:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtBranchName" runat="server"></asp:TextBox>
            <br />
            <br />
            Address Line 1:<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="67px" Width="173px"></asp:TextBox>
            <br />
            <br />
            <br />
            Address Line 2:<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="52px" Width="150px"></asp:TextBox>
            <br />
            <br />
            City:<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 13px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Postcode:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAddBranch" runat="server" OnClick="BtnAddBranch_Click" Text="Add Branch" />
            <br />
            <br />
            <asp:Button ID="BtnBackBranch" runat="server" OnClick="BtnBackBranch_Click" Text="Back" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
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
