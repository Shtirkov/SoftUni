﻿using Raiding.Core;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new Engine();

            engine.Start();
        }
    }
}