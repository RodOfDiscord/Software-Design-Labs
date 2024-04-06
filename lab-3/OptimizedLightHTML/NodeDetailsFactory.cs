namespace OptimizedLightHTML
{
    public static class NodeDetailsFactory
    {
        private static Dictionary<int, NodeDetails> cache = [];

        public static NodeDetails GetNodeDetails(string tagName, string tagType, bool isPaired)
        {
            int id = tagName.GetHashCode() ^ tagType.GetHashCode();
            NodeDetails? nodeDetails = cache.GetValueOrDefault(id);
            if (nodeDetails == null)
            {
                nodeDetails = new(tagName, tagType, isPaired);
                cache[id] = nodeDetails;
            }
            return nodeDetails;
        }
    }
}
