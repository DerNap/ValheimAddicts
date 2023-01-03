using HarmonyLib;
using UnityEngine;
using CustomSlotItemLib;

namespace WisplightSlot
{
    [HarmonyPatch]
    public class Patches
    {
        [HarmonyPatch(typeof(ZNetScene), "Awake")]
        [HarmonyPostfix]
        static void PrefabPostfix(ref ZNetScene __instance)
        {
            GameObject wisplightPrefab = __instance.GetPrefab("Demister");
            CustomSlotManager.ApplyCustomSlotItem(wisplightPrefab, "wisplight");
        }
    }
}
