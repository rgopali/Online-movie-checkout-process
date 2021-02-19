<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="CS322" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Final Large project #2</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="main.css">
   
</head>
<body>

     <div class="content">
        <form id="form1" runat="server">
            <asp:Panel ID="home" runat="server" Wrap="true" Visible="true">
                <h1> Rinku's Community</h1>
                <h2> We are in this together!</h2>
                <p> All the neighbours have put down the collection of all DVD video library they have.</p>
                <p> Feel free to have and look and check them out.</p>
                <asp:Button id="mlist" onclick="order" runat="server" Text="List of DVD video library"></asp:Button>  
                <br> <br><br>
        <a id="admin" href="index.aspx"> <STYLE>A {text-decoration: none;} </STYLE><b>|||CLICK HERE FOR ADMIN SITE|||</b></a>
            </asp:Panel>
      
            <asp:Panel ID="stores_select" runat="server" Wrap="true" Visible="false">
                <h2>List of movie collection.</h2>
                    <asp:ListBox id="lb3Names"    
                                AutoPostBack="true" 
                                OnSelectedIndexChanged="place_order"
                                runat="server"/>
                    </asp:ListBox>
            </asp:Panel> 
            </asp:Panel>

            
           
            <asp:Panel ID="showlist" runat="server" Wrap="true" Visible="false">
                    <h2>Pick the video library that you would like to check out.</h2>
                    <asp:ListBox id="lb4Names"    
                                AutoPostBack="true" 
                                OnSelectedIndexChanged="get_order_items"
                                runat="server"/>
                    </asp:ListBox>
            </asp:Panel>
            <asp:Panel ID="items_ordered" runat="server" Wrap="true" Visible="false">
                <asp:label id="st_name_order" runat="server"></asp:label>
                </br><h2>Pick these items up</h2>
                <asp:label id="pick_items"  runat="server" /></asp:label>
                </br>
                <asp:Button id="nlist" onclick="get_order" runat="server" Text="get new store"></asp:Button>
               
            </asp:Panel>



                <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">  
                    <a id="link" href="home.aspx">Home</a> 
                    
                  

                <asp:label id="lblInfo" runat="server" ForeColor="Maroon"></asp:label>
            </asp:Panel>  
            
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">   
            <asp:TextBox id="movie_des" runat="server" style="width:80%"/>
            <asp:Image ID="Image1" runat="server"  /> <br />
            
            
       </asp:Panel> 
       <asp:Panel ID="makelist" runat="server" Wrap="true" Visible="false">
        <asp:label id="st_name" runat="server"></asp:label>
        </br>
        <asp:Button id="slist" onclick="save_items" runat="server" Text="Check out movie"></asp:Button> 
    </asp:Panel>
    
    
    
    </div>      
</form>
</body>
</html>
