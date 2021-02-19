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
    public static string p_filename;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public void add_record(Object sender, EventArgs e)
    {
        Response.Write(" You have connected to your .cs page add records  1");
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

            command = new SqlCommand("INSERT INTO content(movie_title, movie_des, movie_checkout, movie_cover_name)" +
                " VALUES ( @title, @des, @checkout, @cover)", connection);
    
            command.Parameters.AddWithValue("@title", movie_title.Text);
            command.Parameters.AddWithValue("@des", movie_des.Text);
            command.Parameters.AddWithValue("@checkout", movie_checkout.Text);
            command.Parameters.AddWithValue("@cover", "n/a");
                
                command.ExecuteNonQuery();
                connection.Close();   
        }
        catch (Exception err)
                {
                    // Handle an error by displaying the information.
                    lblInfo.Text = "Error reading the database. in add 1 ";
                    lblInfo.Text += err.Message;
                }
                finally
                {
                    // Either way, make sure the connection is properly closed.
                    // (Even if the connection wasn't opened successfully,
                    //  calling Close() won't cause an error.)
                    connection.Close();
                    lblInfo.Text += "<br /><b>Record has been added  in add.</b> ";
                // lblInfo.Text += connection.State.ToString();
                panel5.Visible=true;
                panel1.Visible= false;
                }
                
    } // end of add record

        
   
    public void upload_photo(Object Src, EventArgs E)
        {  
        panel2.Visible = false;
        panel1.Visible = false;
        panel8.Visible = true; 
    }  

        protected void UploadButton_Click(object sender, EventArgs e)
    {
        if(FileUploadControl.HasFile)
        {
            try
            {
                if(FileUploadControl.PostedFile.ContentType == "image/jpeg")
                {
                    if(FileUploadControl.PostedFile.ContentLength < 1024000)
                    {
                        string filename = System.IO.Path.GetFileName(FileUploadControl.FileName);
                        FileUploadControl.SaveAs(Server.MapPath("./covers/") + filename);
                        string mapname = (Server.MapPath("./covers/") + filename);
                    
                    p_filename = "covers/"+filename; 
                   // Response.Write(p_filename); 
                    StatusLabel.Text = mapname;
                    
        
                        //StatusLabel.Text = "Upload status: File uploaded!";
                        insert_record_Photo();
                    }
                    else
                        StatusLabel.Text = "Upload status: The file has to be less than 1000 kb!";
                }
                else
                    StatusLabel.Text = "Upload status: Only JPEG files are accepted!";
            }
            catch(Exception ex)
            {
                StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }
    } //end of upload photo to folder on server

    protected void insert_record_Photo()
    {
        //Response.Write("you have connected to your .cs page add records");   
        panel2.Visible = true;
        panel5.Visible = true;
        // panel_choice.Visible = false;
        // panel7.Visible = false;
        //panel8.Visible = false;
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
            // lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();

                command = new SqlCommand("INSERT INTO content (movie_title, movie_des, movie_checkout, movie_cover_name)" +
                    " VALUES ( @title, @des, @checkout, @cover)", connection);
    
            
    
            
            command.Parameters.AddWithValue("@title", movie_title.Text);
            command.Parameters.AddWithValue("@des", movie_des.Text);
            command.Parameters.AddWithValue("@checkout", movie_checkout.Text);
            command.Parameters.AddWithValue("@cover", p_filename);
           
            //command.Parameters.AddWithValue("@imgloc", p_filename);
            command.ExecuteNonQuery();    
                connection.Close();
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
                lblInfo.Text = "Error reading the database. ";
                lblInfo.Text += err.Message;
                //Response.Write("you have error add records");  
            }
            finally
            {
                // Either way, make sure the connection is properly closed.
                // (Even if the connection wasn't opened successfully,
                //  calling Close() won't cause an error.)
                connection.Close();
                lblInfo.Text += "<br /><b>Record has been added</b> ";
                //lblInfo.Text += connection.State.ToString();
                //Response.Write("you have  add records");  
            }
        }
}


    

   
