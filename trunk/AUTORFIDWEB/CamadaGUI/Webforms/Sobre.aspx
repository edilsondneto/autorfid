<%@ Page Language="C#" MasterPageFile="~/MasterPage/principal.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="CamadaGUI.Webforms.Sobre" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
    <body>
    <br />
    <br />
    <br />
    <p class="principal">
      RFID 

COMO FUNCIONA ? <br />
<br />


O sistema é composto basicamente por um chip (circuito eletrônico integrado), fixado a uma antena. Este conjunto é denominado inlay ou tag, que será lido através de antenas, leitoras e um sistema de processamento de dados. 

As informações sobre o item identificado estão armazenadas no chip que integrado a antenas, capturam ondas de rádio que estão no ar e, a partir delas, geram energia necessária para que a segunda antena transmita para o leitor o sinal que está gravado no chip (seqüência de números). Estes números são enviados para uma base de dados onde são processados e decodificados. 
    </p>
    
    <asp:Image ID="Image1"  runat="server" ImageUrl="~/Content/imageRfid.jpg" width="350"  Height="150" />

    </body>
    </div>
</asp:Content>
