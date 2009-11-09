<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true"
    CodeBehind="ComprarCreditos.aspx.cs" Inherits="AutoRFID_WEB.Webforms.ComprarCreditos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 159px;
        }
        .style2
        {
            width: 115px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="../Content/Mascaras.js"></script>

    <div class="principal">
        <div class="">
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Associado:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="NomeAssociado" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:Label ID="Label1" runat="server" Text="Valor do Crédito"></asp:Label>
                    </td>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Etiqueta"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="106px"></asp:TextBox>
                    </td>
                    <td class="style1">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCadastrar" runat="server" Text="Gerar Boleto" OnClick="btnCadastrar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
