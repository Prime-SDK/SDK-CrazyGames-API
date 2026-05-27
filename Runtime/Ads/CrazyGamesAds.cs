using CrazyGames;
using PrimeGames.SDK.Common;
using System;

namespace PrimeGames.SDK.CrazyGames
{
    [Provider(typeof(IAds))]
    public class CrazyGamesAds : CommonAds
    {
        public CrazyGamesAds(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            // Already initialized in the bootstrap.
            SetInitialized();
        }

        protected override void InvokeBannerImpl()
        {
            Logger.CreateText(this, "Use CrazyGames SDK prefabs for banners.");
        }

        protected override void RefreshBannerImpl()
        {
            CrazySDK.Banner.RefreshBanners();
        }

        protected override void DisableBannerImpl()
        {
            Logger.CreateText(this, "Use CrazyGames SDK prefabs for banners.");
        }

        protected override void InvokeInterstitialImpl(InterstitialParameters parameters, Action onOpen, Action<bool> onClose)
        {
            CrazySDK.Ad.RequestAd(CrazyAdType.Midgame,
                () => { onOpen?.Invoke(); },
                (error) => { onClose?.Invoke(false); },
                () => { onClose?.Invoke(true); }
            );
        }

        protected override void InvokeRewardedImpl(RewardedParameters parameters, Action onOpen, Action<bool> onClose)
        {
            CrazySDK.Ad.RequestAd(CrazyAdType.Rewarded,
                () => { onOpen?.Invoke(); },
                (error) => { onClose?.Invoke(false); },
                () => { onClose?.Invoke(true); }
            );
        }
    }
}
