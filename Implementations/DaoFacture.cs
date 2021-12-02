using System;
using System.Collections.Generic;
using DALAvion.Interfaces;
using GnsNhibGenericDAL.DaoImplementation;
using DALAvion.DataDomain;
using Spring.Transaction.Interceptor;

namespace DALAvion.Implementations
{
	public class DaoFacture : EntityDao<Facture, Decimal>, IDaoFacture
	{
        [Transaction(ReadOnly = true)]
        public decimal? ObtenirNbFicheAValider()
        {
            try
            {
                const string sqlSelect = "SELECT COUNT(*) NB " +
                                         "FROM AVV_DATA_FACTURE " +
                                         "WHERE SYS_VALIDE='N'";
                var sqlQuery = Session.CreateSQLQuery(sqlSelect);
                var tmp = sqlQuery.List()[0];
                return Convert.ToDecimal(tmp);
            }
            catch (Exception _exception)
            {
                Session.Clear();
                throw;
            }
        }
		
	}
}
