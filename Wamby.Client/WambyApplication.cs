using System.Collections.Generic;
using Wamby.PreviousScansPersistence;

namespace Wamby.Client
{
    public static class WambyApplication
    {
        public static Settings.Settings Settings { get; set; } = new();
        public static Settings.SettingsService SettingsService { get; set; } = new();
        public static List<PreviousScan> PreviousScans { get; set; } = new();
        public static PreviousScansPersistenceService PreviousScansPersistenceService { get; set; } = new();
    }
}