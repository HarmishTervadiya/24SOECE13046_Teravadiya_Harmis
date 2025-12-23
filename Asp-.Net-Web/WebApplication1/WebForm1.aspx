<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
<!--    <script src="https://cdn.jsdelivr.net/npm/@tailwindcss/browser@4"></script> -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="text-3xl font-bold underline">
      Hello world!
    </h1>
            <p class="text-3xl font-bold underline">
                &nbsp;</p>
            <p class="text-3xl font-bold underline">
                &nbsp;</p>
            <p class="text-3xl font-bold underline">
                <asp:Label ID="Label1" runat="server" Text="No1"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
            <p class="text-3xl font-bold underline">
                <asp:Label ID="Label2" runat="server" Text="No2"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
            <p class="text-3xl font-bold underline">
                <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
    </p>
            <p class="text-3xl font-bold underline">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button5_Click" Text="Sub" />
&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button3_Click" Text="Mul" />
&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button4_Click" Text="Div" />
&nbsp;&nbsp;
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
    </p>
        </div>
    </form>
</body>
</html>
