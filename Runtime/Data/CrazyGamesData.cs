using CrazyGames;
using PrimeGames.SDK.Common;
using System;

namespace PrimeGames.SDK.CrazyGames
{
    [Provider(typeof(IData))]
    public class CrazyGamesData : CommonData
    {
        private const string JsonKey = "json-data";

        public CrazyGamesData(IEventDispatcher eventDispatcher) : base(eventDispatcher)
        {
            ReadJson((json) => {
                ParseContainers(json);
                SetInitialized();
            });
        }

        protected override void ReadJson(Action<string> jsonRequest)
        {
            string json = CrazySDK.Data.GetString(JsonKey, Naming.EmptyJson);
            jsonRequest?.Invoke(json);
        }

        protected override void WriteJson(string json)
        {
            CrazySDK.Data.SetString(JsonKey, json);
        }
    }
}
