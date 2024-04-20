namespace EventListenerLightHTML
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
            nodes.Remove(node);
        }

        public override string GetInnerHTML()
        {
            string inner = string.Empty;
            foreach (LightNode node in nodes)
            {
                inner += node.GetOuterHTML();
            }
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

            return outer;
        }
    }
}
