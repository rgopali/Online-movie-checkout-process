<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="CS322" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> C/O Data</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
        <h3>make a choice</h3>
    <asp:Button id="grid" onclick="btnSubmit_Click_one" runat="server" Text="Get all the records"></asp:Button>
    <asp:Button id="one" onclick="Get_one" runat="server" Text="get one record"></asp:Button>
       
          
   </asp:Panel>
        
    <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    <asp:GridView id="data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    
    <Columns>
     
      <asp:BoundField DataField="movie_title"
        HeaderText="Movie Title"/>
      

  
    </Columns>
  </asp:GridView>
  
    </asp:Panel>
        
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
         <asp:ListBox id="allstudents"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      runat="server"/>
           </asp:ListBox>
       </asp:Panel> 
        
        
       <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
       <h2>connection information remove at production time</h2>
       <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
        
        
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">   
         <h2>in panel 5</h2>
            <asp:GridView id="one_data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
   
      <asp:BoundField DataField="movie_title"
        HeaderText="Movie Title"/>
      
    </Columns>
  </asp:GridView>
            
            
            
       </asp:Panel> 
<asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false">
      
         <h2>pick a user/h2>
            <asp:GridView id="photo_data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
     
  
      <asp:BoundField DataField="movie_title"
        HeaderText="Movie Title"/>
    
    </Columns>
  </asp:GridView>
                  
            
       </asp:Panel> 
            
    </div>
    </form>
</body>
</html>
