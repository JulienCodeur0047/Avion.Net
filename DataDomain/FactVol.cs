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
    public partial class  FactVol:EntityBase     {
			private Decimal? _id;

        private String _volconcerne;
			private Decimal _montant;


		#region InRef
				private Facture _factureref;
		private VolHdr _volhdrref;

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

        public virtual void setMontant(Decimal? pMontant)
        {
            _montant = decimal.Round(pMontant.GetValueOrDefault(0));
        }
public virtual Decimal Montant
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



			
		

	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryFactVol  _queryobject= new QueryFactVol();
	return _queryobject;
}
        #endregion		
        #region Constructors
		public FactVol()
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
            FactVol castObj = obj as FactVol;
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