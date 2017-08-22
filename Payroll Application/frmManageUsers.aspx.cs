using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"),
        txtUserName.Text, txtUserPassword.Text, DropDownList1.SelectedValue))
        {
            lblError.Text = "The user was successfully added!";
            grdUsers.DataBind();
        }
        else
        {
            lblError.Text = "The user was NOT successfully added!";
        }
    }

}