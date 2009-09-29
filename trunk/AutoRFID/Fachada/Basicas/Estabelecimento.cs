using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class Estabelecimento
    {
        private int idestabelecimento;
        private String cnpj;           
        private String razaosocial;
        private String endereco;
        private int numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String email;
        private String fone;
        private String fonecelular;
        private int qtdvagas;
        private int qtdvagasocupadas;

        public Estabelecimento()
        {
            //idestabelecimento = 0;
        }
        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public String Fonecelular
        {
            get { return fonecelular; }
            set { fonecelular = value; }
        }
        public int QtdVagasOcupadas
        {
            get { return qtdvagasocupadas; }
            set { qtdvagasocupadas = value; }
        }

        public int QtdVagas
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
            get { return idestabelecimento; }
            set { idestabelecimento = value; }
        }

        

    }
}
