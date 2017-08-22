using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // Declares new ds User
        dsUser dsUserLogin;
        // Declare local variable security level
        string SecurityLevel;
        // Instantiates the dsUser with the value returned from VerifyUser in clsDatalayer
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        // If no value was returned from VerifyUser then dont authenticate
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;

            if (clsBusinessLayer.SendEmail("knguyen53@my.devry.edu",
            "knguyen53@my.devry.edu", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText +
                " Your incorrect login information was sent to knguyen53@my.devry.edu";
            }



            return;
        }
        // Gets the users security level
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // Checks security level for user and sets the user level
        switch (SecurityLevel)
        {
            case "A":
                // If authentication is true, security level A
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // If authentication is false, security level A
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                e.Authenticated = true;
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}