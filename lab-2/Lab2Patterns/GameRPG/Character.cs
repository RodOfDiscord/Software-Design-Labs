using System.Drawing;

namespace GameRPG
{
    public abstract class Character
    {
        public string? Name { get; set; }

        public string? BodyType { get; set; }

        public Color EyesColor { get; set; }

        public Color HairColor { get; set; }

        public string? HairStyle { get; set; }

        public string? HatType { get; set; }

        public Color HatColor { get; set; }

        public double Height { get; set; }

        public Color PantsColor { get; set; }

        public Color ShirtColor { get; set; }

        public Color ShoesColor { get; set; }
    }
}
