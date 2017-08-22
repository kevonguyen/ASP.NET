<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

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
        <asp:Panel ID="Panel1" runat="server" Height="300px" HorizontalAlign="Left" Width="600px">
            <asp:Label ID="Label1" runat="server" Text="First Name:" width="87px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server" Height="16px" Width="149px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" height="19px" Text="Last Name:" width="87px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtLastName" runat="server" width="149px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" height="19px" Text="Pay Rate:" width="87px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPayRate" runat="server" style="height: 22px" width="149px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Pay Rate is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" height="19px" Text="Start Date:" width="87px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStartDate" runat="server" width="149px"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Date must be in this format: mm/dd/yyyy" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label5" runat="server" height="19px" Text="End Date:" width="87px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEndDate" runat="server" width="149px"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$">Date must be in this format: mm/dd/yyyy</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" PostBackUrl="~/frmMain.aspx" Text="Cancel" />
            &nbsp;<asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Text="View Personnel" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
