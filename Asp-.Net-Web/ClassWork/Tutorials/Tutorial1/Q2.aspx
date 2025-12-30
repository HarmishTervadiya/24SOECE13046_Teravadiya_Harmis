<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Q2.aspx.cs" Inherits="ClassWork.Tutorials.Tutorial1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="LabelTemp" runat="server" Text="Temperature"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxTemp" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownConversion" runat="server">
            <asp:ListItem Value="CtoF">C to F</asp:ListItem>
            <asp:ListItem Value="FtoC">F to C</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="ButtonConvert" runat="server" Text="Convert" OnClick="ButtonConvert_Click" />
        <br />
        <asp:Label ID="LabelConverted" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>