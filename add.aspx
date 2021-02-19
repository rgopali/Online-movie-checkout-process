<%@ Page Language="C#" AutoEventWireup ="true" CodeFile="add.aspx.cs" Inherits="CS322" EnableSessionState=true%>

<!DOCTYPE html>
    <head runat="server">

        <style>
            body{
                background-color:rgba(128, 128, 128, 0.212);
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
    <title>Milestone Part #1 </title>
    <body>
        <form id="form1" runat="server">
            <div>   
              <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
                <h1> Welcome  :) Enter your information: </h1>

                <h2>Username</h2> <asp:TextBox ID = "adm_username" runat="server" type="email" required></asp:TextBox>
                <h2> Password  (Must be 6 characters long) </h2> <asp:TextBox ID = "adm_password" runat="server" pattern="(.{6,}$)" required></asp:TextBox>
                <h2> First Name</h2> <asp:TextBox ID = "adm_fname" runat="server" required ></asp:TextBox>
                <h2> Last Name </h2> <asp:TextBox ID = "adm_lname" runat="server" required></asp:TextBox>

            <asp:Button id="btnSubmit" onclick="add_record" runat="server" Text="Add more records "></asp:Button>
           
           </asp:Panel> 
               <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false"> 
           <asp:label id="lblInfo" runat="server"></asp:label>
                </asp:Panel>

                <asp:Panel ID ="panel5" runat="server" Wrap="true" Visible ="false">
                    <h2> <a href="add.aspx"> Click to add another Data </a> </h2>
                </asp:Panel>
             
            </div>
        </form>
    </body>
</html>
    

