﻿using System.Diagnostics.CodeAnalysis;

namespace Nefarius.Vicius.Abstractions.Models;

/// <summary>
///     Parameters that might be provided by both the server and the local configuration.
/// </summary>
/// <remarks>Keep in sync with <see cref="MergedConfig"/>.</remarks>
[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public sealed class SharedConfig
{
    private ProductVersionDetectionImplementation? _detection;

    /// <summary>
    ///     The process window title visible in the taskbar.
    /// </summary>
    public string? WindowTitle { get; set; }

    /// <summary>
    ///     The product name displayed in the UI and dialogs.
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    ///     The implementation to use to detect the locally installed product version to compare release versions against.
    /// </summary>
    public ProductVersionDetectionMethod? DetectionMethod { get; private set; }

    /// <summary>
    ///     The details of the selected <see cref="DetectionMethod" />.
    /// </summary>
    public ProductVersionDetectionImplementation? Detection
    {
        get => _detection;
        set
        {
            DetectionMethod = value switch
            {
                RegistryValueConfig _ => ProductVersionDetectionMethod.RegistryValue,
                FileVersionConfig _ => ProductVersionDetectionMethod.FileVersion,
                FileSizeConfig _ => ProductVersionDetectionMethod.FileSize,
                FileChecksumConfig _ => ProductVersionDetectionMethod.FileChecksum,
                CustomExpressionConfig _ => ProductVersionDetectionMethod.CustomExpression,
                _ => DetectionMethod
            };

            _detection = value;
        }
    }

    /// <summary>
    ///     URL pointing to a help article opening when an update error occurred.
    /// </summary>
    public string? InstallationErrorUrl { get; set; }

    /// <summary>
    ///     The preferred setup download directory.
    /// </summary>
    /// <remarks>By default, a temporary directory of the current user is used.</remarks>
    public DownloadLocationConfig? DownloadLocation { get; set; }

    /// <summary>
    ///     Gets or sets whether the updater should run as a temporary copy instead from the origin directory.
    /// </summary>
    /// <example>
    ///     This feature is useful when the updater is shipped with a product using Windows Installer, which detects open
    ///     processes that block an upgrade. Enabling this setting re-launches the updater process from a temporary copy so
    ///     on-the-fly upgrades in the origin directory become possible.
    /// </example>
    public bool? RunAsTemporaryCopy { get; set; }
}