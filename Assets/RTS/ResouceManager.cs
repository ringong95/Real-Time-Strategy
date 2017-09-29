using UnityEngine;
using System.Collections;
 
namespace RTS {
    public static class ResourceManager {
        //scroll
        public static int ScrollWidth { get { return 15; } }
        public static float ScrollSpeed { get { return 25; } }
        //Rotate 
        public static float RotateAmount { get { return 10; } }
        public static float RotateSpeed { get { return 100; } }
        //Camera Height
        public static float MinCameraHeight { get { return 10; } }
        public static float MaxCameraHeight { get { return 40; } }
        // invalid positions
        private static Vector3 invalidPosition = new Vector3(-99999, -99999, -99999);
        public static Vector3 InvalidPosition { get { return invalidPosition; } }

    }
}