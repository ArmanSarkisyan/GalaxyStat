using System.Collections.Generic;
namespace GalaxyStat
{
    public class Star : SpaceObj
    {
        public Star(string name, double mass, double size, int temp, double lum)
        {
            Name = name;
            Mass = mass;
            Size = size;
            Temp = temp;
            Lum = lum;
            StarClass = ClassFinder();
        }
        public override string Name { get; set; }
        public char StarClass { get; set; }
        public double Mass { get; set; }
        public double Size { get; set; }
        public int Temp { get; set; }
        public double Lum { get; set; }
        private char ClassFinder()
        {
            if (Temp >= 30000 && Lum >= 30000 & Mass >= 16 & Size / 2 >= 6.6)
            {
                return 'O';
            }
            else if (Temp >= 10000 && Temp < 30000 && Lum >= 25 && Lum < 30000 &&
                     Mass >= 2.1 && Mass < 16 && Size / 2 >= 1.8 && Size / 2 < 6.6)
            {
                return 'B';
            }
            else if (Temp >= 7500 && Temp < 10000 && Lum >= 5 && Lum < 25 &&
                     Mass >= 1.4 && Mass < 2.1 && Size / 2 >= 1.4 && Size / 2 < 1.8)
            {
                return 'A';
            }
            else if (Temp >= 6000 && Temp < 7500 && Lum >= 1.5 && Lum < 5 &&
                     Mass >= 1.04 && Mass < 1.4 && Size / 2 >= 1.15 && Size / 2 < 1.4)
            {
                return 'F';
            }
            else if (Temp >= 5200 && Temp < 6000 && Lum >= 0.6 && Lum < 1.5 &&
                     Mass >= 0.8 && Mass < 1.04 && Size / 2 >= 0.96 && Size / 2 < 1.15)
            {
                return 'G';
            }
            else if (Temp >= 3700 && Temp < 5200 && Lum >= 0.08 && Lum < 0.6 &&
                     Mass >= 0.45 && Mass < 0.8 && Size / 2 >= 0.7 && Size / 2 < 0.96)
            {
                return 'K';
            }
            else if (Temp >= 2400 && Temp < 3700 && Lum <= 0.08 && Mass >= 0.08 && Mass < 0.45 &&
                     Size / 2 <= 0.7)
            {
                return 'M';
            }
            else return 'X';
        }
    }
}