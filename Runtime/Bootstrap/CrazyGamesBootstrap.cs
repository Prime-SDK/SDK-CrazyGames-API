using CrazyGames;
using PrimeGames.SDK.Common;

namespace PrimeGames.SDK.CrazyGames
{
    [Provider(typeof(IBootstrap))]
    public class CrazyGamesBootstrap : CommonBootstrap
    {
        public CrazyGamesBootstrap(IEventDispatcher eventDispatcher)
        {
            eventDispatcher.Start += EventDispatcher_Start;
        }

        private void EventDispatcher_Start()
        {
            CrazySDK.Init(() =>
            {
                SetInitialized();
            });
        }
    }
}
