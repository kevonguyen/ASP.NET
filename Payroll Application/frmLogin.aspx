<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
    
    </div>
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="frmMain.aspx" TitleText="Please enter your UserName and Password in order to log in to the system." OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    </form>
</body>
</html>
