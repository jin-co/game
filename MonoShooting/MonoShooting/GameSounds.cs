using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // sound class that controls the sounds
    class GameSounds
    {
        public ContentManager Content { get; set; }
        public static Song BackgroundMusic { get; set; }
        public static Song BackgroundMusicEnd { get; set; }
        public static Song BackgroundMusicInbound { get; set; }
        public static Song BackgroundMusicSlayer { get; set; }
        public static SoundEffect Jump { get; set; }
        public static SoundEffect StageClear { get; set; }
        public static SoundEffect Tap { get; set; }
        public static SoundEffect Enter { get; set; }
        public static SoundEffect Dead { get; set; }
        public static SoundEffect Hurt { get; set; }
        public static SoundEffect Bullet { get; set; }
        public static SoundEffect DogBark { get; set; }

        public GameSounds(ContentManager content)
        {
            Content = content;
            // background
            BackgroundMusic = Content.Load<Song>("Assets/Sounds/sound_back");
            BackgroundMusicEnd = Content.Load<Song>("Assets/Sounds/sound_back_end");
            BackgroundMusicInbound = Content.Load<Song>("Assets/Sounds/sound_back_inbound");
            BackgroundMusicSlayer = Content.Load<Song>("Assets/Sounds/sound_back_slayer");
            
            // game sounds
            StageClear = Content.Load<SoundEffect>("Assets/Sounds/sound_clear");
            Dead = Content.Load<SoundEffect>("Assets/Sounds/sound_dead");
            
            // enemies sounds            
            Bullet = Content.Load<SoundEffect>("Assets/Sounds/sound_bullet");
            DogBark = Content.Load<SoundEffect>("Assets/Sounds/sound_dog_bark");

            // biker sounds
            Jump = Content.Load<SoundEffect>("Assets/Sounds/sound_jump");
            Hurt = Content.Load<SoundEffect>("Assets/Sounds/sound_hurt_man");

            // page sounds
            Tap = Content.Load<SoundEffect>("Assets/Sounds/sound_menu_tab");
            Enter = Content.Load<SoundEffect>("Assets/Sounds/sound_menu_enter");
        }
    }
}
