﻿using Umbraco.Cms.Core.Models;

namespace Nikcio.UHeadless.UmbracoElements.Properties.EditorsValues.MultiUrlPicker.Commands {
    /// <summary>
    /// A command to create a link for a multi url picker
    /// </summary>
    public class CreateLink {
        /// <inheritdoc/>
        public CreateLink(Link umbracoLink) {
            UmbracoLink = umbracoLink;
        }

        /// <summary>
        /// The umbraco link model
        /// </summary>
        public Link UmbracoLink { get; }
    }
}
