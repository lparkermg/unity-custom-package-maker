// <copyright file="PackageManifest.cs" company="Luke Parker">
// Copyright (c) Luke Parker 2018.
// </copyright>

namespace UnityPackageMaker
{
    /// <summary>
    /// Struct matching the packages manifest.json
    /// </summary>
    internal struct PackageManifest
    {
        /// <summary>
        /// Gets or sets the full name of the package i.e "com.lukeparker.package".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name for the package.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the package version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the minimum unity version the package supports.
        /// </summary>
        public string Unity { get; set; }

        /// <summary>
        /// Gets or sets the package description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the keywords for the package.
        /// </summary>
        public string[] Keywords { get; set; }

        /// <summary>
        /// Gets or sets the category of the package.
        /// </summary>
        public string Category { get; set; }
    }
}