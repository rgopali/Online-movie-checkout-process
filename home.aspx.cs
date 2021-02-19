using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class CS322: System.Web.UI.Page
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
    
    protected void order(Object Src, EventArgs E)
    {
        home.Visible = true;
        stores_select.Visible = true;
        showlist.Visible = false;
        panel2.Visible = true;
        get_connection();
        try
        {
            // Try to open the connection.
           // panel_db.Visible = true;
            connection.Open();
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
             command = new SqlCommand("SELECT * FROM content", connection);

           reader = command.ExecuteReader();
            lb3Names.DataSource = reader;
            lb3Names.DataTextField = "movie_title";
            lb3Names.DataValueField = "movie_id";
            lb3Names.DataBind();
            reader.Close();
           
        }
         
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
           // panel_db.Visible = true;
        }
        finally
        {
           // panel_db.Visible = true;
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            //lblInfo.Text = "good connect. ";
            connection.Close();
        } 
    }  // end of order 
    protected void get_order(Object Src, EventArgs E)
    {
        home.Visible = false;
        stores_select.Visible = false;
        items_ordered.Visible = false;
        showlist.Visible = true;
        panel2.Visible = true;
     

        get_connection();
        try
        {
            // Try to open the connection.
           // panel_db.Visible = true;
            connection.Open();
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
             command = new SqlCommand("SELECT * FROM content", connection);

           reader = command.ExecuteReader();
            lb4Names.DataSource = reader;
            lb4Names.DataTextField = "movie_des";
            lb4Names.DataValueField = "movie_id";
            lb4Names.DataBind();
            reader.Close();
           
        }
         
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
           // panel_db.Visible = true;
        }
        finally
        {
           // panel_db.Visible = true;
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
           // lblInfo.Text = "good connect. ";
            connection.Close();
        } 
    }  // end of get_order items
        public void place_order(Object Src, EventArgs E)
    {  
        home.Visible = false;
        stores_select.Visible = false;
        
        showlist.Visible = false;
        panel2.Visible = true;
                     
      
        panel5.Visible = true;
        makelist.Visible = true;
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
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
           
            command = new SqlCommand("SELECT * FROM content WHERE movie_id=@id", connection);
           //  Response.Write("the id value is in place order"+ lb3Names.SelectedValue); 
            command.Parameters.AddWithValue("@id", lb3Names.SelectedValue);

            reader = command.ExecuteReader();
              while (reader.Read())
             {   
                movie_des.Text = (string) reader["movie_des"];
                Image1.ImageUrl =  (string) reader["movie_cover_name"];
             }   
            reader.Close();
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
            //lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
           // lblInfo.Text += connection.State.ToString();
        }
        
    }
    public void save_items(Object Src, EventArgs E)
    {  
         
        home.Visible = false;
        stores_select.Visible = false;
        makelist.Visible = false;
        panel2.Visible = true;
        panel5.Visible=false;
        
          get_connection();
        try
        {
            // Try to open the connection.
           // panel_db.Visible = true;
            connection.Open();
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            //Response.Write("the id value is in save_items"+ lb3Names.SelectedValue); 
             
                  command = new SqlCommand("UPDATE content SET movie_checkout = @check WHERE movie_id=@id", connection);      
          command.Parameters.AddWithValue("@id", lb3Names.SelectedValue);                 
            command.Parameters.AddWithValue("@check", "y");
         
            command.ExecuteNonQuery();

            command = new SqlCommand("INSERT INTO checkout (movie_id)" +
                " VALUES (@checkout)", connection);
    
    
            //command.Parameters.AddWithValue("@id", lb3Names.SelectedValue);
            command.Parameters.AddWithValue("@checkout", lb3Names.SelectedValue);
            
                
                command.ExecuteNonQuery();
                 
            connection.Close();
           
        }

        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
           // panel_db.Visible = true;
        }
        finally
        {
           // panel_db.Visible = true;
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            lblInfo.Text = "DVD checkout successful.";
            connection.Close();
        }       
             
    } //end of save items
    public void get_order_items(Object Src, EventArgs E)
    {  
        home.Visible = false;
        stores_select.Visible = false;
        showlist.Visible = false;
        makelist.Visible = false;
        items_ordered.Visible = true;
        panel2.Visible = true;
          get_connection();
        try
        {
            // Try to open the connection.
           // panel_db.Visible = true;
            connection.Open();
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            //lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            st_name_order.Text =  lb4Names.SelectedItem.Text;
            command = new SqlCommand("SELECT * FROM content WHERE movie_id=@id", connection);

           // command = new SqlCommand("SELECT * FROM orders", connection);

            command.Parameters.AddWithValue("@id", lb4Names.SelectedValue);
            reader = command.ExecuteReader();
            while (reader.Read())
                {
                    pick_items.Text = (string) reader["movie_des"];
                }     
           
            connection.Close();
           
        }
         
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
           // panel_db.Visible = true;
        }
        finally
        {
           // panel_db.Visible = true;
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            //lblInfo.Text = "got order ";
            connection.Close();
        }            
    } //end of get ordere items
    
    


}
    