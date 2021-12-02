using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    /// Facture object for NHibernate mapped table AVV_DATA_FACTURE.
    /// </summary>
    [Serializable]
    public partial class  Facture:EntityBase     {
			private Decimal? _id;

			private DateTime _facturedate;
	private String _facturereference;
	private Decimal? _facturemontant;
	private String _sysvalide;
	private DateTime? _sysvalidedate;
	private String _sysvalideoperateur;
	private DateTime? _voldebut;
	private DateTime? _volfin;
        private String _factureobservation;


		#region InRef
				private Fournisseur _fournisseurref;

		#endregion
		#region Outref
				private IMyCollection<FactVol> _listfactvolfacture;

		#endregion
		public virtual Decimal? Id
{
	get 
	{
		CheckSecurity("Id",PropertyAccess.Read,null);
		return _id;
	}
}

		
public virtual DateTime FactureDate
	{
		get 
		{
			CheckSecurity("FactureDate",PropertyAccess.Read,null);
			return _facturedate;
		}
		set
		{
			CheckSecurity("FactureDate",PropertyAccess.Write,value);
			if (value != _facturedate)lock (_syncRoot)
			{
				_facturedate=value;
				NotifyPropertyChanged("FactureDate");
			}
		}
	}
	public virtual String FactureReference
	{
		get 
		{
			CheckSecurity("FactureReference",PropertyAccess.Read,null);
			return _facturereference;
		}
		set
		{
			CheckSecurity("FactureReference",PropertyAccess.Write,value);
			if (value != _facturereference)lock (_syncRoot)
			{
				_facturereference=value;
				NotifyPropertyChanged("FactureReference");
			}
		}
	}
		public virtual Decimal? FactureMontant
	{
		get 
		{
			CheckSecurity("FactureMontant",PropertyAccess.Read,null);
			return _facturemontant;
		}
		set
		{
			CheckSecurity("FactureMontant",PropertyAccess.Write,value);
			if (value != _facturemontant)lock (_syncRoot)
			{
				_facturemontant=value;
				NotifyPropertyChanged("FactureMontant");
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
		public virtual DateTime? VolDebut
	{
		get 
		{
			CheckSecurity("VolDebut",PropertyAccess.Read,null);
			return _voldebut;
		}
		set
		{
			CheckSecurity("VolDebut",PropertyAccess.Write,value);
			if (value != _voldebut)lock (_syncRoot)
			{
				_voldebut=value;
				NotifyPropertyChanged("VolDebut");
			}
		}
	}
	public virtual DateTime? VolFin
	{
		get 
		{
			CheckSecurity("VolFin",PropertyAccess.Read,null);
			return _volfin;
		}
		set
		{
			CheckSecurity("VolFin",PropertyAccess.Write,value);
			if (value != _volfin)lock (_syncRoot)
			{
				_volfin=value;
				NotifyPropertyChanged("VolFin");
			}
		}
	}

    public virtual String FactureObservation
    {
        get
        {
            CheckSecurity("FactureObservation", PropertyAccess.Read, null);
            return _factureobservation;
        }
        set
        {
            CheckSecurity("FactureObservation", PropertyAccess.Write, value);
            if (value != _factureobservation) lock (_syncRoot)
                {
                    _factureobservation = value;
                    NotifyPropertyChanged("FactureObservation");
                }
        }
    }

			public virtual Fournisseur FournisseurRef
	{
		get
		{
			CheckSecurity("FournisseurRef",PropertyAccess.Read,null);
			return _fournisseurref;
		}
		
		set
			{
				CheckSecurity("FournisseurRef",PropertyAccess.Write,value);
				if (value != _fournisseurref)
				{
					_fournisseurref = value;
					NotifyPropertyChanged("FournisseurRef");
				}
			}
	}



			
			public virtual   IMyCollection<FactVol>   ListFactVolFacture
	{
		get
		{
			if (_listfactvolfacture == null)
			{
				_listfactvolfacture=new UserList<FactVol>();
				_listfactvolfacture.ListChanged+=ListFactVolFacture_EventChanged;
			}
			return _listfactvolfacture;
		}
		set
		{
			if (_listfactvolfacture != null)
			_listfactvolfacture.ListChanged-=ListFactVolFacture_EventChanged;
			_listfactvolfacture=value;
			if (_listfactvolfacture != null)
			{	
				_listfactvolfacture.ListChanged +=ListFactVolFacture_EventChanged;
			}
		}
	}
	void ListFactVolFacture_EventChanged (object sender, ListChangedEventArgs e)
	{
	    Decimal _dureeTotal = _listfactvolfacture.Sum(factVol => factVol.DurreVol);

	    foreach (var item in this._listfactvolfacture)
	    {
	        item.setMontant(0);
            if (_dureeTotal>0)
	            item.setMontant((this._facturemontant.GetValueOrDefault(0)*item.DurreVol)/_dureeTotal);
	    }

			NotifyPropertyChanged("ListFactVolFacture");
	}


	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryFacture  _queryobject= new QueryFacture();
	_queryobject.ListFactVolFacture.Add(new FactVol().GetObjectQuery());
	return _queryobject;
}
        #endregion		
        #region Constructors
		public Facture()
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
            Facture castObj = obj as Facture;
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