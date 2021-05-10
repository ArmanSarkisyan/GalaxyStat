namespace GalaxyStat
{
    public class Galaxy : SpaceObj
    {
        public Galaxy(string name, string type, string age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public override string Name { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }
    }
}