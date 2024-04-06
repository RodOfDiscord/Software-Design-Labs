namespace VirusFamily
{
    public class Virus : ICloneable
    {
        public List<Virus> Children { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Species { get; set; }

        public object Clone()
        {
            Virus other = (Virus)MemberwiseClone(); // cloning primitive types
            other.Children = []; // clear list of reference types and then do a deep copying

            foreach (Virus child in Children)
            {
                other.Children.Add((Virus)child.Clone());
            }

            return other;
        }

        public Virus(List<Virus> childs, string name, double weight, string species, int age = 0)
        {
            Children = childs;
            Name = name;
            Age = age;
            Weight = weight;
            Species = species;
        }

        public Virus(string name, double weight, string species, int age = 0)
        {
            Children = [];
            Name = name;
            Age = age;
            Weight = weight;
            Species = species;
        }

        public override string ToString()
        {
            string info = $"\nname = {Name}\nspecies = {Species}\nweight = {Weight}\nage = {Age}\n";
            if (Children.Count != 0)
            {
                info += "Childs:\n";
                foreach (Virus v in Children)
                {
                    string tmp = v.ToString().Replace("\n", "\n\t");
                    info += tmp;
                }
            }

            return info;
        }
    }
}
