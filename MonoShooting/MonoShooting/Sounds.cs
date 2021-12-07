using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Sounds
    {
        public static Song BackgroundMusic { get; set; }
        public static Song BackgroundMusicEnd { get; set; }
        public static Song BackgroundMusicInbound { get; internal set; }
        public static SoundEffect Jump { get; set; }
        public static SoundEffect StageClear { get; set; }
        public static SoundEffect Tap { get; set; }
        public static SoundEffect Enter { get; set; }
        public static SoundEffect Dead { get; set; }
        public static SoundEffect Hurt { get; set; }
        public static SoundEffect Bullet { get; set; }
    }
}
