namespace LightHTML.state
{
    public abstract class NodeState
    {
        protected LightNode? nodeContext;

        public abstract void OnClick();

        public abstract void OnHover();

        public void SetContext (LightNode nodeContext)
        {
            this.nodeContext = nodeContext;
        }
    }
}
