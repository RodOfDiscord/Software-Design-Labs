namespace LightHTML
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> nodes = [];
        public List<string> CSSClasses = [];
        public string TagName { get; set; }
        public string TagType { get; set; }
        public bool IsPaired { get; set; }

        public LightElementNode(string tagName, string tagType, bool isPaired)
        {
            TagName = tagName;
            TagType = tagType;
            IsPaired = isPaired;
            OnCreated();
        }

        public int CountNodes()
        {
            return nodes.Count;
        }

        public void AddNode(LightNode node)
        {
            nodes.Add(node);
        }

        public void RemoveNode(LightNode node)
        {
            OnRemoved();
            nodes.Remove(node);
        }

        public List<LightNode> GetNodes()
        {
            return nodes;
        }

        public override string GetInnerHTML()
        {
            string inner = string.Empty;
            foreach (LightNode node in nodes)
            {
                inner += node.GetOuterHTML();
            }

            OnTextRendered();
            return inner;
        }

        public override string GetOuterHTML()
        {
            if (!IsPaired)
                return $"<{TagName}/>";

            string outer = $"<{TagName}>";
            foreach (LightNode node in nodes)
                outer += node.GetOuterHTML();
            outer += $"</{TagName}>";

            OnTextRendered();
            return outer;
        }

        protected override void OnCreated()
        {
            Console.WriteLine($"Element {TagName} was created" );
        }

        protected override void OnRemoved()
        {
            Console.WriteLine($"Child element was removed from {TagName}");
        }

        protected override void OnTextRendered()
        {
           Console.WriteLine("Text was rendered");
        }
    }
}