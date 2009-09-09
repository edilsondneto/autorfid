<%@ Page Language="C#" MasterPageFile="~/MasterPage/principal.Master" AutoEventWireup="true"
    CodeBehind="Cadastro.aspx.cs" Inherits="CamadaGUI.Webforms.Cadastro" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" src="../Content/Mascaras.js"></script>

    <div class="principal">
        <div class="cad">
            <table>
                <tr>
                    <td><asp:Label ID="lblRazaoSocial" runat="server" Text="Razão Social:"></asp:Label></td>
                    <td><asp:TextBox ID="txtRazaoSocial" runat="server" Width="200px" Height="13px" MaxLength="20"></asp:TextBox></td> 
                </tr>
                <tr>
                    <td><asp:Label ID="lblCnpj" runat="server" Text="Cnpj:"></asp:Label></td>
                    <td><asp:TextBox ID="txtCnpj" runat="server" Width="150px" Height="13px" TextMode="SingleLine" onkeyup="formataCNPJ(this, event)" ></asp:TextBox>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtCnpj" text="Cnpj inválido!" 
                            validationExpression="\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label></td>
                    <td><asp:TextBox ID="txtNome" runat="server" Width="200px" Height="13px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTxtNome" runat="server" 
                        ErrorMessage="Campo nome requerido" ControlToValidate="txtNome">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCpf" runat="server" Text="Cpf:"></asp:Label></td>
                    <td><asp:TextBox ID="txtCpf" runat="server" Width="150px" Height="13px" onkeyup="formataCPF(this, event)" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Campo cpf requerido" ControlToValidate="txtCpf">*</asp:RequiredFieldValidator>
                        <asp:regularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtCpf" text="CPF inválido !" 
                            validationExpression="\d{3}\.\d{3}\.\d{3}\-\d{2}" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblEndereco" runat="server" Text="Endereço:"></asp:Label></td>
                    <td><asp:TextBox ID="txtEndereco" runat="server" Width="200px" Height="13px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Campo endereço requerido" ControlToValidate="txtEndereco">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblNumero" runat="server" Text="Número:"></asp:Label></td>
                    <td><asp:TextBox ID="txtNumero" runat="server" Width="50px" Height="13px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="Campo número requerido" ControlToValidate="txtNumero">*</asp:RequiredFieldValidator>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtNumero" text="Número inválido!" 
                            validationExpression="\d*" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblEstado" runat="server" Text="Estado:"></asp:Label></td>
                    <td><asp:DropDownList ID="ddlEstado" runat="server">
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
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="Campo estado requerido" ControlToValidate="ddlEstado">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblBairro" runat="server" Text="Bairro:"></asp:Label></td>
                    <td><asp:TextBox ID="txtBairro" runat="server" Width="100px" Height="13px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ErrorMessage="Campo bairro requerido" ControlToValidate="txtBairro">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCep" runat="server" Text="Cep:"></asp:Label></td>
                    <td><asp:TextBox ID="txtCep" runat="server" Width="70px" Height="13px" onkeyup="formataCEP(this, event)"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ErrorMessage="Campo cep requerido" ControlToValidate="txtCep">*</asp:RequiredFieldValidator>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtCep" text="Cep inválido!" 
                            validationExpression="\d{5}\-\d{3}" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label></td>
                    <td><asp:TextBox ID="txtEmail" runat="server" Width="150px" Height="13px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ErrorMessage="Campo e-mail requerido" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator5" ControlToValidate="txtEmail" text="E-mail inválido!" 
                            validationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblFone" runat="server" Text="Fone:"></asp:Label></td>
                    <td><asp:TextBox ID="txtFone" runat="server" Width="100px" Height="13px" onkeyup="formataTelefone(this, event)" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ErrorMessage="Campo fone requerido" ControlToValidate="txtFone">*</asp:RequiredFieldValidator>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator6" ControlToValidate="txtFone" text="Fone inválido!" 
                            validationExpression="\(\d{2}\)\ \d{4}\-\d{4}" runat="Server"/>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCelular" runat="server" Text="Celular:"></asp:Label></td>
                    <td><asp:TextBox ID="txtCelular" runat="server" Width="100px" Height="13px" onkeyup="formataTelefone(this, event)"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="Campo celular requerido" ControlToValidate="txtCelular">*</asp:RequiredFieldValidator>
                    <asp:regularExpressionValidator ID="RegularExpressionValidator7" ControlToValidate="txtCelular" text="Celular inválido!" 
                            validationExpression="\(\d{2}\)\ \d{4}\-\d{4}" runat="Server"/>
                    </td>
                    
                </tr>
            </table>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" 
                onclick="btnCadastrar_Click" />
		         
        </div>
    </div>
</asp:Content>
