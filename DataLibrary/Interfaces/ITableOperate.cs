using System.Text.Json.Serialization;
using DataLibrary.Enums;

namespace DataLibrary;

/// <summary>
/// ITableOperate
/// </summary>
public interface ITableOperate
{
    /// <summary>
    /// Gets or sets the no.
    /// </summary>
    /// <value>
    /// The no.
    /// </value>
    int No { get; set; }
     
    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    /// <value>
    /// The settings.
    /// </value>
    ITableSetting Settings { get; set; }
     
    /// <summary>
    /// Executes the core asynchronous.
    /// </summary>
    /// <returns></returns>
    Task ExecuteCoreAsync();

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    string ToString();
}