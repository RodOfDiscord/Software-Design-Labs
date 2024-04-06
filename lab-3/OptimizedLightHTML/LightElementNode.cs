namespace OptimizedLightHTML
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> nodes = [];
        private NodeDetails nodeDetails;
        public List<string> CSSClasses = [];
        public string TagName { get => nodeDetails.TagName; }
        public bool IsPaired { get => nodeDetails.IsPaired; }
        public string TagType { get => nodeDetails.TagType; } 

        public LightElementNode(string tagName, string tagType, bool isPaired)
        {
            nodeDetails = NodeDetailsFactory.GetNodeDetails(tagName, tagType, isPaired);
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
