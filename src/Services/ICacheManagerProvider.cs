using System.Data;

using CMS.Base;

namespace XperienceCommunity.CacheManager.Services;

/// <summary>
/// Contains methods for retrieving results from the connected database.
/// </summary>
public interface ICacheManagerProvider
{
    /// <summary>
    /// Gets all cache items in the current result set.
    /// </summary>
    public DataSet? Get();


    /// <summary>
    /// Clears the cache by removing all items from the result set.
    /// </summary>
    public void Clear();


    /// <summary>
    /// Gets the number of cache items in the result set.
    /// </summary>
    public int Count();

    /// <summary>
    /// Gets the current result set converted to <see cref="IDataContainer"/>s. Automatically sets the identifier for each container to
    /// be retrieved later by <see cref="GetRowAsText"/>.
    /// </summary>
    public Task<IEnumerable<IDataContainer>> GetRowsAsDataContainer();

    /// <summary>
    /// Gets a record from the current result set, transformed into a human-readable format.
    /// </summary>
    /// <param name="rowIdentifier">The identifier of the record to retrieve.</param>
    public Task<string> GetRowAsText(int rowIdentifier);
}
