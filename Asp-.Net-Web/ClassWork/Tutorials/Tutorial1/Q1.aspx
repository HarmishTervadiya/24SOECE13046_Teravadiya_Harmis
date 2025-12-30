<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Q1.aspx.cs" Inherits="ClassWork.Tutorials.Tutorial1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
     <asp:Label ID="LabelPrompt" runat="server" Text="Enter name"></asp:Label>
     <br />
     <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
     <br />
     <asp:Button ID="ButtonGreet" runat="server" Text="Greet" OnClick="ButtonGreet_Click" />
     <br />
     <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
 </div>
</asp:Content>
