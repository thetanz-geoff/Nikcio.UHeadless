﻿using HotChocolate;
using Nikcio.UHeadless.UmbracoElements.Properties.EditorsValues.MultiUrlPicker.Commands;
using Umbraco.Cms.Core.Models;

namespace Nikcio.UHeadless.UmbracoElements.Properties.EditorsValues.MultiUrlPicker.Models {
    /// <summary>
    /// Represents a link item
    /// </summary>
    [GraphQLDescription("Represents a link item.")]
    public class BasicLink : Link {
        /// <summary>
        /// Gets the name of the lin
        /// </summary>
        [GraphQLDescription("Gets the name of the link.")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the target of the link
        /// </summary>
        [GraphQLDescription("Gets the target of the link.")]
        public virtual string Target { get; set; }

        /// <summary>
        /// Gets the type of the link
        /// </summary>
        [GraphQLDescription("Gets the type of the link.")]
        public virtual LinkType Type { get; set; }

        /// <summary>
        /// Gets the url of a link
        /// </summary>
        [GraphQLDescription("Gets the url of a link.")]
        public virtual string Url { get; set; }

        /// <inheritdoc/>
        public BasicLink(CreateLink createLink) : base(createLink) {
            Name = createLink.UmbracoLink.Name;
            Target = createLink.UmbracoLink.Target;
            Type = createLink.UmbracoLink.Type;
            Url = createLink.UmbracoLink.Url;
        }
    }
}