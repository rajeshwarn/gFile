//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Linq;
using System.Data.Linq;
using System.Linq.Expressions;
using System.Data.Linq.Mapping;
using System.Collections;
using System.Collections.Generic;
using Gravitybox.gFileSystem.EFDAL;

namespace Gravitybox.gFileSystem.EFDAL
{
	#region ConfigSettingQuery

	/// <summary>
	/// This is a helper object for running LINQ queries on the ConfigSetting collection.
	/// </summary>
	[Serializable]
	[Table(Name = "ConfigSetting")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class ConfigSettingQuery : IBusinessObjectLINQQuery
	{
		#region Properties
		/// <summary>
		/// (Maps to the 'ConfigSetting.ID' database field)
		/// </summary>
		[Column(Name = "ID", DbType = "Int", CanBeNull = false, IsPrimaryKey = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual int ID { get; set; }
		/// <summary>
		/// (Maps to the 'ConfigSetting.Name' database field)
		/// </summary>
		[Column(Name = "Name", DbType = "VarChar (50)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Name { get; set; }
		/// <summary>
		/// (Maps to the 'ConfigSetting.Value' database field)
		/// </summary>
		[Column(Name = "Value", DbType = "VarChar (500)", CanBeNull = true, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Value { get; set; }
		/// <summary>
		/// The date of creation
		/// </summary>
		[Column(Name = "CreatedDate", DbType = "DateTime", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual DateTime? CreatedDate { get; set; }
		/// <summary>
		/// The name of the creating entity
		/// </summary>
		[Column(Name = "CreatedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string CreatedBy { get; set; }
		/// <summary>
		/// The date of last modification
		/// </summary>
		[Column(Name = "ModifiedDate", DbType = "DateTime", CanBeNull = true)]
		public virtual DateTime? ModifiedDate { get; set; }
		/// <summary>
		/// The name of the last modifing entity
		/// </summary>
		[Column(Name = "ModifiedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string ModifiedBy { get; set; }
		/// <summary>
		/// This is an internal field and is not to be used.
		/// </summary>
		[Column(Name = "Timestamp", DbType = "Binary", CanBeNull = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual byte[] Timestamp { get; set; }

		#endregion

	}

	#endregion

	#region ContainerQuery

	/// <summary>
	/// This is a helper object for running LINQ queries on the Container collection.
	/// </summary>
	[Serializable]
	[Table(Name = "Container")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class ContainerQuery : IBusinessObjectLINQQuery
	{
		#region Properties
		/// <summary>
		/// (Maps to the 'Container.ContainerId' database field)
		/// </summary>
		[Column(Name = "ContainerId", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long ContainerId { get; set; }
		/// <summary>
		/// (Maps to the 'Container.Name' database field)
		/// </summary>
		[Column(Name = "Name", DbType = "NVarChar (450)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Name { get; set; }
		/// <summary>
		/// (Maps to the 'Container.TenantId' database field)
		/// </summary>
		[Column(Name = "TenantId", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long TenantId { get; set; }
		/// <summary>
		/// The date of creation
		/// </summary>
		[Column(Name = "CreatedDate", DbType = "DateTime", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual DateTime? CreatedDate { get; set; }
		/// <summary>
		/// The name of the creating entity
		/// </summary>
		[Column(Name = "CreatedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string CreatedBy { get; set; }
		/// <summary>
		/// The date of last modification
		/// </summary>
		[Column(Name = "ModifiedDate", DbType = "DateTime", CanBeNull = true)]
		public virtual DateTime? ModifiedDate { get; set; }
		/// <summary>
		/// The name of the last modifing entity
		/// </summary>
		[Column(Name = "ModifiedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string ModifiedBy { get; set; }
		/// <summary>
		/// This is an internal field and is not to be used.
		/// </summary>
		[Column(Name = "Timestamp", DbType = "Binary", CanBeNull = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual byte[] Timestamp { get; set; }
		/// <summary>
		/// This is a mapping of the relationship with the Tenant entity.
		/// </summary>
		[Association(ThisKey = "TenantId", OtherKey = "TenantID")]
		public Gravitybox.gFileSystem.EFDAL.TenantQuery Tenant { get; private set; }


		#endregion

	}

	#endregion

	#region FileStashQuery

	/// <summary>
	/// This is a helper object for running LINQ queries on the FileStash collection.
	/// </summary>
	[Serializable]
	[Table(Name = "FileStash")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class FileStashQuery : IBusinessObjectLINQQuery
	{
		#region Properties
		/// <summary>
		/// (Maps to the 'FileStash.ContainerId' database field)
		/// </summary>
		[Column(Name = "ContainerId", DbType = "BigInt", CanBeNull = true, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long? ContainerId { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.CrcPlain' database field)
		/// </summary>
		[Column(Name = "CrcPlain", DbType = "VarChar (32)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string CrcPlain { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.FileStashID' database field)
		/// </summary>
		[Column(Name = "FileStashID", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long FileStashID { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.IsCompressed' database field)
		/// </summary>
		[Column(Name = "IsCompressed", DbType = "Bit", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual bool IsCompressed { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.Path' database field)
		/// </summary>
		[Column(Name = "Path", DbType = "NVarChar (450)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Path { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.Size' database field)
		/// </summary>
		[Column(Name = "Size", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long Size { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.StorageSize' database field)
		/// </summary>
		[Column(Name = "StorageSize", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long StorageSize { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.TenantID' database field)
		/// </summary>
		[Column(Name = "TenantID", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long TenantID { get; set; }
		/// <summary>
		/// (Maps to the 'FileStash.UniqueKey' database field)
		/// </summary>
		[Column(Name = "UniqueKey", DbType = "UniqueIdentifier", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual System.Guid UniqueKey { get; set; }
		/// <summary>
		/// The date of creation
		/// </summary>
		[Column(Name = "CreatedDate", DbType = "DateTime", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual DateTime? CreatedDate { get; set; }
		/// <summary>
		/// The name of the creating entity
		/// </summary>
		[Column(Name = "CreatedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string CreatedBy { get; set; }
		/// <summary>
		/// The date of last modification
		/// </summary>
		[Column(Name = "ModifiedDate", DbType = "DateTime", CanBeNull = true)]
		public virtual DateTime? ModifiedDate { get; set; }
		/// <summary>
		/// The name of the last modifing entity
		/// </summary>
		[Column(Name = "ModifiedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string ModifiedBy { get; set; }
		/// <summary>
		/// This is an internal field and is not to be used.
		/// </summary>
		[Column(Name = "Timestamp", DbType = "Binary", CanBeNull = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual byte[] Timestamp { get; set; }
		/// <summary>
		/// This is a mapping of the relationship with the Tenant entity.
		/// </summary>
		[Association(ThisKey = "TenantID", OtherKey = "TenantID")]
		public Gravitybox.gFileSystem.EFDAL.TenantQuery Tenant { get; private set; }

		/// <summary>
		/// This is a mapping of the relationship with the Container entity.
		/// </summary>
		[Association(ThisKey = "ContainerId", OtherKey = "ContainerId")]
		public Gravitybox.gFileSystem.EFDAL.ContainerQuery Container { get; private set; }


		#endregion

	}

	#endregion

	#region TenantQuery

	/// <summary>
	/// This is a helper object for running LINQ queries on the Tenant collection.
	/// </summary>
	[Serializable]
	[Table(Name = "Tenant")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class TenantQuery : IBusinessObjectLINQQuery
	{
		#region Properties
		/// <summary>
		/// (Maps to the 'Tenant.Key' database field)
		/// </summary>
		[Column(Name = "Key", DbType = "VarBinary (48)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual System.Byte[] Key { get; set; }
		/// <summary>
		/// (Maps to the 'Tenant.Name' database field)
		/// </summary>
		[Column(Name = "Name", DbType = "NVarChar (50)", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string Name { get; set; }
		/// <summary>
		/// (Maps to the 'Tenant.TenantID' database field)
		/// </summary>
		[Column(Name = "TenantID", DbType = "BigInt", CanBeNull = false, IsPrimaryKey = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual long TenantID { get; set; }
		/// <summary>
		/// (Maps to the 'Tenant.UniqueKey' database field)
		/// </summary>
		[Column(Name = "UniqueKey", DbType = "UniqueIdentifier", CanBeNull = false, IsPrimaryKey = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual System.Guid UniqueKey { get; set; }
		/// <summary>
		/// The date of creation
		/// </summary>
		[Column(Name = "CreatedDate", DbType = "DateTime", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual DateTime? CreatedDate { get; set; }
		/// <summary>
		/// The name of the creating entity
		/// </summary>
		[Column(Name = "CreatedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string CreatedBy { get; set; }
		/// <summary>
		/// The date of last modification
		/// </summary>
		[Column(Name = "ModifiedDate", DbType = "DateTime", CanBeNull = true)]
		public virtual DateTime? ModifiedDate { get; set; }
		/// <summary>
		/// The name of the last modifing entity
		/// </summary>
		[Column(Name = "ModifiedBy", DbType = "VarChar(100)", CanBeNull = true)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual string ModifiedBy { get; set; }
		/// <summary>
		/// This is an internal field and is not to be used.
		/// </summary>
		[Column(Name = "Timestamp", DbType = "Binary", CanBeNull = false)]
		[System.Diagnostics.DebuggerNonUserCode()]
		public virtual byte[] Timestamp { get; set; }

		#endregion

	}

	#endregion

}
