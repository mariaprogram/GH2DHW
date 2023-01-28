using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVS
{
    public class BulletView : LevelObjectView
    {
        private int _demagePoint = 10;

        public int DemagePoint { get => _demagePoint; set => _demagePoint = value; }
    }
}