﻿using System.Threading.Tasks;
using Volo.Abp.GlobalFeatures;
using Volo.CmsKit.GlobalFeatures;
using Volo.CmsKit.Pages;

namespace Volo.CmsKit.Public.Pages;

[RequiresGlobalFeature(typeof(PagesFeature))]
public class PagePublicAppService : CmsKitPublicAppServiceBase, IPagePublicAppService
{
    protected IPageRepository PageRepository { get; }

    public PagePublicAppService(IPageRepository pageRepository)
    {
        PageRepository = pageRepository;
    }

    public virtual async Task<PageDto> FindBySlugAsync(string slug)
    {
        var page = await PageRepository.FindBySlugAsync(slug);

        if (page == null)
        {
            return null;
        }

        return ObjectMapper.Map<Page, PageDto>(page);
    }
}
