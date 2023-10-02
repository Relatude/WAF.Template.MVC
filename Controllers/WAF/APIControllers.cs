// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.API;

namespace WAF{
public static class ApiConfig{
public static void RegisterDataModel() {
StaticContext.RegisterModelsInAssembly<BaseDefinition>();
StaticContext.RegisterModelsInAssembly<NativeDefinition>();
StaticContext.RegisterModelsInAssembly<CustomDefinition>();
}
}
}


public class WAFPropertyHandlerController : WAF.API.Web.WAFPropertyHandlerControllerBase{
public WAFPropertyHandlerController(WAF.API.Web.WAFControllerContext ctx) : base(ctx) { }
}

public class Native_ContentBaseController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentBase> { 
public Native_ContentBaseController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_BlogPageController : WAF.Server.Controllers.ContentController<WAF.API.Native.BlogPage> { 
public Native_BlogPageController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_BlogController : WAF.Server.Controllers.ContentController<WAF.API.Native.Blog> { 
public Native_BlogController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_BlogCategoryController : WAF.Server.Controllers.ContentController<WAF.API.Native.BlogCategory> { 
public Native_BlogCategoryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_BlogPostController : WAF.Server.Controllers.ContentController<WAF.API.Native.BlogPost> { 
public Native_BlogPostController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentFile> { 
public Native_ContentFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DefCultureController : WAF.Server.Controllers.ContentController<WAF.API.Native.DefCulture> { 
public Native_DefCultureController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentSnapshotController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentSnapshot> { 
public Native_ContentSnapshotController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DocumentFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.DocumentFile> { 
public Native_DocumentFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DomainController : WAF.Server.Controllers.ContentController<WAF.API.Native.Domain> { 
public Native_DomainController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_UrlStatusController : WAF.Server.Controllers.ContentController<WAF.API.Native.UrlStatus> { 
public Native_UrlStatusController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_InstallationController : WAF.Server.Controllers.ContentController<WAF.API.Native.Installation> { 
public Native_InstallationController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentTagController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentTag> { 
public Native_ContentTagController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_TagVocabularyController : WAF.Server.Controllers.ContentController<WAF.API.Native.TagVocabulary> { 
public Native_TagVocabularyController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_TagTermController : WAF.Server.Controllers.ContentController<WAF.API.Native.TagTerm> { 
public Native_TagTermController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileConversionController : WAF.Server.Controllers.ContentController<WAF.API.Native.FileConversion> { 
public Native_FileConversionController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileFolderController : WAF.Server.Controllers.ContentController<WAF.API.Native.FileFolder> { 
public Native_FileFolderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileLibraryController : WAF.Server.Controllers.ContentController<WAF.API.Native.FileLibrary> { 
public Native_FileLibraryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileshareController : WAF.Server.Controllers.ContentController<WAF.API.Native.Fileshare> { 
public Native_FileshareController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileshareFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.FileshareFile> { 
public Native_FileshareFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_FileshareFolderController : WAF.Server.Controllers.ContentController<WAF.API.Native.FileshareFolder> { 
public Native_FileshareFolderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumController : WAF.Server.Controllers.ContentController<WAF.API.Native.Forum> { 
public Native_ForumController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumCategoryController : WAF.Server.Controllers.ContentController<WAF.API.Native.ForumCategory> { 
public Native_ForumCategoryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumGlobalSettingsController : WAF.Server.Controllers.ContentController<WAF.API.Native.ForumGlobalSettings> { 
public Native_ForumGlobalSettingsController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumMessageController : WAF.Server.Controllers.ContentController<WAF.API.Native.ForumMessage> { 
public Native_ForumMessageController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumRankController : WAF.Server.Controllers.ContentController<WAF.API.Native.ForumRank> { 
public Native_ForumRankController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ForumThreadController : WAF.Server.Controllers.ContentController<WAF.API.Native.ForumThread> { 
public Native_ForumThreadController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_GroupFileLibraryController : WAF.Server.Controllers.ContentController<WAF.API.Native.GroupFileLibrary> { 
public Native_GroupFileLibraryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_HierarchicalContentController : WAF.Server.Controllers.ContentController<WAF.API.Native.HierarchicalContent> { 
public Native_HierarchicalContentController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ImageFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.ImageFile> { 
public Native_ImageFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_LogSettingController : WAF.Server.Controllers.ContentController<WAF.API.Native.LogSetting> { 
public Native_LogSettingController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ModuleController : WAF.Server.Controllers.ContentController<WAF.API.Native.Module> { 
public Native_ModuleController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_NewsletterController : WAF.Server.Controllers.ContentController<WAF.API.Native.Newsletter> { 
public Native_NewsletterController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_NewsletterDeliveryController : WAF.Server.Controllers.ContentController<WAF.API.Native.NewsletterDelivery> { 
public Native_NewsletterDeliveryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_NewsletterRecipientListController : WAF.Server.Controllers.ContentController<WAF.API.Native.NewsletterRecipientList> { 
public Native_NewsletterRecipientListController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ScheduledTaskController : WAF.Server.Controllers.ContentController<WAF.API.Native.ScheduledTask> { 
public Native_ScheduledTaskController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SiteController : WAF.Server.Controllers.ContentController<WAF.API.Native.Site> { 
public Native_SiteController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SoundFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.SoundFile> { 
public Native_SoundFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_StylesheetController : WAF.Server.Controllers.ContentController<WAF.API.Native.Stylesheet> { 
public Native_StylesheetController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SystemUserController : WAF.Server.Controllers.ContentController<WAF.API.Native.SystemUser> { 
public Native_SystemUserController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_TemplateController : WAF.Server.Controllers.ContentController<WAF.API.Native.Template> { 
public Native_TemplateController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_MVCTemplateController : WAF.Server.Controllers.ContentController<WAF.API.Native.MVCTemplate> { 
public Native_MVCTemplateController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_UserGroupController : WAF.Server.Controllers.ContentController<WAF.API.Native.UserGroup> { 
public Native_UserGroupController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_VideoFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.VideoFile> { 
public Native_VideoFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_InteractiveFileController : WAF.Server.Controllers.ContentController<WAF.API.Native.InteractiveFile> { 
public Native_InteractiveFileController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_HierarchicalFolderController : WAF.Server.Controllers.ContentController<WAF.API.Native.HierarchicalFolder> { 
public Native_HierarchicalFolderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SpecializedPageController : WAF.Server.Controllers.ContentController<WAF.API.Native.SpecializedPage> { 
public Native_SpecializedPageController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_RedirectPageController : WAF.Server.Controllers.ContentController<WAF.API.Native.RedirectPage> { 
public Native_RedirectPageController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SMSController : WAF.Server.Controllers.ContentController<WAF.API.Native.SMS> { 
public Native_SMSController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentQueryController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentQuery> { 
public Native_ContentQueryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_JoinQueryController : WAF.Server.Controllers.ContentController<WAF.API.Native.JoinQuery> { 
public Native_JoinQueryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_QueryFilterController : WAF.Server.Controllers.ContentController<WAF.API.Native.QueryFilter> { 
public Native_QueryFilterController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ArticleBaseController : WAF.Server.Controllers.ContentController<WAF.API.Native.ArticleBase> { 
public Native_ArticleBaseController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_WebFormController : WAF.Server.Controllers.ContentController<WAF.API.Native.WebForm> { 
public Native_WebFormController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_WebFormSubmitController : WAF.Server.Controllers.ContentController<WAF.API.Native.WebFormSubmit> { 
public Native_WebFormSubmitController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ProductBaseController : WAF.Server.Controllers.ContentController<WAF.API.Native.ProductBase> { 
public Native_ProductBaseController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ProductCategoryController : WAF.Server.Controllers.ContentController<WAF.API.Native.ProductCategory> { 
public Native_ProductCategoryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ShopController : WAF.Server.Controllers.ContentController<WAF.API.Native.Shop> { 
public Native_ShopController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ReviewController : WAF.Server.Controllers.ContentController<WAF.API.Native.Review> { 
public Native_ReviewController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_OrderController : WAF.Server.Controllers.ContentController<WAF.API.Native.Order> { 
public Native_OrderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_OrderItemController : WAF.Server.Controllers.ContentController<WAF.API.Native.OrderItem> { 
public Native_OrderItemController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_CurrencyController : WAF.Server.Controllers.ContentController<WAF.API.Native.Currency> { 
public Native_CurrencyController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_CountryController : WAF.Server.Controllers.ContentController<WAF.API.Native.Country> { 
public Native_CountryController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ManufacturerController : WAF.Server.Controllers.ContentController<WAF.API.Native.Manufacturer> { 
public Native_ManufacturerController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ShippingMethodController : WAF.Server.Controllers.ContentController<WAF.API.Native.ShippingMethod> { 
public Native_ShippingMethodController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_PaymentMethodController : WAF.Server.Controllers.ContentController<WAF.API.Native.PaymentMethod> { 
public Native_PaymentMethodController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DashboardBoxController : WAF.Server.Controllers.ContentController<WAF.API.Native.DashboardBox> { 
public Native_DashboardBoxController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ShopEmailController : WAF.Server.Controllers.ContentController<WAF.API.Native.ShopEmail> { 
public Native_ShopEmailController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountBaseController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountBase> { 
public Native_DiscountBaseController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_UsedDiscountController : WAF.Server.Controllers.ContentController<WAF.API.Native.UsedDiscount> { 
public Native_UsedDiscountController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountPercentageOffProductController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountPercentageOffProduct> { 
public Native_DiscountPercentageOffProductController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ProductImportController : WAF.Server.Controllers.ContentController<WAF.API.Native.ProductImport> { 
public Native_ProductImportController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountAmountOffProductController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountAmountOffProduct> { 
public Native_DiscountAmountOffProductController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountAmountOffOrderController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountAmountOffOrder> { 
public Native_DiscountAmountOffOrderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountPercentageOffOrderController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountPercentageOffOrder> { 
public Native_DiscountPercentageOffOrderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountPercentageOffShippingController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountPercentageOffShipping> { 
public Native_DiscountPercentageOffShippingController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountAmountOffShippingController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountAmountOffShipping> { 
public Native_DiscountAmountOffShippingController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountAmountOffProductYWhenBuyingXController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX> { 
public Native_DiscountAmountOffProductYWhenBuyingXController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_DiscountPercentageOffProductYWhenBuyingXController : WAF.Server.Controllers.ContentController<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX> { 
public Native_DiscountPercentageOffProductYWhenBuyingXController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_CreditCardPaymentMethodController : WAF.Server.Controllers.ContentController<WAF.API.Native.CreditCardPaymentMethod> { 
public Native_CreditCardPaymentMethodController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ProductBundleController : WAF.Server.Controllers.ContentController<WAF.API.Native.ProductBundle> { 
public Native_ProductBundleController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ItemCostShippingCalculationMethodController : WAF.Server.Controllers.ContentController<WAF.API.Native.ItemCostShippingCalculationMethod> { 
public Native_ItemCostShippingCalculationMethodController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_PercentageShippingCalculationMethodController : WAF.Server.Controllers.ContentController<WAF.API.Native.PercentageShippingCalculationMethod> { 
public Native_PercentageShippingCalculationMethodController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_AdaptiveNewsletterController : WAF.Server.Controllers.ContentController<WAF.API.Native.AdaptiveNewsletter> { 
public Native_AdaptiveNewsletterController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_NewsletterTemplateController : WAF.Server.Controllers.ContentController<WAF.API.Native.NewsletterTemplate> { 
public Native_NewsletterTemplateController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_BasicNewsletterController : WAF.Server.Controllers.ContentController<WAF.API.Native.BasicNewsletter> { 
public Native_BasicNewsletterController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_StandardVisitorSegmentController : WAF.Server.Controllers.ContentController<WAF.API.Native.StandardVisitorSegment> { 
public Native_StandardVisitorSegmentController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_SegmentationSettingsController : WAF.Server.Controllers.ContentController<WAF.API.Native.SegmentationSettings> { 
public Native_SegmentationSettingsController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_TaxClassController : WAF.Server.Controllers.ContentController<WAF.API.Native.TaxClass> { 
public Native_TaxClassController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_TaxRateController : WAF.Server.Controllers.ContentController<WAF.API.Native.TaxRate> { 
public Native_TaxRateController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ChatController : WAF.Server.Controllers.ContentController<WAF.API.Native.Chat> { 
public Native_ChatController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ChatAccountController : WAF.Server.Controllers.ContentController<WAF.API.Native.ChatAccount> { 
public Native_ChatAccountController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_StorageProviderController : WAF.Server.Controllers.ContentController<WAF.API.Native.StorageProvider> { 
public Native_StorageProviderController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentCardTemplateController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentCardTemplate> { 
public Native_ContentCardTemplateController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_UIMenuItemController : WAF.Server.Controllers.ContentController<WAF.API.Native.UIMenuItem> { 
public Native_UIMenuItemController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_UIPlugInController : WAF.Server.Controllers.ContentController<WAF.API.Native.UIPlugIn> { 
public Native_UIPlugInController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_OptimizingModuleController : WAF.Server.Controllers.ContentController<WAF.API.Native.OptimizingModule> { 
public Native_OptimizingModuleController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_ContentModuleBaseController : WAF.Server.Controllers.ContentController<WAF.API.Native.ContentModuleBase> { 
public Native_ContentModuleBaseController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
public class Native_HeadlessServerController : WAF.Server.Controllers.ContentController<WAF.API.Native.HeadlessServer> { 
public Native_HeadlessServerController(AdminUIAPIControllerContext ctx) : base(ctx) {    }
}
