using System;
using DALAvion.Domain;
using GnsBusinessObjectBase.Implementations;
using NHibernate.Proxy;

namespace DALAvion.DataDomain
{
    /// <summary>
    /// Avion object for NHibernate mapped table AVV_DATA_AVION.
    /// </summary>
    [Serializable]
    public partial class Avion : EntityBase
    {
        private Decimal? _id;

        private String _avioncode;
        private String _avionlibelle;

        private Decimal? _avionnbplace;

        private Decimal? _avioncharge;


        #region InRef
        private Fournisseur _fournisseurref;
        #endregion
        #region Outref

        #endregion
        public virtual Decimal? Id
        {
            get
            {
                CheckSecurity("Id", PropertyAccess.Read, null);
                return _id;
            }
        }


        public virtual Decimal? AvionNbPlace
        {
            get
            {
                CheckSecurity("AvionNbPlace", PropertyAccess.Read, null);
                return _avionnbplace;
            }
            set
            {
                CheckSecurity("AvionNbPlace", PropertyAccess.Write, value);
                if (value != _avionnbplace) lock (_syncRoot)
                    {
                        _avionnbplace = value;
                        NotifyPropertyChanged("AvionNbPlace");
                    }
            }
        }

        public virtual Decimal? AvionCharge
        {
            get
            {
                CheckSecurity("AvionCharge", PropertyAccess.Read, null);
                return _avioncharge;
            }
            set
            {
                CheckSecurity("AvionCharge", PropertyAccess.Write, value);
                if (value != _avioncharge) lock (_syncRoot)
                    {
                        _avioncharge = value;
                        NotifyPropertyChanged("AvionCharge");
                    }
            }
        }

        public virtual String AvionCode
        {
            get
            {
                CheckSecurity("AvionCode", PropertyAccess.Read, null);
                return _avioncode;
            }
            set
            {
                CheckSecurity("AvionCode", PropertyAccess.Write, value);
                if (value != _avioncode) lock (_syncRoot)
                    {
                        _avioncode = value;
                        NotifyPropertyChanged("AvionCode");
                    }
            }
        }

        public virtual String AvionLibelle
        {
            get
            {
                CheckSecurity("AvionLibelle", PropertyAccess.Read, null);
                return _avionlibelle;
            }
            set
            {
                CheckSecurity("AvionLibelle", PropertyAccess.Write, value);
                if (value != _avionlibelle) lock (_syncRoot)
                    {
                        _avionlibelle = value;
                        NotifyPropertyChanged("AvionLibelle");
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
        #region override GetObjectQuery
        public override EntityBase GetObjectQuery()
        {
            QueryAvion _queryobject = new QueryAvion();
            return _queryobject;
        }
        #endregion
        #region Constructors
        public Avion()
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

            if ((obj == null) || (!_type1.Equals(_type2))) return false;
            Avion castObj = obj as Avion;
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