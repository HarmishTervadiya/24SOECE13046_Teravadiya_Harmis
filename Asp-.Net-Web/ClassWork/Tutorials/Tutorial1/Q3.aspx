<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Q3.aspx.cs" Inherits="ClassWork.Tutorials.Tutorial1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="LabelA" runat="server" Text="Number 1"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxA" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelB" runat="server" Text="Number 2"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxB" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownOp" runat="server">
            <asp:ListItem Value="+">+</asp:ListItem>
            <asp:ListItem Value="-">-</asp:ListItem>
            <asp:ListItem Value="*">*</asp:ListItem>
            <asp:ListItem Value="/">/</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="ButtonCalc" runat="server" Text="Calculate" OnClick="ButtonCalc_Click" />
        <br />
        <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>