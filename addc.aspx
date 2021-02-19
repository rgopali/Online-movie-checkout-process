<%@ Page Language="C#" AutoEventWireup ="true" CodeFile="addc.aspx.cs" Inherits="CS322" EnableSessionState=true%>

<!DOCTYPE html>
    <head runat="server">
         <style>
            body{
                background-color:rgba(250, 164, 164, 0.212);
            }
            h2{
                color:rgb(83, 32, 32);
                font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
            }
            h1{
                color: red;
                font-family: Georgia, 'Times New Roman', Times, serif;
                font-size: 40px;
                font-weight: bold;
            }

        </style>
    </head>
    <title>Final project - Add </title>
    <body>
        <form id="form1" runat="server">
            <div>   
              <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
            
                <h1> Welcome  :) Enter your information: </h1>

                <h2>Movie Title</h2> <asp:TextBox ID = "movie_title" runat="server" required></asp:TextBox>
                <h2> Movie Description </h2> <asp:TextBox ID = "movie_des" runat="server" ></asp:TextBox>
                <h2> Movie check-out [Y/N] </h2> <asp:TextBox ID = "movie_checkout" runat="server" MaxLength="1" required ></asp:TextBox>
               
                <h2>If photo is available click button to upload photo, then record will be added</h2>
                <asp:Button id="uploadphoto" onclick="upload_photo" runat="server" Text="upload photo"></asp:Button>
                <h2>If photo is NOT available click button to  added record without photo, may be uploaded later</h2>
                 <asp:Button id="btnSubmit" onclick="add_record" runat="server" Text="Add more records "></asp:Button>   
           </asp:Panel> 
           <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    
    
        </asp:Panel>
         <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
          
           </asp:Panel> 
               <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false"> 
           <asp:label id="lblInfo" runat="server"></asp:label>
                </asp:Panel>

                <asp:Panel ID ="panel5" runat="server" Wrap="true" Visible ="false">
                    <h2> <a href="menu.html"> Back to Rinku's awesome Database menu </a> </h2>
                </asp:Panel>
                <asp:Panel ID="panel8" runat="server" Wrap="true" Visible="false">  
                    <asp:FileUpload id="FileUploadControl" runat="server" />            
                  <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
                  <br /><br />
                  <asp:Label runat="server" id="StatusLabel"   />
              </asp:Panel> 
             
             
            </div>
        </form>
    </body>
</html>
    

