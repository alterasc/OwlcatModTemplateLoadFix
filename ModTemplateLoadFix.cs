using HarmonyLib;
using Kingmaker.BundlesLoading;
using System.Collections.Generic;
using System.Linq;

namespace OwlcatModTemplateLoadFix.Base
{
    public static class ModTemplateLoadFix
    {
        [HarmonyPatch(typeof(LocationList), nameof(LocationList.OnAfterDeserialize))]
        private class LocationList_OnAfterDeserialize_Patch
        {
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var codes = new List<CodeInstruction>(instructions);
                if (codes.Count == 30)
                {
                    codes.RemoveRange(codes.Count - 7, 6);
                }
                return codes.AsEnumerable();
            }
        }
    }
}
