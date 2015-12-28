<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TalktoFriends.ascx.cs" Inherits="Supbook.Web.Controls.TalktoFriends" %>
<p>
        New message
        <asp:DropDownList ID="ddl_selectUser" runat="server" DataTextField="Nom" DataValueField="IdUser">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;<asp:TextBox ID="tb_newPrivateMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
        &nbsp;<asp:Button ID="bt_newPrivateMessage" runat="server" 
            onclick="bt_newPrivateMessage_Click" Text="Send it" />
    </p>
    <p>
        <asp:ListView ID="lview_listUsers" runat="server">
            <ItemTemplate>
                <a href="privateSingleMessage.aspx?id=<%# Eval("IdUser") %>">
                    <%# Eval("Nom") %> <%# Eval("Prenom") %>
                </a><br />
            </ItemTemplate>
        </asp:ListView>
    </p>