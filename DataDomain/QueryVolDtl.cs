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
    /// VolDtl object for NHibernate mapped table AVV_DATA_VOL_DTL.
    /// </summary>
    [Serializable]
    public partial class  QueryVolDtl:EntityBase     {
			private string _id;

			private string _imputationcode;
            private string _imputationpourcentage;
	private string _dtlnbplacedisponible;
	private string _dtlnbplacecadre;
	private string _dtlnbplacenoncadre;
	private string _dtlnbplacemissionnaire;
	private string _dtlnbplacevisiteur;
	private string _dtlnbplacefamille;
    private string _dtlnbplaceautres;
	private string _dtlchargekgdisponible;
	private string _dtlchargekgutilise;
	private string _dtlobservation;


		#region InRef
				private VolHdr _hdrref;

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

    public virtual string ImputationPourcentage
    {
        get
        {
            CheckSecurity("ImputationPourcentage", PropertyAccess.Read, null);
            return _imputationpourcentage;
        }
        set
        {
            CheckSecurity("ImputationPourcentage", PropertyAccess.Write, value);
            if (value != _imputationpourcentage) lock (_syncRoot)
                {
                    _imputationpourcentage = value;
                    NotifyPropertyChanged("ImputationPourcentage");
                }
        }
    }
	public virtual string DtlNbPlaceDisponible
	{
		get 
		{
			CheckSecurity("DtlNbPlaceDisponible",PropertyAccess.Read,null);
			return _dtlnbplacedisponible;
		}
		set
		{
			CheckSecurity("DtlNbPlaceDisponible",PropertyAccess.Write,value);
			if (value != _dtlnbplacedisponible)lock (_syncRoot)
			{
				_dtlnbplacedisponible=value;
				NotifyPropertyChanged("DtlNbPlaceDisponible");
			}
		}
	}
	public virtual string DtlNbPlaceCadre
	{
		get 
		{
			CheckSecurity("DtlNbPlaceCadre",PropertyAccess.Read,null);
			return _dtlnbplacecadre;
		}
		set
		{
			CheckSecurity("DtlNbPlaceCadre",PropertyAccess.Write,value);
			if (value != _dtlnbplacecadre)lock (_syncRoot)
			{
				_dtlnbplacecadre=value;
				NotifyPropertyChanged("DtlNbPlaceCadre");
			}
		}
	}
	public virtual string DtlNbPlaceNonCadre
	{
		get 
		{
			CheckSecurity("DtlNbPlaceNonCadre",PropertyAccess.Read,null);
			return _dtlnbplacenoncadre;
		}
		set
		{
			CheckSecurity("DtlNbPlaceNonCadre",PropertyAccess.Write,value);
			if (value != _dtlnbplacenoncadre)lock (_syncRoot)
			{
				_dtlnbplacenoncadre=value;
				NotifyPropertyChanged("DtlNbPlaceNonCadre");
			}
		}
	}
	public virtual string DtlNbPlaceMissionnaire
	{
		get 
		{
			CheckSecurity("DtlNbPlaceMissionnaire",PropertyAccess.Read,null);
			return _dtlnbplacemissionnaire;
		}
		set
		{
			CheckSecurity("DtlNbPlaceMissionnaire",PropertyAccess.Write,value);
			if (value != _dtlnbplacemissionnaire)lock (_syncRoot)
			{
				_dtlnbplacemissionnaire=value;
				NotifyPropertyChanged("DtlNbPlaceMissionnaire");
			}
		}
	}
	public virtual string DtlNbPlaceVisiteur
	{
		get 
		{
			CheckSecurity("DtlNbPlaceVisiteur",PropertyAccess.Read,null);
			return _dtlnbplacevisiteur;
		}
		set
		{
			CheckSecurity("DtlNbPlaceVisiteur",PropertyAccess.Write,value);
			if (value != _dtlnbplacevisiteur)lock (_syncRoot)
			{
				_dtlnbplacevisiteur=value;
				NotifyPropertyChanged("DtlNbPlaceVisiteur");
			}
		}
	}
	public virtual string DtlNbPlaceFamille
	{
		get 
		{
			CheckSecurity("DtlNbPlaceFamille",PropertyAccess.Read,null);
			return _dtlnbplacefamille;
		}
		set
		{
			CheckSecurity("DtlNbPlaceFamille",PropertyAccess.Write,value);
			if (value != _dtlnbplacefamille)lock (_syncRoot)
			{
				_dtlnbplacefamille=value;
				NotifyPropertyChanged("DtlNbPlaceFamille");
			}
		}
	}

    public virtual string DtlNbPlaceAutres
    {
        get
        {
            CheckSecurity("DtlNbPlaceAutres", PropertyAccess.Read, null);
            return _dtlnbplaceautres;
        }
        set
        {
            CheckSecurity("DtlNbPlaceAutres", PropertyAccess.Write, value);
            if (value != _dtlnbplaceautres) lock (_syncRoot)
            {
                _dtlnbplaceautres = value;
                NotifyPropertyChanged("DtlNbPlaceAutres");
            }
        }
    }

	public virtual string DtlChargeKgDisponible
	{
		get 
		{
			CheckSecurity("DtlChargeKgDisponible",PropertyAccess.Read,null);
			return _dtlchargekgdisponible;
		}
		set
		{
			CheckSecurity("DtlChargeKgDisponible",PropertyAccess.Write,value);
			if (value != _dtlchargekgdisponible)lock (_syncRoot)
			{
				_dtlchargekgdisponible=value;
				NotifyPropertyChanged("DtlChargeKgDisponible");
			}
		}
	}
	public virtual string DtlChargeKgUtilise
	{
		get 
		{
			CheckSecurity("DtlChargeKgUtilise",PropertyAccess.Read,null);
			return _dtlchargekgutilise;
		}
		set
		{
			CheckSecurity("DtlChargeKgUtilise",PropertyAccess.Write,value);
			if (value != _dtlchargekgutilise)lock (_syncRoot)
			{
				_dtlchargekgutilise=value;
				NotifyPropertyChanged("DtlChargeKgUtilise");
			}
		}
	}
	public virtual string DtlObservation
	{
		get 
		{
			CheckSecurity("DtlObservation",PropertyAccess.Read,null);
			return _dtlobservation;
		}
		set
		{
			CheckSecurity("DtlObservation",PropertyAccess.Write,value);
			if (value != _dtlobservation)lock (_syncRoot)
			{
				_dtlobservation=value;
				NotifyPropertyChanged("DtlObservation");
			}
		}
	}

			public virtual VolHdr HdrRef
	{
		get
		{
			CheckSecurity("HdrRef",PropertyAccess.Read,null);
			return _hdrref;
		}
		
		set
			{
				CheckSecurity("HdrRef",PropertyAccess.Write,value);
				if (value != _hdrref)
				{
					_hdrref = value;
					NotifyPropertyChanged("HdrRef");
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
		public QueryVolDtl()
				 : base(typeof(VolDtl))
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
            QueryVolDtl castObj = obj as QueryVolDtl;
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