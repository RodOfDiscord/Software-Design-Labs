namespace LightHTML
{
    public abstract class LightNode
    {
        public abstract string GetInnerHTML();
        public abstract string GetOuterHTML();

        protected virtual void OnCreated() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnTextRendered() { }
    }
}