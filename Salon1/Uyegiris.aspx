<%@ Page Title="" Language="C#" MasterPageFile="~/Ana.Master" AutoEventWireup="true" CodeBehind="Uyegiris.aspx.cs" Inherits="Salon1.Uyegiris" %>
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
    <h1 class="title">Üye Girişi:</h1>
   
      <div class="input-container">
        &nbsp;<table class="nav-justified">
              <tr>
                  <td style="width: 51px">
         <label for="Username">E-mail:</label></td>
                  <td><input type="text" id="Username" required="required"/></td>
              </tr>
              <tr>
                  <td style="width: 51px">
           <label for="Password">Şifre: </label></td>
                  <td>
        <input type="password" id="Password" required="required"/></td>
              </tr>
          </table>
          <table class="nav-justified">
              <tr>
                  <td>
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" />
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>
&nbsp;<div class="bar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          </div>
      </div>
    &nbsp;</div>
 
    </div></div>
</div>
</asp:Content>
