namespace MCP.Data.Helpers
{
    public enum CachingEnum
    {
        LocalizedEntries,
        DamageReasons,
        ActivityOptions
    }

    public static class CachingEnumExtension
    {
        /// <summary>
        ///     Get the Cache-ExpiringTime of each enum
        /// </summary>
        /// <param name="c"> the enum key </param>
        /// <returns> expiring time in minutes</returns>
        public static int GetCacheExpiringTime(this CachingEnum c)
        {
            switch (c)
            {
                case CachingEnum.LocalizedEntries:
                    //case CachingEnum.x:
                    return 1200; // 20 hours
                case CachingEnum.DamageReasons:
                    //case CachingEnum.x:
                    return 1200; // 20 hours
                case CachingEnum.ActivityOptions:
                    //case CachingEnum.x:
                    return 1200; // 20 hours

                default:
                    return 1; //1 minute
            }
        }
    }
}