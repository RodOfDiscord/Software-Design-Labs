using System.Drawing;

namespace GameRPG
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder WithName(string name);
        ICharacterBuilder WithHairColor(Color hairColor);
        ICharacterBuilder WithHairStyle(string hairStyle);
        ICharacterBuilder WithEyesColor(Color eyesColor);
        ICharacterBuilder WithBodyType(string bodyType);
        ICharacterBuilder WithHeight(double height);
        ICharacterBuilder WithHat(string hatType, Color color);
        ICharacterBuilder WithShirtColor(Color shirtColor);
        ICharacterBuilder WithPantsColor(Color pantsColor);
        ICharacterBuilder WithShoesColor(Color shoesColor);

    }
}
