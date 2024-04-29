namespace LightHTML
{
    public class LightTextNode : LightNode
    {
        public string TextContent { get; set; }

        public LightTextNode(string textContent)
        {
            TextContent = textContent;
            OnCreated();
        }

        public override string GetInnerHTML()
        {
            OnTextRendered();
            return TextContent;
        }

        public override string GetOuterHTML()
        {
            OnTextRendered();
            return TextContent;
        }

        protected override void OnCreated()
        {
            Console.WriteLine($"Text element was created");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine("Text was rendered");
        }
    }
}