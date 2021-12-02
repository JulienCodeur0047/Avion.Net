using System;
using System.Collections.Generic;
using GnsNhibGenericDAL.DaoImplementation;
using GnsNhibGenericDAL.Interface;
using DALAvion.DataDomain;
namespace DALAvion.Interfaces
{

	public interface IDaoVolHdr : IEntityDao<VolHdr, Decimal>
	{
	    Decimal? ObtenirNbFicheAValider();
	    IList<VolHdr> ListerVolHdr( DateTime pDateDebut, DateTime pDateFin);
        IList<VolHdr> ListerVolHdr(Decimal pIdFournisseur, DateTime pDateDebut, DateTime pDateFin);
        Decimal ObtenirTotalHeures(Decimal pFournisseurId, DateTime pDateDebut, DateTime pDateFin);
	}
}

	