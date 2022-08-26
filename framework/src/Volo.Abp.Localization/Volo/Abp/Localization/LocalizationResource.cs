﻿using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Volo.Abp.Localization;

public class LocalizationResource : LocalizationResourceBase
{
    [NotNull]
    private Type ResourceType { get; }

    public LocalizationResource(
        [NotNull] Type resourceType,
        [CanBeNull] string defaultCultureName = null,
        [CanBeNull] ILocalizationResourceContributor initialContributor = null)
        : base(LocalizationResourceNameAttribute.GetName(resourceType))
    {
        ResourceType = Check.NotNull(resourceType, nameof(resourceType));
        DefaultCultureName = defaultCultureName;

        AddBaseResourceTypes();
        
        if (initialContributor != null)
        {
            Contributors.Add(initialContributor);
        }
    }

    protected virtual void AddBaseResourceTypes()
    {
        var descriptors = ResourceType
            .GetCustomAttributes(true)
            .OfType<IInheritedResourceTypesProvider>();

        foreach (var descriptor in descriptors)
        {
            foreach (var baseResourceType in descriptor.GetInheritedResourceTypes())
            {
                BaseResourceNames.AddIfNotContains(LocalizationResourceNameAttribute.GetName(baseResourceType));
            }
        }
    }
}