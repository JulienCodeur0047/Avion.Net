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
    /// Aeroport object for NHibernate mapped table AVV_DATA_AEROPORT.
    /// </summary>
    [Serializable]
    public partial class  Aeroport:EntityBase     {
			private Decimal? _id;

			private String _aeroportcode;
	private String _aeroportlibelle;


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

		
public virtual String AeroportCode
	{
		get 
		{
			CheckSecurity("AeroportCode",PropertyAccess.Read,null);
			return _aeroportcode;
		}
		set
		{
			CheckSecurity("AeroportCode",PropertyAccess.Write,value);
			if (value != _aeroportcode)lock (_syncRoot)
			{
				_aeroportcode=value;
				NotifyPropertyChanged("AeroportCode");
			}
		}
	}
	public virtual String AeroportLibelle
	{
		get 
		{
			CheckSecurity("AeroportLibelle",PropertyAccess.Read,null);
			return _aeroportlibelle;
		}
		set
		{
			CheckSecurity("AeroportLibelle",PropertyAccess.Write,value);
			if (value != _aeroportlibelle)lock (_syncRoot)
			{
				_aeroportlibelle=value;
				NotifyPropertyChanged("AeroportLibelle");
			}
		}
	}
	
		
			
		

	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryAeroport  _queryobject= new QueryAeroport();
	return _queryobject;
}
        #endregion		
        #region Constructors
		public Aeroport()
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
            Aeroport castObj = obj as Aeroport;
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