using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVS
{
    public enum AnimState
    {
        Idle=0,
        Run=1,
        Jamp=2,
        Count = 4
    }

    [CreateAssetMenu(fileName = "SpriteAnimCfg, SpriteAnimCount", menuName ="Configs/Animation", order = 1)]
    public class AnimationConfig : ScriptableObject
    {
        [Serializable]
        public class SprateSequence
        {
            public AnimState Track;
            public List<Sprite> Sprites = new List<Sprite>();
        }

        public List<SprateSequence> Sequences = new List<SprateSequence>();
    }
}