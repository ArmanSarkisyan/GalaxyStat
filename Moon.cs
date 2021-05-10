namespace GalaxyStat
{
    public class Moon : SpaceObj
    {
        public Moon(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
    }
}