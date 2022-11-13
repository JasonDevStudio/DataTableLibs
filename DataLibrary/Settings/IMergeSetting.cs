using System.Text.Json.Serialization;

namespace DataLibrary;

/// <summary>
/// IMergeSetting
/// </summary>
/// <seealso cref="ITableSetting" />
public interface IMergeSetting : ITableSetting
{  
    /// <summary>
    /// Gets or sets the right table identifier.
    /// </summary>
    /// <value>
    /// The right table identifier.
    /// </value>
    string RightTableId { get; set; }
    
    /// <summary>
    /// Gets the right table.
    /// </summary>
    /// <value>
    /// The right table.
    /// </value>
    [JsonIgnore]
    IDataTable RightTable { get; }

    /// <summary>
    /// Gets or sets the math columns.
    /// </summary>
    /// <value>
    /// The math columns.
    /// </value>
    List<(IDataColumn left, IDataColumn right)> MathColumns { get; set; } 
}
