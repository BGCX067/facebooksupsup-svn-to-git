<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Global.Master" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="Supbook.Web.mypage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
<div>
    <div style="width: 732px;margin-left: 200px;margin-top: -10px;border: 4px solid #3B5998;min-height:900px;background-color: #ffffff;float:left;">
        <img alt="imageperso" src="/images/imageperso.png" style="margin:0;"/>
        <asp:Panel runat="server" ID="PanelPublishStatus">
            <asp:TextBox runat="server" ID="monmessage" Text="A propos de moi" style="width: 90%;margin-left: 2px;height: 27px;border: 2px solid darkBlue;margin-top: 1px;" onclick="javascript:efface()"></asp:TextBox><asp:Button ID="monbouton" runat="server" OnClick="add" Text="Envoyer" style="height: 34px;"/>
        </asp:Panel>
        <input type="button" value="Mes Amis" style="margin-left: 172px;"/>
        <input type="button" value="Mes photos" />
        <input type="button" value="Mes informations personnelles" />
        <asp:GridView ID="Listedesannonces" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="DateWall" HeaderText="Date" />
                <asp:BoundField DataField="TxtWall" HeaderText="Message" />
            </Columns>
        </asp:GridView>


        
    </div>
    <div style="Float: right;width: 300px;border: 4px solid #3B5998;min-height: 900px;background-color: #ffffff;margin-top: -10px;">
        <p style="font-size: 23px;margin-left: 100px;">Mes amis :</p>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
