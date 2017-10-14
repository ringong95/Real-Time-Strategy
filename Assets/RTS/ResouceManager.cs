﻿using UnityEngine;
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

        private static GUISkin selectBoxSkin;
        public static GUISkin SelectBoxSkin { get { return selectBoxSkin; } }

        private static Bounds invalidBounds = new Bounds(new Vector3(-99999, -99999, -99999), new Vector3(0, 0, 0));
        public static Bounds InvalidBounds { get { return invalidBounds; } }

        
        public static void StoreSelectBoxItems(GUISkin skin) {
            selectBoxSkin = skin;
        }
    }
}