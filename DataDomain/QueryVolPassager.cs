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
    /// VolPassager object for NHibernate mapped table AVV_DATA_VOL_PASSAGER.
    /// </summary>
    [Serializable]
    public partial class  QueryVolPassager:EntityBase     {
			private string _id;

			private String _passagerimputation;
            private String _passagermatricule;
	private String _passagernomprenom;
	private String _passagerstatut;
	private String _passagermotif;


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


public virtual String PassagerImputation
	{
		get 
		{
			CheckSecurity("PassagerImputation",PropertyAccess.Read,null);
			return _passagerimputation;
		}
		set
		{
			CheckSecurity("PassagerImputation",PropertyAccess.Write,value);
			if (value != _passagerimputation)lock (_syncRoot)
			{
				_passagerimputation=value;
				NotifyPropertyChanged("PassagerImputation");
			}
		}
	}
public virtual String PassagerMatricule
{
    get
    {
        CheckSecurity("PassagerMatricule", PropertyAccess.Read, null);
        return _passagermatricule;
    }
    set
    {
        CheckSecurity("PassagerMatricule", PropertyAccess.Write, value);
        if (value != _passagermatricule) lock (_syncRoot)
            {
                _passagermatricule = value;
                NotifyPropertyChanged("PassagerMatricule");
            }
    }
}
	public virtual String PassagerNomPrenom
	{
		get 
		{
			CheckSecurity("PassagerNomPrenom",PropertyAccess.Read,null);
			return _passagernomprenom;
		}
		set
		{
			CheckSecurity("PassagerNomPrenom",PropertyAccess.Write,value);
			if (value != _passagernomprenom)lock (_syncRoot)
			{
				_passagernomprenom=value;
				NotifyPropertyChanged("PassagerNomPrenom");
			}
		}
	}
	public virtual String PassagerStatut
	{
		get 
		{
			CheckSecurity("PassagerStatut",PropertyAccess.Read,null);
			return _passagerstatut;
		}
		set
		{
			CheckSecurity("PassagerStatut",PropertyAccess.Write,value);
			if (value != _passagerstatut)lock (_syncRoot)
			{
				_passagerstatut=value;
				NotifyPropertyChanged("PassagerStatut");
			}
		}
	}
	public virtual String PassagerMotif
	{
		get 
		{
			CheckSecurity("PassagerMotif",PropertyAccess.Read,null);
			return _passagermotif;
		}
		set
		{
			CheckSecurity("PassagerMotif",PropertyAccess.Write,value);
			if (value != _passagermotif)lock (_syncRoot)
			{
				_passagermotif=value;
				NotifyPropertyChanged("PassagerMotif");
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
		public QueryVolPassager()
				 : base(typeof(VolPassager))
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
            QueryVolPassager castObj = obj as QueryVolPassager;
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