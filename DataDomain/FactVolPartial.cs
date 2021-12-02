using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALAvion.DataDomain
{
    public partial class FactVol
    {
        public virtual Decimal DurreVol
        {
            get
            {
                if (this.VolHdrRef != null && this.VolConcerne=="O")
                    return VolHdrRef.DureeVol;
                return 0;
            }
        }
    }
}
