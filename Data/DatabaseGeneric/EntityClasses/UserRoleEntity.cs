﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Demo.HelperClasses;
using Demo.FactoryClasses;
using Demo.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Demo.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'UserRole'.<br/><br/></summary>
	[Serializable]
	public partial class UserRoleEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private RoleEntity _role;
		private UserEntity _user;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static UserRoleEntityStaticMetaData _staticMetaData = new UserRoleEntityStaticMetaData();
		private static UserRoleRelations _relationsFactory = new UserRoleRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Role</summary>
			public static readonly string Role = "Role";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UserRoleEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UserRoleEntityStaticMetaData()
			{
				SetEntityCoreInfo("UserRoleEntity", InheritanceHierarchyType.None, false, (int)Demo.EntityType.UserRoleEntity, typeof(UserRoleEntity), typeof(UserRoleEntityFactory), false);
				AddNavigatorMetaData<UserRoleEntity, RoleEntity>("Role", "UserRoles", (a, b) => a._role = b, a => a._role, (a, b) => a.Role = b, Demo.RelationClasses.StaticUserRoleRelations.RoleEntityUsingRoleIdStatic, ()=>new UserRoleRelations().RoleEntityUsingRoleId, null, new int[] { (int)UserRoleFieldIndex.RoleId }, null, true, (int)Demo.EntityType.RoleEntity);
				AddNavigatorMetaData<UserRoleEntity, UserEntity>("User", "UserRoles", (a, b) => a._user = b, a => a._user, (a, b) => a.User = b, Demo.RelationClasses.StaticUserRoleRelations.UserEntityUsingUserIdStatic, ()=>new UserRoleRelations().UserEntityUsingUserId, null, new int[] { (int)UserRoleFieldIndex.UserId }, null, true, (int)Demo.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static UserRoleEntity()
		{
		}

		/// <summary> CTor</summary>
		public UserRoleEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserRoleEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserRoleEntity</param>
		public UserRoleEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for UserRole which data should be fetched into this UserRole object</param>
		public UserRoleEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="validator">The custom validator object for this UserRoleEntity</param>
		public UserRoleEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserRoleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Role' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRole() { return CreateRelationInfoForNavigator("Role"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser() { return CreateRelationInfoForNavigator("User"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserRoleEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static UserRoleRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Role' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRole { get { return _staticMetaData.GetPrefetchPathElement("Role", CommonEntityBase.CreateEntityCollection<RoleEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("User", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The Id property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)UserRoleFieldIndex.Id, true); }
			set { SetValue((int)UserRoleFieldIndex.Id, value); }		}

		/// <summary>The IsActive property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."IsActive".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserRoleFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserRoleFieldIndex.IsActive, value); }
		}

		/// <summary>The RoleId property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."RoleId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RoleId
		{
			get { return (System.Int32)GetValue((int)UserRoleFieldIndex.RoleId, true); }
			set	{ SetValue((int)UserRoleFieldIndex.RoleId, value); }
		}

		/// <summary>The UserId property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."UserId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserId
		{
			get { return (System.Int32)GetValue((int)UserRoleFieldIndex.UserId, true); }
			set	{ SetValue((int)UserRoleFieldIndex.UserId, value); }
		}

		/// <summary>Gets / sets related entity of type 'RoleEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RoleEntity Role
		{
			get { return _role; }
			set { SetSingleRelatedEntityNavigator(value, "Role"); }
		}

		/// <summary>Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get { return _user; }
			set { SetSingleRelatedEntityNavigator(value, "User"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Demo
{
	public enum UserRoleFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>RoleId. </summary>
		RoleId,
		///<summary>UserId. </summary>
		UserId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Demo.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: UserRole. </summary>
	public partial class UserRoleRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between UserRoleEntity and RoleEntity over the m:1 relation they have, using the relation between the fields: UserRole.RoleId - Role.Id</summary>
		public virtual IEntityRelation RoleEntityUsingRoleId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Role", false, new[] { RoleFields.Id, UserRoleFields.RoleId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UserRoleEntity and UserEntity over the m:1 relation they have, using the relation between the fields: UserRole.UserId - User.Id</summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "User", false, new[] { UserFields.Id, UserRoleFields.UserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRoleRelations
	{
		internal static readonly IEntityRelation RoleEntityUsingRoleIdStatic = new UserRoleRelations().RoleEntityUsingRoleId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new UserRoleRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticUserRoleRelations() { }
	}
}
