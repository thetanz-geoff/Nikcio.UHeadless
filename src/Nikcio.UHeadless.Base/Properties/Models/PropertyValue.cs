﻿using HotChocolate.Types;
using Nikcio.UHeadless.Base.Properties.Commands;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Nikcio.UHeadless.Base.Properties.Models;

/// <summary>
/// A base for property values
/// </summary>
[InterfaceType]
public abstract class PropertyValue : IDiscoverable
{
    /// <inheritdoc/>
    protected PropertyValue(CreatePropertyValue createPropertyValue)
    {
        publishedProperty = createPropertyValue.Property;
    }

    /// <summary>
    /// The published property
    /// </summary>
    protected readonly IPublishedProperty publishedProperty;

    /// <summary>
    /// The property alias
    /// </summary>
    public string Alias => publishedProperty.Alias;
}
