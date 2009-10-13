using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCampoBD
{
    public class CampoBD
    {
        public String sNomeCampo;
        public String sDescricaoCampo;
        public Boolean bFiltro;
        public int iTamColuna;

        public CampoBD(String sNomeCampo, String sDescricaoCampo, Boolean bFiltro, int iTamColuna)
        {
            this.sNomeCampo = sNomeCampo;
            this.sDescricaoCampo = sDescricaoCampo;
            this.bFiltro = bFiltro;
            this.iTamColuna = iTamColuna;
        }
    }
}
