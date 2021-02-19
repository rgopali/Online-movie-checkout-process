<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatec.aspx.cs" Inherits="CS322" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update</title>
    <style>
      body{
        background-color: rgb(135, 214, 192);
      }
        h3{
        font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }
        h2{
          font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }
  
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
    <h3>Click "Update" to make changes in content table!!</h3>
    <asp:Button id="update" onclick="btnSubmit_Click_one" runat="server" Text="Update"></asp:Button>
   

   </asp:Panel>
    
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
      <h2>Please choose a record to update: </h2>
         <asp:ListBox id="allstudents"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      
                      runat="server"/>
           </asp:ListBox>
       </asp:Panel>  
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">
         <h2>Update the record you selected: </h2>
           <asp:label id="update_id" runat="server"></asp:label> 
            <h3>Movie Title</h3>
            <asp:TextBox id="movie_title" runat="server"/>
            <h3>Movie Description</h3>
            <asp:TextBox id="movie_des" runat="server"/>
            <h3>Movie Checkout</h3>
            <asp:TextBox id="movie_checkout"  MaxLength="1"  runat="server"/>
            <h3>Movie Covername</h3>
            <asp:TextBox id="movie_cover_name" runat="server"/>
          <asp:Button id="update_rec" onclick="btnSubmit_update_record" runat="server" Text="Submit"></asp:Button>  
       </asp:Panel> 
        
    <asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false"> 
            <h2> <a href="updatec.aspx"> Click to change another record!</a></h2>
        </asp:Panel>    
        
        <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
          <asp:label id="lblInfo" runat="server"></asp:label>
               </asp:Panel>

              
        
    </div>
    </form>
</body>
</html>
