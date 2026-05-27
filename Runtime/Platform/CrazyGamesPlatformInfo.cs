using PrimeGames.SDK.Common;

namespace PrimeGames.SDK.CrazyGames
{
    [Provider(typeof(IPlatformInfo))]
    public class CrazyGamesPlatformInfo : CommonPlatformInfo
    {
        protected override string GetAppIdImpl()
        {
            return string.Empty;
        }

        protected override PlatformType GetCurrentImpl()
        {
            return PlatformType.CrazyGames;
        }

        protected override DeploymentType GetDeploymentImpl()
        {
            return DeploymentType.Web;
        }
    }
}
