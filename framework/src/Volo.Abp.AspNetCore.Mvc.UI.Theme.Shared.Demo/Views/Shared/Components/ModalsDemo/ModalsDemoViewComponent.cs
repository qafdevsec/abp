using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Prismjs;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Demo.Views.Shared.Components.ModalsDemo;

[Widget(
    StyleTypes = new[] { typeof(PrismjsStyleBundleContributor) },
    ScriptTypes = new[] { typeof(PrismjsScriptBundleContributor) }
)]
public class ModalsDemoViewComponent : AbpViewComponent
{
    public const string ViewPath = "/Views/Shared/Components/ModalsDemo/Default.cshtml";

    public virtual IViewComponentResult Invoke()
    {
        return View(ViewPath);
    }
}
