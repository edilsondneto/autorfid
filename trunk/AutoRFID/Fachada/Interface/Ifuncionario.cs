using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    public interface Ifuncionario
    {
        void InserirFuncionario(Funcionario f);
        void AlterarFuncionario(Funcionario f);
        void ExcluirFuncionario(String cpf);
        void ExcluirFuncionario(int idfuncionario);
        Funcionario ConsultarFuncionario(String cpf);
        Funcionario ConsultarFuncionario(int idfuncionario);
        DataSet ListarFuncionario(String sFiltro, List<CampoBD> lsCampos);
        DataSet ListarFuncionario();
    }
}
