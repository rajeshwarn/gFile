//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 612
using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using Gravitybox.gFileSystem.EFDAL.Entity;
using System.Data.Entity.Core.Objects;

namespace Gravitybox.gFileSystem.EFDAL
{
	#region EntityMappingConstants Enumeration

	/// <summary>
	/// A map for all entity types in this library
	/// </summary>
	public enum EntityMappingConstants
	{
		/// <summary>
		/// A mapping for the the ConfigSetting entity
		/// </summary>
		ConfigSetting,
		/// <summary>
		/// A mapping for the the Container entity
		/// </summary>
		Container,
		/// <summary>
		/// A mapping for the the FileStash entity
		/// </summary>
		FileStash,
		/// <summary>
		/// A mapping for the the Tenant entity
		/// </summary>
		Tenant,
	}

	#endregion

	#region Entity Context

	/// <summary>
	/// The object context for the schema tied to this generated model.
	/// </summary>
	[DataContract]
	[Serializable]
	public partial class gFileSystemEntities : System.Data.Entity.DbContext, Gravitybox.gFileSystem.EFDAL.IgFileSystemEntities, IContext
	{
		static gFileSystemEntities()
		{
			System.Data.Entity.Infrastructure.Interception.DbInterception.Add(new DbInterceptor());
		}

		/// <summary />
		public static Action<string> QueryLogger { get; set; }

		/// <summary>
		/// A unique key for this object instance
		/// </summary>
		public Guid InstanceKey { get; private set; }

		/// <summary />
		protected override void Dispose(bool disposing)
		{
			QueryPreCache.RemoveAll(InstanceKey);
			base.Dispose(disposing);
		}

		/// <summary>
		/// The audit modifier used to mark database edits
		/// </summary>
		protected ContextStartup _contextStartup = new ContextStartup(null);

		private static Dictionary<string, SequentialIdGenerator> _sequentialIdGeneratorCache = new Dictionary<string, SequentialIdGenerator>();
		private static object _seqCacheLock = new object();

		private const string _version = "0.0.0.0.20";
		private const string _modelKey = "d570da75-dc5a-443f-83e7-b964165ae8e7";

		/// <summary />
		[field:NonSerialized]
		public event EventHandler<Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs> BeforeSaveModifiedEntity;
		/// <summary />
		protected virtual void OnBeforeSaveModifiedEntity(Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs e)
		{
			if(BeforeSaveModifiedEntity != null)
			{
				BeforeSaveModifiedEntity(this, e);
			}
		}

		/// <summary />
		[field:NonSerialized]
		public event EventHandler<Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs> BeforeSaveAddedEntity;
		/// <summary />
		protected virtual void OnBeforeSaveAddedEntity(Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs e)
		{
			if(BeforeSaveAddedEntity != null)
			{
				BeforeSaveAddedEntity(this, e);
			}
		}

		/// <summary />
		[field:NonSerialized]
		public event EventHandler<Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs> AfterSaveModifiedEntity;
		/// <summary />
		protected virtual void OnAfterSaveModifiedEntity(Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs e)
		{
			if(AfterSaveModifiedEntity != null)
			{
				AfterSaveModifiedEntity(this, e);
			}
		}

		/// <summary />
		[field:NonSerialized]
		public event EventHandler<Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs> AfterSaveAddedEntity;
		/// <summary />
		protected virtual void OnAfterSaveAddedEntity(Gravitybox.gFileSystem.EFDAL.EventArguments.EntityListEventArgs e)
		{
			if(AfterSaveAddedEntity != null)
			{
				AfterSaveAddedEntity(this, e);
			}
		}

		#region Constructors

		private void ResetContextStartup()
		{
			try
			{
				var frame = new System.Diagnostics.StackFrame(2, true);
				var method = frame.GetMethod();
				int lineNumber = frame.GetFileLineNumber();
				_contextStartup.DebugInfo = method.DeclaringType.ToString() + "." + method.Name + ":" + lineNumber;
			}
			catch { }
		}

		/// <summary>
		/// Initializes a new gFileSystemEntities object using the connection string found in the 'gFileSystemEntities' section of the application configuration file.
		/// </summary>
		public gFileSystemEntities() :
			base(Util.ConvertNormalCS2EFFromConfig("name=gFileSystemEntities"))
		{
			InstanceKey = Guid.NewGuid();
			_contextStartup = new EFDAL.ContextStartup(null, true);
			ResetContextStartup();
			try
			{
				var builder = new System.Data.Odbc.OdbcConnectionStringBuilder(Util.StripEFCS2Normal(this.Database.Connection.ConnectionString));
				var timeoutValue = "30";
				if (builder.ContainsKey("connect timeout"))
					timeoutValue = (string) builder["connect timeout"];
				else if (builder.ContainsKey("connection timeout"))
					timeoutValue = (string) builder["connection timeout"];
				var v = Convert.ToInt32(timeoutValue);
				if (v > 0)
					this.CommandTimeout = v;
			}
			catch { }
			this.OnContextCreated();
		}

		/// <summary>
		/// Initialize a new gFileSystemEntities object with an audit modifier.
		/// </summary>
		public gFileSystemEntities(ContextStartup contextStartup) :
			base(Util.ConvertNormalCS2EFFromConfig("name=gFileSystemEntities", contextStartup))
		{
			InstanceKey = Guid.NewGuid();
			_contextStartup = contextStartup;
			ResetContextStartup();
			this.ContextOptions.LazyLoadingEnabled = contextStartup.AllowLazyLoading;
			this.CommandTimeout = contextStartup.CommandTimeout;
			this.OnContextCreated();
		}

		/// <summary>
		/// Initialize a new gFileSystemEntities object with an audit modifier.
		/// </summary>
		public gFileSystemEntities(ContextStartup contextStartup, string connectionString) :
			base(Util.ConvertNormalCS2EF(connectionString, contextStartup))
		{
			InstanceKey = Guid.NewGuid();
			_contextStartup = contextStartup;
			ResetContextStartup();
			this.ContextOptions.LazyLoadingEnabled = contextStartup.AllowLazyLoading;
			this.CommandTimeout = contextStartup.CommandTimeout;
			this.OnContextCreated();
		}

		/// <summary>
		/// Initialize a new gFileSystemEntities object.
		/// </summary>
		public gFileSystemEntities(string connectionString) :
			base(Util.ConvertNormalCS2EF(connectionString))
		{
			InstanceKey = Guid.NewGuid();
			_contextStartup = new EFDAL.ContextStartup(null, true);
			ResetContextStartup();
			try
			{
				var builder = new System.Data.Odbc.OdbcConnectionStringBuilder(Util.StripEFCS2Normal(this.Database.Connection.ConnectionString));
				var timeoutValue = "30";
				if (builder.ContainsKey("connect timeout"))
					timeoutValue = (string) builder["connect timeout"];
				else if (builder.ContainsKey("connection timeout"))
					timeoutValue = (string) builder["connection timeout"];
				var v = Convert.ToInt32(timeoutValue);
				if (v > 0)
					this.CommandTimeout = v;
			}
			catch { }
			this.OnContextCreated();
		}

		#endregion

		partial void OnContextCreated();
		partial void OnBeforeSaveChanges(ref bool cancel);
		partial void OnAfterSaveChanges();

		/// <summary>
		/// Model creation event
		/// </summary>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
			Database.SetInitializer(new CustomDatabaseInitializer<gFileSystemEntities>());

			//Manually set the entities that have a security function because their DbSet<> is protected and not set

			#region Hierarchy Mapping
			#endregion

			#region Map Tables
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().ToTable("ConfigSetting", "dbo");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().ToTable("Container", "dbo");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().ToTable("FileStash", "dbo");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().ToTable("Tenant", "dbo");
			#endregion

			#region Setup Fields

			//Field setup for ConfigSetting entity
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().Property(d => d.ID).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().Property(d => d.Name).IsRequired().HasMaxLength(50).HasColumnType("VARCHAR");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().Property(d => d.Value).IsOptional().HasMaxLength(500).HasColumnType("VARCHAR");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().Property(d => d.Timestamp).IsConcurrencyToken(true);

			//Field setup for Container entity
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().Property(d => d.ContainerId).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().Property(d => d.Name).IsRequired().HasMaxLength(450);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().Property(d => d.TenantId).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().Property(d => d.Timestamp).IsConcurrencyToken(true);

			//Field setup for FileStash entity
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.ContainerId).IsOptional();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.CrcPlain).IsRequired().HasMaxLength(32).HasColumnType("VARCHAR");
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.FileStashID).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.IsCompressed).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.Path).IsRequired().HasMaxLength(450);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.Size).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.StorageSize).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.TenantID).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.UniqueKey).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().Property(d => d.Timestamp).IsConcurrencyToken(true);

			//Field setup for Tenant entity
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().Property(d => d.Key).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().Property(d => d.Name).IsRequired().HasMaxLength(50);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().Property(d => d.TenantID).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().Property(d => d.UniqueKey).IsRequired();
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().Property(d => d.Timestamp).IsConcurrencyToken(true);

			#endregion

			#region Ignore Enum Properties


			#endregion

			#region Relations

			//Relation Container -> FileStash
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>()
							 .HasOptional(a => a.Container)
							 .WithMany(b => b.FileStashList)
							 .HasForeignKey(u => new { u.ContainerId })
							 .WillCascadeOnDelete(false);

			//Relation Tenant -> FileStash
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>()
							 .HasRequired(a => a.Tenant)
							 .WithMany(b => b.FileStashList)
							 .HasForeignKey(u => new { u.TenantID })
							 .WillCascadeOnDelete(false);

			//Relation Tenant -> Container
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>()
							 .HasRequired(a => a.Tenant)
							 .WithMany(b => b.ContainerList)
							 .HasForeignKey(u => new { u.TenantId })
							 .WillCascadeOnDelete(false);

			#endregion

			#region Functions


			#endregion

			#region Primary Keys

			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting>().HasKey(x => new { x.ID });
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Container>().HasKey(x => new { x.ContainerId });
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.FileStash>().HasKey(x => new { x.FileStashID });
			modelBuilder.Entity<Gravitybox.gFileSystem.EFDAL.Entity.Tenant>().HasKey(x => new { x.TenantID });

			#endregion

		}

		/// <summary />
		public static void ResetSequentialGuid(EntityMappingConstants entity, string key, Guid seed)
		{
			if (string.IsNullOrEmpty(key))
				throw new Exception("Invalid key");

			lock (_seqCacheLock)
			{
				var k = entity.ToString() + "|" + key;
				if (!_sequentialIdGeneratorCache.ContainsKey(k))
					_sequentialIdGeneratorCache.Add(k, new SequentialIdGenerator(seed));
				else
					_sequentialIdGeneratorCache[k].LastValue = seed;
			}

		}

		/// <summary />
		public static Guid GetNextSequentialGuid(EntityMappingConstants entity, string key)
		{
			if (string.IsNullOrEmpty(key))
				throw new Exception("Invalid key");

			lock (_seqCacheLock)
			{
				var k = entity.ToString() + "|" + key;
				if (!_sequentialIdGeneratorCache.ContainsKey(k))
					ResetSequentialGuid(entity, key, Guid.NewGuid());
				return _sequentialIdGeneratorCache[k].NewId();
			}
		}

		/// <summary>
		/// Persists all updates to the data source and resets change tracking in the object context.
		/// </summary>
		/// <returns>The number of objects in an System.Data.Entity.EntityState.Added, System.Data.Entity.EntityState.Modified, or System.Data.Entity.EntityState.Deleted state when System.Data.Objects.ObjectContext.SaveChanges() was called.</returns>
		public override int SaveChanges()
		{
			var cancel = false;
			OnBeforeSaveChanges(ref cancel);
			if (cancel) return 0;

			//Get the added list
			var addedList = this.ObjectContext.ObjectStateManager.GetObjectStateEntries(System.Data.Entity.EntityState.Added);
			var markedTime = System.DateTime.Now;
			//Process added list
			foreach (var item in addedList)
			{
				var entity = item.Entity as IAuditable;
				if (entity != null)
				{
					var audit = entity as IAuditableSet;
					if (entity.IsModifyAuditImplemented && entity.ModifiedBy != this.ContextStartup.Modifer)
					{
						if (audit != null) audit.ResetCreatedBy(this.ContextStartup.Modifer);
						if (audit != null) audit.ResetModifiedBy(this.ContextStartup.Modifer);
					}
					audit.CreatedDate = markedTime;
					audit.ModifiedDate = markedTime;
				}
			}
			this.OnBeforeSaveAddedEntity(new EventArguments.EntityListEventArgs { List = addedList });

			//Process modified list
			var modifiedList = this.ObjectContext.ObjectStateManager.GetObjectStateEntries(System.Data.Entity.EntityState.Modified);
			foreach (var item in modifiedList)
			{
				var entity = item.Entity as IAuditable;
				if (entity != null)
				{
					var audit = entity as IAuditableSet;
					if (entity.IsModifyAuditImplemented && entity.ModifiedBy != this.ContextStartup.Modifer)
					{
						if (audit != null) audit.ResetModifiedBy(this.ContextStartup.Modifer);
					}
					audit.ModifiedDate = markedTime;
				}
			}
			this.OnBeforeSaveModifiedEntity(new EventArguments.EntityListEventArgs { List = modifiedList });

			var retval = 0;
			DbContextTransaction customTrans = null;
			try
			{
				_paramList.Clear();
				if (base.Database.CurrentTransaction == null)
					customTrans = base.Database.BeginTransaction();
				retval += QueryPreCache.ExecuteDeletes(this);
				retval += base.SaveChanges();
				retval += QueryPreCache.ExecuteUpdates(this);
				if (customTrans != null)
					customTrans.Commit();
			}
			catch (System.Data.Entity.Validation.DbEntityValidationException ex)
			{
				var sb = new System.Text.StringBuilder();
				foreach (var error in ex.EntityValidationErrors)
				{
					foreach (var validationError in error.ValidationErrors)
					{
						sb.AppendLine(validationError.PropertyName + ": " + validationError.ErrorMessage);
					}
				}
				throw new System.Data.Entity.Validation.DbEntityValidationException(sb.ToString(), ex.EntityValidationErrors);
			}
			catch
			{
				throw;
			}
			finally
			{
				if (customTrans != null)
					customTrans.Dispose();
			}
			this.OnAfterSaveAddedEntity(new EventArguments.EntityListEventArgs { List = addedList });
			this.OnAfterSaveModifiedEntity(new EventArguments.EntityListEventArgs { List = modifiedList });
			OnAfterSaveChanges();
			return retval;
		}

		#region Entity Sets

		/// <summary>
		/// Entity set for ConfigSetting
		/// </summary>
		public virtual DbSet<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting> ConfigSetting { get; set; }

		/// <summary>
		/// Entity set for Container
		/// </summary>
		public virtual DbSet<Gravitybox.gFileSystem.EFDAL.Entity.Container> Container { get; set; }

		/// <summary>
		/// Entity set for FileStash
		/// </summary>
		public virtual DbSet<Gravitybox.gFileSystem.EFDAL.Entity.FileStash> FileStash { get; set; }

		/// <summary>
		/// Entity set for Tenant
		/// </summary>
		public virtual DbSet<Gravitybox.gFileSystem.EFDAL.Entity.Tenant> Tenant { get; set; }

		#endregion

		/// <summary>
		/// The global settings of this context
		/// </summary>
		public virtual ContextStartup ContextStartup
		{
			get { return _contextStartup; }
		}

		/// <summary />
		public virtual System.Data.Entity.Core.Objects.ObjectContextOptions ContextOptions
		{
			get { return this.ObjectContext.ContextOptions; }
		}

		/// <summary>
		/// Determines the version of the model that created this library.
		/// </summary>
		public virtual string Version
		{
			get { return _version; }
		}

		/// <summary>
		/// Determines the key of the model that created this library.
		/// </summary>
		public virtual string ModelKey
		{
			get { return _modelKey; }
		}

		/// <summary>
		/// Determines if the API matches the database connection
		/// </summary>
		public virtual bool IsValidConnection()
		{
			return IsValidConnection(GetConnectionString(), true);
		}

		/// <summary>
		/// Determines if the API matches the database connection
		/// </summary>
		public virtual bool IsValidConnection(bool checkVersion)
		{
			return IsValidConnection(GetConnectionString(), checkVersion);
		}

		/// <summary>
		/// Determines if the API matches the database connection
		/// </summary>
		/// <param name="checkVersion">Determines if the check also includes the exact version of the model</param>
		/// <param name="connectionString">Determines the connection string to use when connecting to the database</param>
		/// <returns></returns>
		public virtual bool IsValidConnection(string connectionString, bool checkVersion = true)
		{
			if (string.IsNullOrEmpty(connectionString))
				return false;

			//Get current version
			var version = GetDBVersion(connectionString);

			//If there is any version then the ModelKey was found, if not found then the database does not contain this model
			if (string.IsNullOrEmpty(version))
				return false;

			if (checkVersion)
			{
				if (version != this.Version)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Retrieves the latest database version for the current model
		/// </summary>
		public string GetDBVersion(string connectionString = null)
		{
			var conn = new System.Data.SqlClient.SqlConnection();
			try
			{
				if (string.IsNullOrEmpty(connectionString))
					connectionString = this.ConnectionString;
				conn.ConnectionString = connectionString;
				conn.Open();

				var da = new SqlDataAdapter("select * from sys.tables where name = '__nhydrateschema'", conn);
				var ds = new DataSet();
				da.Fill(ds);
				if (ds.Tables[0].Rows.Count > 0)
				{
					da = new SqlDataAdapter("SELECT * FROM [__nhydrateschema] where [ModelKey] = '" + this.ModelKey + "'", conn);
					ds = new DataSet();
					da.Fill(ds);
					var t = ds.Tables[0];
					if (t.Rows.Count > 0)
					{
						return (string) t.Rows[0]["dbVersion"];
					}
				}
				return string.Empty;
			}
			catch (Exception)
			{
				return string.Empty;
			}
			finally
			{
				if (conn != null)
					conn.Close();
			}
		}

		#region AddItem Methods

		/// <summary>
		/// Adds an entity of to the object context
		/// </summary>
		/// <param name="entity">The entity to add</param>
		public virtual Gravitybox.gFileSystem.EFDAL.IBusinessObject AddItem(Gravitybox.gFileSystem.EFDAL.IBusinessObject entity)
		{
			if (entity == null) throw new NullReferenceException();
			var audit = entity as Gravitybox.gFileSystem.EFDAL.IAuditableSet;
			if (audit != null)
			{
				audit.CreatedBy = _contextStartup.Modifer;
				audit.ModifiedBy = _contextStartup.Modifer;
			}
			if (false) { }
			else if (entity is Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting)
			{
				this.ConfigSetting.Add((Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting)entity);
			}
			else if (entity is Gravitybox.gFileSystem.EFDAL.Entity.Container)
			{
				this.Container.Add((Gravitybox.gFileSystem.EFDAL.Entity.Container)entity);
			}
			else if (entity is Gravitybox.gFileSystem.EFDAL.Entity.FileStash)
			{
				this.FileStash.Add((Gravitybox.gFileSystem.EFDAL.Entity.FileStash)entity);
			}
			else if (entity is Gravitybox.gFileSystem.EFDAL.Entity.Tenant)
			{
				this.Tenant.Add((Gravitybox.gFileSystem.EFDAL.Entity.Tenant)entity);
			}
			return entity;
		}

		#endregion

		#region DeleteItem Methods

		/// <summary>
		/// Deletes an entity from the context
		/// </summary>
		/// <param name="entity">The entity to delete</param>
		public virtual void DeleteItem(IBusinessObject entity)
		{
			if (entity == null) return;
			else this.ObjectContext.DeleteObject(entity);
		}

		#endregion

		/// <summary>
		/// Returns the connection string used for this context object
		/// </summary>
		public string ConnectionString
		{
			get
			{
				try
				{
					if (this.Database.Connection != null && !string.IsNullOrEmpty(this.Database.Connection.ConnectionString))
					{
						return Util.StripEFCS2Normal(this.Database.Connection.ConnectionString);
					}
					else
					{
						return null;
					}
				}
				catch (Exception)
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Returns the globally configured connection string for this context type
		/// </summary>
		internal static string GetConnectionString()
		{
			try
			{
				var a = System.Configuration.ConfigurationManager.ConnectionStrings["gFileSystemEntities"];
				if (a != null)
				{
					var s = a.ConnectionString;
					var regEx = new System.Text.RegularExpressions.Regex("provider connection string\\s*=\\s*\"([^\"]*)");
					var m = regEx.Match(s);
					var connString = s;
					if (m != null && m.Groups.Count > 1)
					{
						connString = m.Groups[1].Value;
					}
					return connString;
				}
				else
				{
					throw new Exception("The connection string was not found.");
				}
			}
			catch (Exception)
			{
				throw new Exception("The connection string was not found.");
			}
		}

		#region IgFileSystem Members

		/// <summary />
		IQueryable<Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting> Gravitybox.gFileSystem.EFDAL.IgFileSystemEntities.ConfigSetting
		{
			get { return this.ConfigSetting.AsQueryable(); }
		}

		/// <summary />
		IQueryable<Gravitybox.gFileSystem.EFDAL.Entity.Container> Gravitybox.gFileSystem.EFDAL.IgFileSystemEntities.Container
		{
			get { return this.Container.AsQueryable(); }
		}

		/// <summary />
		IQueryable<Gravitybox.gFileSystem.EFDAL.Entity.FileStash> Gravitybox.gFileSystem.EFDAL.IgFileSystemEntities.FileStash
		{
			get { return this.FileStash.AsQueryable(); }
		}

		/// <summary />
		IQueryable<Gravitybox.gFileSystem.EFDAL.Entity.Tenant> Gravitybox.gFileSystem.EFDAL.IgFileSystemEntities.Tenant
		{
			get { return this.Tenant.AsQueryable(); }
		}

		/// <summary />
		protected List<string> _paramList = new List<string>();
		#endregion

		#region IContext Interface

		Enum IContext.GetEntityFromField(Enum field)
		{
			return GetEntityFromField(field);
		}

		object IContext.GetMetaData(Enum entity)
		{
			return GetMetaData((EntityMappingConstants)entity);
		}

		System.Type IContext.GetFieldType(Enum field)
		{
			return this.GetFieldType(field);
		}

		#endregion

		#region GetEntityFromField

		/// <summary>
		/// Determines the entity from one of its fields
		/// </summary>
		public static EntityMappingConstants GetEntityFromField(Enum field)
		{
			if (field is Gravitybox.gFileSystem.EFDAL.Entity.ConfigSetting.FieldNameConstants) return Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.ConfigSetting;
			if (field is Gravitybox.gFileSystem.EFDAL.Entity.Container.FieldNameConstants) return Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.Container;
			if (field is Gravitybox.gFileSystem.EFDAL.Entity.FileStash.FieldNameConstants) return Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.FileStash;
			if (field is Gravitybox.gFileSystem.EFDAL.Entity.Tenant.FieldNameConstants) return Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.Tenant;
			throw new Exception("Unknown field type!");
		}

		#endregion

		#region GetMetaData

		/// <summary>
		/// Gets the meta data object for an entity
		/// </summary>
		public static Gravitybox.gFileSystem.EFDAL.IMetadata GetMetaData(Gravitybox.gFileSystem.EFDAL.EntityMappingConstants table)
		{
			switch (table)
			{
				case Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.ConfigSetting: return new Gravitybox.gFileSystem.EFDAL.Entity.Metadata.ConfigSettingMetadata();
				case Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.Container: return new Gravitybox.gFileSystem.EFDAL.Entity.Metadata.ContainerMetadata();
				case Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.FileStash: return new Gravitybox.gFileSystem.EFDAL.Entity.Metadata.FileStashMetadata();
				case Gravitybox.gFileSystem.EFDAL.EntityMappingConstants.Tenant: return new Gravitybox.gFileSystem.EFDAL.Entity.Metadata.TenantMetadata();
			}
			throw new Exception("Entity not found!");
		}

		/// <summary />
		public static string GetTableName(Gravitybox.gFileSystem.EFDAL.EntityMappingConstants entity)
		{
			var item = GetMetaData(entity);
			if (item == null) return null;
			return item.GetTableName();
		}
		#endregion

		#region Interface Extras

		/// <summary>
		/// Reloads the context object from database
		/// </summary>
		public void ReloadItem(BaseEntity entity)
		{
			this.Entry(entity).Reload();
		}

		/// <summary>
		/// Detaches the the object from context
		/// </summary>
		public void DetachItem(BaseEntity entity)
		{
			this.ObjectContext.Detach(entity);
		}

		#endregion

		#region ObjectContext

		/// <summary>
		/// Gets the object context
		/// </summary>
		public System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				if (_objectContext == null)
					_objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;
				return _objectContext;
			}
		}
		private System.Data.Entity.Core.Objects.ObjectContext _objectContext = null;

		/// <summary>
		/// Accepts all changes made to objects in the object context
		/// </summary>
		public void AcceptAllChanges()
		{
			this.ObjectContext.AcceptAllChanges();
		}

		/// <summary>
		/// Determines the timeout of the database connection
		/// </summary>
		public int? CommandTimeout
		{
			get { return this.Database.CommandTimeout; }
			set { this.Database.CommandTimeout = value; }
		}

		#endregion

	}
	#endregion

	internal class CustomDatabaseInitializer<TContext> : IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
	{
		public void InitializeDatabase(TContext context)
		{
		}
	}

	#region DbInterceptor
	internal class DbInterceptor : System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor
	{
		#region IDbCommandInterceptor Members

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.NonQueryExecuted(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
		}

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.NonQueryExecuting(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
		}

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.ReaderExecuted(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
		{
		}

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.ReaderExecuting(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
		{
			try
			{
				//If this is a tenant table then rig query plan for this specific tenant
				if (command.CommandText.Contains("__vw_tenant_"))
				{
					var builder = new SqlConnectionStringBuilder(command.Connection.ConnectionString);
					command.CommandText = "--T:" + builder.UserID + "\r\n" + command.CommandText;
				}
				if (gFileSystemEntities.QueryLogger != null)
				{
					var debugInfo = ((IgFileSystemEntities)(interceptionContext.DbContexts.First())).ContextStartup.DebugInfo;
					gFileSystemEntities.QueryLogger(debugInfo + "\r\n" + command.CommandText);
				}
			}
			catch { }
		}

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.ScalarExecuted(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
		}

		void System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor.ScalarExecuting(System.Data.Common.DbCommand command, System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
		}

		#endregion
	}
	#endregion
}

namespace Gravitybox.gFileSystem.EFDAL.Entity
{
}
#pragma warning restore 612

