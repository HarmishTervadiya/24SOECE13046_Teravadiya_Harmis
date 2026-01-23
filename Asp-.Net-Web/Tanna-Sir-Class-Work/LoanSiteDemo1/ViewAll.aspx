<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewAll.aspx.cs" Inherits="_Default" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoanNo" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="LoanNo" HeaderText="LoanNo" InsertVisible="False" ReadOnly="True" SortExpression="LoanNo" />
                    <asp:BoundField DataField="AccountNo" HeaderText="AccountNo" SortExpression="AccountNo" />
                    <asp:BoundField DataField="LoanCategory" HeaderText="LoanCategory" SortExpression="LoanCategory" />
                    <asp:BoundField DataField="LoanType" HeaderText="LoanType" SortExpression="LoanType" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="CurrentAddress" HeaderText="CurrentAddress" SortExpression="CurrentAddress" />
                    <asp:BoundField DataField="LoanRemarks" HeaderText="LoanRemarks" SortExpression="LoanRemarks" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Loan]"></asp:SqlDataSource>
</asp:Content>