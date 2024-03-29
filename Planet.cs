﻿namespace GalaxyStat
{
    public class Planet : SpaceObj
    {
        public Planet(string name, string type, string habitation)
        {
            Name = name;
            PlanetType = type;
            Habitation = habitation;
        }
        public override string Name { get; set; }
        public string PlanetType { get; set; }
        public string Habitation { get; set; }
    }
}