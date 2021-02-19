using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class CS322 : System.Web.UI.Page
{
    SqlConnection connection;
    SqlCommand command;
    SqlDataReader reader;

     protected void Page_Load(object sender, EventArgs e)
    {
   
    }

    public void add_record(Object sender, EventArgs e)
    {
        Response.Write(" You have connected to your .cs page add records");
        panel2.Visible = true;

        string connectionString =
    " Data Source = teach-web01.park.edu\\MSSQLSER2;" +
    " Initial Catalog = CS322;" +
    " Integrated Security = False;" +
    " User Id = allstudents;" +
    " Password = M@zep817;" +
    "MultipleActiveResultSets = True";
    
    connection = new SqlConnection(connectionString);
    try
        {
            // Try to open the connection.
            connection.Open();
            // lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            // this is were the code goes if connection is good

             command = new SqlCommand("INSERT INTO adm_tbl (adm_username, adm_password, adm_fname, adm_lname)" +
                  " VALUES ( @username, @password, @firstname, @lastname)", connection);
   
          
        
          command.Parameters.AddWithValue("@username", adm_username.Text);
          command.Parameters.AddWithValue("@password", adm_password.Text);
          command.Parameters.AddWithValue("@firstname", adm_fname.Text);
          command.Parameters.AddWithValue("@lastname", adm_lname.Text);
        
                command.ExecuteNonQuery();
                
            
            connection.Close();

   
          
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            lblInfo.Text += "<br /><b>Record has been added.</b> ";
           // lblInfo.Text += connection.State.ToString();
           panel5.Visible=true;
           panel1.Visible= false;
        }
        
    }
}
    

   
