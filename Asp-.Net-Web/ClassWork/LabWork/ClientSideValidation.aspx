<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientSideValidation.aspx.cs" Inherits="ClassWork.LabWork.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="1) ViewState Example"></asp:Label>
<br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="ButtonViewState" runat="server" OnClick="ButtonViewState_Click" Text="Save in viewstate" />
&nbsp;
<asp:Label ID="LabelViewState" runat="server" Text="LabelViewState"></asp:Label>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="2) HiddenField Example"></asp:Label>
&nbsp;<asp:HiddenField ID="HiddenField2" runat="server" OnValueChanged="HiddenField2_ValueChanged" />
    <br />
<asp:Button ID="ButtonHidden" runat="server" OnClick="ButtonHidden_Click" Text="Save Hidden Value" />
&nbsp;&nbsp;
<asp:Label ID="LabelHidden" runat="server" Text="LabelHidden"></asp:Label>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="3) Cookies Example"></asp:Label>
<br />
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
<asp:Button ID="ButtonCreateCookie" runat="server" Text="CreateCookie" OnClick="ButtonCreateCookie_Click" />
<asp:Button ID="ButtonReadCookie" runat="server" Text="Read Cookie" OnClick="ButtonReadCookie_Click" />
&nbsp;&nbsp;
<asp:Label ID="LabelCookie" runat="server" Text="LabelCookie"></asp:Label>
<br />
<br />
<asp:Label ID="Label7" runat="server" Text="4) Query String Example"></asp:Label>
<br />
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:Button ID="Buttonquery" runat="server" Text="Send via Query String" OnClick="Buttonquery_Click" />
&nbsp;
<asp:Label ID="LabelQuery" runat="server" Text="LabelQuery"></asp:Label>
<br />
<br />
<br />
<br />

</asp:Content>
