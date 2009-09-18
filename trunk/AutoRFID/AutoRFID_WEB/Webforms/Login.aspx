<%@ Page Language="C#" MasterPageFile="Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AutoRFID_WEB.Webforms.Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="principal">
    <div class="login">
    <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333" UserNameLabelText="Usuário:" 
            FailureText="Login ou senha inválido." 
            onauthenticate="Login1_Authenticate" PasswordLabelText="Senha:" 
            RememberMeText="Lembrar senha!" TitleText="Login">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
        </div>
    </div>
</asp:Content>
