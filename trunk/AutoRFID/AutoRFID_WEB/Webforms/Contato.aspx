<%@ Page Language="C#" MasterPageFile="Master.Master" AutoEventWireup="true"
    CodeBehind="Contato.aspx.cs" Inherits="AutoRFID_WEB.Webforms.Contato" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 204px;
        }
        .style2
        {
            width: 204px;
            height: 1px;
        }
        .style3
        {
            height: 1px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
        <br />
        <br />
        <center style="font-family: Arial; font-size: large; color: #0000FF; text-decoration: blink">
            Solicite informações sobre etiqueta RFID
        </center>
        <br />
        <br />
        <table class="contato" 
            style="font-family: Arial; font-size: small; color: #0066FF; ">
            <tr>
                <td rowspan="10" width="150">
                    <img alt="" src="../Content/imagens/chip.jpg" 
                        style="width: 273px; height: 194px" /></td>
           
                <td class="style2" 
                    style="color: #0000FF; ">
                    Walmir Silva
                </td>
                <td class="style3">
                    <a href="mailto:walmirsaraujo@gmail.com">walmirsaraujo@gmail.com</a>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    style="color: #0000FF; ">
                    Josenilton Leandro
                </td>
                <td>
                    <a href="mailto:jlaleandro@gmail.com">jlaleandro@gmail.com</a></td>
            </tr>
            <tr>
                <td class="style1" 
                    style="color: #0000FF; ">
                    Rafael Freire
                </td>
                <td>
                    <a href="mailto:rfmelo@gmail.com">rfmelo@gmail.com</a>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    style="color: #0000FF; ">
                    Diego Bezerra
                </td>
                <td>
                    <a href="mailto:dbezera21@gmail.com">dbezera21@gmail.com</a></td>
            </tr>
            <tr>
                <td class="style1" 
                    style="color: #0000FF; ">
                    Kildare Alexandre
                </td>
                <td>
                    <a href="mailto:kps@gmail.com">kps@gmail.com</a>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    style="color: #0000FF; ">
                    Dyego Valença
                </td>
                <td>
                    <a href="mailto:d7@gmail.com">d7@gmail.com</a>
                </td>
            </tr>
            <tr> <td></td> <td></td> </tr>
            <tr> <td></td> <td></td> </tr>
            <tr> <td></td> <td></td> </tr>
            <tr> <td>Fone: (81)3466-4500</td> <td>Fax: (81)3466-4501</td> </tr>

        </table>
        <br />
    </div>
</asp:Content>
