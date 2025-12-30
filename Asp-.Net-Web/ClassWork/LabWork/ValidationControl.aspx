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
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameText" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        2) Range Validator
    </p>
    <p>
                <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" ErrorMessage="Age must be between 18 and 40" ForeColor="Red" MaximumValue="40" MinimumValue="18"></asp:RangeValidator>
    <p>
                3) Expression Validator<p>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Email is Invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <p>
                Required validator<p>
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
                4) Compare validator<p>
                <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

        &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Password does not match" ForeColor="Red" ValueToCompare="TextBox3"></asp:CompareValidator>
    </p>
    <p>
                5) Custom Validator</p>
    <p>
                Number:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

        &nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Number must be even" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" />
    <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="SubmitBtn" runat="server" OnClick="Button1_Click" Text="Submit" />
    </p>


</asp:Content>