using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALAvion.DataDomain
{
    public partial class VolHdr
    {
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", HdrDate.ToShortDateString(), HdrTypeVol, AeroportDepart, AeroportDestination, HeureDecolage);
        }

        public virtual Decimal DureeVol
        {
            get { return DureeMn01.GetValueOrDefault(0) + DureeMn02.GetValueOrDefault(0); }
        }

        private Decimal _coutvol;
        public virtual Decimal CoutVol
        {
            get { return _coutvol; }
            set { _coutvol = value; }
        }
    }

    public partial class QueryVolHdr
    {

        private String _coutvol;
        public virtual String CoutVol
        {
            get { return null; }
        }
    }
}
