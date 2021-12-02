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
    /// FactVol object for NHibernate mapped table AVV_DATA_FACT_VOL.
    /// </summary>
    [Serializable]
    public partial class  QueryFactVol:EntityBase     {
			private string _id;
            private String _volconcerne;
			private string _montant;


		#region InRef
				private Facture _factureref;
		private VolHdr _volhdrref;

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


        public virtual String VolConcerne
        {
            get
            {
                CheckSecurity("VolConcerne", PropertyAccess.Read, null);
                return _volconcerne;
            }
            set
            {
                CheckSecurity("VolConcerne", PropertyAccess.Write, value);
                if (value != _volconcerne) lock (_syncRoot)
                    {
                        _volconcerne = value;
                        NotifyPropertyChanged("VolConcerne");
                    }
            }
        }
	public virtual string Montant
	{
		get 
		{
			CheckSecurity("Montant",PropertyAccess.Read,null);
			return _montant;
		}
		set
		{
			CheckSecurity("Montant",PropertyAccess.Write,value);
			if (value != _montant)lock (_syncRoot)
			{
				_montant=value;
				NotifyPropertyChanged("Montant");
			}
		}
	}

			public virtual Facture FactureRef
	{
		get
		{
			CheckSecurity("FactureRef",PropertyAccess.Read,null);
			return _factureref;
		}
		
		set
			{
				CheckSecurity("FactureRef",PropertyAccess.Write,value);
				if (value != _factureref)
				{
					_factureref = value;
					NotifyPropertyChanged("FactureRef");
				}
			}
	}


	public virtual VolHdr VolHdrRef
	{
		get
		{
			CheckSecurity("VolHdrRef",PropertyAccess.Read,null);
			return _volhdrref;
		}
		
		set
			{
				CheckSecurity("VolHdrRef",PropertyAccess.Write,value);
				if (value != _volhdrref)
				{
					_volhdrref = value;
					NotifyPropertyChanged("VolHdrRef");
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
		public QueryFactVol()
				 : base(typeof(FactVol))
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
            QueryFactVol castObj = obj as QueryFactVol;
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