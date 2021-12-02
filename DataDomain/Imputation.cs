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
    public partial class  Imputation:EntityBase     {
			private Decimal? _id;

			private String _imputationcode;
	private String _imputationlibelle;


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

		
public virtual String ImputationCode
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
	public virtual String ImputationLibelle
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
	
		
			
		

	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryImputation  _queryobject= new QueryImputation();
	return _queryobject;
}
        #endregion		
        #region Constructors
		public Imputation()
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
            Imputation castObj = obj as Imputation;
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