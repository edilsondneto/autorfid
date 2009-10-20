using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class Associado
    {
        private int idassociado;
        private String cpf_cnpj;
        private String nome_razaosocial;
        private String tipo_pf_pj;
        private String endereco;
        private int numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String email;
        private String fone;
        private String fonecel;



        public Associado()
        {
        }

        public int Idassociado
        {
            get { return idassociado; }
            set { idassociado = value; }
        }


        public string Cpf_cnpj
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }

        public string Nome_razaosocial
        {
            get { return nome_razaosocial; }
            set { nome_razaosocial = value; }
        }

        public string Tipo_pf_pj
        {
            get { return tipo_pf_pj; }
            set { tipo_pf_pj = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public String Fonecel
        {
            get { return fonecel; }
            set { fonecel = value; }
        }

    }
}
