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

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Site - Website</summary>
	[PublishedContentModel("siteWebsite")]
	public partial class SiteWebsite : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "siteWebsite";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SiteWebsite(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SiteWebsite, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Common Title
		///</summary>
		[ImplementPropertyType("commonTitle")]
		public string CommonTitle
		{
			get { return this.GetPropertyValue<string>("commonTitle"); }
		}

		///<summary>
		/// Copyright: Enter the copyright text that will appear on the bottom of the page. Use ##year## as a current year
		///</summary>
		[ImplementPropertyType("copyright")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> Copyright
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("copyright"); }
		}

		///<summary>
		/// Google Analytics Code
		///</summary>
		[ImplementPropertyType("googleAnalyticsCode")]
		public string GoogleAnalyticsCode
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsCode"); }
		}

		///<summary>
		/// Logo
		///</summary>
		[ImplementPropertyType("logo")]
		public IPublishedContent Logo
		{
			get { return this.GetPropertyValue<IPublishedContent>("logo"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> SiteName
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("siteName"); }
		}

		///<summary>
		/// Internal Redirect
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return this.GetPropertyValue<IPublishedContent>("umbracoInternalRedirectId"); }
		}
	}
}
