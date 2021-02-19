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
      
    public void btnSubmit_Click_one(Object Src, EventArgs E)
    {
        
       panel2.Visible = true;
        panel1.Visible = false;
        panel4.Visible = true;
        
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
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM adm_tbl", connection);
        
            reader = command.ExecuteReader();
            allstudents.DataSource = reader;
            allstudents.DataTextField = "adm_lname";
            allstudents.DataValueField = "adm_id";
            allstudents.DataBind();
            reader.Close();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
           // lblInfo.Text = "Error reading the database. ";
           // lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            //lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            //lblInfo.Text += connection.State.ToString();
        }
    } // end of button click one
    
    public void Get_data(Object Src, EventArgs E)
    {  
       panel2.Visible = true;
       
        panel4.Visible = false;
        panel1.Visible = false;
        panel5.Visible = true;
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
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM adm_tbl WHERE adm_id=@id", connection);
            command.Parameters.AddWithValue("@id", allstudents.SelectedValue);

            reader = command.ExecuteReader();
            
            while (reader.Read())
    {
          adm_username.Text = (string) reader["adm_username"];
          adm_password.Text = (string) reader["adm_password"];
          adm_fname.Text = (string) reader["adm_fname"];
          adm_lname.Text = (string) reader["adm_lname"];
    }
            reader.Close();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
           // lblInfo.Text = "Error reading the database. ";
           // lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
           // lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
           // lblInfo.Text += connection.State.ToString();
        }
    } // end of get one data
    
public void btnSubmit_delete_record(Object Src, EventArgs E)
    {  
       panel2.Visible = true; 
        panel4.Visible = false;
        panel1.Visible = false;
        panel5.Visible = false;
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
           // llInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
           // lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
           
       Response.Write("<p>" + "You have DELETED the following record: " );
        Response.Write("<p>" + "User Name: " + adm_username.Text);
          Response.Write("<p>" + "Password: " + adm_password.Text); 
           Response.Write("<p>" + "First Name: " + adm_fname.Text); 
                      Response.Write("<p>" + "Last Name: " + adm_lname.Text); 

      command = new SqlCommand("delete from adm_tbl WHERE adm_id=@id", connection);
   
             
         command.Parameters.AddWithValue("@id", allstudents.SelectedValue);
         command.Parameters.AddWithValue("@username", adm_username.Text);
         command.Parameters.AddWithValue("@password", adm_password.Text); 
         command.Parameters.AddWithValue("@firstname", adm_fname.Text);
        command.Parameters.AddWithValue("@lastname", adm_lname.Text);
              

          
                command.ExecuteNonQuery();
            
        
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
            lblInfo.Text += "<br /><b>Delete was successfull</b> ";
            //lblInfo.Text += connection.State.ToString();
            panel5.Visible = false;
            panel6.Visible = true;
        }

    } // end of get one data
        
    
    
}   
        
    
        
        
        
 