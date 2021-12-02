using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALAvion.DataDomain
{
    public partial class Fournisseur
    {
        public override string ToString()
        {
            return String.Format("[{0}] {1}", FrnsCode,FrnsDesignation);
        }
    }
}
