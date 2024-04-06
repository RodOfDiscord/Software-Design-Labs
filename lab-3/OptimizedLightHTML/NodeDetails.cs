namespace OptimizedLightHTML
{
    public class NodeDetails
    {
        public NodeDetails(string tagName, string tagType, bool isPaired)
        {
            TagName = tagName;
            TagType = tagType;
            IsPaired = isPaired;
        }

        public string TagName { get; set; }
        public string TagType { get; set; }
        public bool IsPaired { get; set; }

    }
}
