using System.Text.Json.Serialization;
using DataLibrary.Enums;

namespace DataLibrary;

/// <summary>
/// IOperateSetting
/// </summary>
/// <seealso cref="DataLibrary.ITableSetting" />
public interface IOperateSetting : ITableSetting
{  
    /// <summary>
    /// Gets or sets the midfield columns.
    /// </summary>
    /// <value>
    /// The midfield columns.
    /// </value>
    List<(IDataColumn origin, IDataColumn current)> MidfieldColumns { get; set; }    
}
