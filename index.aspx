<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="CS322" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Large project Part #2 </title>

</head>
<body>
<form id="form1" runat="server">
    
<div class="container">
  <div class="header"><h1>Registered User</h1>
    
      <div id="nav">
          <! -->
          <%		
          Response.Write("Today's Date: ") ;  
          Response.Write(DateTime.Now.ToString());
        %>
     </div>  
  </div>
  
  <div class="content">
      
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
        <br>
      <asp:Button id="btnSubmit1" onclick="btnSubmit_old_user" runat="server" Text="Sign In"></asp:Button>
      
       </asp:Panel>    
         
          
       <asp:Panel ID="old_user" runat="server" Wrap="true" Visible="false">   
       <h4> User Name</h4>
        <asp:TextBox ID="adm_username" runat="server" required="required"  />
          
      <h4> Password</h4>
        <asp:TextBox ID="adm_password" runat="server" required="required"  />
         <asp:Button id="btnSubmit3" onclick="btnSubmit_check_user" runat="server" Text="enter">
              </asp:Button>
      </asp:Panel>
         
       
      
      <asp:Panel ID="panel_tryagain" runat="server" Wrap="true" Visible="false">    
        <h1> Sorry. Your user name or password did not match !!</h1>
           <asp:Button id="btnSubmit4" onclick="btnSubmit_return" runat="server" Text="Press to try again">
              </asp:Button>
    
        </asp:Panel> 
      
  <asp:Panel ID="panel_good" runat="server" Wrap="true" Visible="false">    
        <h1> Success !! Username and password matched. </h1> 
        <p> Now time to "CLICK" on your Menu below.</p>
        
        <h2> <a href="menu.html">Menu </a> </h2>
          
        </asp:Panel> 
       <asp:Panel ID="panel_db" runat="server" Wrap="true" Visible="false">    
        <asp:label id="lblInfo" runat="server"></asp:label>
        </asp:Panel>   
        
        <asp:Panel ID ="panel5" runat="server" Wrap="true" Visible ="false">
          <h2> <a href="add.aspx"> Click here to Register!!! </a> </h2>
      </asp:Panel>
   
          
      
    </div>
    <!-- end .content --></div>

  <!-- end .container --></div>

    
</form>
</body>
</html>
