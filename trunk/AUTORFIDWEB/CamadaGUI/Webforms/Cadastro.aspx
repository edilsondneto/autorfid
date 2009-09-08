<%@ Page Language="C#" MasterPageFile="~/MasterPage/principal.Master" AutoEventWireup="true"
    CodeBehind="Cadastro.aspx.cs" Inherits="CamadaGUI.Webforms.Cadastro" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
        <div class="cad">
            <asp:Label ID="lblNome" runat="server" Text="Nome completo:"></asp:Label>
            <br />
            <asp:TextBox ID="txtNome" runat="server" Width="435px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEndereço" runat="server" Text="Endereço"></asp:Label>
            <br />
            <asp:TextBox ID="txtEndereço" runat="server" Width="434px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" />
        </div>
    </div>
</asp:Content>
