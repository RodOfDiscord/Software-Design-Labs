namespace EventListenerLightHTML
{
    public class LightTextNode : LightNode
    {
        public string TextContent { get; set; }

        public LightTextNode(string textContent)
        {
            TextContent = textContent;
        }

        public override string GetInnerHTML()
        {
            return TextContent;
        }

        public override string GetOuterHTML()
        {
            return TextContent;
        }
    }
}
