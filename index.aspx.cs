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
    protected void get_connection()
    {
       string connectionString =
     " Data Source = teach-web01.park.edu\\MSSQLSER2;" +
    " Initial Catalog = CS322;" +
    " Integrated Security = False;" +
    " User Id = allstudents;" +
    " Password = M@zep817;" +
    "MultipleActiveResultSets = True";
    

        connection = new SqlConnection(connectionString);
        
    } // end
    protected void btnSubmit_old_user(object sender, EventArgs e)
    {
        panel1.Visible = false;
        old_user.Visible = true;  
        
    }
     protected void btnSubmit_return(object sender, EventArgs e)
    {
        panel1.Visible = false;
        old_user.Visible = true; 
       panel_tryagain.Visible = false;  


    }

   
    protected void btnSubmit_check_user(object sender, EventArgs e)
    {
    
        get_connection();
        try
        {
            // Try to open the connection.
            //panel_db.Visible = true;
            connection.Open();
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            command = new SqlCommand("SELECT * FROM adm_tbl WHERE adm_username = @username and adm_password = @password", connection);
           
         
          command.Parameters.AddWithValue("@username", adm_username.Text);
          command.Parameters.AddWithValue("@password", adm_password.Text);
           
            
            reader = command.ExecuteReader();
           
          		 if (reader.HasRows)
          		  {
            		    old_user.Visible = false;  
                 	  panel_good.Visible = true;
                                
           		 }
            
          		  else {
               
            		  panel_tryagain.Visible = true;  
            		  old_user.Visible = false; 
                       panel5.Visible=true;
                
           		 }
  
                reader.Close();
   
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
            panel_db.Visible = true;
        }
        finally
        {
            panel_db.Visible = false;
            
            lblInfo.Text = "good connect. ";
            connection.Close();
        }
        
           
    }
  
}