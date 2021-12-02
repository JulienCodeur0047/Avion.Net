using System;
using System.Collections.Generic;
using DALAvion.Interfaces;
using GnsNhibGenericDAL.DaoImplementation;
using DALAvion.DataDomain;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace DALAvion.Implementations
{
	public class DaoVolHdr : EntityDao<VolHdr, Decimal>, IDaoVolHdr
	{
        [Transaction(ReadOnly = true)]
	    public decimal? ObtenirNbFicheAValider()
	    {
            try
            {
                const string sqlSelect = "SELECT COUNT(*) NB " +
                                         "FROM AVV_DATA_VOL_HDR " +
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
         [Transaction(ReadOnly = true)]
	    public IList<VolHdr> ListerVolHdr(DateTime pDateDebut, DateTime pDateFin)
	    {
            DetachedCriteria dc = DetachedCriteria.For<VolHdr>()
                .CreateAlias("FournisseurRef", "FournisseurRef")
                .Add(Restrictions.Ge("HdrDate", pDateDebut))
                .Add(Restrictions.Le("HdrDate", pDateFin));
            ICriteria cr = dc.GetExecutableCriteria(Session);
            return cr.List<VolHdr>();
	    }

	    [Transaction(ReadOnly = true)]
	    public IList<VolHdr> ListerVolHdr(decimal pIdFournisseur, DateTime pDateDebut, DateTime pDateFin)
	    {
            DetachedCriteria dc = DetachedCriteria.For<VolHdr>()
                .Add(Restrictions.Eq("FournisseurRef.Id", pIdFournisseur))
                .Add(Restrictions.Ge("HdrDate", pDateDebut))
                .Add(Restrictions.Le("HdrDate", pDateFin));
            ICriteria cr = dc.GetExecutableCriteria(Session);
            return cr.List<VolHdr>();
	    }

        [Transaction(ReadOnly = true)]
        public decimal ObtenirTotalHeures(Decimal pIdFournisseur, DateTime pDateDebut, DateTime pDateFin)
	    {
            try
            {
                const string sqlSelect = "SELECT SUM(NVL(DUREE_MN_01,0)+NVL(DUREE_MN_02,0)) TOTAL " +
                                         "FROM AVV_DATA_VOL_HDR " +
                                         "WHERE HDR_DATE BETWEEN :parDateDebut AND :parDateFin AND ID_FOURNISSEUR = :parIdFournisseur";
                var sqlQuery = Session.CreateSQLQuery(sqlSelect);
                sqlQuery.SetParameter("parDateDebut", pDateDebut);
                sqlQuery.SetParameter("parDateFin", pDateFin);
                sqlQuery.SetParameter("parIdFournisseur", pIdFournisseur);
                var tmp = sqlQuery.List()[0];
                return Decimal.Round(Convert.ToDecimal(tmp)/60);
            }
            catch (Exception _exception)
            {
                Session.Clear();
                throw;
            }
	    }
	}
}
