using Harmony;
using System.Reflection;

namespace AudicaModding
{
    internal static class Hooks
    {
        public static void ApplyHooks(HarmonyInstance instance)
        {
            instance.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(PauseHandler), "HMDMounted")]
        private static class PatchPauseHandlerMounted
        {
            private static bool Prefix()
            {
                return true;
            }
        }

        [HarmonyPatch(typeof(PauseHandler), "HMDUnmounted")]
        private static class PatchPauseHandlerUnounted
        {
            private static bool Prefix()
            {
                return true;
            }
        }
    }
}