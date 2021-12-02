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
    /// VolHdr object for NHibernate mapped table AVV_DATA_VOL_HDR.
    /// </summary>
    [Serializable]
    public partial class  QueryVolHdr:EntityBase     {
			private string _id;

			private string _hdrdate;
	private string _avioncode;
	private string _hdrtypevol;

    private string _hdrnbplace;
    private string _hdrcharge;


	private string _hdrregulier;
	private string _aeroportdepart;
	private string _aeroportdestination;
	private string _aeroportescale;
	private string _heuredecolage;
	private string _dureemn01;
	private string _dureemn02;
	private string _hdrobservation;
	private string _sysvalide;
	private string _sysvalidedate;
	private string _sysvalideoperateur;


		#region InRef
    private Fournisseur _fournisseurref;
		
		#endregion
		#region Outref
				private IList _listvoldtlhdr;
                private IList _listvolpassagerhdr;
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


		
	public virtual string HdrDate
	{
		get 
		{
			CheckSecurity("HdrDate",PropertyAccess.Read,null);
			return _hdrdate;
		}
		set
		{
			CheckSecurity("HdrDate",PropertyAccess.Write,value);
			if (value != _hdrdate)lock (_syncRoot)
			{
				_hdrdate=value;
				NotifyPropertyChanged("HdrDate");
			}
		}
	}
	public virtual string AvionCode
	{
		get 
		{
			CheckSecurity("AvionCode",PropertyAccess.Read,null);
			return _avioncode;
		}
		set
		{
			CheckSecurity("AvionCode",PropertyAccess.Write,value);
			if (value != _avioncode)lock (_syncRoot)
			{
				_avioncode=value;
				NotifyPropertyChanged("AvionCode");
			}
		}
	}
	public virtual string HdrTypeVol
	{
		get 
		{
			CheckSecurity("HdrTypeVol",PropertyAccess.Read,null);
			return _hdrtypevol;
		}
		set
		{
			CheckSecurity("HdrTypeVol",PropertyAccess.Write,value);
			if (value != _hdrtypevol)lock (_syncRoot)
			{
				_hdrtypevol=value;
				NotifyPropertyChanged("HdrTypeVol");
			}
		}
	}

    public virtual string HdrNbPlace
    {
        get
        {
            CheckSecurity("HdrNbPlace", PropertyAccess.Read, null);
            return _hdrnbplace;
        }
        set
        {
            CheckSecurity("HdrNbPlace", PropertyAccess.Write, value);
            if (value != _hdrnbplace) lock (_syncRoot)
                {
                    _hdrnbplace = value;
                    NotifyPropertyChanged("HdrNbPlace");
                }
        }
    }

    public virtual string HdrCharge
    {
        get
        {
            CheckSecurity("HdrCharge", PropertyAccess.Read, null);
            return _hdrcharge;
        }
        set
        {
            CheckSecurity("HdrCharge", PropertyAccess.Write, value);
            if (value != _hdrcharge) lock (_syncRoot)
                {
                    _hdrcharge = value;
                    NotifyPropertyChanged("HdrCharge");
                }
        }
    }

	public virtual string HdrRegulier
	{
		get 
		{
			CheckSecurity("HdrRegulier",PropertyAccess.Read,null);
			return _hdrregulier;
		}
		set
		{
			CheckSecurity("HdrRegulier",PropertyAccess.Write,value);
			if (value != _hdrregulier)lock (_syncRoot)
			{
				_hdrregulier=value;
				NotifyPropertyChanged("HdrRegulier");
			}
		}
	}
	public virtual string AeroportDepart
	{
		get 
		{
			CheckSecurity("AeroportDepart",PropertyAccess.Read,null);
			return _aeroportdepart;
		}
		set
		{
			CheckSecurity("AeroportDepart",PropertyAccess.Write,value);
			if (value != _aeroportdepart)lock (_syncRoot)
			{
				_aeroportdepart=value;
				NotifyPropertyChanged("AeroportDepart");
			}
		}
	}
	public virtual string AeroportDestination
	{
		get 
		{
			CheckSecurity("AeroportDestination",PropertyAccess.Read,null);
			return _aeroportdestination;
		}
		set
		{
			CheckSecurity("AeroportDestination",PropertyAccess.Write,value);
			if (value != _aeroportdestination)lock (_syncRoot)
			{
				_aeroportdestination=value;
				NotifyPropertyChanged("AeroportDestination");
			}
		}
	}
	public virtual string AeroportEscale
	{
		get 
		{
			CheckSecurity("AeroportEscale",PropertyAccess.Read,null);
			return _aeroportescale;
		}
		set
		{
			CheckSecurity("AeroportEscale",PropertyAccess.Write,value);
			if (value != _aeroportescale)lock (_syncRoot)
			{
				_aeroportescale=value;
				NotifyPropertyChanged("AeroportEscale");
			}
		}
	}
	public virtual string HeureDecolage
	{
		get 
		{
			CheckSecurity("HeureDecolage",PropertyAccess.Read,null);
			return _heuredecolage;
		}
		set
		{
			CheckSecurity("HeureDecolage",PropertyAccess.Write,value);
			if (value != _heuredecolage)lock (_syncRoot)
			{
				_heuredecolage=value;
				NotifyPropertyChanged("HeureDecolage");
			}
		}
	}
	public virtual string DureeMn01
	{
		get 
		{
			CheckSecurity("DureeMn01",PropertyAccess.Read,null);
			return _dureemn01;
		}
		set
		{
			CheckSecurity("DureeMn01",PropertyAccess.Write,value);
			if (value != _dureemn01)lock (_syncRoot)
			{
				_dureemn01=value;
				NotifyPropertyChanged("DureeMn01");
			}
		}
	}
	public virtual string DureeMn02
	{
		get 
		{
			CheckSecurity("DureeMn02",PropertyAccess.Read,null);
			return _dureemn02;
		}
		set
		{
			CheckSecurity("DureeMn02",PropertyAccess.Write,value);
			if (value != _dureemn02)lock (_syncRoot)
			{
				_dureemn02=value;
				NotifyPropertyChanged("DureeMn02");
			}
		}
	}
	public virtual string HdrObservation
	{
		get 
		{
			CheckSecurity("HdrObservation",PropertyAccess.Read,null);
			return _hdrobservation;
		}
		set
		{
			CheckSecurity("HdrObservation",PropertyAccess.Write,value);
			if (value != _hdrobservation)lock (_syncRoot)
			{
				_hdrobservation=value;
				NotifyPropertyChanged("HdrObservation");
			}
		}
	}
	public virtual string SysValide
	{
		get 
		{
			CheckSecurity("SysValide",PropertyAccess.Read,null);
			return _sysvalide;
		}
		set
		{
			CheckSecurity("SysValide",PropertyAccess.Write,value);
			if (value != _sysvalide)lock (_syncRoot)
			{
				_sysvalide=value;
				NotifyPropertyChanged("SysValide");
			}
		}
	}
	public virtual string SysValideDate
	{
		get 
		{
			CheckSecurity("SysValideDate",PropertyAccess.Read,null);
			return _sysvalidedate;
		}
		set
		{
			CheckSecurity("SysValideDate",PropertyAccess.Write,value);
			if (value != _sysvalidedate)lock (_syncRoot)
			{
				_sysvalidedate=value;
				NotifyPropertyChanged("SysValideDate");
			}
		}
	}
	public virtual string SysValideOperateur
	{
		get 
		{
			CheckSecurity("SysValideOperateur",PropertyAccess.Read,null);
			return _sysvalideoperateur;
		}
		set
		{
			CheckSecurity("SysValideOperateur",PropertyAccess.Write,value);
			if (value != _sysvalideoperateur)lock (_syncRoot)
			{
				_sysvalideoperateur=value;
				NotifyPropertyChanged("SysValideOperateur");
			}
		}
	}

    public virtual Fournisseur FournisseurRef
    {
        get
        {
            CheckSecurity("FournisseurRef", PropertyAccess.Read, null);
            return _fournisseurref;
        }

        set
        {
            CheckSecurity("FournisseurRef", PropertyAccess.Write, value);
            if (value != _fournisseurref)
            {
                _fournisseurref = value;
                NotifyPropertyChanged("FournisseurRef");
            }
        }
    }
			
			public virtual  IList   ListVolDtlHdr
	{
		get
		{
			
			if (_listvoldtlhdr == null)
			{
				_listvoldtlhdr=new List<QueryVolDtl>();
				
			}
			return _listvoldtlhdr;			
		}
		set
		{
			_listvoldtlhdr=value;
		}
	}

            public virtual IList ListVolPassagerHdr
            {
                get
                {

                    if (_listvolpassagerhdr == null)
                    {
                        _listvolpassagerhdr = new List<QueryVolPassager>();

                    }
                    return _listvolpassagerhdr;
                }
                set
                {
                    _listvolpassagerhdr = value;
                }
            }

		#region criteria
			public override DetachedCriteria BuildCriteria()
{
	DetachedCriteria _subqueryVolDtl=null;
		if (ListVolDtlHdr != null && ListVolDtlHdr.Count != 0)
		{
			_subqueryVolDtl = ((QueryVolDtl)ListVolDtlHdr[0]).BuildCriteria();
		}
        DetachedCriteria _subqueryVolPassager = null;
        if (ListVolPassagerHdr != null && ListVolPassagerHdr.Count != 0)
        {
            _subqueryVolPassager = ((QueryVolPassager)ListVolPassagerHdr[0]).BuildCriteria();
        }
        if (_subqueryVolDtl == null && _subqueryVolPassager == null)
			return base.BuildCriteria();
		DetachedCriteria _mainquery= base.BuildCriteria();
		if (_mainquery == null)
			_mainquery=DetachedCriteria.For<VolHdr>();
		if (_mainquery != null)
		{
			if (_subqueryVolDtl !=null)
			{
				_subqueryVolDtl.SetProjection(Projections.Property("HdrRef"));
				_mainquery.Add(Subqueries.PropertyIn("Id", _subqueryVolDtl));
			}
            if (_subqueryVolPassager != null)
            {
                _subqueryVolPassager.SetProjection(Projections.Property("HdrRef"));
                _mainquery.Add(Subqueries.PropertyIn("Id", _subqueryVolPassager));
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
		public QueryVolHdr()
				 : base(typeof(VolHdr))
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
            QueryVolHdr castObj = obj as QueryVolHdr;
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