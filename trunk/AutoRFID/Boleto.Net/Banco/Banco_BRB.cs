using System;
using System.Web.UI;
using Microsoft.VisualBasic;

[assembly: WebResource("BoletoNet.Imagens.070.jpg", "image/jpg")]
namespace BoletoNet
{
    /// <author>  
    /// Eduardo Frare
    /// Stiven 
    /// Diogo
    /// Miamoto
    /// </author>    


    /// <summary>
    /// Classe referente ao banco Banco_BRB
    /// </summary>
    internal class Banco_BRB : AbstractBanco, IBanco
    {
        private int _dacBoleto = 0;

        internal Banco_BRB()
        {
            this.Codigo = 70;
            this.Digito = 1;
            this.Nome = "Banco_BRB";
        }

        #region IBanco Members

        public override void FormataCodigoBarra(Boleto boleto)
        {
            // C�digo de Barras
            //banco & moeda & fator & valor & carteira & nossonumero & dac_nossonumero & agencia & conta & dac_conta & "000"

            string banco = Utils.FormatCode(Codigo.ToString(), 3);
            int moeda = boleto.Moeda;
            //string digito = "";
            string valorBoleto = boleto.ValorBoleto.ToString("f").Replace(",", "").Replace(".", "");
            valorBoleto = Utils.FormatCode(valorBoleto, 10);

            string fatorVencimento = FatorVencimento(boleto).ToString();
            string chave = boleto.CodigoBarra.Chave;


            boleto.CodigoBarra.Codigo =
                string.Format("{0}{1}{2}{3}{4}", banco, moeda,fatorVencimento,
                              valorBoleto, boleto.CodigoBarra.Chave);


            _dacBoleto = Banco_BRB.Mod11_CodigoBarra(boleto.CodigoBarra.Codigo, 9);

            boleto.CodigoBarra.Codigo = Strings.Left(boleto.CodigoBarra.Codigo, 4) + _dacBoleto + Strings.Right(boleto.CodigoBarra.Codigo, 39);
        }

        public override void FormataLinhaDigitavel(Boleto boleto)
        {
            string BBB = Utils.FormatCode(Codigo.ToString(), 3);
            int M = boleto.Moeda;
            string CCCCC1 = boleto.CodigoBarra.Chave.Substring(0, 5);
            int D1 = 0;

            string CCCCCCCCCC2 = boleto.CodigoBarra.Chave.Substring(5, 10);
            int D2 = 0;

            string CCCCCCCCCC3 = boleto.CodigoBarra.Chave.Substring(15, 10);
            int D3 = 0;

            D1 = Mod10(BBB + M + CCCCC1);
            string Grupo1 = string.Format("{0}.{1}{2} ", BBB + M + CCCCC1.Substring(0, 1), CCCCC1.Substring(1, 4), D1);

            D2 = Mod10(CCCCCCCCCC2);
            string Grupo2 = string.Format("{0}.{1}{2} ", CCCCCCCCCC2.Substring(0, 5), CCCCCCCCCC2.Substring(5, 5), D2);

            D3 = Mod10(CCCCCCCCCC3);
            string Grupo3 = string.Format("{0}.{1}{2} ", CCCCCCCCCC3.Substring(0, 5), CCCCCCCCCC3.Substring(5, 5), D3);

            string Grupo4 = string.Format("{0} {1}{2}", _dacBoleto, FatorVencimento(boleto).ToString(), Utils.FormatCode(boleto.ValorBoleto.ToString("f").Replace(",", "").Replace(".", ""), 10));

            boleto.CodigoBarra.LinhaDigitavel = Grupo1 + Grupo2 + Grupo3 + Grupo4;
        }

        public override void FormataNossoNumero(Boleto boleto)
        {
            boleto.NossoNumero = string.Format("{0}{1}{2}", boleto.Categoria, boleto.NossoNumero, Utils.FormatCode(Codigo.ToString(), 3) + boleto.CodigoBarra.Chave.Substring(23, 2));
        }

        public override void FormataNumeroDocumento(Boleto boleto)
        {
            boleto.NumeroDocumento = string.Format("{0}", boleto.NumeroDocumento);
        }

        public override void ValidaBoleto(Boleto boleto)
        {
            //Verifica se o nosso n�mero � v�lido
            if (Utils.ToInt64(boleto.NossoNumero) == 0)
                throw new NotImplementedException("Nosso n�mero inv�lido");

            //Verifica se o tamanho para o NossoNumero s�o 12 d�gitos
            if (Convert.ToInt32(boleto.NossoNumero).ToString().Length > 6)
                throw new NotImplementedException("A quantidade de d�gitos do nosso n�mero para a carteira " + boleto.Carteira + ", s�o 6 n�meros.");
            else if (Convert.ToInt32(boleto.NossoNumero).ToString().Length < 6)
                boleto.NossoNumero = Utils.FormatCode(boleto.NossoNumero, 6);

            if (boleto.Carteira != "COB")
                throw new NotImplementedException("Carteira n�o implementada. Utilize a carteira COB.");

            //Atribui o nome do banco ao local de pagamento
            boleto.LocalPagamento += Nome + "";

            //Verifica se data do processamento � valida
            if (boleto.DataProcessamento.ToString("dd/MM/yyyy") == "01/01/0001")
                boleto.DataProcessamento = DateTime.Now;

            //Verifica se data do documento � valida
            if (boleto.DataDocumento.ToString("dd/MM/yyyy") == "01/01/0001")
                boleto.DataDocumento = DateTime.Now;

            FormataChave(boleto);
            FormataCodigoBarra(boleto);
            FormataLinhaDigitavel(boleto);
            FormataNossoNumero(boleto);
            FormataNumeroDocumento(boleto);
        }

        #endregion

        public void FormataChave(Boleto boleto)
        {
            string zeros = "000";
            string agencia = boleto.Cedente.ContaBancaria.Agencia;
            string conta = boleto.Cedente.ContaBancaria.Conta + boleto.Cedente.ContaBancaria.DigitoConta;
            int categoria = 1;
            boleto.Categoria = categoria;
            string nossonumero = boleto.NossoNumero;
            string banco = Utils.FormatCode(Codigo.ToString(), 3);
            
            //Mod10 dentro da classe Banco_BRB pelas particularidades que ela tem.
            int d1 = Banco_BRB.Mod10(zeros + agencia + conta + categoria + nossonumero + banco);
            int d2 = Banco_BRB.Mod11_NossoNumero(zeros + agencia + conta + categoria + nossonumero + banco + d1, 7);

            if (d2 > 10)
            {
                d1 += 1;
                d2 -= 20;
            }

            boleto.CodigoBarra.Chave = zeros + agencia + conta + categoria + nossonumero + banco + d1 + d2;
        }

        internal static int Mod11_CodigoBarra(string value, int Base)
        {
            int Digito, Soma = 0, Peso = 2;

            for (int i = value.Length; i > 0; i--)
            {
                Soma = Soma + (Convert.ToInt32(Strings.Mid(value, i, 1)) * Peso);
                if (Peso == Base)
                    Peso = 2;
                else
                    Peso = Peso + 1;
            }

            if (((Soma % 11) == 0) || ((Soma % 11) == 10) || ((Soma % 11) == 1))
            {
                Digito = 1;
            }
            else
            {
                Digito = 11 - (Soma % 11);
            }
            
            return Digito;
        }

        internal static int Mod11_NossoNumero(string value, int Base)
        {

            int Digito, Soma = 0, Peso = 2;

            for (int i = value.Length; i > 0; i--)
            {
                Soma = Soma + (Convert.ToInt32(Strings.Mid(value, i, 1)) * Peso);
                if (Peso == Base)
                    Peso = 2;
                else
                    Peso = Peso + 1;
            }

             if ((Soma % 11) > 1)
            {
                Digito = 11 - (Soma % 11);
            }
            else if ((Soma % 11) == 1)
            {
                int d1 = Utils.ToInt32(Strings.Mid(value, value.Length, value.Length - 1));

                d1 += 1;

                if (d1 == 10)
                    d1 = 0;

                Digito = Banco_BRB.Mod11_NossoNumero(Strings.Mid(value, 1, value.Length - 1) + d1, 7);
                Digito += 20;               
            }
            else 
            {
                Digito = (Soma % 11);
            }

            return Digito;
  
        }


        internal static int Mod10(string seq)
        {

            int Digito, Soma = 0, Peso = 2, res;

            for (int i = seq.Length; i > 0; i--)
            {
                res = (Convert.ToInt32(Strings.Mid(seq, i, 1)) * Peso);

                if (res > 9)
                    res = (res - 9);

                Soma += res;

                if (Peso == 2)
                    Peso = 1;
                else
                    Peso = Peso + 1;
            }
            
            Digito = ((10 - (Soma % 10)) % 10);

            return Digito;
       }

        public override string GerarHeaderRemessa(string numeroConvenio, Cedente cedente, TipoArquivo tipoArquivo)
        {
            throw new Exception("Fun��o n�o implementada.");
        }
    }
}
