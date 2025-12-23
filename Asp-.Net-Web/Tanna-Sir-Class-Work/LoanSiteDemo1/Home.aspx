<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HDFC Loans - Next Step to Dreams</h1>
           <br />
           <hr />
            <div style="">
           <asp:Label ID="label1" Text="Logged In User" runat="server" />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
                </div>
            <br />
            <hr />

            <br />
            <br />

            <asp:Label runat="server" Text="Welcome to the place to fulfill your dreams for the family and social needs" Font-Bold="True" Font-Size="Large" />
            <br />
            <br />
            <hr />
        
            <h2>Contact Us</h2>
            <br />
            <p>HDFC Loan Service</p>
            <p>Mumbai, Maharashtra, India</p>
            <p>&nbsp;</p>

            <br />
            <hr />
            

        </div>
    </form>
</body>
</html>
