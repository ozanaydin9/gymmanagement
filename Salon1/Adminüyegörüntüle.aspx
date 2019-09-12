<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminüyegörüntüle.aspx.cs" Inherits="Salon1.Adminüyegörüntüle" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    ÜYELER<br />
    <br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="user_id" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
    <Columns>
        <asp:BoundField DataField="user_id" HeaderText="user_id" />
        <asp:BoundField DataField="user_name" HeaderText="user_name" />
        <asp:BoundField DataField="user_age" HeaderText="user_age" />
        <asp:BoundField DataField="user_adress" HeaderText="user_adress" />
        <asp:BoundField DataField="user_tel" HeaderText="user_tel" />
        <asp:BoundField DataField="user_email" HeaderText="user_email" />
        <asp:BoundField DataField="user_pass" HeaderText="user_pass" />
        <asp:BoundField DataField="trainer_id" HeaderText="trainer_id" />
        <asp:BoundField DataField="program_id" HeaderText="program_id" />
        <asp:BoundField DataField="package_id" HeaderText="package_id" />
        <asp:BoundField DataField="payment_id" HeaderText="payment_id" />
        <asp:CommandField ShowEditButton="true" />
        <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
    
    <br />
    <br />
    <br />

    
</asp:Content>
