<%@ Page Language="C#" MasterPageFile="~/Webforms/Master.Master" AutoEventWireup="true"
    CodeBehind="ConsultarVagas.aspx.cs" Inherits="AutoRFID_WEB.Webforms.ConsultarVagas"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
        <div class="vagas">
            <asp:Label ID="Label1" runat="server" Text="Estabelecimento"></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="296px" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                AutoPostBack="True" onload="DropDownList1_Load">
            </asp:DropDownList>
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Localização"></asp:Label><br />
            <table style="width: 427px" border="2">
                <tr>
                    <td colspan="2">
                        Endereço:
                    </td>
                </tr>
                <tr>
                    <td td colspan="2">
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Cidade:
                    </td>
                    <td>
                        Bairro:
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        Quantidade de Vagas:
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div class="test">
        Vagas Ocupadas
        <br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" 
                runat="server" Text="" Font-Size="X-Large"></asp:Label>
        </div>
    </div>
</asp:Content>
