﻿using Nikcio.UHeadless.Base.Properties.Models;
using Nikcio.UHeadless.Media.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;

namespace Nikcio.UHeadless.Media.Repositories;

/// <summary>
/// A repository to get Media from Umbraco
/// </summary>
public interface IMediaRepository<TMedia, TProperty>
    where TMedia : IMedia<TProperty>
    where TProperty : IProperty
{
    /// <summary>
    /// Gets the Media based on a fetch method
    /// </summary>
    /// <param name="fetch">The fetch method</param>
    /// <param name="culture">The culture</param>
    /// <returns></returns>
    TMedia? GetMedia(Func<IPublishedMediaCache?, IPublishedContent?> fetch, string? culture);

    /// <summary>
    /// Gets a Media lsit based on a fetch method
    /// </summary>
    /// <param name="fetch">The fetch method</param>
    /// <param name="culture">The culture</param>
    /// <returns></returns>
    IEnumerable<TMedia?> GetMediaList(Func<IPublishedMediaCache?, IEnumerable<IPublishedContent>?> fetch, string? culture);

    /// <summary>
    /// Gets a <see cref="IPublishedContent"/> converted to T
    /// </summary>
    /// <param name="media">The published Media</param>
    /// <param name="culture">The culture</param>
    /// <returns></returns>
    TMedia? GetConvertedMedia(IPublishedContent media, string culture);
}