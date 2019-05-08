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
	/// <summary>Page - Home Page</summary>
	[PublishedContentModel("pageHomePage")]
	public partial class PageHomePage : PublishedContentModel, ITabContent, ITabNavigation, ITabSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body
		///</summary>
		[ImplementPropertyType("body")]
		public Our.Umbraco.Vorto.Models.VortoValue<IHtmlString> Body
		{
			get { return Umbraco.Web.PublishedContentModels.TabContent.GetBody(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> Title
		{
			get { return Umbraco.Web.PublishedContentModels.TabContent.GetTitle(this); }
		}

		///<summary>
		/// Hide In XML Sitemap
		///</summary>
		[ImplementPropertyType("hideInXMLSitemap")]
		public bool HideInXmlsitemap
		{
			get { return Umbraco.Web.PublishedContentModels.TabNavigation.GetHideInXmlsitemap(this); }
		}

		///<summary>
		/// Internal Redirect
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.TabNavigation.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Redirect To
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.TabNavigation.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.TabSeo.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.TabSeo.GetMetaKeywords(this); }
		}

		///<summary>
		/// Meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TabSeo.GetMetaTitle(this); }
		}
	}
}
