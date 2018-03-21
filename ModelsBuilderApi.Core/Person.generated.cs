//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace ModelsBuilderApi.Core
{
	/// <summary>Person</summary>
	[PublishedContentModel("person")]
	public partial class Person : PublishedContentModel, INavigationBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "person";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Person(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Person, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Department
		///</summary>
		[ImplementPropertyType("department")]
		public IEnumerable<string> Department
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("department"); }
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public string Email
		{
			get { return this.GetPropertyValue<string>("email"); }
		}

		///<summary>
		/// Facebook username
		///</summary>
		[ImplementPropertyType("facebookUsername")]
		public string FacebookUsername
		{
			get { return this.GetPropertyValue<string>("facebookUsername"); }
		}

		///<summary>
		/// Instagram Username
		///</summary>
		[ImplementPropertyType("instagramUsername")]
		public string InstagramUsername
		{
			get { return this.GetPropertyValue<string>("instagramUsername"); }
		}

		///<summary>
		/// LinkedIn username
		///</summary>
		[ImplementPropertyType("linkedInUsername")]
		public string LinkedInUsername
		{
			get { return this.GetPropertyValue<string>("linkedInUsername"); }
		}

		///<summary>
		/// Photo
		///</summary>
		[ImplementPropertyType("photo")]
		public IPublishedContent Photo
		{
			get { return this.GetPropertyValue<IPublishedContent>("photo"); }
		}

		///<summary>
		/// Twitter username
		///</summary>
		[ImplementPropertyType("twitterUsername")]
		public string TwitterUsername
		{
			get { return this.GetPropertyValue<string>("twitterUsername"); }
		}

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is consired optional since most modern search engines don't use this anymore
		///</summary>
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords
		{
			get { return ModelsBuilderApi.Core.NavigationBase.GetKeywords(this); }
		}

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription
		{
			get { return ModelsBuilderApi.Core.NavigationBase.GetSeoMetaDescription(this); }
		}

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide
		{
			get { return ModelsBuilderApi.Core.NavigationBase.GetUmbracoNavihide(this); }
		}
	}
}
