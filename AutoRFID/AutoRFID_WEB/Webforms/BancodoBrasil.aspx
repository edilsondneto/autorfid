<%@ Page Language="C#" MasterPageFile="MasterPrint.master" AutoEventWireup="true" CodeFile="BancodoBrasil.aspx.cs" Inherits="Bancos_BancodoBrasil" %>
<%@ Register Assembly="Boleto.Net" Namespace="BoletoNet" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <cc1:BoletoBancario id="boletoBancario" runat="server" CodigoBanco="001"></cc1:BoletoBancario>
</asp:Content>

