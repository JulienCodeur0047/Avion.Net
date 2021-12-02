using System;
using System.Collections.Generic;
using DALAvion.DataDomain;
using DALAvion.Domain;
using GnsNhibGenericDAL.DaoImplementation;
using GnsNhibGenericDAL.Interface;

namespace DALAvion.Interfaces
{

	public interface IDaoAvion : IEntityDao<Avion, Decimal>
	{
	    IList<Avion> ListerAvion();
	    Decimal ObtenirNbPlace(string pAvionCode);
	    Avion ObtenirAvion(String pAvionCode);
	}
}

	