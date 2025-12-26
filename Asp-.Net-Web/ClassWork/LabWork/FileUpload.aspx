<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="ClassWork.LabWork.WebForm2" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />

</asp:Content>
