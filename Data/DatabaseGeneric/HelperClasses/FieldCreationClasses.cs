﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Demo.HelperClasses
{
	/// <summary>Field Creation Class for entity RoleEntity</summary>
	public partial class RoleFields
	{
		/// <summary>Creates a new RoleEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.Id); }}
		/// <summary>Creates a new RoleEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.IsActive); }}
		/// <summary>Creates a new RoleEntity.NameArabic field instance</summary>
		public static EntityField2 NameArabic { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.NameArabic); }}
		/// <summary>Creates a new RoleEntity.NameEnglish field instance</summary>
		public static EntityField2 NameEnglish { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.NameEnglish); }}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.CreatedByUserId field instance</summary>
		public static EntityField2 CreatedByUserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.CreatedByUserId); }}
		/// <summary>Creates a new UserEntity.DateCreated field instance</summary>
		public static EntityField2 DateCreated { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.DateCreated); }}
		/// <summary>Creates a new UserEntity.Email field instance</summary>
		public static EntityField2 Email { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Email); }}
		/// <summary>Creates a new UserEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Id); }}
		/// <summary>Creates a new UserEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.IsActive); }}
		/// <summary>Creates a new UserEntity.LastModified field instance</summary>
		public static EntityField2 LastModified { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.LastModified); }}
		/// <summary>Creates a new UserEntity.LastModifiedByUserId field instance</summary>
		public static EntityField2 LastModifiedByUserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.LastModifiedByUserId); }}
		/// <summary>Creates a new UserEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Name); }}
		/// <summary>Creates a new UserEntity.NationalId field instance</summary>
		public static EntityField2 NationalId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.NationalId); }}
	}

	/// <summary>Field Creation Class for entity UserRoleEntity</summary>
	public partial class UserRoleFields
	{
		/// <summary>Creates a new UserRoleEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.Id); }}
		/// <summary>Creates a new UserRoleEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.IsActive); }}
		/// <summary>Creates a new UserRoleEntity.RoleId field instance</summary>
		public static EntityField2 RoleId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.RoleId); }}
		/// <summary>Creates a new UserRoleEntity.UserId field instance</summary>
		public static EntityField2 UserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.UserId); }}
	}
	

}