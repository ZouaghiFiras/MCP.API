// Bring in the necessary namespaces for the classes and interfaces used in this code

using CED.Data.Entities;

namespace MCP.Data.Helpers
{
    public class CacheProvider : ICacheProvider
    {
        private readonly IDataBaseProvider _dataBaseProvider;

        public CacheProvider(IDataBaseProvider dataBaseProvider)
        {
            _dataBaseProvider = dataBaseProvider;
        }

        public List<LocalizedEntry> lstLocalizedEntries => GetLocalizedEntries();
        public List<DamageReason> lstDamageReasons => GetDamageReasons();
        public List<ActivityOption> lstActivityOptions => GetActivityOptions();

        public void onInit()
        {
            using (var context = new DataContext())
            {
                GetLocalizedEntries();
                GetDamageReasons();
                GetActivityOptions();
            }
        }

        public List<LocalizedEntry> GetLocalizedEntries()
        {
            return Caching.GetOrSet<List<LocalizedEntry>>(CachingEnum.LocalizedEntries,
                _dataBaseProvider.GetLocalizedEntries);
        }
        public List<DamageReason> GetDamageReasons()
        {
            return Caching.GetOrSet<List<DamageReason>>(CachingEnum.DamageReasons,
                _dataBaseProvider.GetDamageReasons);
        }
        public List<ActivityOption> GetActivityOptions()
        {
            return Caching.GetOrSet<List<ActivityOption>>(CachingEnum.ActivityOptions,
                _dataBaseProvider.GetActivityOptions);
        }
    }
}