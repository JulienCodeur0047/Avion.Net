using System;
using System.Collections.Generic;
using GnsNhibGenericDAL.DaoImplementation;
using GnsNhibGenericDAL.Interface;
using DALAvion.DataDomain;
namespace DALAvion.Interfaces
{

	public interface IDaoAeroport : IEntityDao<Aeroport, Decimal>
	{
	}
}

	