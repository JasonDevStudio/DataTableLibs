namespace DataLibrary;

/// <summary>
/// IDataTable
/// </summary>
public interface IDataTable
{
    /// <summary>
    /// Gets or sets the data source.
    /// </summary>
    /// <value>
    /// The data source.
    /// </value>
    IDataSource DataSource { get; set; }

    /// <summary>
    /// Gets or sets the data rows.
    /// </summary>
    /// <value>
    /// The data rows.
    /// </value>
    List<IDataRow> Rows { get; set; }

    /// <summary>
    /// Gets or sets the columns.
    /// </summary>
    /// <value>
    /// The columns.
    /// </value>
    List<IDataColumn> Columns { get; set; }

    /// <summary>
    /// Gets or sets the operates.
    /// </summary>
    /// <value>
    /// The operates.
    /// </value>
    List<ITableOperate> OperateHistories { get; set; }
}