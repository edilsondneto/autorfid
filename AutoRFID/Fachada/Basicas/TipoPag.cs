using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    class TipoPag
    {
        private int idTipoPag;
        private String strTipoPag;

        public int IdTipoPag { 
            get { return idTipoPag; }
            set { idTipoPag = value; }
        }
        public String StrTipoPag
        {
            get { return strTipoPag; }
            set { strTipoPag = value; }
        }
    public TipoPag() { 
        }
    }
}
