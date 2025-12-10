using System;
using SamuraiMod.Modules;
using SamuraiMod.Survivors.Samurai.Achievements;

namespace SamuraiMod.Survivors.Samurai
{
    public static class SamuraiTokens
    {
        public static void Init()
        {
            AddSamuraiTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Samurai.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddSamuraiTokens()
        {
            string prefix = SamuraiSurvivor.SAMURAI_PREFIX;

            string desc = "Samurai from a different world.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Swing sword to generate stickers." + Environment.NewLine + Environment.NewLine
             + "< ! > Perform iaijutsu to consume stickers for big attacks." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, sammin it.";
            string outroFailure = "..and so he ate shit.";

            Language.Add(prefix + "NAME", "Samurai");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "Warrior From Another World");
            Language.Add(prefix + "LORE", "out here sammin it");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Samurai passive");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", "Does something I think.");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_SLASH_NAME", "Sword");
            Language.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * SamuraiStaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_GUN_NAME", "Handgun");
            Language.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Tokens.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * SamuraiStaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            Language.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            Language.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * SamuraiStaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(SamuraiMasteryAchievement.identifier), "Samurai: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(SamuraiMasteryAchievement.identifier), "As Samurai, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
