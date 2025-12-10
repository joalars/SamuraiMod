using SamuraiMod.Survivors.Samurai.Achievements;
using RoR2;
using UnityEngine;

namespace SamuraiMod.Survivors.Samurai
{
    public static class SamuraiUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                SamuraiMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(SamuraiMasteryAchievement.identifier),
                SamuraiSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
