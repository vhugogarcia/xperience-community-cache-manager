namespace XperienceCommunity.CacheManager.Models;

public class CacheItem
{
    public required string Key { get; set; }
    public required string Value { get; set; }
    public DateTime? Expiration { get; set; }
}
