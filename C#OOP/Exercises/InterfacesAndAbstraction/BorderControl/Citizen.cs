﻿using BorderControl.Interfaces;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
