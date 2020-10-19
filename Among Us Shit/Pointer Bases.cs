using System.Security.Cryptography;

namespace Among_Us_Shit.Pointers
{
    class Pointer_Bases
    {
        public static string gameSettingsBase = "GameAssembly.dll+00DA3C30,5C,14,";
        public static string rolesBase = "GameAssembly.dll+00DA5A84,5C,0,34,";
        public static string yCoordPointer = "GameAssembly.dll+00DA1764,E80,54,8,94,44,4,130";
        public static string xCoordPointer = "GameAssembly.dll+00DA1764,E80,54,8,94,44,4,12C";
        public static string killCooldownPointer = "GameAssembly.dll+00DA3C30,5C,10,44";
        public static string cameraFrozenPointer = "UnityPlayer.dll+0126ABC0,0,10,83C,4E4,198,3C,18";
        public static string noClip = "GameAssembly.dll+00DA1764,E80,8,1C,1C,1C,1C,2C";
        public static string taskListItems = "GameAssembly.dll+00DA5A84,5C,0,8,78,18,74,C";
    }
}
