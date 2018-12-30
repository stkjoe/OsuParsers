﻿using System.Drawing;
using OsuParsers.Enums;

namespace OsuParsers.Beatmaps.Objects.Catch
{
    public class CatchFruit : HitObject
    {
        public CatchFruit(Point position, int startTime, HitSoundType hitSound, Extras extras) 
            : base(position, startTime, hitSound, extras)
        {
        }
    }
}
