using HarmonyLib;
using UnityEngine;

namespace MoreAprilFools
{
    [HarmonyPatch(typeof(scrCamera), "Update")]
    public static class UpdatePatch1
    {
        public static void Postfix(scrCamera __instance)
        {
            if (!scnLevelSelect.instance)
                __instance.camobj.transform.localEulerAngles = new Vector3(__instance.transform.localEulerAngles.x, __instance.transform.localEulerAngles.y, __instance.rot + 180);
        }
    }

    [HarmonyPatch(typeof(scrVfxPlus), "Update")]
    public static class UpdatePatch2
    {
        public static void Postfix(scrVfxPlus __instance, scrCamera ___cam)
        {
            if (!scnLevelSelect.instance)
                ___cam.transform.rotation = Quaternion.Euler(0, 0, __instance.camAngle + 180);
        }
    }
}
