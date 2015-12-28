<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="timeline.aspx.cs" Inherits="Supbook.Web.timeline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">



    <asp:Repeater ID="RepeaterWall" runat="server">

    <ItemTemplate>
    <%# DataBinder.Eval(Container.DataItem, "TxtWall") %> <br />
    </ItemTemplate>

    </asp:Repeater>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
