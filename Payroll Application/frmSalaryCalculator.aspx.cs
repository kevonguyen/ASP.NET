using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        //Declare variables to be used to extract data and perform calculations.
        double AnnualHours = 0.0;   //Will hold the numeric value of annual hours from text box
        double PayRate = 0.0;   //Will hold the numeric value of pay rate from text box
        double Salary = 0.0;    //Will hold the numeric value for the calculated salary

        //Extract values from the text boxes
        AnnualHours = double.Parse(txtAnnualHours.Text);
        PayRate = double.Parse(txtPayRate.Text);

        //Perform calculations using the numeric variables, which now hold values from text boxes.
        Salary = AnnualHours * PayRate;

        //Display results by assigning values to labels on the form.
        lblAnnualSalary.Text = "Annual salary is: " + Salary.ToString("C");	//C - Formats for currency.
    }
}