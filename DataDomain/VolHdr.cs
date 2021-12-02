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
    public partial class  VolHdr:EntityBase     {
			private Decimal? _id;

			private DateTime _hdrdate;
	private String _avioncode;
	private String _hdrtypevol;

    private Decimal _hdrnbplace;
    private Decimal _hdrcharge;

	private String _hdrregulier;
	private String _aeroportdepart;
	private String _aeroportdestination;
	private String _aeroportescale;
	private DateTime? _heuredecolage;
	private Decimal? _dureemn01;
	private Decimal? _dureemn02;
	private String _hdrobservation;
	private String _sysvalide;
	private DateTime? _sysvalidedate;
	private String _sysvalideoperateur;


		#region InRef
    private Fournisseur _fournisseurref;
		
		#endregion
		#region Outref
				private IMyCollection<VolDtl> _listvoldtlhdr;
                private IMyCollection<VolPassager> _listvolpassagerhdr;
		#endregion
		public virtual Decimal? Id
{
	get 
	{
		CheckSecurity("Id",PropertyAccess.Read,null);
		return _id;
	}
}

		
public virtual DateTime HdrDate
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
	public virtual String AvionCode
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
	public virtual String HdrTypeVol
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

    public virtual Decimal HdrNbPlace
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

    public virtual Decimal HdrCharge
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
	public virtual String HdrRegulier
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
	public virtual String AeroportDepart
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
	public virtual String AeroportDestination
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
	public virtual String AeroportEscale
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
		public virtual DateTime? HeureDecolage
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
	public virtual Decimal? DureeMn01
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
	public virtual Decimal? DureeMn02
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
public virtual String HdrObservation
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
	public virtual String SysValide
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
		public virtual DateTime? SysValideDate
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
public virtual String SysValideOperateur
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
			
			public virtual   IMyCollection<VolDtl>   ListVolDtlHdr
	{
		get
		{
			if (_listvoldtlhdr == null)
			{
				_listvoldtlhdr=new UserList<VolDtl>();
				_listvoldtlhdr.ListChanged+=ListVolDtlHdr_EventChanged;
			}
			return _listvoldtlhdr;
		}
		set
		{
			if (_listvoldtlhdr != null)
			_listvoldtlhdr.ListChanged-=ListVolDtlHdr_EventChanged;
			_listvoldtlhdr=value;
			if (_listvoldtlhdr != null)
			{	
				_listvoldtlhdr.ListChanged +=ListVolDtlHdr_EventChanged;
			}
		}
	}
	void ListVolDtlHdr_EventChanged (object sender, ListChangedEventArgs e)
	{
			NotifyPropertyChanged("ListVolDtlHdr");
	}

    public virtual IMyCollection<VolPassager> ListVolPassagerHdr
    {
        get
        {
            if (_listvolpassagerhdr == null)
            {
                _listvolpassagerhdr = new UserList<VolPassager>();
                _listvolpassagerhdr.ListChanged += ListVolPassagerHdr_EventChanged;
            }
            return _listvolpassagerhdr;
        }
        set
        {
            if (_listvolpassagerhdr != null)
                _listvolpassagerhdr.ListChanged -= ListVolPassagerHdr_EventChanged;
            _listvolpassagerhdr = value;
            if (_listvolpassagerhdr != null)
            {
                _listvolpassagerhdr.ListChanged += ListVolPassagerHdr_EventChanged;
            }
        }
    }
    void ListVolPassagerHdr_EventChanged(object sender, ListChangedEventArgs e)
    {
        NotifyPropertyChanged("ListVolPassagerHdr");
    }
	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryVolHdr  _queryobject= new QueryVolHdr();
	_queryobject.ListVolDtlHdr.Add(new VolDtl().GetObjectQuery());
    _queryobject.ListVolPassagerHdr.Add(new VolPassager().GetObjectQuery());
	return _queryobject;
}
        #endregion		
        #region Constructors
		public VolHdr()
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
            VolHdr castObj = obj as VolHdr;
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