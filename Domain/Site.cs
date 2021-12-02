using System;
using System.ComponentModel;
using GnsBusinessObjectBase.Implementations;
using GnsUserCollection.Implementation;
using GnsUserCollection.Interfaces;
using NHibernate.Proxy;

namespace DALAvion.Domain
{
    /// <summary>
    /// Site object for NHibernate mapped table AVV_DATA_SITE.
    /// </summary>
    [Serializable]
    public partial class  Site:EntityBase     {
			private Decimal? _id;

			private String _sitecode;
	private String _sitelibelle;


		#region InRef
		
		#endregion
		#region Outref

		#endregion
		public virtual Decimal? Id
{
	get 
	{
		CheckSecurity("Id",PropertyAccess.Read,null);
		return _id;
	}
}

		
public virtual String SiteCode
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
	public virtual String SiteLibelle
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
	


	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QuerySite  _queryobject= new QuerySite();
	return _queryobject;
}
        #endregion		
        #region Constructors
		public Site()
        {
            
            
        }
        #endregion  
		#region Equals and GetHashCode override
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
            Site castObj = obj as Site;
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