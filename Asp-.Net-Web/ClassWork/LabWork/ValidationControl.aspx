<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidationControl.aspx.cs" Inherits="ClassWork.LabWork.ValidationControl" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >


    <p>
        Validator Control</p>
    <p>
        1) Required field validator</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NameText" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameText" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>


</asp:Content>