<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Supbook.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login :<br />
    Username : 
    <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" ControlToValidate="TextBoxUsername" ValidationGroup="login" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    <br />
    Password : 
    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator2" ControlToValidate="TextBoxPassword" ValidationGroup="login" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
    

        <br />
        <asp:Label ID="LabelError" runat="server" Text="Mot de passe incorrect" Visible="false"></asp:Label>
    

    &nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/userInscription.aspx">S'inscrire</asp:HyperLink>
    

    <br />
    

    <asp:Button ID="ButtonLogin" runat="server" Text="Login" ValidationGroup="login" 
            onclick="Button1_Click"/>

</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
