namespace EventListenerLightHTML
{
    public abstract class LightNode 
    {
        public abstract string GetInnerHTML();
        public abstract string GetOuterHTML();

        public EventHandler<EventArgs>? OnClick;
        public EventHandler<EventArgs>? OnMouseOver;

        public virtual void Click()
        {
            Console.WriteLine("clicked on the element");
            OnClick?.Invoke(this, EventArgs.Empty);
        }

        public virtual void MouseOver()
        {
            Console.WriteLine("mouse over the element");
            OnMouseOver?.Invoke(this, EventArgs.Empty);
        }
    }
}
