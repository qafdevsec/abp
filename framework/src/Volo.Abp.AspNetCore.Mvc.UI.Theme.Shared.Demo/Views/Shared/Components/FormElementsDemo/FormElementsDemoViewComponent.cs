using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Prismjs;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Demo.Views.Shared.Components.FormElementsDemo;

[Widget(
    StyleTypes = new[] { typeof(PrismjsStyleBundleContributor) },
    ScriptTypes = new[] { typeof(PrismjsScriptBundleContributor) }
)]
public class FormElementsDemoViewComponent : AbpViewComponent
{
    public const string ViewPath = "/Views/Shared/Components/FormElementsDemo/Default.cshtml";

    public virtual IViewComponentResult Invoke()
    {
        var model = new FormElementsDemoModel();

        return View(ViewPath, model);
    }
}
