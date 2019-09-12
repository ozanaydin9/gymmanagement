<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminvitaminsatış.aspx.cs" Inherits="Salon1.Adminvitaminsatış" %>
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
  
    
      Satış


      <br />
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="nutrition_id" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
    <Columns>
        <asp:BoundField DataField="nutrition_id" HeaderText="nutrition_id" />
        <asp:BoundField DataField="nutrition_name" HeaderText="nutrition_name" />
        <asp:BoundField DataField="nutrition_price" HeaderText="nutrition_price" />
        <asp:BoundField DataField="nutrition_saleprice" HeaderText="nutrition_saleprice" />
        <asp:BoundField DataField="nutrition_stock" HeaderText="nutrition_stock" />
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
