namespace DataLibrary;

/// <summary>
/// IDataColumn
/// </summary>
public interface IDataColumn
{
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; }

    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    string Type { get; }

    /// <summary>
    /// Gets the type of the data.
    /// </summary>
    /// <value>
    /// The type of the data.
    /// </value>
    string DataType { get; }
}
