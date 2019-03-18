<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BranchMenu.aspx.cs" Inherits="VGFrontEnd.BranchMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Video Game Branch<br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Branch" Width="147px" />
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" Height="24px" OnClick="btnDelete_Click1" Text="Delete Branch" Width="149px" />
            <br />
            <br />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click1" Text="Update Branch" Width="154px" />
            <br />
            <br />
            <asp:Button ID="btnFilterByPostCode" runat="server" Text="FilterByPostCode" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnExit" runat="server" Height="26px" Text="Exit" Width="81px" />
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
