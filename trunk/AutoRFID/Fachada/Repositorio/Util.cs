using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using PCampoBD;

namespace Fachada.Repositorio
{
    public class Util
    {
        public static String f_RetornaFiltroCad(String sFiltro, List<CampoBD> lsCampos)
        {
            String sSql = "";
            int iCont = 0;

            if (sFiltro != "")
            {

                foreach (CampoBD str in lsCampos)
                {
                    if (iCont == 0)
                    {
                        iCont = 1;
                        sSql = sSql + " WHERE ( ";
                    }
                    else
                    {
                        if (str.bFiltro == true){
                            sSql = sSql + " OR ";
                        }
                    };

                    if (str.bFiltro == true){
                        sSql = sSql + str.sNomeCampo + " LIKE '%" + sFiltro + "%'";
                    }
                }
                sSql = sSql + ")";
            }
            return sSql;
        }

        public static String f_RetornaSqlCampos(List<CampoBD> lsCampos)
        {
            String sSql = "";
            foreach (CampoBD str in lsCampos)
            {
                if (sSql != ""){
                sSql = sSql + ",";
                }
                sSql = sSql + str.sNomeCampo;
            }
            return sSql;
        }
    }
}
