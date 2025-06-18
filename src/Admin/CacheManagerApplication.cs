using CMS.Membership;

using Kentico.Xperience.Admin.Base;
using Kentico.Xperience.Admin.Base.UIPages;

using XperienceCommunity.CacheManager.Admin;
using XperienceCommunity.CacheManager.Admin.UIPages;

// Main application
[assembly: UIApplication(
    identifier: CacheManagerApplicationPage.IDENTIFIER,
    type: typeof(CacheManagerApplicationPage),
    slug: "cachemanager",
    name: "Cache manager",
    category: BaseApplicationCategories.DEVELOPMENT,
    icon: Icons.Database,
    templateName: TemplateNames.SECTION_LAYOUT)]

// Result page
[assembly: UIPage(
    parentType: typeof(CacheManagerApplicationPage),
    slug: "list",
    uiPageType: typeof(ResultListing),
    name: "List of cache items",
    templateName: TemplateNames.LISTING,
    order: UIPageOrder.NoOrder)]

// View details
[assembly: UIPage(
    parentType: typeof(ResultListing),
    slug: PageParameterConstants.PARAMETERIZED_SLUG,
    uiPageType: typeof(ViewDetails),
    name: "View details",
    templateName: TemplateNames.EDIT,
    order: UIPageOrder.NoOrder)]


namespace XperienceCommunity.CacheManager.Admin;

/// <summary>
/// The root application page for the Cache Manager.
/// </summary>
[UIPermission(SystemPermissions.VIEW)]
[UIPermission(SystemPermissions.UPDATE, "Execute")]
public class CacheManagerApplicationPage : ApplicationPage
{
    public const string IDENTIFIER = "XperienceCommunity.CacheManager";
}
