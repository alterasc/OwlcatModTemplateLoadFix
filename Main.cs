using HarmonyLib;
using UnityModManagerNet;

namespace OwlcatModTemplateLoadFix
{
    static class Main
    {
        public static bool Enabled;
        public static UnityModManager.ModEntry ModEntry;
        static bool Load(UnityModManager.ModEntry modEntry)
        {            
            var harmony = new Harmony(modEntry.Info.Id);
            ModEntry = modEntry;
            modEntry.OnToggle = OnToggle;
            harmony.PatchAll();
            return true;
        }
        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Enabled = value;
            return true;
        }
    }
}
