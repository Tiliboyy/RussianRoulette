﻿using Exiled.API.Interfaces;

namespace RussianRoulette
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}