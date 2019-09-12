<%@ Page Title="" Language="C#" MasterPageFile="~/Ana.Master" AutoEventWireup="true" CodeBehind="Admingiris.aspx.cs" Inherits="Salon1.Admingiris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
	<div class="row">
		
<!-- Mixins-->
<!-- Pen Title-->
<div class="pen-title">
  <h1>&nbsp;</h1>
</div>
<div class="container">
  <div class="card">
    <h1 class="title">Admin Girişi:</h1>
    
      <div class="input-container">
        &nbsp;<table class="nav-justified">
              <tr>
                  <td style="width: 51px">
                      E-mail:</td>
                  <td>
                      <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td style="width: 51px">
                      Şifre: </td>
                  <td>
                      <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                  </td>
              </tr>
          </table>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" />
          <br />
          <div class="bar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
      </div>
    &nbsp;</div>
 

</div>
</div>
    </div>
</asp:Content>
