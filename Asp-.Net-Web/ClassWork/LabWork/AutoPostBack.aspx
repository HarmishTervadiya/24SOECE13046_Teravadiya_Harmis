<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AutoPostBack.aspx.cs" Inherits="ClassWork.LabWork.WebForm3" %>

<asp:Content ContentPlaceHolderID="MainContent" runAt="server">     
    <div>

            <asp:Label ID="Label1" runat="server" Text="TextBox Output"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"
                AutoPostBack="True"
                OnTextChanged="TextBox1_TextChanged">
            </asp:TextBox>

            <br /><br />

            <asp:Label ID="LabelRadio" runat="server" Text="Radio Output"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>

            <br />

            <asp:Label ID="LabelDropDown" runat="server" Text="Dropdown Output"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="--Select City--" Value=""></asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
            </asp:DropDownList>

        </div>
</asp:Content>