using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page{


    protected void Page_Load(object sender, EventArgs e)
    {
        // If user has administrator level
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
            //WIll disable, unable to click, and make invisible.  No submit button
        }
        else
        {
            btnSubmit.Visible = false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool allCorrect = true;
        lblError.Text = "";
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;



        if (Request["txtFirstName"].ToString().Trim() == "")
        {
            allCorrect = false;
            lblError.Text = "First Name is required ";
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
        }

        if (Request["txtLastName"].ToString().Trim() == "")
        {
            allCorrect = false;
            lblError.Text = lblError.Text + "Last Name is required ";
            txtLastName.BackColor = System.Drawing.Color.Yellow;
        }

        if (Request["txtPayRate"].ToString().Trim() == "")
        {
            allCorrect = false;
            lblError.Text = lblError.Text + "Pay Rate is required ";
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
        }
        if (Request["txtStartDate"].ToString().Trim() == "")
        {
            allCorrect = false;
            lblError.Text = lblError.Text + "Start Date is required ";
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
        }
        if (Request["txtEndDate"].ToString().Trim() == "")
        {
            allCorrect = false;
            lblError.Text = lblError.Text + "End Date is required ";
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
        }

        if (allCorrect)
        {
            DateTime myStartDate = DateTime.Parse(txtStartDate.Text);
            DateTime myEndDate = DateTime.Parse(txtEndDate.Text);
            if (DateTime.Compare(myStartDate, myEndDate) > 0)
            {
                allCorrect = false;
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + " Start Date must be earlier than End Date ";

            }
         }

        if (allCorrect)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            Response.Redirect("frmPersonnelVerified.aspx");
        }


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}