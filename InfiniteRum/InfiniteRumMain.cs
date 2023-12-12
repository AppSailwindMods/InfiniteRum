using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace InfiniteRum
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class InfiniteRumMain : BaseUnityPlugin
    {
        public const string GUID = "com.app24.infiniterum";
        public const string NAME = "Infinte Rum";
        public const string VERSION = "1.1.1";

        internal static ManualLogSource logSource;

        private void Awake()
        {
            logSource = Logger;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
        }
    }
}
