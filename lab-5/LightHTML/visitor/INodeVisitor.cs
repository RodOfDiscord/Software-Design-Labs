namespace LightHTML.visitor
{
    public interface INodeVisitor
    {
        public void Visit(LightElementNode node);
        public void Visit(LightTextNode node);
    }
}
