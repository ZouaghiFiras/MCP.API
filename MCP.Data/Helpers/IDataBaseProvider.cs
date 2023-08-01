// Bring in the necessary namespaces for the classes and interfaces used in this code

using CED.Data.Entities;

namespace MCP.Data.Helpers
{
    public interface IDataBaseProvider
    {
        List<LocalizedEntry> GetLocalizedEntries();
        List<DamageReason> GetDamageReasons();
        List<ActivityOption> GetActivityOptions();
    }
}