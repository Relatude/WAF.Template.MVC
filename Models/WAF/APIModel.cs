// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };



namespace WAF.API.GraphQL {
public class RelatudeContentQuery {
WAF.API.Web.WAFNativeContext _ctx;
public RelatudeContentQuery(WAF.API.Web.WAFNativeContext ctx) {
  _ctx = ctx;
}


[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPage>> GetBlogPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Blog>> GetBlogs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Blog>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogCategory>> GetBlogCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPost>> GetBlogPosts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPost>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentFile>> GetContentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DefCulture>> GetDefCultures() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DefCulture>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentSnapshot>> GetContentSnapshots() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentSnapshot>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DocumentFile>> GetDocumentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DocumentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Domain>> GetDomains() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Domain>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UrlStatus>> GetUrlStati() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UrlStatus>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Installation>> GetInstallatia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Installation>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentTag>> GetContentTags() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentTag>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagVocabulary>> GetTagVocabularies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagVocabulary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagTerm>> GetTagTerms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagTerm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileConversion>> GetFileConversia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileConversion>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileFolder>> GetFileFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileLibrary>> GetFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Fileshare>> GetFileshares() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Fileshare>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFile>> GetFileshareFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFolder>> GetFileshareFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Forum>> GetForums() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Forum>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumCategory>> GetForumCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumGlobalSettings>> GetForumGlobalSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumGlobalSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumMessage>> GetForumMessages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumMessage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumRank>> GetForumRanks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumRank>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumThread>> GetForumThreads() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumThread>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.GroupFileLibrary>> GetGroupFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.GroupFileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalContent>> GetHierarchicalContents() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalContent>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ImageFile>> GetImageFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ImageFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.LogSetting>> GetLogSettings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.LogSetting>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Module>> GetModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Module>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Newsletter>> GetNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Newsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterDelivery>> GetNewsletterDeliveries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterDelivery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterRecipientList>> GetNewsletterRecipientLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterRecipientList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ScheduledTask>> GetScheduledTasks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ScheduledTask>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Site>> GetSites() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Site>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SoundFile>> GetSoundFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SoundFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Stylesheet>> GetStylesheets() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Stylesheet>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SystemUser>> GetSystemUsers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SystemUser>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Template>> GetTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Template>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MVCTemplate>> GetMVCTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MVCTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UserGroup>> GetUserGroups() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UserGroup>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VideoFile>> GetVideoFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VideoFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.InteractiveFile>> GetInteractiveFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.InteractiveFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalFolder>> GetHierarchicalFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SpecializedPage>> GetSpecializedPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SpecializedPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.RedirectPage>> GetRedirectPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.RedirectPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MessageBase>> GetMessageBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MessageBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SMS>> GetSMSs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SMS>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQueryBase>> GetContentQueryBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQueryBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQuery>> GetContentQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.JoinQuery>> GetJoinQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.JoinQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.QueryFilter>> GetQueryFilters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.QueryFilter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ArticleBase>> GetArticleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ArticleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebForm>> GetWebForms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebForm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebFormSubmit>> GetWebFormSubmits() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebFormSubmit>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBase>> GetProductBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductCategory>> GetProductCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Shop>> GetShops() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Shop>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Review>> GetReviews() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Review>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Order>> GetOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Order>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OrderItem>> GetOrderItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OrderItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Currency>> GetCurrencies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Currency>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Country>> GetCountries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Country>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Manufacturer>> GetManufacturers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Manufacturer>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShippingMethod>> GetShippingMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShippingMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PaymentMethod>> GetPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DashboardBox>> GetDashboardBoxes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DashboardBox>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShopEmail>> GetShopEmails() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShopEmail>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountBase>> GetDiscountBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UsedDiscount>> GetUsedDiscounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UsedDiscount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProduct>> GetDiscountPercentageOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductImport>> GetProductImports() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductImport>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProduct>> GetDiscountAmountOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffOrder>> GetDiscountAmountOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffOrder>> GetDiscountPercentageOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffShipping>> GetDiscountPercentageOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffShipping>> GetDiscountAmountOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>> GetDiscountAmountOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>> GetDiscountPercentageOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.CreditCardPaymentMethod>> GetCreditCardPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.CreditCardPaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBundle>> GetProductBundles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBundle>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ItemCostShippingCalculationMethod>> GetItemCostShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ItemCostShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PercentageShippingCalculationMethod>> GetPercentageShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PercentageShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.AdaptiveNewsletter>> GetAdaptiveNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.AdaptiveNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterTemplate>> GetNewsletterTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BasicNewsletter>> GetBasicNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BasicNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VisitorSegment>> GetVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StandardVisitorSegment>> GetStandardVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StandardVisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SegmentationSettings>> GetSegmentationSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SegmentationSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxClass>> GetTaxClasses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxClass>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxRate>> GetTaxRates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxRate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Chat>> GetChats() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Chat>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ChatAccount>> GetChatAccounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ChatAccount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StorageProvider>> GetStorageProviders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StorageProvider>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentCardTemplate>> GetContentCardTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentCardTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIMenuItem>> GetUIMenuItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIMenuItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIPlugIn>> GetUIPlugIns() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIPlugIn>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OptimizingModule>> GetOptimizingModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OptimizingModule>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentModuleBase>> GetContentModuleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentModuleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HeadlessServer>> GetHeadlessServers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HeadlessServer>(QueryOptions.Default).ToList().AsQueryable());
}

}
}

