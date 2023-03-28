using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Json;
using Volo.Abp.Minify.Scripts;

namespace MyCompanyName.MyProjectName.Web;

[ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Client)]
[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(AbpApplicationLocalizationScriptController), IncludeSelf = true)]
public class MyAbpApplicationLocalizationScriptController : AbpApplicationLocalizationScriptController
{
    public MyAbpApplicationLocalizationScriptController(
        AbpApplicationLocalizationAppService localizationAppService,
        IOptions<AbpAspNetCoreMvcOptions> options,
        IJsonSerializer jsonSerializer,
        IJavascriptMinifier javascriptMinifier)
        : base(localizationAppService, options, jsonSerializer, javascriptMinifier)
    {
    }
}
