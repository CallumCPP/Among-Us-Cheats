using System;
using System.Security.Cryptography;

namespace Among_Us_Shit.Pointers
{
    class Pointer_Bases
    {
        public static string gameSettingsBase = "GameAssembly.dll+01383260,4E0,";
        public static string rolesBase = "GameAssembly.dll+014527C4,E28,24,354,";
        public static string yCoordPointer = "UnityPlayer.dll+01277F00,20,34,4,40,F0";
        public static string xCoordPointer = "UnityPlayer.dll+01277F00,20,34,4,40,EC";
        public static string killCooldownPointer = "GameAssembly.dll+01464A04,404,24,408";
        public static string cameraFrozenPointer = "UnityPlayer.dll+0126ABC0,0,10,83C,4E4,198,3C,18";
        public static string noClip = "GameAssembly.dll+0144BB70,5C,0,8,1C,2C";
        public static string taskListItems = "GameAssembly.dll+00DA5A84,5C,0,8,78,18,74,C";
    }

    class Last_Offset_Bases
    {
        public static int gameSettingsOffset = 0x9C0;
    }
}
