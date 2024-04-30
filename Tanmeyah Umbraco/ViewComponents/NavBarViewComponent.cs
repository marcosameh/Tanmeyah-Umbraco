using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoBlog.CustomModels;

namespace UmbracoBlog.ViewComponents
{
    [ViewComponent]
    public class NavBarViewComponent : ViewComponent
    {
        private readonly UmbracoHelper umbracoHelper;

        public NavBarViewComponent(UmbracoHelper umbracoHelper)
        {
            this.umbracoHelper = umbracoHelper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navBarModel = new NavBarNode();
            var rootContent = umbracoHelper.ContentAtRoot().FirstOrDefault() as Home;

            if (rootContent != null)
            {
                navBarModel.Name = rootContent.Name;

                foreach (var childContent in rootContent.Children())
                {
                    var navBarChild = new NavBarNode();
                    navBarChild.Name = childContent.Name;
                    navBarChild.Url = childContent.Url();

                    navBarModel.Children.Add(navBarChild);

                    if (childContent.Children() != null)
                    {
                        foreach (var grandChildContent in childContent.Children())
                        {
                            navBarChild.Children.Add(new NavBarNode { Name = grandChildContent.Name, Url = grandChildContent.Url() });
                        }
                    }
                }
            }

            return View(navBarModel);
        }
    }
}