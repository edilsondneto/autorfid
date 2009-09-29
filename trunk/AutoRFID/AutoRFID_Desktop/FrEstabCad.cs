using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fachada.Basicas;

namespace AutoRFID_Desktop
{
    public partial class FrEstabCad : AutoRFID_Desktop.frCadPad
    {
        private Fachada.Fachada.Fachada objFachada;
        private Estabelecimento objEstabelecimento;
        private Estabelecimento objEstabConsulta;

        public FrEstabCad()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
      
            if (!base.validacaoMSG.Equals("ok"))
            {
                MessageBox.Show(base.validacaoMSG, "Atenção!");
                return;
            }
            try
            {
                this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
                this.objEstabelecimento = new Estabelecimento();
                
                try//se for alteração
                {
                    int idEstab = this.objEstabConsulta.IdEstabelecimento;
                    if (idEstab > 0)
                    {
                        this.objEstabelecimento.IdEstabelecimento=idEstab;
                    }
                }
                catch
                { }
                
                
                //tirando as máscaras dos campos
                cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                fone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                fonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                this.objEstabelecimento.Cnpj = cnpj.Text;
                this.objEstabelecimento.Razaosocial = textRazaoSocial.Text;
                this.objEstabelecimento.Endereco = textEndereco.Text;
                this.objEstabelecimento.Bairro = textBairro.Text;
                this.objEstabelecimento.Numero = int.Parse(textNumero.Text);
                this.objEstabelecimento.Cidade = textCidade.Text;
                this.objEstabelecimento.Estado = comboEstado.Text;
                this.objEstabelecimento.Cep = maskedTextCep.Text;
                this.objEstabelecimento.Email = textEmail.Text;
                this.objEstabelecimento.QtdVagas = int.Parse(textQuantidade.Text);
                this.objEstabelecimento.Fone = fone.Text;
                this.objEstabelecimento.Fonecelular = fonecelular.Text;
                //-------
                if (this.objEstabelecimento.IdEstabelecimento.Equals(0))
                {
                 this.objFachada.IncluirEstabelecimento(this.objEstabelecimento);
                 this.CarregarCampos(null, null);
                }   
                else
                {
                    this.objFachada.AlterarEstabelecimento(this.objEstabelecimento);
                }

                base.habilita();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção o Registro não foi gravado.");

            }                
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {

            cnpj.Focus();
        }

        private void lblRazãoSocial_Click(object sender, EventArgs e)
        {

        }
        private void CarregarCampos(String idEstab, String cnpj)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
            this.objEstabConsulta = new Estabelecimento();

            try
            {
                if (!idEstab.Equals(null))
                    this.objEstabConsulta.IdEstabelecimento = int.Parse(idEstab);
                else
                    this.objEstabConsulta.IdEstabelecimento = 0;

            }
            catch (Exception ex) { }
            this.objEstabConsulta.Cnpj = cnpj;

            this.objEstabConsulta = this.objFachada.ConsultarEstabelecimento(this.objEstabConsulta);

            //Preencher campos do form
            //this.textCodigo.Text = this.objAssociado.Idassociado.ToString();
            
            this.cnpj.Text = this.objEstabConsulta.Cnpj;
            this.textRazaoSocial.Text = this.objEstabConsulta.Razaosocial;
            this.textEndereco.Text = this.objEstabConsulta.Endereco;
            this.textBairro.Text = this.objEstabConsulta.Bairro;
            this.textCidade.Text = this.objEstabConsulta.Cidade;
            this.textNumero.Text = this.objEstabConsulta.Numero.ToString();
            this.comboEstado.Text = this.objEstabConsulta.Estado;
            this.maskedTextCep.Text = this.objEstabConsulta.Cep;
            this.textEmail.Text = this.objEstabConsulta.Email;
            this.textQuantidade.Text = this.objEstabConsulta.QtdVagas.ToString();
            this.fone.Text = this.objEstabConsulta.Fone;
            this.fonecelular.Text = this.objEstabConsulta.Fonecelular;
        }

        private void FrEstabCad_Load(object sender, EventArgs e)
        {
            this.CarregarCampos(null, null);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();


            try
            {
                //int idAssoc = int.Parse(this.textCodigo.Text);
                //this.objFachada.ExcluirAssociado(idAssoc);

                //this.objEstabConsulta = 
                this.objFachada.ExcluirEstabelecimento(this.objEstabConsulta);
                this.CarregarCampos(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro. " + ex.Message, "Atenção!");
            }

        }
    }
}
