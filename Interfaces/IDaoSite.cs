using System;
using System.Collections.Generic;
using DALAvion.Domain;
using GnsNhibGenericDAL.DaoImplementation;
using GnsNhibGenericDAL.Interface;

namespace DALAvion.Interfaces
{

	public interface IDaoSite : IEntityDao<Site, Decimal>
	{
	    IList<Site> ListerSite();

	    Site FindSiteByLibelle(string pLibelle);
	}
}

	