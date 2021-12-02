using System;
using System.Collections.Generic;
using DALAvion.Domain;
using DALAvion.Interfaces;
using GnsNhibGenericDAL.DaoImplementation;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace DALAvion.Implementations
{
	public class DaoSite : EntityDao<Site, Decimal>, IDaoSite
	{
        [Transaction (ReadOnly = true)]
	    public IList<Site> ListerSite()
	    {
	        DetachedCriteria criteria = DetachedCriteria.For<Site>()
                .AddOrder(Order.Desc("SiteCode"));
	        ICriteria cr = criteria.GetExecutableCriteria(Session);
	        var _result = cr.List<Site>();
	        return _result;

	    }

        [Transaction(ReadOnly = true)]
	    public Site FindSiteByLibelle(string pLibelle)
	    {
            DetachedCriteria dc = DetachedCriteria.For<Site>()
                .Add(Restrictions.Eq("SiteCode",pLibelle));
            ICriteria criteria = dc.GetExecutableCriteria(Session);
            IList<Site> tmp = criteria.List<Site>();
            if (tmp.Count == 0)
                return null;
            if (tmp.Count == 1)
                return tmp[0];
            throw new ApplicationException("site introuvable");
	    }
	}
}
