﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKyQLBVHQT_Final
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyBenhVien_DoAnCuoiKi")]
	public partial class QLBVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBacSi(BacSi instance);
    partial void UpdateBacSi(BacSi instance);
    partial void DeleteBacSi(BacSi instance);
    #endregion
		
		public QLBVDataContext() : 
				base(global::DoAnCuoiKyQLBVHQT_Final.Properties.Settings.Default.QuanLyBenhVien_DoAnCuoiKiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLBVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BacSi> BacSis
		{
			get
			{
				return this.GetTable<BacSi>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spThemBacSi")]
		public int spThemBacSi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBS", DbType="NVarChar(10)")] string maBS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HoBS", DbType="NVarChar(30)")] string hoBS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenBS", DbType="NVarChar(20)")] string tenBS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgaySinh", DbType="Date")] System.Nullable<System.DateTime> ngaySinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GioiTinh", DbType="NVarChar(10)")] string gioiTinh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChucVu", DbType="NVarChar(20)")] string chucVu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKhoa", DbType="NVarChar(10)")] string maKhoa)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBS, hoBS, tenBS, ngaySinh, gioiTinh, chucVu, maKhoa);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spLayBacSi")]
		public ISingleResult<spLayBacSiResult> spLayBacSi()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<spLayBacSiResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BacSi")]
	public partial class BacSi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaBS;
		
		private string _HoBS;
		
		private string _TenBS;
		
		private System.DateTime _NgaySinh;
		
		private string _GioiTinh;
		
		private string _ChucVu;
		
		private string _MaKhoa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBSChanging(string value);
    partial void OnMaBSChanged();
    partial void OnHoBSChanging(string value);
    partial void OnHoBSChanged();
    partial void OnTenBSChanging(string value);
    partial void OnTenBSChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnMaKhoaChanging(string value);
    partial void OnMaKhoaChanged();
    #endregion
		
		public BacSi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBS", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaBS
		{
			get
			{
				return this._MaBS;
			}
			set
			{
				if ((this._MaBS != value))
				{
					this.OnMaBSChanging(value);
					this.SendPropertyChanging();
					this._MaBS = value;
					this.SendPropertyChanged("MaBS");
					this.OnMaBSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoBS", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string HoBS
		{
			get
			{
				return this._HoBS;
			}
			set
			{
				if ((this._HoBS != value))
				{
					this.OnHoBSChanging(value);
					this.SendPropertyChanging();
					this._HoBS = value;
					this.SendPropertyChanged("HoBS");
					this.OnHoBSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBS", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenBS
		{
			get
			{
				return this._TenBS;
			}
			set
			{
				if ((this._TenBS != value))
				{
					this.OnTenBSChanging(value);
					this.SendPropertyChanging();
					this._TenBS = value;
					this.SendPropertyChanged("TenBS");
					this.OnTenBSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this.OnMaKhoaChanging(value);
					this.SendPropertyChanging();
					this._MaKhoa = value;
					this.SendPropertyChanged("MaKhoa");
					this.OnMaKhoaChanged();
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
	
	public partial class spLayBacSiResult
	{
		
		private string _MaBS;
		
		private string _HoBS;
		
		private string _TenBS;
		
		private System.DateTime _NgaySinh;
		
		private string _GioiTinh;
		
		private string _ChucVu;
		
		private string _MaKhoa;
		
		public spLayBacSiResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBS", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaBS
		{
			get
			{
				return this._MaBS;
			}
			set
			{
				if ((this._MaBS != value))
				{
					this._MaBS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoBS", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string HoBS
		{
			get
			{
				return this._HoBS;
			}
			set
			{
				if ((this._HoBS != value))
				{
					this._HoBS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBS", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenBS
		{
			get
			{
				return this._TenBS;
			}
			set
			{
				if ((this._TenBS != value))
				{
					this._TenBS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this._ChucVu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoa", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string MaKhoa
		{
			get
			{
				return this._MaKhoa;
			}
			set
			{
				if ((this._MaKhoa != value))
				{
					this._MaKhoa = value;
				}
			}
		}
	}
}
#pragma warning restore 1591