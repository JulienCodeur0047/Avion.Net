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
    /// Fournisseur object for NHibernate mapped table AVV_DATA_FOURNISSEUR.
    /// </summary>
    [Serializable]
    public partial class  Fournisseur:EntityBase     {
			private Decimal? _id;

			private String _frnscode;
	private String _frnsdesignation;
	private Decimal? _frnsnbheures;


		#region InRef
		
		#endregion
		#region Outref
				private IMyCollection<Facture> _listfacturefournisseur;

		#endregion
		public virtual Decimal? Id
{
	get 
	{
		CheckSecurity("Id",PropertyAccess.Read,null);
		return _id;
	}
}

		
public virtual String FrnsCode
	{
		get 
		{
			CheckSecurity("FrnsCode",PropertyAccess.Read,null);
			return _frnscode;
		}
		set
		{
			CheckSecurity("FrnsCode",PropertyAccess.Write,value);
			if (value != _frnscode)lock (_syncRoot)
			{
				_frnscode=value;
				NotifyPropertyChanged("FrnsCode");
			}
		}
	}
	public virtual String FrnsDesignation
	{
		get 
		{
			CheckSecurity("FrnsDesignation",PropertyAccess.Read,null);
			return _frnsdesignation;
		}
		set
		{
			CheckSecurity("FrnsDesignation",PropertyAccess.Write,value);
			if (value != _frnsdesignation)lock (_syncRoot)
			{
				_frnsdesignation=value;
				NotifyPropertyChanged("FrnsDesignation");
			}
		}
	}
		public virtual Decimal? FrnsNbHeures
	{
		get 
		{
			CheckSecurity("FrnsNbHeures",PropertyAccess.Read,null);
			return _frnsnbheures;
		}
		set
		{
			CheckSecurity("FrnsNbHeures",PropertyAccess.Write,value);
			if (value != _frnsnbheures)lock (_syncRoot)
			{
				_frnsnbheures=value;
				NotifyPropertyChanged("FrnsNbHeures");
			}
		}
	}

		
			
			public virtual   IMyCollection<Facture>   ListFactureFournisseur
	{
		get
		{
			if (_listfacturefournisseur == null)
			{
				_listfacturefournisseur=new UserList<Facture>();
				_listfacturefournisseur.ListChanged+=ListFactureFournisseur_EventChanged;
			}
			return _listfacturefournisseur;
		}
		set
		{
			if (_listfacturefournisseur != null)
			_listfacturefournisseur.ListChanged-=ListFactureFournisseur_EventChanged;
			_listfacturefournisseur=value;
			if (_listfacturefournisseur != null)
			{	
				_listfacturefournisseur.ListChanged +=ListFactureFournisseur_EventChanged;
			}
		}
	}
	void ListFactureFournisseur_EventChanged (object sender, ListChangedEventArgs e)
	{
			NotifyPropertyChanged("ListFactureFournisseur");
	}


	
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
{
	QueryFournisseur  _queryobject= new QueryFournisseur();
	_queryobject.ListFactureFournisseur.Add(new Facture().GetObjectQuery());
	return _queryobject;
}
        #endregion		
        #region Constructors
		public Fournisseur()
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
            Fournisseur castObj = obj as Fournisseur;
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