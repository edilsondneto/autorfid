<%@ Page Language="C#" MasterPageFile="Master.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs"
    Inherits="AutoRFID_WEB.Webforms.Cadastro" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 468px;
        }
        .style3
        {
            width: 562px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="../Content/Mascaras.js"></script>

    <div class="principal">
        <br />
            <center style="font-family: Arial; font-size: large; color: #0000FF; text-decoration: blink">
            PRÉ-CADASTRO
        </center>      
        <br />
        <table style="width: 925px">
            <!-- Tippo Cpf/ Cnpj e Campo  -->
            <tr>
                <td rowspan="6" width="150">
                    <img alt="" src="../Content/imagens/vaga.jpg" 
                        style="width: 263px; height: 270px" /></td>
                <td colspan="2">
                    <asp:RadioButton ID="rbtPesJur" runat="server" GroupName="rdtPessoa" OnCheckedChanged="rbtPesJur_CheckedChanged"
                        AutoPostBack="true" />
                    <asp:Label ID="lblPesJur" runat="server" Text="Pessoa Jurídica"></asp:Label>
                    <asp:RadioButton ID="rbtPesFis" runat="server" GroupName="rdtPessoa" OnCheckedChanged="rbtPesFis_CheckedChanged"
                        AutoPostBack="true" />
                    <asp:Label ID="lblPesFis" runat="server" Text="Pessoa Física"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Label ID="lblCnpj" runat="server" Text="CNPJ/CPF:"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtCnpj" runat="server" Enabled="true" MaxLength="18" TextMode="SingleLine"
                        Width="111px" Height="22px" style="margin-bottom: 0px"></asp:TextBox>
                    <ajaxtoolkit:MaskedEditExtender ID="mask1" runat="server" ClearMaskOnLostFocus="false"
                        Mask="," TargetControlID="txtCnpj">
                    </ajaxtoolkit:MaskedEditExtender>
                    <ajaxtoolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" EmptyValueMessage="*"
                        IsValidEmpty="false" InvalidValueMessage="CNPJ/CPF invalido" ControlExtender="mask1"
                        ControlToValidate="txtCnpj" ValidationExpression=""></ajaxtoolkit:MaskedEditValidator>
                </td>
            </tr>
            <!--   -->
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblNome" runat="server" Text="Nome/Razão social:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" MaxLength="60" Width="436px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtNome" runat="server" ControlToValidate="txtNome"
                        ErrorMessage="Campo nome requerido">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <!--   -->
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblEndereco" runat="server" Text="Endereço:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtEndereco" runat="server" Width="436px" MaxLength="60"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo endereço requerido"
                        ControlToValidate="txtEndereco">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <!--   -->
            <tr>
                <td class="style2" colspan="2">
                    <asp:Label ID="lblNumero" runat="server" Text="Número:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblBairro" runat="server" Text="Bairro:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Cidade:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNumero" runat="server" MaxLength="11" Width="55px"></asp:TextBox>
                    <ajaxtoolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server" ClearMaskOnLostFocus="false"
                        Mask="99999999999" TargetControlID="txtNumero">
                    </ajaxtoolkit:MaskedEditExtender>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNumero"
                        ErrorMessage="Campo número requerido">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:TextBox ID="txtBairro" runat="server" Width="145px" MaxLength="60"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo bairro requerido"
                        ControlToValidate="txtBairro">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:TextBox ID="TextCidade" runat="server" Width="184px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextCidade"
                        ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <!-- Estado - Cep e Fone  -->
            <tr>
                <td class="style3">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCep" runat="server" Text="Cep:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtCep"
                        Text="Cep inválido!" ValidationExpression="\d{5}\-\d{3}" runat="Server" />
                    &nbsp;<asp:Label ID="lblFone" runat="server" Text="Fone:"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" ControlToValidate="txtFone"
                        Text="Fone inválido!" ValidationExpression="\(\d{2}\)\ \d{4}\-\d{4}" runat="Server" />
                &nbsp;&nbsp;
                    <asp:Label ID="lblCelular" runat="server" Text="Celular:"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" ControlToValidate="txtCelular"
                        Text="Celular inválido!" ValidationExpression="\(\d{2}\)\ \d{4}\-\d{4}" runat="Server" />
                    <br />
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="ac">AC</asp:ListItem>
                        <asp:ListItem Value="al">AL</asp:ListItem>
                        <asp:ListItem Value="ap">AP</asp:ListItem>
                        <asp:ListItem Value="am">AM</asp:ListItem>
                        <asp:ListItem Value="ba">BA</asp:ListItem>
                        <asp:ListItem Value="ce">CE</asp:ListItem>
                        <asp:ListItem Value="df">DF</asp:ListItem>
                        <asp:ListItem Value="es">ES</asp:ListItem>
                        <asp:ListItem Value="go">GO</asp:ListItem>
                        <asp:ListItem Value="ma">MA</asp:ListItem>
                        <asp:ListItem Value="mt">MT</asp:ListItem>
                        <asp:ListItem Value="mg">MS</asp:ListItem>
                        <asp:ListItem Value="pa">PA</asp:ListItem>
                        <asp:ListItem Value="pb">PB</asp:ListItem>
                        <asp:ListItem Value="pr">PR</asp:ListItem>
                        <asp:ListItem Value="pe">PE</asp:ListItem>
                        <asp:ListItem Value="pi">PI</asp:ListItem>
                        <asp:ListItem Value="rj">RJ</asp:ListItem>
                        <asp:ListItem Value="sp">SP</asp:ListItem>
                        <asp:ListItem Value="se">SE</asp:ListItem>
                        <asp:ListItem Value="to">TO</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo estado requerido"
                        ControlToValidate="ddlEstado">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:TextBox ID="txtCep" runat="server" Width="98px" onkeyup="formataCEP(this, event)"
                        MaxLength="9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo cep requerido"
                        ControlToValidate="txtCep">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:TextBox ID="txtFone" runat="server" Width="120px" onkeyup="formataTelefone(this, event)"
                        Rows="14"></asp:TextBox>
                <!-- </td>  -->
               <!--  <td> -->
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo fone requerido"
                        ControlToValidate="txtFone">*</asp:RequiredFieldValidator>
                    <asp:TextBox ID="txtCelular" runat="server" Width="102px" onkeyup="formataTelefone(this, event)"
                        Rows="14"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo celular requerido"
                        ControlToValidate="txtCelular">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;<asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" ControlToValidate="txtEmail"
                        Text="E-mail inválido!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        runat="Server" />
                    <br />
                    <asp:TextBox ID="txtEmail" runat="server" Width="204px" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo e-mail requerido"
                        ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
