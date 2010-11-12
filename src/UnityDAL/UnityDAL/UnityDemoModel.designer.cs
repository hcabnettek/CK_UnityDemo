﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4206
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnityDAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks2008R2")]
	public partial class UnityDemoModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProductCategory(ProductCategory instance);
    partial void UpdateProductCategory(ProductCategory instance);
    partial void DeleteProductCategory(ProductCategory instance);
    partial void InsertProductSubcategory(ProductSubcategory instance);
    partial void UpdateProductSubcategory(ProductSubcategory instance);
    partial void DeleteProductSubcategory(ProductSubcategory instance);
    #endregion
		
		public UnityDemoModelDataContext() : 
				base(global::UnityDAL.Properties.Settings.Default.AdventureWorks2008R2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UnityDemoModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UnityDemoModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UnityDemoModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UnityDemoModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductCategory> ProductCategories
		{
			get
			{
				return this.GetTable<ProductCategory>();
			}
		}
		
		public System.Data.Linq.Table<ProductSubcategory> ProductSubcategories
		{
			get
			{
				return this.GetTable<ProductSubcategory>();
			}
		}
	}
	
	[Table(Name="Production.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _ProductNumber;
		
		private bool _MakeFlag;
		
		private bool _FinishedGoodsFlag;
		
		private string _Color;
		
		private short _SafetyStockLevel;
		
		private short _ReorderPoint;
		
		private decimal _StandardCost;
		
		private decimal _ListPrice;
		
		private string _Size;
		
		private string _SizeUnitMeasureCode;
		
		private string _WeightUnitMeasureCode;
		
		private System.Nullable<decimal> _Weight;
		
		private int _DaysToManufacture;
		
		private string _ProductLine;
		
		private string _Class;
		
		private string _Style;
		
		private System.Nullable<int> _ProductSubcategoryID;
		
		private System.Nullable<int> _ProductModelID;
		
		private System.DateTime _SellStartDate;
		
		private System.Nullable<System.DateTime> _SellEndDate;
		
		private System.Nullable<System.DateTime> _DiscontinuedDate;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
		private EntityRef<ProductSubcategory> _ProductSubcategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnProductNumberChanging(string value);
    partial void OnProductNumberChanged();
    partial void OnMakeFlagChanging(bool value);
    partial void OnMakeFlagChanged();
    partial void OnFinishedGoodsFlagChanging(bool value);
    partial void OnFinishedGoodsFlagChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnSafetyStockLevelChanging(short value);
    partial void OnSafetyStockLevelChanged();
    partial void OnReorderPointChanging(short value);
    partial void OnReorderPointChanged();
    partial void OnStandardCostChanging(decimal value);
    partial void OnStandardCostChanged();
    partial void OnListPriceChanging(decimal value);
    partial void OnListPriceChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnSizeUnitMeasureCodeChanging(string value);
    partial void OnSizeUnitMeasureCodeChanged();
    partial void OnWeightUnitMeasureCodeChanging(string value);
    partial void OnWeightUnitMeasureCodeChanged();
    partial void OnWeightChanging(System.Nullable<decimal> value);
    partial void OnWeightChanged();
    partial void OnDaysToManufactureChanging(int value);
    partial void OnDaysToManufactureChanged();
    partial void OnProductLineChanging(string value);
    partial void OnProductLineChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    partial void OnStyleChanging(string value);
    partial void OnStyleChanged();
    partial void OnProductSubcategoryIDChanging(System.Nullable<int> value);
    partial void OnProductSubcategoryIDChanged();
    partial void OnProductModelIDChanging(System.Nullable<int> value);
    partial void OnProductModelIDChanged();
    partial void OnSellStartDateChanging(System.DateTime value);
    partial void OnSellStartDateChanged();
    partial void OnSellEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnSellEndDateChanged();
    partial void OnDiscontinuedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDiscontinuedDateChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Product()
		{
			this._ProductSubcategory = default(EntityRef<ProductSubcategory>);
			OnCreated();
		}
		
		[Column(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ProductNumber", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string ProductNumber
		{
			get
			{
				return this._ProductNumber;
			}
			set
			{
				if ((this._ProductNumber != value))
				{
					this.OnProductNumberChanging(value);
					this.SendPropertyChanging();
					this._ProductNumber = value;
					this.SendPropertyChanged("ProductNumber");
					this.OnProductNumberChanged();
				}
			}
		}
		
		[Column(Storage="_MakeFlag", DbType="Bit NOT NULL")]
		public bool MakeFlag
		{
			get
			{
				return this._MakeFlag;
			}
			set
			{
				if ((this._MakeFlag != value))
				{
					this.OnMakeFlagChanging(value);
					this.SendPropertyChanging();
					this._MakeFlag = value;
					this.SendPropertyChanged("MakeFlag");
					this.OnMakeFlagChanged();
				}
			}
		}
		
		[Column(Storage="_FinishedGoodsFlag", DbType="Bit NOT NULL")]
		public bool FinishedGoodsFlag
		{
			get
			{
				return this._FinishedGoodsFlag;
			}
			set
			{
				if ((this._FinishedGoodsFlag != value))
				{
					this.OnFinishedGoodsFlagChanging(value);
					this.SendPropertyChanging();
					this._FinishedGoodsFlag = value;
					this.SendPropertyChanged("FinishedGoodsFlag");
					this.OnFinishedGoodsFlagChanged();
				}
			}
		}
		
		[Column(Storage="_Color", DbType="NVarChar(15)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[Column(Storage="_SafetyStockLevel", DbType="SmallInt NOT NULL")]
		public short SafetyStockLevel
		{
			get
			{
				return this._SafetyStockLevel;
			}
			set
			{
				if ((this._SafetyStockLevel != value))
				{
					this.OnSafetyStockLevelChanging(value);
					this.SendPropertyChanging();
					this._SafetyStockLevel = value;
					this.SendPropertyChanged("SafetyStockLevel");
					this.OnSafetyStockLevelChanged();
				}
			}
		}
		
		[Column(Storage="_ReorderPoint", DbType="SmallInt NOT NULL")]
		public short ReorderPoint
		{
			get
			{
				return this._ReorderPoint;
			}
			set
			{
				if ((this._ReorderPoint != value))
				{
					this.OnReorderPointChanging(value);
					this.SendPropertyChanging();
					this._ReorderPoint = value;
					this.SendPropertyChanged("ReorderPoint");
					this.OnReorderPointChanged();
				}
			}
		}
		
		[Column(Storage="_StandardCost", DbType="Money NOT NULL")]
		public decimal StandardCost
		{
			get
			{
				return this._StandardCost;
			}
			set
			{
				if ((this._StandardCost != value))
				{
					this.OnStandardCostChanging(value);
					this.SendPropertyChanging();
					this._StandardCost = value;
					this.SendPropertyChanged("StandardCost");
					this.OnStandardCostChanged();
				}
			}
		}
		
		[Column(Storage="_ListPrice", DbType="Money NOT NULL")]
		public decimal ListPrice
		{
			get
			{
				return this._ListPrice;
			}
			set
			{
				if ((this._ListPrice != value))
				{
					this.OnListPriceChanging(value);
					this.SendPropertyChanging();
					this._ListPrice = value;
					this.SendPropertyChanged("ListPrice");
					this.OnListPriceChanged();
				}
			}
		}
		
		[Column(Storage="_Size", DbType="NVarChar(5)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[Column(Storage="_SizeUnitMeasureCode", DbType="NChar(3)")]
		public string SizeUnitMeasureCode
		{
			get
			{
				return this._SizeUnitMeasureCode;
			}
			set
			{
				if ((this._SizeUnitMeasureCode != value))
				{
					this.OnSizeUnitMeasureCodeChanging(value);
					this.SendPropertyChanging();
					this._SizeUnitMeasureCode = value;
					this.SendPropertyChanged("SizeUnitMeasureCode");
					this.OnSizeUnitMeasureCodeChanged();
				}
			}
		}
		
		[Column(Storage="_WeightUnitMeasureCode", DbType="NChar(3)")]
		public string WeightUnitMeasureCode
		{
			get
			{
				return this._WeightUnitMeasureCode;
			}
			set
			{
				if ((this._WeightUnitMeasureCode != value))
				{
					this.OnWeightUnitMeasureCodeChanging(value);
					this.SendPropertyChanging();
					this._WeightUnitMeasureCode = value;
					this.SendPropertyChanged("WeightUnitMeasureCode");
					this.OnWeightUnitMeasureCodeChanged();
				}
			}
		}
		
		[Column(Storage="_Weight", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[Column(Storage="_DaysToManufacture", DbType="Int NOT NULL")]
		public int DaysToManufacture
		{
			get
			{
				return this._DaysToManufacture;
			}
			set
			{
				if ((this._DaysToManufacture != value))
				{
					this.OnDaysToManufactureChanging(value);
					this.SendPropertyChanging();
					this._DaysToManufacture = value;
					this.SendPropertyChanged("DaysToManufacture");
					this.OnDaysToManufactureChanged();
				}
			}
		}
		
		[Column(Storage="_ProductLine", DbType="NChar(2)")]
		public string ProductLine
		{
			get
			{
				return this._ProductLine;
			}
			set
			{
				if ((this._ProductLine != value))
				{
					this.OnProductLineChanging(value);
					this.SendPropertyChanging();
					this._ProductLine = value;
					this.SendPropertyChanged("ProductLine");
					this.OnProductLineChanged();
				}
			}
		}
		
		[Column(Storage="_Class", DbType="NChar(2)")]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[Column(Storage="_Style", DbType="NChar(2)")]
		public string Style
		{
			get
			{
				return this._Style;
			}
			set
			{
				if ((this._Style != value))
				{
					this.OnStyleChanging(value);
					this.SendPropertyChanging();
					this._Style = value;
					this.SendPropertyChanged("Style");
					this.OnStyleChanged();
				}
			}
		}
		
		[Column(Storage="_ProductSubcategoryID", DbType="Int")]
		public System.Nullable<int> ProductSubcategoryID
		{
			get
			{
				return this._ProductSubcategoryID;
			}
			set
			{
				if ((this._ProductSubcategoryID != value))
				{
					if (this._ProductSubcategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductSubcategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductSubcategoryID = value;
					this.SendPropertyChanged("ProductSubcategoryID");
					this.OnProductSubcategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_ProductModelID", DbType="Int")]
		public System.Nullable<int> ProductModelID
		{
			get
			{
				return this._ProductModelID;
			}
			set
			{
				if ((this._ProductModelID != value))
				{
					this.OnProductModelIDChanging(value);
					this.SendPropertyChanging();
					this._ProductModelID = value;
					this.SendPropertyChanged("ProductModelID");
					this.OnProductModelIDChanged();
				}
			}
		}
		
		[Column(Storage="_SellStartDate", DbType="DateTime NOT NULL")]
		public System.DateTime SellStartDate
		{
			get
			{
				return this._SellStartDate;
			}
			set
			{
				if ((this._SellStartDate != value))
				{
					this.OnSellStartDateChanging(value);
					this.SendPropertyChanging();
					this._SellStartDate = value;
					this.SendPropertyChanged("SellStartDate");
					this.OnSellStartDateChanged();
				}
			}
		}
		
		[Column(Storage="_SellEndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> SellEndDate
		{
			get
			{
				return this._SellEndDate;
			}
			set
			{
				if ((this._SellEndDate != value))
				{
					this.OnSellEndDateChanging(value);
					this.SendPropertyChanging();
					this._SellEndDate = value;
					this.SendPropertyChanged("SellEndDate");
					this.OnSellEndDateChanged();
				}
			}
		}
		
		[Column(Storage="_DiscontinuedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DiscontinuedDate
		{
			get
			{
				return this._DiscontinuedDate;
			}
			set
			{
				if ((this._DiscontinuedDate != value))
				{
					this.OnDiscontinuedDateChanging(value);
					this.SendPropertyChanging();
					this._DiscontinuedDate = value;
					this.SendPropertyChanged("DiscontinuedDate");
					this.OnDiscontinuedDateChanged();
				}
			}
		}
		
		[Column(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Association(Name="ProductSubcategory_Product", Storage="_ProductSubcategory", ThisKey="ProductSubcategoryID", OtherKey="ProductSubcategoryID", IsForeignKey=true)]
		public ProductSubcategory ProductSubcategory
		{
			get
			{
				return this._ProductSubcategory.Entity;
			}
			set
			{
				ProductSubcategory previousValue = this._ProductSubcategory.Entity;
				if (((previousValue != value) 
							|| (this._ProductSubcategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductSubcategory.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._ProductSubcategory.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._ProductSubcategoryID = value.ProductSubcategoryID;
					}
					else
					{
						this._ProductSubcategoryID = default(Nullable<int>);
					}
					this.SendPropertyChanged("ProductSubcategory");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="Production.ProductCategory")]
	public partial class ProductCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductCategoryID;
		
		private string _Name;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<ProductSubcategory> _ProductSubcategories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductCategoryIDChanging(int value);
    partial void OnProductCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public ProductCategory()
		{
			this._ProductSubcategories = new EntitySet<ProductSubcategory>(new Action<ProductSubcategory>(this.attach_ProductSubcategories), new Action<ProductSubcategory>(this.detach_ProductSubcategories));
			OnCreated();
		}
		
		[Column(Storage="_ProductCategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductCategoryID
		{
			get
			{
				return this._ProductCategoryID;
			}
			set
			{
				if ((this._ProductCategoryID != value))
				{
					this.OnProductCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductCategoryID = value;
					this.SendPropertyChanged("ProductCategoryID");
					this.OnProductCategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Association(Name="ProductCategory_ProductSubcategory", Storage="_ProductSubcategories", ThisKey="ProductCategoryID", OtherKey="ProductCategoryID")]
		public EntitySet<ProductSubcategory> ProductSubcategories
		{
			get
			{
				return this._ProductSubcategories;
			}
			set
			{
				this._ProductSubcategories.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ProductSubcategories(ProductSubcategory entity)
		{
			this.SendPropertyChanging();
			entity.ProductCategory = this;
		}
		
		private void detach_ProductSubcategories(ProductSubcategory entity)
		{
			this.SendPropertyChanging();
			entity.ProductCategory = null;
		}
	}
	
	[Table(Name="Production.ProductSubcategory")]
	public partial class ProductSubcategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductSubcategoryID;
		
		private int _ProductCategoryID;
		
		private string _Name;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<Product> _Products;
		
		private EntityRef<ProductCategory> _ProductCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductSubcategoryIDChanging(int value);
    partial void OnProductSubcategoryIDChanged();
    partial void OnProductCategoryIDChanging(int value);
    partial void OnProductCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public ProductSubcategory()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			this._ProductCategory = default(EntityRef<ProductCategory>);
			OnCreated();
		}
		
		[Column(Storage="_ProductSubcategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductSubcategoryID
		{
			get
			{
				return this._ProductSubcategoryID;
			}
			set
			{
				if ((this._ProductSubcategoryID != value))
				{
					this.OnProductSubcategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductSubcategoryID = value;
					this.SendPropertyChanged("ProductSubcategoryID");
					this.OnProductSubcategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_ProductCategoryID", DbType="Int NOT NULL")]
		public int ProductCategoryID
		{
			get
			{
				return this._ProductCategoryID;
			}
			set
			{
				if ((this._ProductCategoryID != value))
				{
					if (this._ProductCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductCategoryID = value;
					this.SendPropertyChanged("ProductCategoryID");
					this.OnProductCategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[Association(Name="ProductSubcategory_Product", Storage="_Products", ThisKey="ProductSubcategoryID", OtherKey="ProductSubcategoryID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		[Association(Name="ProductCategory_ProductSubcategory", Storage="_ProductCategory", ThisKey="ProductCategoryID", OtherKey="ProductCategoryID", IsForeignKey=true)]
		public ProductCategory ProductCategory
		{
			get
			{
				return this._ProductCategory.Entity;
			}
			set
			{
				ProductCategory previousValue = this._ProductCategory.Entity;
				if (((previousValue != value) 
							|| (this._ProductCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductCategory.Entity = null;
						previousValue.ProductSubcategories.Remove(this);
					}
					this._ProductCategory.Entity = value;
					if ((value != null))
					{
						value.ProductSubcategories.Add(this);
						this._ProductCategoryID = value.ProductCategoryID;
					}
					else
					{
						this._ProductCategoryID = default(int);
					}
					this.SendPropertyChanged("ProductCategory");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.ProductSubcategory = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.ProductSubcategory = null;
		}
	}
}
#pragma warning restore 1591