using LightHTML.state;
using LightHTML.visitor;

namespace LightHTML
{
    public abstract class LightNode
    {
        protected NodeState state;
        public LightNode() 
        {
            state = new Enabled();
        }

        public abstract string GetInnerHTML();
        public abstract string GetOuterHTML();

        protected virtual void OnCreated() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnTextRendered() { }

        public abstract void Accept(INodeVisitor visitor);

        public void ChangeState(NodeState state)
        {
            this.state = state;
        }
    }
}