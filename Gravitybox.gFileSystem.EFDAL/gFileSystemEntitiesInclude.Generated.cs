//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Data.Linq.Mapping;
using Gravitybox.gFileSystem.EFDAL;

namespace Gravitybox.gFileSystem.EFDAL
{
	#region ConfigSettingInclude

	/// <summary>
	/// This is a helper object for creating LINQ definitions for context includes on the ConfigSetting collection.
	/// </summary>
	[Serializable]
	[Table(Name = "ConfigSetting")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class ConfigSettingInclude : Gravitybox.gFileSystem.EFDAL.IContextInclude
	{
	}

	#endregion

	#region ContainerInclude

	/// <summary>
	/// This is a helper object for creating LINQ definitions for context includes on the Container collection.
	/// </summary>
	[Serializable]
	[Table(Name = "Container")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class ContainerInclude : Gravitybox.gFileSystem.EFDAL.IContextInclude
	{
		/// <summary>
		/// This is a mapping of the relationship with the FileStash entity.
		/// </summary>
		[Association(ThisKey = "ContainerId", OtherKey = "ContainerId")]
		public Gravitybox.gFileSystem.EFDAL.FileStashInclude FileStashList { get; private set; }

		/// <summary>
		/// This is a mapping of the relationship with the Tenant entity.
		/// </summary>
		[Association(ThisKey = "TenantId", OtherKey = "TenantID")]
		public Gravitybox.gFileSystem.EFDAL.TenantInclude Tenant { get; private set; }

	}

	#endregion

	#region FileStashInclude

	/// <summary>
	/// This is a helper object for creating LINQ definitions for context includes on the FileStash collection.
	/// </summary>
	[Serializable]
	[Table(Name = "FileStash")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class FileStashInclude : Gravitybox.gFileSystem.EFDAL.IContextInclude
	{
		/// <summary>
		/// This is a mapping of the relationship with the Tenant entity.
		/// </summary>
		[Association(ThisKey = "TenantID", OtherKey = "TenantID")]
		public Gravitybox.gFileSystem.EFDAL.TenantInclude Tenant { get; private set; }

		/// <summary>
		/// This is a mapping of the relationship with the Container entity.
		/// </summary>
		[Association(ThisKey = "ContainerId", OtherKey = "ContainerId")]
		public Gravitybox.gFileSystem.EFDAL.ContainerInclude Container { get; private set; }

	}

	#endregion

	#region TenantInclude

	/// <summary>
	/// This is a helper object for creating LINQ definitions for context includes on the Tenant collection.
	/// </summary>
	[Serializable]
	[Table(Name = "Tenant")]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "6.0.0")]
	public partial class TenantInclude : Gravitybox.gFileSystem.EFDAL.IContextInclude
	{
		/// <summary>
		/// This is a mapping of the relationship with the FileStash entity.
		/// </summary>
		[Association(ThisKey = "TenantID", OtherKey = "TenantID")]
		public Gravitybox.gFileSystem.EFDAL.FileStashInclude FileStashList { get; private set; }

		/// <summary>
		/// This is a mapping of the relationship with the Container entity.
		/// </summary>
		[Association(ThisKey = "TenantID", OtherKey = "TenantId")]
		public Gravitybox.gFileSystem.EFDAL.ContainerInclude ContainerList { get; private set; }

	}

	#endregion

}
