<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="Invitation.aspx.cs" Inherits="Supbook.Web.Invitation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <p>
        Inviter un ami :</p>
    <p>
        email :
        <asp:TextBox ID="tb_mail" runat="server" Height="23px" Width="131px" />
        <asp:RegularExpressionValidator id="regEmail" ControlToValidate="tb_mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Runat="server"><span style="color:red">Email invalide</span>
        </asp:RegularExpressionValidator> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="tb_mail" runat="server" ValidationGroup="validation" ErrorMessage="Ce champ est requis"><span style="color:red">Ce champ est requis</span></asp:RequiredFieldValidator>
<br /><br />

&nbsp;<asp:Button ID="Button1" runat="server" Text="Inviter !" 
            onclick="Button1_Click" />
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
