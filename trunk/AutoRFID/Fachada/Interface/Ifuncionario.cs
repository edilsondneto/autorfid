﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;

namespace Fachada.Interface
{
    public interface Ifuncionario
    {
        void InserirFuncionario(Funcionario f);
        void AlterarFuncionario(Funcionario f);
        void ExcluirFuncionario(int codigo);
        Funcionario ConsultarFuncionario(Funcionario f);
        List<Funcionario> ListarFuncionario();
    }
}