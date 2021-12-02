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
    /// Facture object for NHibernate mapped table AVV_DATA_FACTURE.
    /// </summary>
    [Serializable]
    public partial class  QueryFacture:EntityBase     {
			private string _id;

			private string _facturedate;
	private string _facturereference;
	private string _facturemontant;
	private string _sysvalide;
	private string _sysvalidedate;
	private string _sysvalideoperateur;
	private string _voldebut;
	private string _volfin;
    private String _factureobservation;


		#region InRef
				private Fournisseur _fournisseurref;

		#endregion
		#region Outref
				private IList _listfactvolfacture;

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


		
	public virtual string FactureDate
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
	public virtual string FactureReference
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
	public virtual string FactureMontant
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
	public virtual string VolDebut
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
	public virtual string VolFin
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



			
			public virtual  IList   ListFactVolFacture
	{
		get
		{
			
			if (_listfactvolfacture == null)
			{
				_listfactvolfacture=new List<QueryFactVol>();
				
			}
			return _listfactvolfacture;			
		}
		set
		{
			_listfactvolfacture=value;
		}
	}

		#region criteria
			public override DetachedCriteria BuildCriteria()
{
	DetachedCriteria _subqueryFactVol=null;
		if (ListFactVolFacture != null && ListFactVolFacture.Count != 0)
		{
			_subqueryFactVol = ((QueryFactVol)ListFactVolFacture[0]).BuildCriteria();
		}		
		if ( _subqueryFactVol== null  )
			return base.BuildCriteria();
		DetachedCriteria _mainquery= base.BuildCriteria();
		if (_mainquery == null)
			_mainquery=DetachedCriteria.For<Facture>();
		if (_mainquery != null)
		{
			if (_subqueryFactVol !=null)
			{
				_subqueryFactVol.SetProjection(Projections.Property("FactureRef"));
				_mainquery.Add(Subqueries.PropertyIn("Id", _subqueryFactVol));
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
		public QueryFacture()
				 : base(typeof(Facture))
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
            QueryFacture castObj = obj as QueryFacture;
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