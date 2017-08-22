<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="84px" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" Width="426px" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="800px" Width="600px">
            <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="142px" ImageUrl="~/Images/calculator.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx" Visible="False">Annual Salary Calculator</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="121px" ImageUrl="~/Images/add personnel.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx" Visible="False">Add Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="81px" ImageUrl="~/Images/User Activity.jpg" PostBackUrl="~/frmUserActivity.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx" Visible="False">View User Activity</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="81px" ImageUrl="~/Images/staff.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Visible="False">View Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnSearch" runat="server" Height="81px" ImageUrl="~/Images/search.png" PostBackUrl="~/frmSearchPersonnel.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx" Visible="False">Search Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="81px" ImageUrl="~/Images/edit.png" PostBackUrl="~/frmEditPersonnel.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx" Visible="False">Edit Personnel</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnEditUsers" runat="server" Height="81px" ImageUrl="~/Images/edit.png" PostBackUrl="~/frmManageUsers.aspx" Width="127px" Visible="False" />
            &nbsp;<asp:LinkButton ID="linkbtnEditUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx" Visible="False">Edit User</asp:LinkButton>
        </asp:Panel>
    </form>
</body>
</html>
