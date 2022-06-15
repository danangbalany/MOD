using BokuMono;
using BokuMono.Data;
using HarmonyLib;

namespace ModTemplate.Harmony_Patches
{
    [HarmonyPatch(typeof(PlayerRecoveryMasterData), nameof(PlayerRecoveryMasterData.GetRecoveryRate))]
    class Patch
    {
        static void Postfix(PlayerRecoveryMasterData __instance)
        {
            //This changes the time that the player wakes up to 6:00 AM, regardless of when they went to sleep. 
            __instance.WakeUpTime = "6:00";
        }
    }
}
