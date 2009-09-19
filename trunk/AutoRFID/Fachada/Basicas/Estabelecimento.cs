using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class Estabelecimento
    {
        private int idestabelecimento;
        private String razaosocial;
        private String endereco;
        private int numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String email;
        private String fone;
        private int qtdvagas;
        private int qtdvagasdisponiveis;

        public Estabelecimento()
        {

        }

        public int Qtdvagasdisponiveis
        {
            get { return qtdvagasdisponiveis; }
            set { qtdvagasdisponiveis = value; }
        }

        public int Qtdvagas
        {
            get { return qtdvagas; }
            set { qtdvagas = value; }
        }

        public String Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        } 

        public int IdEstabelecimento
        {
            get { return IdEstabelecimento; }
            set { IdEstabelecimento = value; }
        }

        

    }
}
