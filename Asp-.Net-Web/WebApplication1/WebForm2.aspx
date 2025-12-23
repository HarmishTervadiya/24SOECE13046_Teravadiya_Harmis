<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 77px;
            width: 401px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 443px; border-color: brown; border-width: 5px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Registration Form<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="409px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mobile No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Email Id"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="188px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="188px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Father Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Mother Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Width="188px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="188px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Select Course"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="199px">
                <asp:ListItem>B.Tech</asp:ListItem>
                <asp:ListItem>B.Sc</asp:ListItem>
                <asp:ListItem>BCA</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Branch<br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" Text="CE" runat="server" />
&nbsp;<asp:CheckBox ID="CheckBox2" Text="ME" runat="server" />
&nbsp;<asp:CheckBox ID="CheckBox3" Text="CV" runat="server" />
            <br />
            <br />
            Address<br />
            <textarea id="TextArea1" cols="20" name="S1" rows="1"></textarea><br />
            <br />
            <br />
&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#CC3300" Text="Submit" Width="388px" />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
