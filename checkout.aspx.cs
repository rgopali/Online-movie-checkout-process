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
        panel3.Visible = true;
        panel1.Visible = false;
        //panel4.Visible = true;
        
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
            
            //command = new SqlCommand("SELECT * FROM checkout", connection);
            command = new SqlCommand("SELECT * FROM content WHERE movie_checkout ='y'", connection);
           reader = command.ExecuteReader();
            data.DataSource = reader;
            data.DataBind();
           
            reader.Close();
            
           // reader = command.ExecuteReader();
           // lb2Names.DataSource = reader;
           // lb2Names.DataTextField = "last_name";
           // lb2Names.DataValueField = "adm_id";
           // lb2Names.DataBind();
           // reader.Close();
   
        
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
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += connection.State.ToString();
        }
    } // end of button click one
    public void Get_one(Object Src, EventArgs E)
    {  
        //panel2.Visible = true;
        panel3.Visible = true;
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
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM checkout", connection);

           //reader = command.ExecuteReader();
            //data.DataSource = reader;
            //data.DataBind();
           
            //reader.Close();
            
            reader = command.ExecuteReader();
            allstudents.DataSource = reader;
            allstudents.DataTextField = "movie_title";
            allstudents.DataValueField = "checkout_id";
            allstudents.DataBind();
            reader.Close();
   
        
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
         //   lblInfo.Text = "Error reading the database. ";
          //  lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += connection.State.ToString();
        }
    } // end of get one 
    
    public void Get_data(Object Src, EventArgs E)

    {  
       panel2.Visible = true;
        panel3.Visible = false;
        panel4.Visible = false;
        panel1.Visible = false;
        
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
            
            command = new SqlCommand("SELECT * FROM content WHERE movie_checkout='Y'", connection);
           // command.Parameters.AddWithValue("@id", allstudents.SelectedValue);

            reader = command.ExecuteReader();
            one_data.DataSource = reader;
            one_data.DataBind();
            reader.Close();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
           // lblInfo.Text = "Error reading the database. ";
          //lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += connection.State.ToString();
        }
    } // end of get one data

    
        
    
        
        
        
 
}