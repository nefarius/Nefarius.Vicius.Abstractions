using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nefarius.Vicius.Abstractions.Models;

/// <summary>
///     The shared configuration that has been merged with local and remote parameters.
/// </summary>
/// <remarks>Keep in sync with <see cref="SharedConfig"/>.</remarks>
[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class MergedConfig
{
    /// <summary>
    ///     The process window title visible in the taskbar.
    /// </summary>
    [Required]
    public required string WindowTitle { get; set; }

    /// <summary>
    ///     The product name displayed in the UI and dialogs.
    /// </summary>
    [Required]
    public required string ProductName { get; set; }

    /// <summary>
    ///     The implementation to use to detect the locally installed product version to compare release versions against.
    /// </summary>
    [Required]
    public required ProductVersionDetectionMethod DetectionMethod { get; set; }

    /// <summary>
    ///     The details of the selected <see cref="DetectionMethod" />.
    /// </summary>
    [Required]
    public required ProductVersionDetectionImplementation Detection { get; set; }

    /// <summary>
    ///     URL pointing to a help article opening when an update error occurred.
    /// </summary>
    [Required]
    public required string InstallationErrorUrl { get; set; }

    /// <summary>
    ///     The preferred setup download directory.
    /// </summary>
    /// <remarks>By default, a temporary directory of the current user is used.</remarks>
    [Required]
    public required DownloadLocationConfig DownloadLocation { get; set; }

    /// <summary>
    ///     Gets or sets whether the updater should run as a temporary copy instead from the origin directory.
    /// </summary>
    /// <example>
    ///     This feature is useful when the updater is shipped with a product using Windows Installer, which detects open
    ///     processes that block an upgrade. Enabling this setting re-launches the updater process from a temporary copy so
    ///     on-the-fly upgrades in the origin directory become possible.
    /// </example>
    [Required]
    public required bool RunAsTemporaryCopy { get; set; }
}