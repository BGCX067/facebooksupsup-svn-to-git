<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="privateSingleMessage.aspx.cs" Inherits="Supbook.Web.privateSingleMessage" %>
<%@ Register TagName="Talk" TagPrefix="Control" Src="~/Controls/TalktoFriends.ascx"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:ListView ID="lview_MPs" runat="server">
    <ItemTemplate>
        <%# Eval("DateMP") %> <%# Eval("TxtMP") %><br />
    </ItemTemplate>
    </asp:ListView>
    <Control:Talk id ="MonHead" runat="server"></Control:Talk> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
