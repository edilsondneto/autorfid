﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class Funcionario
    {
        #region atributos
        private int idfuncionario;
        private int idestabelecimento;
        private String cpf;
        private String nome;
        private int numero;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;
        private String email;
        private String funcao;
        private String fone;
        private String endereco;
        private String fonecelular;
        #endregion

        public Funcionario()
        {

        }

        #region properties

        public String Fonecelular
        {
            get { return fonecelular; }
            set { fonecelular = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public String Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        public String Email
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

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public int Idestabelecimento
        {
            get { return idestabelecimento; }
            set { idestabelecimento = value; }
        }

        public int Idfuncionario
        {
            get { return idfuncionario; }
            set { idfuncionario = value; }
        }
        #endregion
    }
}
