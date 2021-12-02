using System;
using System.Collections.Generic;
using System.Linq;
using DALAvion.DataDomain;
using DALAvion.Domain;
using DALAvion.Interfaces;
using GnsNhibGenericDAL.DaoImplementation;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Util;
using Spring.Transaction.Interceptor;

namespace DALAvion.Implementations
{
	public class DaoAvion : EntityDao<Avion, Decimal>, IDaoAvion
	{
        [Transaction (ReadOnly = true)]
	    public IList<Avion> ListerAvion()
	    {
	        DetachedCriteria cr = DetachedCriteria.For<Avion>()
                .AddOrder(Order.Desc("Id"));
	        ICriteria _result = cr.GetExecutableCriteria(Session);
	        
            return _result.List<Avion>();
	    }

	    public decimal ObtenirNbPlace(string pAvionCode)
	    {
	        DetachedCriteria _dc = DetachedCriteria.For<Avion>()
	            .Add(Restrictions.Eq("AvionCode", pAvionCode));
	        ICriteria _cr = _dc.GetExecutableCriteria(Session);
	        var _listAvion = _cr.List<Avion>();
	        var _avionNbPlace = _listAvion.First().AvionNbPlace;
	        if (_avionNbPlace != null) return (decimal) _avionNbPlace;
	        return 0;
	    }

	    public Avion ObtenirAvion(string pAvionCode)
	    {
            DetachedCriteria _dc = DetachedCriteria.For<Avion>()
                .Add(Restrictions.Eq("AvionCode", pAvionCode));
            ICriteria _cr = _dc.GetExecutableCriteria(Session);
	        if (_cr.List().Count > 0)
	            return _cr.List<Avion>()[0];
	        return null;
	    }
	}
}
