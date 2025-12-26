<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="ClassWork.LabWork.MultiView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        Multi VIew</p>
    <p>
        <br />
        <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:Label ID="Label1" Text="This is view 1" runat="server" />
                &nbsp;<br />
                <br />
                <asp:Button ID="Button1" Text="Next" runat="server" OnClick="Button1_Click" />
            </asp:View>
     
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label2" Text="This is view 2" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button2" Text="Prev" runat="server" OnClick="Button2_Click" />
                &nbsp;
                <asp:Button ID="Button3" Text="Next" runat="server" OnClick="Button3_Click" />
</asp:View>

            <asp:View ID="View3" runat="server">
                <asp:Label ID="Label3" Text="This is view 3" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button4" Text="Prev" runat="server" OnClick="Button4_Click" />
                &nbsp;<asp:Button ID="Button5" Text="Next" runat="server" OnClick="Button5_Click" />
</asp:View>

            <asp:View ID="View4" runat="server">
                <asp:Label ID="Label4" Text="This is view 4" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button6" Text="Prev" runat="server" OnClick="Button6_Click" />
                &nbsp;
</asp:View>
            </asp:MultiView>
    </p>
    Wizard<br />
    <asp:Wizard ID="Wizard1" runat="server" BackColor="#E6E2D8" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Width="966px">
        <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
        <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
        <SideBarButtonStyle ForeColor="White" />
        <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
        <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
        <WizardSteps>
            <asp:WizardStep runat="server" title="Step 1">
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Step 2">
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>

</asp:Content>