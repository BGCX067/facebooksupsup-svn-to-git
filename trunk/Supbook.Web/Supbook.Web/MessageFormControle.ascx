<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageFormControle.ascx.cs" Inherits="Supbook.Web.MessageFormControle" %>
<asp:TextBox ID="tb_message" runat="server" Height="51px" TextMode="MultiLine" 
    Width="294px"></asp:TextBox>
&nbsp;<asp:Button ID="bt_send_message" runat="server" Text="Valider" 
    onclick="bt_send_message_Click" />