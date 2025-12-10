using RoR2;
using SamuraiMod.Modules.Achievements;

namespace SamuraiMod.Survivors.Samurai.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class SamuraiMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = SamuraiSurvivor.SAMURAI_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = SamuraiSurvivor.SAMURAI_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => SamuraiSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}