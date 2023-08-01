using CED.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCP.Data.Helpers
{
    public class DataBaseProvider : IDataBaseProvider
    {
        private readonly DataContext _entities;

        public DataBaseProvider(DataContext entities)
        {
            _entities = entities;
        }

        public List<LocalizedEntry> GetLocalizedEntries()
        {
            return _entities.LocalizedEntries.AsNoTracking().ToList();
        }
        public List<DamageReason> GetDamageReasons()
        {
            return _entities.DamageReasons.AsNoTracking().ToList();
        }
        public List<ActivityOption> GetActivityOptions()
        {
            return _entities.ActivityOptions.AsNoTracking().ToList();
        }
    }
}