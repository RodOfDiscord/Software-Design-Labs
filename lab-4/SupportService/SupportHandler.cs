namespace SupportService
{
    public abstract class SupportHandler
    {
        private SupportHandler? _next;

        protected virtual void Next(Request request)
        {
            if (_next != null)
            {
                _next.Handle(request);
            }
            else
            {
                Console.WriteLine("There`s nothig we can do");
            }
        }

        public abstract void Handle(Request request);

        public SupportHandler Link(SupportHandler handler)
        {
            _next = handler;
            return handler;
        }
    }
}
