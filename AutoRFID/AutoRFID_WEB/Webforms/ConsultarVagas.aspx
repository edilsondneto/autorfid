<%@ Page Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true"
    CodeBehind="ConsultarVagas.aspx.cs" Inherits="AutoRFID_WEB.Webforms.ConsultarVagas"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
        <div class="vagas">
            <table style="width: 427px" border="2" class="vagas">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Estabelecimento"></asp:Label><br />
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="413px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                            AutoPostBack="True" OnLoad="DropDownList1_Load">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        Endereço:
                    </td>
                </tr>
                <tr>
                    <td td colspan="3">
                        <asp:Label ID="Lblendereco" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Cidade:
                    </td>
                    <td colspan="2">
                        Bairro:
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lblcidade" runat="server" Text=""></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Lblbairro" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        Quantidade Vagas
                    </td>
                    <td align="center">
                        Vagas Ocupadas
                    </td>
                    <td align="center">
                        Total Disponivel
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lblquantvagas" runat="server" Text=""></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblvagasocupadas" runat="server" Text=""></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lbltotaldisponivel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
