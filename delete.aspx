<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="CS322" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete: Large project part #3 </title>
    <style>
      body{
        background-color: rgba(137, 85, 221, 0.486);
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
    <h3>Click "Delete" to remove your record for the database!</h3>
    <asp:Button id="update" onclick="btnSubmit_Click_one" runat="server" Text="Delete"></asp:Button>
   

   </asp:Panel>

    
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
      <h2>Select a record to delete from CS322 Database!!</h2>
         <asp:ListBox id="allstudents"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      
                      runat="server"/>
           </asp:ListBox>
       </asp:Panel>  
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">
         <h2>The selected record will be deleted!!</h2>
           <asp:label id="update_id" runat="server"></asp:label> 
            <h3>User Name</h3>
            <asp:TextBox id="adm_username" runat="server"/>
            <h3>Password </h3>
            <asp:TextBox id="adm_password" runat="server"/>
            <h3>First Name</h3>    
            <asp:TextBox id="adm_fname" runat="server"/>
            <h3>Last Name</h3>
            <asp:TextBox id="adm_lname" runat="server"/>
         
          <asp:Button id="update_rec" onclick="btnSubmit_delete_record" runat="server" Text="Submit"></asp:Button>  
       </asp:Panel> 
        
    <asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false"> 
            <h2> <a href="delete.aspx">Click here delete another record :'( </a></h2>
        </asp:Panel>    
        
        <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
          <asp:label id="lblInfo" runat="server" ></asp:label>
               </asp:Panel>

        
        
    </div>
    </form>
</body>
</html>
