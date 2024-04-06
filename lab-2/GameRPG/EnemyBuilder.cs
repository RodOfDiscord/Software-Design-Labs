using System.Drawing;

namespace GameRPG
{
    public class EnemyBuilder : ICharacterBuilder
    {
        Enemy enemy = new();

        public EnemyBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            enemy = new();
        }

        public Enemy Build()
        {
            Enemy result = enemy;
            Reset();
            return result;
        }

        public ICharacterBuilder WithHairColor(Color color)
        {
            enemy.HairColor = color;
            return this;
        }

        public ICharacterBuilder WithHairStyle(string hairStyle)
        {
            enemy.HairStyle = hairStyle;
            return this;
        }

        public ICharacterBuilder WithEyesColor(Color eyesColor)
        {
            enemy.EyesColor = eyesColor;
            return this;
        }

        public ICharacterBuilder WithBodyType(string bodyType)
        {
            enemy.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder WithHeight(double height)
        {
            enemy.Height = height;
            return this;
        }

        public ICharacterBuilder WithHat(string hatType, Color color)
        {
            enemy.HatType = hatType;
            enemy.HatColor = color;
            return this;
        }

        public ICharacterBuilder WithShirtColor(Color color)
        {
            enemy.ShirtColor = color;
            return this;
        }

        public ICharacterBuilder WithPantsColor(Color color)
        {
            enemy.PantsColor = color;
            return this;
        }

        public ICharacterBuilder WithShoesColor(Color color)
        {
            enemy.ShoesColor = color;
            return this;
        }

        public ICharacterBuilder WithName(string name)
        {
            enemy.Name = name;
            return this;
        }
    }
}
