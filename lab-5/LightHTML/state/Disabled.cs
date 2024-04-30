namespace LightHTML.state
{
    public class Disabled : NodeState
    {
        public override void OnClick()
        {
            Console.WriteLine("Element disabled");
        }

        public override void OnHover()
        {
            Console.WriteLine("Hovering element...");
        }
    }
}
