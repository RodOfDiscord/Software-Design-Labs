namespace LightHTML.visitor
{
    public class NodeVisitor : INodeVisitor
    {
        public void Visit(LightElementNode node)
        {
            node.CSSClasses.Add("nav-container");
        }

        public void Visit(LightTextNode node)
        {
            node.TextContent += "!";
        }
    }
}
