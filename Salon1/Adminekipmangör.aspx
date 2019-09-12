<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminekipmangör.aspx.cs" Inherits="Salon1.Adminekipmangör" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    
      <table style="width: 100%">
          <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
      </table>
  
    
      EKİPMANLARI GÖRÜNTÜLE


      <br />
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="equipment_id" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
    <Columns>
        <asp:BoundField DataField="equipment_id" HeaderText="equipment_id" />
        <asp:BoundField DataField="equipment_name" HeaderText="equipment_name" />
        <asp:BoundField DataField="equipment_price" HeaderText="equipment_price" />
        <asp:BoundField DataField="equipment_stock" HeaderText="equipment_stock" />
        <asp:CommandField ShowEditButton="true" />
        <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
      


      <br />
      <br />
      <br />
      <br />
      <br />
      


</asp:Content>
