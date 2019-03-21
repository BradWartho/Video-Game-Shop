<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BranchMenu.aspx.cs" Inherits="VGFrontEnd.BranchMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head
     runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        #irc_mi {
            height: 173px;
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Video Game Branch&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            <asp:Button ID="btnFilterByPostCode" runat="server" Text="Filter By Post Code" OnClick="btnFilterByPostCode_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnReturntoMainMenu" runat="server" Height="34px" Text="Return to Main Menu" Width="154px" OnClick="btnReturntoMainMenu_Click" />
            <br />
            <br />
            <br />
            <br />
            <a id="irc_mil" data-cthref="https://www.google.com/url?sa=i&amp;rct=j&amp;q=&amp;esrc=s&amp;source=images&amp;cd=&amp;cad=rja&amp;uact=8&amp;ved=2ahUKEwjH9eCO9JPhAhUMThoKHVb4DLQQjRx6BAgBEAU&amp;url=https%3A%2F%2Fwww.reachaccountant.com%2Ferp-software-pos-software-blog%2Fgst-registration-for-branches%2F&amp;psig=AOvVaw0mKPPtQBjSjdSll7ESMMF2&amp;ust=1553280818494905" data-ved="2ahUKEwjH9eCO9JPhAhUMThoKHVb4DLQQjRx6BAgBEAU" href="https://www.google.com/url?sa=i&amp;rct=j&amp;q=&amp;esrc=s&amp;source=images&amp;cd=&amp;cad=rja&amp;uact=8&amp;ved=2ahUKEwjH9eCO9JPhAhUMThoKHVb4DLQQjRx6BAgBEAU&amp;url=https%3A%2F%2Fwww.reachaccountant.com%2Ferp-software-pos-software-blog%2Fgst-registration-for-branches%2F&amp;psig=AOvVaw0mKPPtQBjSjdSll7ESMMF2&amp;ust=1553280818494905" jsaction="mousedown:irc.rl;focus:irc.rl;irc.il;" style="border: 0px currentColor; border-image: none;">
            <img id="irc_mi" alt="Image result for branches business" data-iml="1553194422955" height="262" onload="typeof google==='object'&amp;&amp;google.aft&amp;&amp;google.aft(this)" src="http://www.reachaccountant.com/wp-content/uploads/2018/01/GST-Registration-for-Branches.jpg" width="382" /></a><br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
