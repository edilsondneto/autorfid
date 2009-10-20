using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;
using System.Data;


namespace Fachada.Controlador
{
    public class ControladorEtiquetaAssociado : IEtiquetaAssociado
    {
        private RepositorioEtiqAssociado repositorioEtiqAssociado;

        public ControladorEtiquetaAssociado()
        {
            this.repositorioEtiqAssociado = new RepositorioEtiqAssociado();
        }

        #region IetiquetaAssociado Members

        public void InserirEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            EtiquetaAssociado consultaEtiquetaAsso = repositorioEtiqAssociado.ConsultarEtiquetaAssociado(etiquetaAssociado.CodigoEtiqueta);

            if (consultaEtiquetaAsso.CodigoEtiqueta != null)
                throw new Exception("Código já Existe.");
            else
                repositorioEtiqAssociado.InserirEtiquetaAssociado(etiquetaAssociado);
        }

        public void AlterarEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            EtiquetaAssociado consultaEtiquetaAsso = repositorioEtiqAssociado.ConsultarEtiquetaAssociado(etiquetaAssociado.CodigoEtiqueta);

            if (consultaEtiquetaAsso.CodigoEtiqueta == null)
            {
                throw new Exception("Etiqueta Inexistente!");
            }
            else
            {
                repositorioEtiqAssociado.AlterarEtiquetaAssociado(etiquetaAssociado);
            }

        }

        public void ExcluirEtiquetaAssociado(String codigo)
        {
            EtiquetaAssociado consulta = repositorioEtiqAssociado.ConsultarEtiquetaAssociado(codigo);

            if (consulta.CodigoEtiqueta != null)
                repositorioEtiqAssociado.ExcluirEtiquetaAssociado(codigo);
            else
                throw new Exception("Etiqueta inexistente");

        }

        public EtiquetaAssociado ConsultarEtiquetaAssociado(String codigoetiqueta)
        {
            EtiquetaAssociado consulta = repositorioEtiqAssociado.ConsultarEtiquetaAssociado(codigoetiqueta);

            if (consulta.CodigoEtiqueta == null)
            {
                throw new Exception("Etiqueta inexistente");
            }

            return consulta;

        }

        public DataSet ListarEtiquetaAssociado()
        {
            return repositorioEtiqAssociado.ListarEtiquetaAssociado();
        }

        public DataSet ListarEtiquetaAssociado(int idAssociado)
        {
            return repositorioEtiqAssociado.ListarEtiquetaAssociado(idAssociado);
        }

        public DataSet ListarEtiquetaAssociado(string situacao)
        {
            return this.repositorioEtiqAssociado.ListarEtiquetaAssociado(situacao);
        }

        public DataSet ListarEtiquetaAssociado(string sFiltro, List<CampoBD> lsCampos)
        {
            return this.repositorioEtiqAssociado.ListarEtiquetaAssociado(sFiltro,lsCampos);
        }

        #endregion

    }
}
