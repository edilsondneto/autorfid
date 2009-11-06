<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true" CodeBehind="MenuAssociado.aspx.cs" Inherits="AutoRFID_WEB.Webforms.MenuAssociado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="principal">
     <div>
        <asp:Menu ID="Menu3" runat="server" onmenuitemclick="Menu3_MenuItemClick" 
            Orientation="Horizontal" BackColor="#F7F6F3" DynamicHorizontalOffset="2" 
             Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" Height="82px" 
             StaticSubMenuIndent="10px">
            <StaticSelectedStyle BackColor="#5D7B9D" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <Items>
                <asp:MenuItem ImageUrl="~/Content/imagens/credito2.png" 
                    NavigateUrl="~/Webforms/ComprarCreditos.aspx" Text="Comprar Créditos" 
                    Value="Comprar Créditos"></asp:MenuItem>
                <asp:MenuItem ImageUrl="~/Content/imagens/credito.png" Text="Consultar Saldo" 
                    Value="Consultar Saldo"></asp:MenuItem>
                <asp:MenuItem ImageUrl="~/Content/imagens/cone.png" Text="Consultar Vagas" 
                    Value="Consultar Vagas" NavigateUrl="~/Webforms/ConsultarVagas.aspx"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
    </div>     
 </div>
</asp:Content>
