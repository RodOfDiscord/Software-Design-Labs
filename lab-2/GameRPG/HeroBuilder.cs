using System;
using System.Drawing;

namespace GameRPG
{
    public class HeroBuilder : ICharacterBuilder
    {
        Hero hero = new();

        public HeroBuilder() 
        {
           Reset();
        }

        public void Reset()
        {
            hero = new();
        }

        public Hero Build()
        {
            Hero result = hero;
            Reset();
            return result;
        }

        public ICharacterBuilder WithHairColor(Color color)
        {
            hero.HairColor = color;
            return this;
        }

        public ICharacterBuilder WithHairStyle(string hairStyle)
        {
            hero.HairStyle = hairStyle;
            return this;
        }

        public ICharacterBuilder WithEyesColor(Color eyesColor)
        {
            hero.EyesColor = eyesColor;
            return this;
        }

        public ICharacterBuilder WithBodyType(string bodyType)
        {
            hero.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder WithHeight(double height)
        {
            hero.Height = height;
            return this;
        }

        public ICharacterBuilder WithHat(string hatType, Color color)
        {
            hero.HatType = hatType;
            hero.HatColor = color;
            return this;
        }

        public ICharacterBuilder WithShirtColor(Color color)
        {
            hero.ShirtColor = color;
            return this;
        }

        public ICharacterBuilder WithPantsColor(Color color)
        {
            hero.PantsColor = color;
            return this;
        }

        public ICharacterBuilder WithShoesColor(Color color)
        {
            hero.ShoesColor = color;
            return this;
        }

        public ICharacterBuilder WithName(string name)
        {
            hero.Name = name;
            return this;
        }
    }
}
