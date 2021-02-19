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
            
            command = new SqlCommand("SELECT * FROM content", connection);
        
            reader = command.ExecuteReader();
            allstudents.DataSource = reader;
            allstudents.DataTextField = "movie_title";
            allstudents.DataValueField = "movie_id";
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
            
                command = new SqlCommand("SELECT * FROM content WHERE movie_id=@id", connection);
            command.Parameters.AddWithValue("@id", allstudents.SelectedValue);
          

            reader = command.ExecuteReader();
            
            while (reader.Read())
    {

          movie_title.Text = (string) reader["movie_title"];
          movie_des.Text = (string) reader["movie_des"];
          movie_checkout.Text = (string) reader["movie_checkout"];
          movie_cover_name.Text = (string) reader["movie_cover_name"];

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
        Response.Write("<p>" + "Movie Title: " +  movie_title.Text);
          Response.Write("<p>" + "Movie Description: " +  movie_des.Text); 
           Response.Write("<p>" + "Movie check-out: " + movie_checkout.Text); 
           Response.Write("<p>" + "Movie CoverName: " + movie_cover_name.Text); 



      command = new SqlCommand("delete from content WHERE movie_id=@id", connection);
      
          command.Parameters.AddWithValue("@id", allstudents.SelectedValue); 
          command.Parameters.AddWithValue("@title", movie_title.Text);
          command.Parameters.AddWithValue("@des", movie_des.Text);
          command.Parameters.AddWithValue("@checkout", movie_checkout.Text);
          command.Parameters.AddWithValue("@cover", movie_cover_name.Text);
        
        
   
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
        
    
        
        
        
 