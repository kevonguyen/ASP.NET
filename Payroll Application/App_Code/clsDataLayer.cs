using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Include namespaces to enable database access.
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{

    public static bool SaveUser(string Database, string UserName, string Password,
string SecurityLevel)
    {
        try
        {
            // Opens connection to Database and creates a command
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserLogin (UserName, UserPassword, SecurityLevel) values ('" +
           UserName + "', '" + Password + "', '" + SecurityLevel + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public clsDataLayer()
    {
    }
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Retreives information
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Creates new connection
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Defines sqlDA and what it consist of
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
        // Defines DS and what it consist of
        DS = new dsUserActivity();
        // Outputs the result from information gathered
        sqlDA.Fill(DS.tblUserActivity);
        // Starts over for new user
        return DS;
    }
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Opens connection to Database and creates a command
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
        GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // Create a dataset object of dsUser dataset
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Create a connection to the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        // Open data adapter and set query
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);
        // Allocate dataset
        DS = new dsUser();
        // Fill dataset
        sqlDA.Fill(DS.tblUserLogin);
        // Return dataset
        return DS;
    }

    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {

        // Transaction for SQL
        OleDbTransaction myTransaction = null;

        bool recordSaved;
        try
        {
            // Opens connections to database and creates a command
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            // Setting value to myTransaction
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // Sets value
            strSQL = "Insert into tblPersonnel " +
            "(FirstName, LastName) values ('" +
            FirstName + "', '" + LastName + "')";
            // Receives input
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Executes query
            command.ExecuteNonQuery();
            // Updates tblPersonnel
            strSQL = "Update tblPersonnel " +
            "Set PayRate=" + PayRate + ", " +
            "StartDate='" + StartDate + "', " +
            "EndDate='" + EndDate + "' " +
            "Where ID=(Select Max(ID) From tblPersonnel)";
            // Receives input
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Executes query
            command.ExecuteNonQuery();

            // Commit changes to myTransaction
            myTransaction.Commit();

            // Closes connection
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {

            // Rollback changes
            myTransaction.Rollback();

            recordSaved = false;
        }
        return recordSaved;
    }



////////////////////////////////////////////////////////////////////////
    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        // Retreives information
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Creates new connection
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Defines sqlDA and what it consist of
        if (strSearch == null || strSearch.Trim() == "")
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        }
        // Defines DS and what it consist of
        DS = new dsPersonnel();
        // Outputs the result from information gathered
        sqlDA.Fill(DS.tblPersonnel);
        // Starts over for new user
        return DS;
    }
}