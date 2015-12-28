<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="userInscription.aspx.cs" Inherits="Supbook.Web.userInscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <asp:Label ID="lb_nom" runat="server" Text="Nom" />
&nbsp;<asp:TextBox ID="tb_nom" runat="server" Height="23px" Width="131px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb_nom" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

    <asp:Label ID="lb_prenom" runat="server" Text="Prénom" />
&nbsp;<asp:TextBox ID="tb_prenom" runat="server" Height="23px" Width="131px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tb_prenom" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

    <asp:Label ID="lb_born_date" runat="server" Text="Date de naissance" />
&nbsp;<asp:Calendar ID="cal_born_date" runat="server" Height="23px" Width="131px" />
<asp:Label ID="lb_date_naissance_error" runat="server" />
<br /><br />

<asp:Label ID="lb_adresse" runat="server" Text="Adresse" />
&nbsp;<asp:TextBox TextMode="MultiLine" ID="tb_adresse" runat="server" Height="63px" Width="231px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb_adresse" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

    <asp:Label ID="lb_mail" runat="server" Text="Mail" />
&nbsp;<asp:TextBox ID="tb_mail" runat="server" Height="23px" Width="131px" />
<asp:RegularExpressionValidator id="regEmail" ControlToValidate="tb_mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Runat="server"><span style="color:red">Email invalide</span></asp:RegularExpressionValidator> 
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="tb_mail" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

    <asp:Label ID="lb_pass" runat="server" Text="Mot de passe" />
&nbsp;<asp:TextBox TextMode="Password" ID="tb_pass" runat="server" Height="23px" Width="131px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="tb_pass" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

        <asp:Label ID="lb_pass_2" runat="server" Text="Resaisissez le mot de passe" />
&nbsp;<asp:TextBox TextMode="Password" ID="tb_pass2" runat="server" Height="23px" Width="131px" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tb_pass2" 
runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

<asp:FileUpload ID="fu_photo" runat="server" />
<br /><br /><br />|

<asp:Button ID="bt_valid" runat="server" Text="Valider l'inscription" 
        ValidationGroup="validation" onclick="bt_valid_Click" />

<asp:Label ID="lb_error" runat="server" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
