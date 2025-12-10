using BepInEx;
using SamuraiMod.Survivors.Samurai;
using R2API.Utils;
using RoR2;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

//rename this namespace
namespace SamuraiMod
{
    //[BepInDependency("com.rune580.riskofoptions", BepInDependency.DependencyFlags.SoftDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    public class SamuraiPlugin : BaseUnityPlugin
    {
        public const string MODUID = "com.rayus.SamuraiMod";
        public const string MODNAME = "SamuraiMod";
        public const string MODVERSION = "1.0.0";
        public const string DEVELOPER_PREFIX = "RAYUS";
        public static SamuraiPlugin instance;

        void Awake()
        {
            instance = this;

            Log.Init(Logger);

            Modules.Language.Init();

            new SamuraiSurvivor().Initialize();

            new Modules.ContentPacks().Initialize();
        }
    }
}
