using System.Drawing;

namespace GameRPG
{
    public class CharacterDirector
    {
        ICharacterBuilder characterBuilder;
        public CharacterDirector(ICharacterBuilder builder)
        {
            characterBuilder = builder;
        }

        public void ChangeBuilder(ICharacterBuilder builder)
        {
            characterBuilder = builder;
        }

        public void MakeBasicEnemy()
        {
            characterBuilder
                   .WithName("enemy")
                   .WithEyesColor(Color.Red)
                   .WithHeight(180)
                   .WithHairStyle("curly")
                   .WithPantsColor(Color.Red)
                   .WithHairColor(Color.Black)
                   .WithShoesColor(Color.Brown)
                   .WithPantsColor(Color.Black);
        }

        public void MakeBasicHero()
        {
            characterBuilder
                   .WithName("Sir Wishion")
                   .WithEyesColor(Color.Blue)
                   .WithHeight(160)
                   .WithHairStyle("straight")
                   .WithPantsColor(Color.Black)
                   .WithHairColor(Color.LightGray)
                   .WithShoesColor(Color.Brown)
                   .WithPantsColor(Color.Black)
                   .WithBodyType("slim")
                   .WithHat("fedora", Color.White)
                   .WithShirtColor(Color.AliceBlue);
        }
    }
}
