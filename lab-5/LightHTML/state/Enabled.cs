namespace LightHTML.state
{
    public class Enabled : NodeState
    {
        public override void OnClick()
        {
            Console.WriteLine("Clicking on element...");
        }

        public override void OnHover()
        {
            Console.WriteLine("Hovering element...");
        }
    }
}
