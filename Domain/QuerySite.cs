using System;
using System.Collections;
using System.Collections.Generic;
using GnsBusinessObjectBase.Implementations;
using NHibernate.Criterion;
using NHibernate.Proxy;

namespace DALAvion.Domain
{
    /// <summary>
    /// Site object for NHibernate mapped table AVV_DATA_SITE.
    /// </summary>
    [Serializable]
    public partial class  QuerySite:EntityBase     {
			private string _id;

			private string _sitecode;
	private string _sitelibelle;


		#region InRef
		
		#endregion
		#region Outref

		#endregion
		public virtual string Id
{
	get 
	{
		CheckSecurity("Id",PropertyAccess.Read,null);
		return _id;
	}
	set
	{
		CheckSecurity("Id",PropertyAccess.Write,value);
		if (value != _id)
		{
			_id = value;
			NotifyPropertyChanged("Id");
		}
	}
}


		
	public virtual string SiteCode
	{
		get 
		{
			CheckSecurity("SiteCode",PropertyAccess.Read,null);
			return _sitecode;
		}
		set
		{
			CheckSecurity("SiteCode",PropertyAccess.Write,value);
			if (value != _sitecode)lock (_syncRoot)
			{
				_sitecode=value;
				NotifyPropertyChanged("SiteCode");
			}
		}
	}
	public virtual string SiteLibelle
	{
		get 
		{
			CheckSecurity("SiteLibelle",PropertyAccess.Read,null);
			return _sitelibelle;
		}
		set
		{
			CheckSecurity("SiteLibelle",PropertyAccess.Write,value);
			if (value != _sitelibelle)lock (_syncRoot)
			{
				_sitelibelle=value;
				NotifyPropertyChanged("SiteLibelle");
			}
		}
	}

	

		#region criteria
			public override DetachedCriteria BuildCriteria()
{
	DetachedCriteria _subqueryVol=null;
	
		if ( _subqueryVol== null )
			return base.BuildCriteria();
		DetachedCriteria _mainquery= base.BuildCriteria();
		if (_mainquery == null)
			_mainquery=DetachedCriteria.For<Site>();
		if (_mainquery != null)
		{
			if (_subqueryVol !=null)
			{
				_subqueryVol.SetProjection(Projections.Property("SiteImputationRef"));
				_mainquery.Add(Subqueries.PropertyIn("Id", _subqueryVol));
			}
		}
return _mainquery;
}
		#endregion

	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
return null;
}
        #endregion		
        #region Constructors
		public QuerySite()
				 : base(typeof(Site))
        {
                       
        }
		#endregion
		#region
		  public override int GetHashCode()
        {
            if (Id == null)
                return base.GetHashCode();
            int hash = 57;
            hash = 27 * hash * _id.GetHashCode();
            return hash;
        }
        private Type GetUnproxiedType()
        {
            return GetType();
        }
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            Type _type1 = this.GetType();
            Type _type2 = NHibernateProxyHelper.GetClassWithoutInitializingProxy(obj);
           
            if ((obj == null) || (! _type1.Equals(_type2))) return false;
            QuerySite castObj = obj as QuerySite;
            if (castObj == null) return false;
            if (_id == null && castObj.Id == null)
                return GetHashCode() == castObj.GetHashCode();
            return _id == castObj.Id;
        }
        #endregion Equals and GetHashCode override

        #region Override EntityBase
       
        public override void Clear()
        {
            base.Clear();
            if (IsTransient)
            {
                _id = null;
            }
        }
		#endregion
    }
}