using PrimeGames.SDK.Common;

namespace PrimeGames.SDK.CrazyGames
{
    [Configuration]
    public class CrazyGamesConfiguration : Configuration
    {
        public override string Name => nameof(CrazyGamesConfiguration);
        public override string Description => string.Empty;
        public override string IconName { get; } = "CrazyGames";
        public override bool ReadOnly { get; } = false;

        public override string AchievementsProviderName { get; } = "FallbackAchievements";
        public override string AdsProviderName { get; } = "CrazyGamesAds";
        public override string EventsReporterProviderName { get; } = "FallbackEventsReporter";
        public override string GameplayReporterProviderName { get; } = "FallbackGameplayReporter";
        public override string AddressablesProviderName { get; } = "UnityEngineAddressables";
        public override string AssetBundlesProviderName { get; } = "UnityEngineAssetBundles";
        public override string StreamingAssetsProviderName { get; } = "UnityEngineStreamingAssets";
        public override string AudioProviderName { get; } = "UnityEngineAudio";
        public override string BootstrapProviderName { get; } = "CrazyGamesBootstrap";
        public override string DataProviderName { get; } = "CrazyGamesData";
        public override string DeviceBrowserProviderName { get; } = "UnityEngineDeviceBrowser";
        public override string DeviceCursorProviderName { get; } = "UnityEngineDeviceCursor";
        public override string DeviceInfoProviderName { get; } = "UnityEngineDeviceInfo";
        public override string FlagsProviderName { get; } = "FallbackFlags";
        public override string LanguageInfoProviderName { get; } = "UnityEngineLanguageInfo";
        public override string PauseProviderName { get; } = "UnityEnginePause";
        public override string PaymentsProviderName { get; } = "FallbackPayments";
        public override string PlatformInfoProviderName { get; } = "CrazyGamesPlatformInfo";
        public override string PlatformInteractionsProviderName { get; } = "FallbackPlatformInteractions";
        public override string PlayerAccountProviderName { get; } = "CrazyGamesPlayerAccount";
        public override string DateTimeProviderName { get; } = "SystemDateTime";
        public override string TimeScaleProviderName { get; } = "UnityEngineTimeScale";
    }
}
