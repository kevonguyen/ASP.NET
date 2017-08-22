using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Save user activity to PayrollSystem
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmMain");


        linkbtnCalculator.Visible = true;
        imgbtnCalculator.Visible = true;
        linkbtnViewPersonnel.Visible = true;
        imgbtnViewPersonnel.Visible = true;
        linkbtnSearch.Visible = true;
        imgbtnSearch.Visible = true;

        if (Session["SecurityLevel"] == "A")
        {
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;
            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;
            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;
            linkbtnEditUsers.Visible = true;
            imgbtnEditUsers.Visible = true;
        }


    }
}