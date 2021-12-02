using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Proxy;
using GnsUserCollection.Implementation;
using GnsUserCollection.Interfaces;
using Common.Logging;
using GnsBusinessObjectBase.Implementations;
using DALAvion.DataDomain;

namespace DALAvion.DataDomain
{
    /// <summary>
    /// Imputation object for NHibernate mapped table AVV_DATA_IMPUTATION.
    /// </summary>
    [Serializable]
    public partial class  QueryImputation:EntityBase     {
			private string _id;

			private string _imputationcode;
	private string _imputationlibelle;


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


		
	public virtual string ImputationCode
	{
		get 
		{
			CheckSecurity("ImputationCode",PropertyAccess.Read,null);
			return _imputationcode;
		}
		set
		{
			CheckSecurity("ImputationCode",PropertyAccess.Write,value);
			if (value != _imputationcode)lock (_syncRoot)
			{
				_imputationcode=value;
				NotifyPropertyChanged("ImputationCode");
			}
		}
	}
	public virtual string ImputationLibelle
	{
		get 
		{
			CheckSecurity("ImputationLibelle",PropertyAccess.Read,null);
			return _imputationlibelle;
		}
		set
		{
			CheckSecurity("ImputationLibelle",PropertyAccess.Write,value);
			if (value != _imputationlibelle)lock (_syncRoot)
			{
				_imputationlibelle=value;
				NotifyPropertyChanged("ImputationLibelle");
			}
		}
	}

		
			
		
		#region criteria
			public override DetachedCriteria BuildCriteria()
{
	DetachedCriteria _mainquery= base.BuildCriteria();
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
		public QueryImputation()
				 : base(typeof(Imputation))
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
            QueryImputation castObj = obj as QueryImputation;
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