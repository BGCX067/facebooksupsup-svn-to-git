<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="privateMessages.aspx.cs" Inherits="Supbook.Web.privateMessages" %>
<%@ Register TagName="Talk" TagPrefix="Control" Src="~/Controls/TalktoFriends.ascx"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <Control:Talk id ="MonHead" runat="server"></Control:Talk> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
