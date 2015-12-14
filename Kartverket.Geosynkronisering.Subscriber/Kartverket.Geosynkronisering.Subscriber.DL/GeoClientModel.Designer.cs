﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Kartverket.Geosynkronisering.Subscriber.DL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class geosyncDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new geosyncDBEntities object using the connection string found in the 'geosyncDBEntities' section of the application configuration file.
        /// </summary>
        public geosyncDBEntities() : base("name=geosyncDBEntities", "geosyncDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new geosyncDBEntities object.
        /// </summary>
        public geosyncDBEntities(string connectionString) : base(connectionString, "geosyncDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new geosyncDBEntities object.
        /// </summary>
        public geosyncDBEntities(EntityConnection connection) : base(connection, "geosyncDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Dataset> Dataset
        {
            get
            {
                if ((_Dataset == null))
                {
                    _Dataset = base.CreateObjectSet<Dataset>("Dataset");
                }
                return _Dataset;
            }
        }
        private ObjectSet<Dataset> _Dataset;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Dataset EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDataset(Dataset dataset)
        {
            base.AddObject("Dataset", dataset);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="geosyncDBModel", Name="Dataset")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dataset : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Dataset object.
        /// </summary>
        /// <param name="datasetId">Initial value of the DatasetId property.</param>
        public static Dataset CreateDataset(global::System.Int32 datasetId)
        {
            Dataset dataset = new Dataset();
            dataset.DatasetId = datasetId;
            return dataset;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DatasetId
        {
            get
            {
                return _DatasetId;
            }
            set
            {
                if (_DatasetId != value)
                {
                    OnDatasetIdChanging(value);
                    ReportPropertyChanging("DatasetId");
                    _DatasetId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DatasetId");
                    OnDatasetIdChanged();
                }
            }
        }
        private global::System.Int32 _DatasetId;
        partial void OnDatasetIdChanging(global::System.Int32 value);
        partial void OnDatasetIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> LastIndex
        {
            get
            {
                return _LastIndex;
            }
            set
            {
                OnLastIndexChanging(value);
                ReportPropertyChanging("LastIndex");
                _LastIndex = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastIndex");
                OnLastIndexChanged();
            }
        }
        private Nullable<global::System.Int64> _LastIndex;
        partial void OnLastIndexChanging(Nullable<global::System.Int64> value);
        partial void OnLastIndexChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SyncronizationUrl
        {
            get
            {
                return _SyncronizationUrl;
            }
            set
            {
                OnSyncronizationUrlChanging(value);
                ReportPropertyChanging("SyncronizationUrl");
                _SyncronizationUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SyncronizationUrl");
                OnSyncronizationUrlChanged();
            }
        }
        private global::System.String _SyncronizationUrl;
        partial void OnSyncronizationUrlChanging(global::System.String value);
        partial void OnSyncronizationUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ClientWfsUrl
        {
            get
            {
                return _ClientWfsUrl;
            }
            set
            {
                OnClientWfsUrlChanging(value);
                ReportPropertyChanging("ClientWfsUrl");
                _ClientWfsUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ClientWfsUrl");
                OnClientWfsUrlChanged();
            }
        }
        private global::System.String _ClientWfsUrl;
        partial void OnClientWfsUrlChanging(global::System.String value);
        partial void OnClientWfsUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> MaxCount
        {
            get
            {
                return _MaxCount;
            }
            set
            {
                OnMaxCountChanging(value);
                ReportPropertyChanging("MaxCount");
                _MaxCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxCount");
                OnMaxCountChanged();
            }
        }
        private Nullable<global::System.Int32> _MaxCount;
        partial void OnMaxCountChanging(Nullable<global::System.Int32> value);
        partial void OnMaxCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProviderDatasetId
        {
            get
            {
                return _ProviderDatasetId;
            }
            set
            {
                OnProviderDatasetIdChanging(value);
                ReportPropertyChanging("ProviderDatasetId");
                _ProviderDatasetId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProviderDatasetId");
                OnProviderDatasetIdChanged();
            }
        }
        private global::System.String _ProviderDatasetId;
        partial void OnProviderDatasetIdChanging(global::System.String value);
        partial void OnProviderDatasetIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TargetNamespace
        {
            get
            {
                return _TargetNamespace;
            }
            set
            {
                OnTargetNamespaceChanging(value);
                ReportPropertyChanging("TargetNamespace");
                _TargetNamespace = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TargetNamespace");
                OnTargetNamespaceChanged();
            }
        }
        private global::System.String _TargetNamespace;
        partial void OnTargetNamespaceChanging(global::System.String value);
        partial void OnTargetNamespaceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MappingFile
        {
            get
            {
                return _MappingFile;
            }
            set
            {
                OnMappingFileChanging(value);
                ReportPropertyChanging("MappingFile");
                _MappingFile = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MappingFile");
                OnMappingFileChanged();
            }
        }
        private global::System.String _MappingFile;
        partial void OnMappingFileChanging(global::System.String value);
        partial void OnMappingFileChanged();

        #endregion

    
    }

    #endregion

    
}
