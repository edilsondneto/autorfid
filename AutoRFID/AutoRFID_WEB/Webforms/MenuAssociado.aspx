<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true" CodeBehind="MenuAssociado.aspx.cs" Inherits="AutoRFID_WEB.Webforms.MenuAssociado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="principal">
    <div>
    
        <asp:Menu ID="Menu3" runat="server" onmenuitemclick="Menu3_MenuItemClick" 
            Orientation="Horizontal">
            <Items>
                <asp:MenuItem ImageUrl="~/Content/imagens/credito2.png" 
                    NavigateUrl="~/Webforms/ComprarCreditos.aspx" Text="Comprar Créditos" 
                    Value="Comprar Créditos"></asp:MenuItem>
                <asp:MenuItem ImageUrl="~/Content/imagens/credito.png" Text="Consultar Saldo" 
                    Value="Consultar Saldo"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
    </div>     
 </div>
</asp:Content>
