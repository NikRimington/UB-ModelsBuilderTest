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
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public Newtonsoft.Json.Linq.JToken BodyText
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("bodyText"); }
		}

		///<summary>
		/// Color Theme: This will be a custom property editor later
		///</summary>
		[ImplementPropertyType("colorTheme")]
		public int ColorTheme
		{
			get { return this.GetPropertyValue<int>("colorTheme"); }
		}

		///<summary>
		/// Font: This will be a custom property editor later
		///</summary>
		[ImplementPropertyType("font")]
		public int Font
		{
			get { return this.GetPropertyValue<int>("font"); }
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("footerAddress")]
		public string FooterAddress
		{
			get { return this.GetPropertyValue<string>("footerAddress"); }
		}

		///<summary>
		/// Call To Action Caption: Caption on the Call To Action Button
		///</summary>
		[ImplementPropertyType("footerCTACaption")]
		public string FooterCtacaption
		{
			get { return this.GetPropertyValue<string>("footerCTACaption"); }
		}

		///<summary>
		/// Call To Action Link
		///</summary>
		[ImplementPropertyType("FooterCtalink")]
		public IPublishedContent FooterCtalink
		{
			get { return this.GetPropertyValue<IPublishedContent>("FooterCtalink"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("footerDescription")]
		public string FooterDescription
		{
			get { return this.GetPropertyValue<string>("footerDescription"); }
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("footerHeader")]
		public string FooterHeader
		{
			get { return this.GetPropertyValue<string>("footerHeader"); }
		}

		///<summary>
		/// Hero Background: Spice up the homepage by adding a beautiful photo that relates to your business
		///</summary>
		[ImplementPropertyType("HeroBackgroundImage")]
		public IPublishedContent HeroBackgroundImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("HeroBackgroundImage"); }
		}

		///<summary>
		/// Call To Action Caption: The caption on the button
		///</summary>
		[ImplementPropertyType("heroCTACaption")]
		public string HeroCtacaption
		{
			get { return this.GetPropertyValue<string>("heroCTACaption"); }
		}

		///<summary>
		/// Call To Action Link
		///</summary>
		[ImplementPropertyType("HeroCtalink")]
		public IPublishedContent HeroCtalink
		{
			get { return this.GetPropertyValue<IPublishedContent>("HeroCtalink"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("heroDescription")]
		public string HeroDescription
		{
			get { return this.GetPropertyValue<string>("heroDescription"); }
		}

		///<summary>
		/// Header: This is the main headline for the hero area on the Homepage
		///</summary>
		[ImplementPropertyType("heroHeader")]
		public string HeroHeader
		{
			get { return this.GetPropertyValue<string>("heroHeader"); }
		}

		///<summary>
		/// Logo: Optional. If you add a logo it'll be used in the upper left corner instead of the site name. Make sure to use a transparent logo for best results
		///</summary>
		[ImplementPropertyType("SiteLogo")]
		public IPublishedContent SiteLogo
		{
			get { return this.GetPropertyValue<IPublishedContent>("SiteLogo"); }
		}

		///<summary>
		/// Sitename: Used on the homepage as well as the title and social cards
		///</summary>
		[ImplementPropertyType("sitename")]
		public string Sitename
		{
			get { return this.GetPropertyValue<string>("sitename"); }
		}
	}
}
