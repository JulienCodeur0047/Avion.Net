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
    public partial class  QueryFournisseur:EntityBase     {
			private string _id;

			private string _frnscode;
	private string _frnsdesignation;
	private string _frnsnbheures;


		#region InRef
		
		#endregion
		#region Outref
				private IList _listfacturefournisseur;

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


		
	public virtual string FrnsCode
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
	public virtual string FrnsDesignation
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
	public virtual string FrnsNbHeures
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

		
			
			public virtual  IList   ListFactureFournisseur
	{
		get
		{
			
			if (_listfacturefournisseur == null)
			{
				_listfacturefournisseur=new List<QueryFacture>();
				
			}
			return _listfacturefournisseur;			
		}
		set
		{
			_listfacturefournisseur=value;
		}
	}

		#region criteria
			public override DetachedCriteria BuildCriteria()
{
	DetachedCriteria _subqueryFacture=null;
		if (ListFactureFournisseur != null && ListFactureFournisseur.Count != 0)
		{
			_subqueryFacture = ((QueryFacture)ListFactureFournisseur[0]).BuildCriteria();
		}		
		if ( _subqueryFacture== null  )
			return base.BuildCriteria();
		DetachedCriteria _mainquery= base.BuildCriteria();
		if (_mainquery == null)
			_mainquery=DetachedCriteria.For<Fournisseur>();
		if (_mainquery != null)
		{
			if (_subqueryFacture !=null)
			{
				_subqueryFacture.SetProjection(Projections.Property("FournisseurRef"));
				_mainquery.Add(Subqueries.PropertyIn("Id", _subqueryFacture));
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
		public QueryFournisseur()
				 : base(typeof(Fournisseur))
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
            QueryFournisseur castObj = obj as QueryFournisseur;
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