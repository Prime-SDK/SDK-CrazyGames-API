using CrazyGames;
using PrimeGames.SDK.Common;
using System;

namespace PrimeGames.SDK.CrazyGames
{
    [Provider(typeof(IPlayerAccount))]
    public class CrazyGamesPlayerAccount : CommonPlayerAccount
    {
        private bool isLoggedIn = false;
        private string displayName = string.Empty;

        public CrazyGamesPlayerAccount()
        {
            CrazySDK.User.GetUser(user =>
            {
                if (user != null)
                {
                    isLoggedIn = true;
                    displayName = user.username;
                }
                else
                {
                    isLoggedIn = false;
                }
                SetInitialized();
            });
        }

        protected override string GetDisplayNameImpl()
        {
            return displayName;
        }

        protected override string GetFirstNameImpl()
        {
            return string.Empty;
        }

        protected override string GetLastNameImpl()
        {
            return string.Empty;
        }

        protected override string GetUniqueIdImpl()
        {
            return string.Empty;
        }

        protected override string GetUsernameImpl()
        {
            return displayName;
        }

        protected override void InvokeLoginImpl(Action onLoginSuccess = null, Action onLoginError = null)
        {
            if (isLoggedIn)
            {
                onLoginSuccess?.Invoke();
                return;
            }
            CrazySDK.User.ShowAuthPrompt((error, user) =>
            {
                if (error != null)
                {
                    Logger.CreateError(this, error);
                    onLoginError?.Invoke();
                    return;
                }
                Logger.CreateText(this, "Auth prompt user", user);
                isLoggedIn = true;
                onLoginSuccess?.Invoke();
            });
        }

        protected override bool IsLoggedInImpl()
        {
            return isLoggedIn;
        }
    }
}
