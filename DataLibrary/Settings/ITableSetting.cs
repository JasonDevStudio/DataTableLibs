using System.Text.Json.Serialization;
using DataLibrary.Enums;

namespace DataLibrary;

/// <summary>
/// ISetting
/// </summary>
public interface ITableSetting
{
    /// <summary>
    /// Gets or sets the no.
    /// </summary>
    /// <value>
    /// The no.
    /// </value>
    int No { get; set; }

    /// <summary>
    /// Gets or sets the target.
    /// </summary>
    /// <value>
    /// The target.
    /// </value>
    OperateTarget Target { get; set; }

    /// <summary>
    /// Gets or sets the model.
    /// </summary>
    /// <value>
    /// The model.
    /// </value>
    OperateMode Mode { get; set; }

    /// <summary>
    /// Gets or sets the left table identifier.
    /// </summary>
    /// <value>
    /// The left table identifier.
    /// </value>
    string TableId { get; set; }

    /// <summary>
    /// Gets the left table.
    /// </summary>
    /// <value>
    /// The left table.
    /// </value>
    [JsonIgnore]
    IDataTable Table { get; }

    /// <summary>
    /// Gets or sets the add or delete columns.
    /// </summary>
    /// <value>
    /// The add or delete columns.
    /// </value>
    List<IDataColumn> Columns { get; set; }

    /// <summary>
    /// Gets or sets the rows.
    /// </summary>
    /// <value>
    /// The rows.
    /// </value>
    List<IDataRow> Rows { get; set; }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    string ToString();
}
