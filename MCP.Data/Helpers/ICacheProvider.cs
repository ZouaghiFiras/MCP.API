using CED.Data.Entities;

namespace MCP.Data.Helpers
{
    public interface ICacheProvider
    {
        List<LocalizedEntry> lstLocalizedEntries { get; }
        List<DamageReason> lstDamageReasons { get; }
        List<ActivityOption> lstActivityOptions { get; }
    }
}