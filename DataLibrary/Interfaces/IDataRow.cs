namespace DataLibrary;

/// <summary>
/// IDataColumn
/// </summary>
public interface IDataRow
{
    /// <summary>
    /// Gets or sets the index of the row.
    /// </summary>
    /// <value>
    /// The index of the row.
    /// </value>
    int RowIndex { get; set; }

    /// <summary>
    /// Gets or sets the values.
    /// </summary>
    /// <value>
    /// The values.
    /// </value>
    object[] Values { get; set; }
}
