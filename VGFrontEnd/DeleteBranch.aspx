﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteBranch.aspx.cs" Inherits="VGFrontEnd.DeleteBranch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Delete Branch<br />
            <br />
            <br />
            Branch Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Branch Postcode:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnDeleteBranch" runat="server" OnClick="btnDeleteBranch_Click" Text="Delete Branch" />
            <asp:Label ID="lblDeleteBranch" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Btnback" runat="server" OnClick="Btnback_Click1" Text="Back" />
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
