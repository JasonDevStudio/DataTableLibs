namespace DataLibrary;

/// <summary>
/// IDataSource
/// </summary>
public interface IDataSource
{
    /// <summary>
    /// Queries the asynchronous.
    /// </summary>
    /// <returns></returns>
    Task QueryAsync();

    /// <summary>
    /// Connetcs the core asynchronous.
    /// </summary>
    /// <returns></returns>
    Task ConnetcCoreAsync();
}