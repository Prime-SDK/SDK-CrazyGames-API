1. Install CrazyGames .unitypackage: https://docs.crazygames.com/sdk/intro/#unity

2. Create new assembly definition in the root of the imported CrazySDK folder, called exactly 'CrazySDK'.

3. Install CrazyGames API package:

```git
https://github.com/Prime-SDK/SDK-CrazyGames-API.git
```

4. If you install from PrimeSDK Toolkit, use automatic installation so CrazyGames SDK is imported before this API package.

5. Make sure you've selected WebGL in Build Settings.

6. Open Toolkit, choose CrazyGamesConfiguration for Build.

7. For banners, use prefabs they provided in CrazySDK package.

8. For payments, use XSolla API package for PrimeSDK (available in Toolkit).
