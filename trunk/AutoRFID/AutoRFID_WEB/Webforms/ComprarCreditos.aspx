<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true"
    CodeBehind="ComprarCreditos.aspx.cs" Inherits="AutoRFID_WEB.Webforms.ComprarCreditos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
        <center>
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Associado:"></asp:Label>
                        <br />
                        <asp:Label ID="NomeAssociado" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Valor do Crédito"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <ajaxtoolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TextBox1"
                            Mask="9,999.99" ClearMaskOnLostFocus="false">
                        </ajaxtoolkit:MaskedEditExtender>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Etiqueta"></asp:Label>
                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCadastrar" runat="server" Text="Gerar Boleto" 
                            onclick="btnCadastrar_Click"/>
                    </td>
                </tr>
            </table>
        </center>
    </div>
</asp:Content>
